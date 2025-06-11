#if !RWPre1_4
using Ashs_Alien_Patches;
#endif
using AlienRace;
using HarmonyLib;
using System;
using Verse;

namespace Argonian_Assemblies
{
    /// <summary>
    /// Main argonian class that handles modifications that can not be done in XML. Some patches are split off into their own classes for organization, one ones that are in this class are the left overs.
    /// </summary>
    /// <remarks>
    /// <para>Handles interpawn opinions and pawn thoughts.</para>
    /// </remarks>
    /// 
    [StaticConstructorOnStartup]
    public static class Argonian_Assemblies
    {
        /// <summary>Argonian alien race def.</summary>
        public static readonly ThingDef_AlienRace ArgoRaceDef = (ThingDef_AlienRace)Argo_DefOf.Alien_Argonian;
        /// <summary>Our mod name, for debug output purposes.</summary>
        public static readonly string ModName = "Argonian Race Mod";
        /// <summary>Argonian Harmony ID.</summary>
        public static readonly string HarmonyID = "rimworld.ashilstraza.races.argo.main";
        /// <summary>Reference to harmony.</summary>
        private static readonly Harmony harmony = new(HarmonyID);

        static Argonian_Assemblies()
        {
            Type thisClass = typeof(Argonian_Assemblies);

#if !RWPre1_4
            try
            {
                new Alien_Patches(harmony);
            }
            catch (Exception e)
            {
                Log.Error(string.Format($"{HarmonyID}: Exception when trying to apply Alien Patches. Ensure that you are using the latest version. If issues persist, please notify the author for the {ModName} with the logs. Thanks!\n{e}"));
            }
#endif
        }
    }
}
