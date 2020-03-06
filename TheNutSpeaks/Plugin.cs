using Harmony;

namespace TheNutSpeaks
{
    public class Plugin : EXILED.Plugin
    {
        public static int PatchCounter;

        public override void OnEnable()
        {
            // LoadConfigs();

            HarmonyInstance instance = HarmonyInstance.Create($"com.themoogle.thenutspeaks.{PatchCounter}");
            instance.PatchAll();
        }

        public override void OnDisable()
        {
        }

        private void LoadConfigs()
        {
            // If you have this you dont need this if you have it installed
            // Enabled = Config.GetBool("173t_enabled", true);
        }

        public override void OnReload()
        {

        }

        public override string getName { get; } = "NutSpeaks";
    }
}
