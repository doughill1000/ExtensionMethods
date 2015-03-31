using System.Xml;

namespace System //Root of DateTime
{
    public static class DateTimeExtensions
    {
        public static string ToXmlDateTime(this DateTime dateTime)
        {
            return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);
        }

        public static string ToXmlDateTime(this DateTime dateTime, XmlDateTimeSerializationMode mode)
        {
            return XmlConvert.ToString(dateTime, mode);
        }
    }
}
