using System;
using System.Text;

namespace URISUtil.Logging
{
    public class LogData
    {
        public DateTime Time { get; set; }

        public string ServiceName { get; set; }

        public string TransactionGuid { get; set; }

        public string Caller { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Time: {0}, Service: {1}, Caller: {4}", new string[]
            {
                Time.ToString(),
                ServiceName,
                Caller
            });
            builder.AppendLine();

            builder.AppendFormat("Message: {0}", new string[]
            {
                Message
            });
            builder.AppendLine();

            return builder.ToString();
        }
    }
}
