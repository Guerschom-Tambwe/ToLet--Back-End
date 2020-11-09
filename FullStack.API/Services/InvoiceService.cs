using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using FullStack.API.Helpers;
using FullStack.ViewModels;
using FullStack.Data.Entities;
using FullStack.Data;

namespace FullStack.API.Services
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceModel> GetInvoices();
        InvoiceModel GetInvoice(int id);
        void DeleteInvoice(int id);
        InvoiceModel UpdateInvoice(Invoice invoice);
        InvoiceModel CreateInvoice(Invoice invoice);



    }

    public class InvoiceService : IInvoiceService
    {
        private IFullStackRepository _repo;

        public InvoiceService(IFullStackRepository repo)
        {
            this._repo = repo;
        }

        public IEnumerable<InvoiceModel> GetInvoices()
        {
            //only use for testing
            var userList = _repo.GetInvoices();
            return userList.Select(u => Map(u));
        }

        public InvoiceModel GetInvoice(int id)
        {
            var userEntity = _repo.GetInvoice(id);
            if (userEntity == null) return null;

            return Map(userEntity);
        }

        public void DeleteInvoice(int id)
        {
            var userEntity = _repo.GetInvoice(id);
            _repo.DeleteInvoice(id);

        }

        public InvoiceModel UpdateInvoice(Invoice invoice)
        {
            var updatedInvoice = _repo.UpdateInvoice(invoice);
            return Map(updatedInvoice);
        }

        public InvoiceModel CreateInvoice(Invoice invoice)
        {
            var createdInvoice = _repo.CreateInvoice(invoice);
            return Map(createdInvoice);
        }

        // helper methods
        private InvoiceModel Map(Invoice invoice)
        {
            return new InvoiceModel
            {
                InvoiceId = invoice.InvoiceId,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceRefNumber = invoice.InvoiceRefNumber,
                InvoiceDueDate = invoice.InvoiceDueDate,
                InvoiceItems = invoice.InvoiceItems
            };
        }

    }


}
