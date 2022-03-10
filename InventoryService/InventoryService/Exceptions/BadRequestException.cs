using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Exceptions
{
    /// <summary>
    /// When thrown, this exception will direct the Controller to return BadRequest as the Http response status
    /// </summary>
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {

        }
        public BadRequestException(string message) : base(message)
        {

        }
        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
