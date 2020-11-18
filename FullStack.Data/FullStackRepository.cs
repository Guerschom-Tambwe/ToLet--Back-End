using System.Collections.Generic;
using System.Linq;
using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace FullStack.Data
{
    public interface IFullStackRepository
    {
        User GetUser(int id);
        List<User> GetUsers();
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);

        Invoice GetInvoice(int id);
        List<Invoice> GetInvoices();
        Invoice CreateInvoice(Invoice invoice);
        Invoice UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int id);

        InvoiceItem GetInvoiceItem(int id);
        List<InvoiceItem> GetInvoiceItems();
        InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem);
        InvoiceItem UpdateInvoiceItem(InvoiceItem invoiceItem);
        void DeleteInvoiceItem(int id);

        Province GetProvince(int id);
        Province GetCityFromProvice(string provinceName);
        List<Province> GetProvices();
        Province AddProvince(Province province);
        Province UpdateProvince(Province province);
        void DeleteProvince(int id);

        Advert GetAdvert(int id);
        List<Advert> GetAdverts();

        Advert CreateAdvert(Advert advert);
        Advert UpdateAdvert(Advert advert);
        void DeleteAdvert(int id);

        City GetCity(int id);
        List<City> GetCities();
        City AddCity(City city);
        City UpdateCity(City city);
        void DeleteCity(int id);

        //Do the same for all the other entities, Invoices, Invoice Items, etc

    }
    public class FullStackRepository: IFullStackRepository
    {
        private FullStackDbContext _ctx;
        public FullStackRepository(FullStackDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<User> GetUsers()
        {
            return _ctx.Users.ToList();
        }

        public User GetUser(int id)
        {
            return _ctx.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            var existing = _ctx.Users.SingleOrDefault(em => em.Id == user.Id);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Users.Attach(user);
            _ctx.Entry(user).State = EntityState.Modified;
            _ctx.SaveChanges();

            return user;
        }

        public void DeleteUser(int id)
        {
            var entity = _ctx.Users.Find(id);
            _ctx.Users.Remove(entity);
            _ctx.SaveChanges();
        }

        //Invoice Methods
        public List<Invoice> GetInvoices()
        {
            return _ctx.Invoices.Include(i => i.InvoiceItems).ToList();
        }

        public Invoice GetInvoice(int id)
        {
            return _ctx.Invoices.Where(i => i.InvoiceId == id).Include(i => i.InvoiceItems).FirstOrDefault();
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            _ctx.Invoices.Add(invoice);
            _ctx.SaveChanges();
            return invoice;
        }

        public void DeleteInvoice(int id)
        {

            var entity = _ctx.Invoices.Find(id);
            _ctx.Invoices.Remove(entity);
            _ctx.SaveChanges();
        }

        public Invoice UpdateInvoice(Invoice invoice)
        {

            var existing = _ctx.Invoices.SingleOrDefault(em => em.InvoiceId == invoice.InvoiceId);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Invoices.Attach(invoice);
            _ctx.Entry(invoice).State = EntityState.Modified;
            _ctx.SaveChanges();

            return invoice;
        }

        //Invoice Item Methods
        public List<InvoiceItem> GetInvoiceItems()
        {
            return _ctx.InvoiceItems.ToList();
        }

        public InvoiceItem GetInvoiceItem(int id)
        {
            return _ctx.InvoiceItems.Find(id);
        }

        public InvoiceItem UpdateInvoiceItem(InvoiceItem invoiceItem)
        {

            var existing = _ctx.InvoiceItems.SingleOrDefault(em => em.InvoiceItemId == invoiceItem.InvoiceItemId);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.InvoiceItems.Attach(invoiceItem);
            _ctx.Entry(invoiceItem).State = EntityState.Modified;
            _ctx.SaveChanges();

            return invoiceItem;
        }

        public void DeleteInvoiceItem(int id)
        {

            var entity = _ctx.Invoices.Find(id);
            _ctx.Invoices.Remove(entity);
            _ctx.SaveChanges();
        }

        public InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem)
        {
            _ctx.InvoiceItems.Add(invoiceItem);
            _ctx.SaveChanges();
            return invoiceItem;
        }


       public Province GetProvince(int id)
        {
            return _ctx.Provinces.Where(i => i.ProvinceId == id).Include(i => i.Cities).FirstOrDefault();
        }

        public Province GetCityFromProvice(string provinceName)
        {
            return _ctx.Provinces.Where(i => i.ProvinceName == provinceName).Include(i => i.Cities).FirstOrDefault();
        }

        public List<Province> GetProvices()
        {
            return _ctx.Provinces.Include(i => i.Cities).ToList();
        }
        public Province AddProvince(Province province)
        {
            _ctx.Provinces.Add(province);
            _ctx.SaveChanges();
            return province;
        }
        public Province UpdateProvince(Province province)
        {
            var existing = _ctx.Provinces.SingleOrDefault(em => em.ProvinceId == province.ProvinceId);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Provinces.Attach(province);
            _ctx.Entry(province).State = EntityState.Modified;
            _ctx.SaveChanges();

            return province;
        }
        public void DeleteProvince(int id)
        {
            var entity = _ctx.Provinces.Find(id);
            _ctx.Provinces.Remove(entity);
            _ctx.SaveChanges();
        }

        public Advert GetAdvert(int id)
        {
            return _ctx.Adverts.Find(id);
        }

        public List<Advert> GetAdverts()
        {
            return _ctx.Adverts.ToList();
        }
        public Advert CreateAdvert(Advert advert)  
        {
            _ctx.Adverts.Add(advert);
            _ctx.SaveChanges();
            return advert;
        }
        public Advert UpdateAdvert(Advert advert)
        {
            var existing = _ctx.Adverts.SingleOrDefault(em => em.AdvertId == advert.AdvertId);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Adverts.Attach(advert);
            _ctx.Entry(advert).State = EntityState.Modified;
            _ctx.SaveChanges();

            return advert;
        }
        public void DeleteAdvert(int id)
        {
            var entity = _ctx.Adverts.Find(id);
            _ctx.Adverts.Remove(entity);
            _ctx.SaveChanges();
        }

        public City GetCity(int id)
        {
            return _ctx.Cities.Find(id);
        }
        public List<City> GetCities()
        {
            return _ctx.Cities.ToList();
        }
        public City AddCity(City city)
        {
            _ctx.Cities.Add(city);
            _ctx.SaveChanges();
            return city;
        }
        public City UpdateCity(City city)
        {
            var existing = _ctx.Cities.SingleOrDefault(em => em.CityId == city.CityId);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Cities.Attach(city);
            _ctx.Entry(city).State = EntityState.Modified;
            _ctx.SaveChanges();

            return city;
        }
        public void DeleteCity(int id)
        {
            var entity = _ctx.Cities.Find(id);
            _ctx.Cities.Remove(entity);
            _ctx.SaveChanges();
        }
    }
}