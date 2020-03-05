using Assets._Scripts.Dissonance;
using Harmony;

namespace TheNutSpeaks.Patch
{
    [HarmonyPatch(typeof(DissonanceUserSetup), nameof(DissonanceUserSetup.CallCmdAltIsActive))]
    public class Scp173Speech
    {
        public static bool Speech(DissonanceUserSetup __player, bool ef)
        {
            if (!Plugin.Enabled) return true;

            CharacterClassManager ccm = __player.gameObject.GetComponent<CharacterClassManager>();
            if (ccm.CurClass == RoleType.Scp173 || ccm.CurClass.Is939()) __player.MimicAs939 = ef;

            return true;
        }
    }
}
