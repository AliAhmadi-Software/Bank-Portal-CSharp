using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace KicccIngenicoTestClient
{

    internal class Registery
    {
        private const string RegName = @"Software\KICCCIngenicoPCPOS\{0}{1}{2}{3}";
        private const string KeyId = "Setting";
        public static void Register(Setting setting)
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            var regKey = string.Format(RegName, ver.Build, ver.Major, ver.Minor, ver.Revision);

            var key = Registry.CurrentUser.CreateSubKey(regKey);
            if (key == null) return;
            using (var mStream = new MemoryStream())
            {
                var serializer = new XmlSerializer(setting.GetType());
                serializer.Serialize(mStream, setting);
                key.SetValue(KeyId, mStream.ToArray(), RegistryValueKind.Binary);
            }
        }
        public static Setting Load()
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            var regKey = string.Format(RegName, ver.Build, ver.Major, ver.Minor, ver.Revision);
            var result = new Setting();

            var key = Registry.CurrentUser.OpenSubKey(regKey);
            if (key == null) return result;
            var buffer = key.GetValue(KeyId);
            var serializer = new XmlSerializer(result.GetType());
            if (buffer == null) return result;
            using (var mStream = new MemoryStream((byte[])buffer))
            {
                result = (Setting)serializer.Deserialize(mStream);
            }
            return result;
        }
    }

    public class Setting
    {
        public string SerialNo { get; set; }
        public string TerminalId { get; set; }
        public string AcceptorId { get; set; }
        public string Organization { get; set; }
        public string ServiceCode { get; set; }
        public string SequenceCode { get; set; }
        public string Financialyear { get; set; }
        public string FiscalPeriod { get; set; }
        public string BankCode { get; set; }
    }
}
