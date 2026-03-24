
namespace Product.Application.DTO.Response
{
    public class ApiResponseDto<T>
    {
        public bool Success { get; set; }   

        public string Message { get; set; } 

        public T Result { get; set; }


        public ApiResponseDto(bool success, T data, string message)
        {
            Success = success;
            Message = message;
            Result = data;  
        }
    }
}
