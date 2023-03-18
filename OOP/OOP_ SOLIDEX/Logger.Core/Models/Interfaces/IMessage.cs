
using Logger.Core.Enums;

namespace Logger.Core.Models.Interfaces
{
    public interface IMessage
    {
        string CreatedTime { get; }
        string Text { get; }

        ReportLevel ReportLevel { get; }
    }
}
