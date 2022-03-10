using InventoryService.Exceptions;
using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.Serialization;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService, ILoggerFactory loggerFactory)
        {
            _inventoryService = inventoryService ?? throw new ArgumentNullException(nameof(inventoryService));
        }
        /// <summary>
        /// Get Inventory meta data
        /// </summary>
        /// <returns>Inventory meta data details</returns>
        [HttpGet("metadata")]
        [ProducesResponseType(typeof(InventoryDomainModel), StatusCodes.Status200OK)]
        public IActionResult GetInventoryMetaData()
        {
            try
            {
                var result = _inventoryService.GetInventoryMetaData();

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
