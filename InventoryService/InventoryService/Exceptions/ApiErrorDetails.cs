using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Exceptions
{
    /// <summary>
    /// Standard error data provided by the API
    /// </summary>
    public class ApiErrorDetails
    {
        /// <summary>
        /// HTTP Status Code to respond with - use Microsoft.AspNetCore.Http.StatusCodes
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Message from the exception thrown
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Stacktrace from the exception thrown
        /// </summary>
        public string StackTrace { get; set; }
    }
}
