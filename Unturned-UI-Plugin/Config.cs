using Rocket.API;

namespace Logo.UI.Config
{
    public class Config : IRocketPluginConfiguration
    {
        public ushort UI;
        public string URL;
        public string Sunucuİsim;
        public void LoadDefaults()
        {
            UI = 5924;
            URL = "";
            Sunucuİsim = "";
        }
    }
}
