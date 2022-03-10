using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using InventoryService.Exceptions;
using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        /// <summary>
        /// Get all Products
        /// </summary>
        /// <returns>All Products</returns>
        [HttpGet("All")]
        [ProducesResponseType(typeof(List<ProductDomainModel>), StatusCodes.Status200OK)]
        public IActionResult GetProducts()
        {
            try
            {
                var result = _productService.GetProducts();

                // Assumes that if the result is NULL, then we should return NotFound
                if (result == null)
                    return NotFound(null);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return ProcessException(ex);
            }
        }

        /// <summary>
        /// Get Product by ProductId
        /// </summary>
        /// <param name="employeeId">product Id</param>
        /// <returns>Product details</returns>
        [HttpGet("{productId}")]
        [ProducesResponseType(typeof(ProductDomainModel), StatusCodes.Status200OK)]
        public IActionResult GetProduct([FromRoute] int productId)
        {
            try
            {
                var result = _productService.GetProduct(productId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return ProcessException(ex);
            }
        }

        private IActionResult ProcessException(Exception ex)
        {
            // If there is an inner exception, use that one
            Exception exception = ex.InnerException ?? ex;

            switch (exception)
            {
                case NotFoundException _:
                    return NotFound(null);
                case BadRequestException _:
                case SerializationException _:
                    return BadRequest(ex.Message);
                default:
                    return InternalServerError(exception);
            }
        }

        /// <summary>
        /// Returns an InternalServerError containing exception information
        /// </summary>
        /// <param name="ex">Exception to return information for</param>
        /// <returns>Internal Server Error action result</returns>
        protected IActionResult InternalServerError(Exception ex)
        {
            if (Request != null)
            {
                ApiErrorDetails errorDetails = new ApiErrorDetails()
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace
                };

                return StatusCode(StatusCodes.Status500InternalServerError, errorDetails);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
