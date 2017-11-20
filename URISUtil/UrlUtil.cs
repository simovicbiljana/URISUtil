using System;
using System.Configuration;

namespace URISUtil
{
    public static class UrlUtil
    {
        public static Uri GetServiceUrl(string serviceName, string controllerName, string actionName = null)
        {
            Uri baseUrl = new Uri(ConfigurationManager.AppSettings["Service" + serviceName]);

            if (String.IsNullOrWhiteSpace(actionName))
            {
                return new Uri(baseUrl, String.Format("api/{0}", controllerName));
            }
            else
            {
                return new Uri(baseUrl, String.Format("api/{0}/{1}", controllerName, actionName));
            }
        }
    }
}
