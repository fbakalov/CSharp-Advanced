
using Logger.Core.Layouts.Interfaces;

namespace Logger.Core.Layouts
{
    public class XmlLayout : ILayout
    {
        private const string XmlFormat = "<log>\r\n\r\n<date>{0}</date>\r\n\r\n<level>{1}</level>\r\n\r\n<message>{2}</message>\r\n\r\n</log>";
        public string Format => XmlFormat;
    }
}
