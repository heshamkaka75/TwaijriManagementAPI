namespace TwaijriManagement.Contracts.Response
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string ResponseMessage { get; set; }
        public string? ValidationErrors { get; set; }


        public BaseResponse(bool success, int statusCode, string responseMessage)
        {
            IsSuccess = success;
            StatusCode = statusCode;
            ResponseMessage = responseMessage;
        }
        public BaseResponse(bool success, int statusCode, string responseMessage, string validationErrors)
        {
            IsSuccess = success;
            StatusCode = statusCode;
            ResponseMessage = responseMessage;
            ValidationErrors = validationErrors;
        }
    }

}
