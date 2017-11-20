using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace URISUtil.Response
{
    public static class ErrorResponse
    {

        public static HttpResponseException ErrorMessage(HttpStatusCode statusCode, string message)
        {
            throw new HttpResponseException(new HttpResponseMessage(statusCode) { Content = new StringContent(message) });
        }

        public static HttpResponseException ErrorMessage(HttpStatusCode statusCode, Exception ex)
        {
            return new HttpResponseException(new HttpResponseMessage(statusCode) { Content = new StringContent(ex.Message) });
        }

        public static HttpResponseException ErrorMessage(HttpStatusCode statusCode)
        {
            return new HttpResponseException(new HttpResponseMessage(statusCode));
        }
    }
}
