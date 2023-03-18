

using Logger.Core.Appenders.Interfaces;
using Logger.Core.Enums;
using Logger.Core.Layouts.Interfaces;
using Logger.Core.Models.Interfaces;

namespace Logger.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; set; }

        public void AppendMessage(IMessage message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text));

            MessagesAppended++;
        }
    }
}
