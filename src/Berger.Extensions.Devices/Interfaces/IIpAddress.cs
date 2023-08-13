namespace Berger.Extensions.Devices
{
    public interface IIpAddress
    {
        #region Methods
        public void SetIp(string ip);
        #endregion

        #region Properties
        public string IpAddress { get; }
        #endregion
    }
}