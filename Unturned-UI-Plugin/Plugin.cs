using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Logo.UI.Config;
namespace Unturned_UI_Plugin
{
    public class Plugin : RocketPlugin<Config>
    {
        public static Plugin Instance;
        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += oyuncubaglandı;
        }
        private void oyuncubaglandı(UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(this.Configuration.Instance.UI, (short)5924, player.CSteamID, true);
            EffectManager.sendUIEffectImageURL(5924, player.CSteamID, true, "Resim", this.Configuration.Instance.URL);
            EffectManager.sendUIEffect(Configuration.Instance.UI, 31, player.CSteamID, true, Configuration.Instance.Sunucuİsim);
        }
        protected override void Unload()
        {
            base.Unload();
            Instance = null;
            U.Events.OnPlayerConnected -= oyuncubaglandı;
        }
    }
}
