using Product.Application.DTO.Response;
using System.Text.Json;

namespace Product.API.Middleware
{
    public class CommonResponseMiddleware
    {
        private readonly RequestDelegate next;

        public CommonResponseMiddleware(RequestDelegate next)
        {
            this.next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {

            var originalBody = context.Response.Body;

            using var memoryStream
                 = new MemoryStream();

            context.Response.Body = memoryStream;

            await next(context);

            if (context.Response.ContentType != null
                && context.Response.ContentType.Contains("application/json"))
            {
                memoryStream.Seek(0, SeekOrigin.Begin);
                var repsonseBody = await new StreamReader(memoryStream).ReadToEndAsync();

                var repsonseObj
                     = new ApiResponseDto<object>(
                                success: context.Response.StatusCode is >= 200 and <= 299,
                                data: JsonSerializer.Deserialize<object>(repsonseBody),
                                message: "Request completed successfully"
                         );

                var jsonResponse
                     = JsonSerializer.Serialize(repsonseObj);

                context.Response.Body = originalBody;

                await context.Response.WriteAsync(jsonResponse);
            }
        }
    }
}
