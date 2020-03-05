using Harmony;

namespace TheNutSpeaks
{
    public class Plugin : EXILED.Plugin
    {
        public static bool Enabled;
        public static int PatchCounter;

        public override void OnEnable()
        {
            LoadConfigs();

            if (!Enabled) return;

            HarmonyInstance instance = HarmonyInstance.Create($"ur.mom.gay.thenutspeaks.{PatchCounter}");
            instance.PatchAll();
        }

        public override void OnDisable()
        {
        }

        private void LoadConfigs()
        {
            Enabled = Config.GetBool("173t_enabled", true);
        }

        public override void OnReload()
        {

        }

        public override string getName { get; } = "NutSpeaks";
    }
}
