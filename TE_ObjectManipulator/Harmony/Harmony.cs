using HarmonyLib;
using System.Reflection;

namespace TormentedEmu_Mods_A19
{
  public class Harmony_TE_ObjectManipulator : IModApi
  {
    public void InitMod(Mod mod)
    {
      var harmony = new Harmony("TormentedEmu.Mods.A21");
      harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    [HarmonyPatch(typeof(GameManager), "SetCursorEnabledOverride")]
    public class GameManager_SetCursorEnabledOverride
    {
      static bool Prefix(GameManager __instance, ref bool ___bCursorVisibleOverrideState)
      {
        if (!___bCursorVisibleOverrideState)
        {
          ___bCursorVisibleOverrideState = true;
        }

        return true;
      }
    }
  }

}
