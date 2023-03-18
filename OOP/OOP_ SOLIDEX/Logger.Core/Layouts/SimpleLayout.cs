
using Logger.Core.Layouts.Interfaces;

namespace Logger.Core.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string SipmpleFormat = "{0} - {1} - {2}";
        public string Format => SipmpleFormat;
    }
}
