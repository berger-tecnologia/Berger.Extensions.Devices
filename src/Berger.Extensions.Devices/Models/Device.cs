namespace Berger.Extensions.Devices
{
    public class Device : IIpAddress
    {
        #region Properties
        public Guid? OrganizationID { get; set; }
        public Browser? Browser { get; set; }
        public DeviceType DeviceType { get; set; }
        public string Language { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public string Agent { get; set; } = string.Empty;
        public string Engine { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string Isp { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string OsType { get; set; }
        public string Imei { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public int Memory { get; set; }
        public int Storage { get; set; }
        public bool Https { get; set; }
        public bool Intel { get; set; }
        public bool Amd { get; set; }
        public bool Pocket { get; set; }
        public bool JavaScript { get; set; }
        public bool Trustable { get; set; }
        public bool Authenticated { get; set; }
        #endregion

        #region Methods
        public void SetHttps(bool https)
        {
            this.Https = https;
        }
        public void SetAgent(string agent)
        {
            this.Agent = agent;
        }
        public void SetBrowser(Browser browser)
        {
            this.Browser = browser;
        }
        public void SetDeviceType(DeviceType deviceType)
        {
            this.DeviceType = deviceType;
        }
        public void SetLanguageId(string language)
        {
            this.Language = language;
        }
        public void SetIp(string ip)
        {
            this.IpAddress = ip;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}