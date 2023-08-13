using System.ComponentModel;

namespace Berger.Extensions.Devices
{
    public enum Browser
    {
        [Description("AOSP")]
        AOSP = 1,

        [Description("Apple Safari")]
        Safari = 2,

        [Description("Google Chrome")]
        Chrome = 3,

        [Description("Microsoft Edge")]
        Edge = 4,

        [Description("Microsoft Internet Explorer")]
        InternetExplorer = 5,

        [Description("Mozilla Firefox")]
        Firefox = 6,

        [Description("Opera")]
        Opera = 7,

        [Description("Samsung Internet")]
        SamsungInternet = 8,

        [Description("The PhantomJS Headless Browser")]
        PhantomJS = 9,

        [Description("Unknown")]
        Unknown = 10
    }
}