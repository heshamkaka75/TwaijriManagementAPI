using Microsoft.AspNetCore.Mvc;
using TwaijriManagement.Contracts;
using TwaijriManagement.Contracts.Response;
using TwaijriManagement.Domain.Dtos.CustomerDto;
using TwaijriManagement.Domain.Enums;
using TwaijriManagement.Domain.Models;
using TwaijriManagement.Persistence;

namespace TwaijriManagement.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region dependency injection
        private readonly IUnitOfWork unitOfWork;
        #endregion
        #region Constructor
        public CustomerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        #endregion

        #region Create new Customer
        [HttpPost(ApiRoute.CustomerRoute.Create)]
        public async Task<IActionResult> CreateCustomerAsync(CreateCustomerDto Dto)
        {
            var customer = new Customer { CutomerName = Dto.CutomerName , PhoneNumber = Dto.PhoneNumber };
            await unitOfWork.Customers.AddAsync(customer);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Adding Success..."));
        }
        #endregion

        #region Get Customer
        [HttpGet(ApiRoute.CustomerRoute.Get)]
        public async Task<IActionResult> GetCustomerAsync(Guid id)
        {
            var customer = await unitOfWork.Customers.GetAsync(c => c.Id == id);
            if (customer == null)
            {
                return NotFound(new BaseResponse(false, 404, "Customer is not found"));
            }
            return Ok(customer);
        }
        #endregion

        #region Get All Customer
        [HttpGet(ApiRoute.CustomerRoute.GetAll)]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            var customers = await unitOfWork.Customers.GetAllAsync();
            return Ok(customers);
        }
        #endregion

        #region Update Customer
        [HttpPut(ApiRoute.CustomerRoute.Update)]
        public async Task<IActionResult> UpdateCustomerAsync(UpdateCustomerDto Dto)
        {
            var customer = await unitOfWork.Customers.GetAsync(c => c.Id == Dto.Id);
            if (customer == null)
            {
                return NotFound(new BaseResponse(false, 404, "customer is not found"));
            }
            customer.CutomerName = Dto.CustomerName;
            customer.PhoneNumber = Dto.PhoneNumber;

            unitOfWork.Customers.UpdateAsync(customer);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Update Success..."));
        }
        #endregion

        #region Delete Customer
        [HttpDelete(ApiRoute.CustomerRoute.Delete)]
        public async Task<IActionResult> DeleteCustomerAsync(Guid id)
        {
            var customer = await unitOfWork.Customers.GetAsync(c => c.Id == id);
            if (customer == null)
            {
                return NotFound(new BaseResponse(false, 404, "customer is not found"));
            }

            unitOfWork.Customers.Remove(customer);
            await unitOfWork.CommitAsync();
            return Ok(new BaseResponse(true, StatusCodesEnums.Status200OK, "Delete Success..."));
        }
        #endregion

    }
}


