using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwaijriManagement.Contracts;
using TwaijriManagement.Contracts.Response;
using TwaijriManagement.Domain.Dtos.InvoiceDto;
using TwaijriManagement.Domain.Enums;
using TwaijriManagement.Domain.Models;
using TwaijriManagement.Persistence;

namespace TwaijriManagement.Controllers
{
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        #region dependency injection

        private readonly IUnitOfWork unitOfWork;
        #endregion
        #region Constructor
        public InvoiceController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region Create new Invoice
        [HttpPost(ApiRoute.InvoiceRoute.Create)]
        public async Task<IActionResult> CreateInvoiceAsync(CreateInvoiceDto Dto)
        {
            var invoice = new Invoice { CustomerID = Dto.CustomerId , Value = Dto.Value };
            await unitOfWork.Invoices.AddAsync(invoice);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Adding Success..."));
        }
        #endregion

        #region Get Invoice
        [HttpGet(ApiRoute.InvoiceRoute.Get)]
        public async Task<IActionResult> GetInvoiceAsync(Guid id)
        {
            var invoice = await unitOfWork.Invoices.GetAsync(i => i.Id == id);
            if (invoice == null)
            {
                return NotFound(new BaseResponse(false, 404, "Invoice is not found"));
            }
            return Ok(invoice);
        }
        #endregion

        #region Get All Invoices
        [HttpGet(ApiRoute.InvoiceRoute.GetAll)]
        public async Task<IActionResult> GetAllInvoiceAsync()
        {
            var invoices = await unitOfWork.Invoices.GetAllAsync();
            return Ok(invoices);
        }
        #endregion

        #region Update Invoice
        [HttpPut(ApiRoute.InvoiceRoute.Update)]
        public async Task<IActionResult> UpdateInvoiceAsync(UpdateInvoiceDto Dto)
        {
            var invoice = await unitOfWork.Invoices.GetAsync(c => c.Id == Dto.Id);
            if (invoice == null)
            {
                return NotFound(new BaseResponse(false, 404, "Invoice is not found"));
            }
            invoice.State = Dto.State;
            invoice.Value = Dto.Value;
            invoice.CustomerID = Dto.CustomerId;

            unitOfWork.Invoices.UpdateAsync(invoice);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Update Success..."));
        }
        #endregion

        #region Delete Invoice
        [HttpDelete(ApiRoute.InvoiceRoute.Delete)]
        public async Task<IActionResult> DeleteInvoiceAsync(Guid id)
        {
            var invoice = await unitOfWork.Invoices.GetAsync(c => c.Id == id);
            if (invoice == null)
            {
                return NotFound(new BaseResponse(false, 404, "Invoice is not found"));
            }

            unitOfWork.Invoices.Remove(invoice);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Delete Success..."));
        }
        #endregion

    }
}


