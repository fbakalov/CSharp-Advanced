using Logger.Core.Appenders.Interfaces;
using Logger.Core.Enums;
using Logger.Core.Loggers.Interfaces;
using Logger.Core.Models;
using Logger.Core.Models.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Logger.Core.Loggers
{
    public class Loggerr : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public Loggerr(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Info);

        public void Warning(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Warning);

        public void Error(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Error);

        public void Critical(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Critical);

        public void Fatal(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Fatal);

        private void AppendAll(string dateTime, string text, ReportLevel reportLevel)
        {
            IMessage message = new Message(dateTime, text, reportLevel);

            foreach (IAppender appender in appenders)
            {
                if (message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }
    }
}
