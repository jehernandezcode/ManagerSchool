using System.Net;

namespace SchoolManager.Commons
{
    public class ApiResponse
    {
        public HttpStatusCode? StatusCode { get; set; }

        public bool? IsSuccess { get; set; } = true;

        public Object? Result { get; set; } = null;

        public IEnumerable<Object>? Error { get; set; }
    }
}
