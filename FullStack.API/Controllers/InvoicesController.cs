using Microsoft.AspNetCore.Mvc;
using FullStack.Data.Entities;
using FullStack.API.Services;
using FullStack.ViewModels;

namespace FullStack.API.Controllers
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private IInvoiceService _invoiceService;

        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public IActionResult GetInvoices()
        {
            var invoice = _invoiceService.GetInvoices();
            return Ok(invoice);
        }


        [HttpGet("{id}")]
        public ActionResult<InvoiceModel> GetInvoice(int id)
        {
            var invoice = _invoiceService.GetInvoice(id);

            return invoice;
        }

        [HttpPut("{id}")]
        public ActionResult<InvoiceModel> UpdateInvoice(int id, Invoice invoice)
        {
            if (id != invoice.InvoiceId)
            {
                return BadRequest();
            }

            var updatedInvoices = _invoiceService.UpdateInvoice(invoice);

            return updatedInvoices;
    }

        [HttpPost]
        public ActionResult<InvoiceModel> CreateInvoice(Invoice invoice)
        {
            _invoiceService.CreateInvoice(invoice);

            return CreatedAtAction("GetInvoice", new { id = invoice.InvoiceId }, invoice);
        }


        [HttpDelete("{id}")]
        public ActionResult<InvoiceModel> DeleteInvoice(int id)
        {
            var invoice = _invoiceService.GetInvoice(id);
            if (invoice == null)
            {
                return NotFound();
            }

            _invoiceService.DeleteInvoice(id);

            return Ok(invoice);
        }
    }
}
