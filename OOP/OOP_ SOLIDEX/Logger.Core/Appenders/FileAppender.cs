
using Logger.Core.Appenders.Interfaces;
using Logger.Core.Enums;
using Logger.Core.IO.Interfaces;
using Logger.Core.Layouts.Interfaces;
using Logger.Core.Models.Interfaces;

namespace Logger.Core.Appenders
{
    public class FileAppender : IAppender
    {
        
        public FileAppender(ILayout layout, ILogFile logFile, ReportLevel report = ReportLevel.Info)
        {
            Layout = layout;
            LogFile = logFile;
            ReportLevel = report;
        }

        public ILayout Layout { get; private set; }
        public ILogFile LogFile { get; private set; }
        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }

        public void AppendMessage(IMessage message)
        {
            string content =
                string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text);

            LogFile.WriteLine(content);

            File.AppendAllText(LogFile.FullPath, content + Environment.NewLine);

            MessagesAppended++;
        }
    }
}
