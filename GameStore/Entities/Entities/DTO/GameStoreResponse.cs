using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.DTO
{
    /// <summary>
    /// Response object that contains a boolean success value and an error or success message string.
    /// </summary>
    public class GameStoreResponse
    {
        /// <summary>
        /// Returns a successful response with no message
        /// </summary>
        public GameStoreResponse()
        {
            this.Success = true;
            this.Message = "";
        }
        /// <summary>
        /// Returns a response with the success value of the boolean provided
        /// </summary>
        public GameStoreResponse(bool success)
        {
            this.Success = success;
            this.Message = "";
        }
        /// <summary>
        /// Returns an unsuccessful response with the error message provided
        /// </summary>
        /// <param name="message">Error message</param>
        public GameStoreResponse(string message)
        {
            this.Success = false;
            this.Message = message;
        }
        /// <summary>
        /// Returns a response with the success value and message provided.
        /// </summary>
        /// <param name="message">Error or Success message</param>
        public GameStoreResponse(bool success, string message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Whether or not the operation was a success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Message detailing success or error details
        /// </summary>
        public string Message { get; set; }
    }
}
