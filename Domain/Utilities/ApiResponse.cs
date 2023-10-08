using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utilities
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public bool Status { get; set; }
        public string ResponseMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
        public T Data { get; set; }

        public static ApiResponse<T> Success(T data, string responseMsg = "Transaction performed successfully", string technicalErrMsg = "")
        {
            return new ApiResponse<T>
            {
                Data = data,
                StatusCode = 0,
                Status = true,
                ResponseMessage = responseMsg,
                TechnicalErrorMessage = technicalErrMsg
            };
        }

        public static ApiResponse<T> Error(T data, string responseMsg = "Transaction failed", string technicalErrMsg = "")
        {
            return new ApiResponse<T>
            {
                Data = data,
                StatusCode = 1,
                Status = false,
                ResponseMessage = responseMsg,
                TechnicalErrorMessage = technicalErrMsg
            };
        }
    }
}
