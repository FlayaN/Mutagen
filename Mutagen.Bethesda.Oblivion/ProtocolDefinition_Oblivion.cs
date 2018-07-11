using Loqui;
using Mutagen.Bethesda.Oblivion;

namespace Loqui
{
    public class ProtocolDefinition_Oblivion : IProtocolRegistration
    {
        public readonly static ProtocolKey ProtocolKey = new ProtocolKey("Oblivion");
        public void Register()
        {
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Header_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.TES4_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.OblivionMod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSetting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingString_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Global_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalShort_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Class_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ClassTraining_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Model_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Hair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Faction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Relation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Rank_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Race_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SkillBoost_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SpellUnleveled_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Eye_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceStatsGendered_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceVoices_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceHair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.FacePart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GenderedBodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.BodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.BodyPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.FaceGenData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Sound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoundData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoundDataExtended_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SkillRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MagicEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Script_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptMetaSummary_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LocalVariable_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LandTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.HavokData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Effect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Enchantment_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MagicEffectSubData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.EffectShader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Grass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Light_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptVariableReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptObjectReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Birthsign_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Spell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SpellLeveled_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Activator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AlchemicalApparatus_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Armor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Book_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ClothingAbstract_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Clothing_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Container_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ContainerItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ItemAbstract_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Door_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Worldspace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Ingredient_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Miscellaneous_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Static_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Tree_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Flora_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Furnature_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Weapon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Ammo_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.NPC_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RankPlacement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ItemEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AIPackage_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.CombatStyle_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Creature_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.CreatureSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoundItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LeveledEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LeveledCreature_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.NPCAbstract_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.NPCSpawn_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoulGem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Key_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Potion_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Subspace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SigilStone_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LeveledItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Weather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.WeatherType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.WeatherSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Climate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.WeatherChance_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Region_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionArea_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataObjects_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataMapName_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataGrasses_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataSounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataWeather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionDataObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RegionSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Cell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PlacedObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.TeleportDestination_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LockInformation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.EnableParent_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.DistantLODData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MapMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Water_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PlacedCreature_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PathGrid_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PathGridPoint_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.CellBlock_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.CellSubBlock_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Placed_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.InterCellPoint_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PointToReferenceMapping_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.PlacedNPC_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.CellLighting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Road_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.WorldspaceBlock_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.WorldspaceSubBlock_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RoadPoint_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Landscape_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AlphaLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.BaseLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MapData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.DialogTopic_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Quest_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.DialogItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.DialogResponse_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Condition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptFields_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LogEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.QuestTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.QuestStage_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.IdleAnimation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AIPackageLocation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AIPackageSchedule_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.AIPackageTarget_Registration.Instance);
        }
    }
}
