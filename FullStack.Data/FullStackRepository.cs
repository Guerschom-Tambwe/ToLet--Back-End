using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            throw new NotImplementedException();
            //return _ctx.Users.ToList();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
            //return _ctx.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();

            //_ctx.Users.Add(e);
            //_ctx.SaveChanges();
            //return e;
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();

            //var existing = _ctx.Users.SingleOrDefault(em => em.Id == e.Id);
            //if (existing == null) return null;

            //_ctx.Entry(existing).State = EntityState.Detached;
            //_ctx.Users.Attach(e);
            //_ctx.Entry(e).State = EntityState.Modified;
            //_ctx.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();

            //var entity = _ctx.Users.Find(noteId);
            //_ctx.Users.Remove(entity); //CAREFULL!! here when you copy and paste, change _ctx.Users to the new DBSet
            //_ctx.SaveChanges();
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
    }
}
