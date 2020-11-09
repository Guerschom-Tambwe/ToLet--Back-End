using FullStack.Data;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using System.Linq;
using System;
using System.Collections.Generic;

namespace FullStack.API.Services
{
    public interface IInvoiceItemService
    {
        IEnumerable<InvoiceItemModel> GetInvoiceItems();
        InvoiceItemModel GetInvoiceItem(int id);
        void DeleteById(int id);
        InvoiceItemModel UpdateInvoiceItem(InvoiceItem invoiceItem);
        InvoiceItemModel CreateInvoiceItem(InvoiceItem invoiceItem);
    }

    public class InvoiceItemService: IInvoiceItemService
    {
        public IFullStackRepository _repo;

        public InvoiceItemService(IFullStackRepository repo)
        {
            this._repo = repo;
        }
        public IEnumerable<InvoiceItemModel> GetInvoiceItems()
        {
             var userList = _repo.GetInvoiceItems();
             return userList.Select(u => Map(u));

        }

        public  InvoiceItemModel GetInvoiceItem(int id)
        {
            var userEntity = _repo.GetInvoiceItem(id);
            if (userEntity == null) return null;

            return Map(userEntity);
        }

        public void DeleteById(int id)
        {
            _repo.DeleteInvoice(id);

        }

        public InvoiceItemModel UpdateInvoiceItem(InvoiceItem invoiceItem)
        {
            var updatedInvoice = _repo.UpdateInvoiceItem(invoiceItem);
            return Map(updatedInvoice);
        }

        public InvoiceItemModel CreateInvoiceItem(InvoiceItem invoiceItem)
        {
            var createdInvoiceItem = _repo.CreateInvoiceItem(invoiceItem);
            return Map(createdInvoiceItem);
        }

        // helper methods
        private InvoiceItemModel Map(InvoiceItem invoiceItem)
        {
            return new InvoiceItemModel
            {
                InvoiceItemId = invoiceItem.InvoiceId,
                Description = invoiceItem.Description,
                RatePerHour = invoiceItem.RatePerHour,
                HoursWorked = invoiceItem.HoursWorked,


            };
        }
    }
}
