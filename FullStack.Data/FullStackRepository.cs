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

       /* public User Create(User user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.Users.Any(x => x.Username == user.Username))
                throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }*/

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
    }
}

/*
 * 
 * // Custom exception class for throwing application specific exceptions (e.g. for validation) 
    // that can be caught and handled within the application
 public AppException() : base() {}

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
 */