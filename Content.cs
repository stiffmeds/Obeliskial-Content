using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Obeliskial_Essentials;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Obeliskial_Essentials.Essentials;

namespace Obeliskial_Content
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.stiffmeds.obeliskialessentials")]
    [BepInProcess("AcrossTheObelisk.exe")]
    public class Content : BaseUnityPlugin
    {
        internal const int ModDate = 20231026;
        private readonly Harmony harmony = new(PluginInfo.PLUGIN_GUID);
        internal static ManualLogSource Log;
        public static Dictionary<string, CardData> medsCardsSource = new();
        public static Dictionary<string, SubClassData> medsSubClassesSource = new();
        public static Dictionary<string, CardbackData> medsCardbacksSource = new();
        public static Dictionary<string, SkinData> medsSkinsSource = new();
        public static Dictionary<string, TraitData> medsTraitsSource = new();
        public static List<string> medsCustomTraitsSource = new();
        public static Dictionary<string, NPCData> medsNPCsSource = new();
        public static Dictionary<string, AuraCurseData> medsAurasCursesSource = new();
        public static Dictionary<string, NodeData> medsNodeDataSource = new();
        public static Dictionary<string, LootData> medsLootDataSource = new();
        public static Dictionary<string, PerkData> medsPerksSource = new();
        public static Dictionary<string, PerkNodeData> medsPerksNodesSource = new();
        public static Dictionary<string, ChallengeTrait> medsChallengeTraitsSource = new();
        public static Dictionary<string, CombatData> medsCombatDataSource = new();
        public static Dictionary<string, EventData> medsEventDataSource = new();
        public static Dictionary<string, EventRequirementData> medsEventRequirementDataSource = new();
        public static Dictionary<string, ZoneData> medsZoneDataSource = new();
        public static SortedDictionary<string, KeyNotesData> medsKeyNotesDataSource = new();
        public static Dictionary<string, ChallengeData> medsChallengeDataSource = new();
        public static Dictionary<string, PackData> medsPackDataSource = new();
        public static Dictionary<string, ItemData> medsItemDataSource = new();
        public static Dictionary<string, CardPlayerPackData> medsCardPlayerPackDataSource = new();
        public static Dictionary<string, CorruptionPackData> medsCorruptionPackDataSource = new();
        public static Dictionary<string, CinematicData> medsCinematicDataSource = new();
        public static Dictionary<string, Sprite> medsSprites = new();
        public static Dictionary<int, TierRewardData> medsTierRewardDataSource = new();
        public static Dictionary<string, Node> medsNodeSource = new();
        public static Dictionary<string, string[]> medsSecondRunImport = new();
        public static Dictionary<string, string> medsSecondRunImport2 = new();
        public static Dictionary<string[], string> medsSecondRunImport3 = new();
        public static Dictionary<string, string> medsCardsNeedingItems = new();
        public static Dictionary<string, string> medsCardsNeedingItemEnchants = new();
        public static List<string> medsCustomUnlocks = new();
        public static TMP_SpriteAsset medsFallbackSpriteAsset = ScriptableObject.CreateInstance<TMP_SpriteAsset>();
        public static Dictionary<string, AudioClip> medsAudioClips = new();
        public static Dictionary<string, Sprite> medsVanillaSprites = new();
        public static Dictionary<string, GameObject> medsGOs = new();
        public static Dictionary<string, string> medsNodeCombatEventRelation = new();
        public static Dictionary<string, CardPlayerPairsPackData> medsCardPlayerPairsPackDataSource = new();
        public static Dictionary<string, string> medsNodeEvent = new();
        public static Dictionary<string, int> medsNodeEventPercent = new();
        public static Dictionary<string, int> medsNodeEventPriority = new();
        public static Dictionary<string, ThermometerTierData> medsThermometerTierData = new();
        public static Dictionary<string, string> medsSecondRunCombatEvent = new();
        public static Dictionary<string, string> medsSecondRunCinematicCombat = new();
        public static Dictionary<string, string> medsSecondRunCinematicEvent = new();
        public static Dictionary<string, string[]> medsSecondRunNodesConnected = new();
        public static Dictionary<string, EventReplyDataText> medsEventReplyDataText = new();
        public static Dictionary<string, string> medsCardsNeedingSummonUnits = new();
        public static int medsMaxHeroesInClass = 6;
        public static Dictionary<string, ZoneDataText> medsCustomZones = new();
        public static Dictionary<string, GameObject> medsCustomZoneGOs = new();
        public static Dictionary<string, List<NodeDataText>> medsNodesByZone = new();
        public static bool medsLoadedCustomNodes = false;
        public static Dictionary<string, Vector3> medsNodePositions = new();
        public static GameObject medsBaseRoadGO = (GameObject)null;
        public static Dictionary<string, List<Vector3>> medsCustomRoads = new();
        public static GameObject medsInvisibleGOHolder = new();
        public static List<string> medsVanillaIntroNodes = new List<string>() { "sen_0", "tutorial_0", "secta_0", "spider_0", "forge_0", "sewers_0", "sewers_1", "wolf_0", "pyr_0", "velka_0", "aqua_0", "voidlow_0", "faen_0", "ulmin_0", "voidhigh_0" };
        public static GameObject medsZoneTransitionGO = (GameObject)null;
        public static Dictionary<string, PrestigeDeck> medsPrestigeDecks = new();
        public static bool medsDoNotLetCombatFinish = false;
        public static Dictionary<string, CardData> medsExtendedEnchantments = new();
        public static string medsAwaitingKill = "";
        public static List<string> medsAutoUnlockHeroes = new();
        public static ConfigEntry<bool> medsVanillaContentLog { get; private set; }
        private void Awake()
        {
            Log = Logger;
            medsVanillaContentLog = Config.Bind(new ConfigDefinition("Debug", "Vanilla Content Logging"), false, new ConfigDescription("Logs the loading of each individual piece of vanilla content."));
            LogInfo($"{PluginInfo.PLUGIN_GUID} {PluginInfo.PLUGIN_VERSION} has loaded!");
            harmony.PatchAll();
        }
        internal static void LogDebug(string msg)
        {
            Log.LogDebug(msg);
        }
        internal static void LogInfo(string msg)
        {
            Log.LogInfo(msg);
        }
        internal static void LogWarning(string msg)
        {
            Log.LogWarning(msg);
        }
        internal static void LogError(string msg)
        {
            Log.LogError(msg);
        }
    }
}
