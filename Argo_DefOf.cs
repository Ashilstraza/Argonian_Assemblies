using RimWorld;
using Verse;

namespace Argonian_Assemblies
{
    /// <summary>
    /// List of Argonian related defs that are required for the code.
    /// </summary>
    [DefOf]
    public static class Argo_DefOf
    {
        /// <summary>
        /// Required to make stuff not explode in a red mess of errors.
        /// </summary>
        static Argo_DefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(Argo_DefOf));
        }

        // RaceDef
        public static readonly ThingDef Alien_Argonian;
        // Opinion ThoughtDefs
        // TaleDefs
        // RulePackDefs
        // HediffDefs
        // ApparelDefs
    }
}
