using Loqui;
using Mutagen.Bethesda.Fallout4;

namespace Loqui
{
    public class ProtocolDefinition_Fallout4 : IProtocolRegistration
    {
        public readonly static ProtocolKey ProtocolKey = new ProtocolKey("Fallout4");
        void IProtocolRegistration.Register() => Register();
        public static void Register()
        {
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Fallout4MajorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Fallout4Mod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Fallout4ModHeader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ModStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Fallout4Group_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSetting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSettingInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSettingFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSettingString_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSettingBool_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GameSettingUInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TransientType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AttractionRule_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Keyword_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationReferenceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ActionRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Transform_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectBounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Component_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Global_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SoundDescriptor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Decal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TextureSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GlobalInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GlobalShort_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GlobalFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GlobalBool_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ActorValueInformation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ADamageType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DamageType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DamageTypeIndexed_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Class_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationTargetRadius_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ALocationTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationCell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationObjectId_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationObjectType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationKeyword_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LocationFallback_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Relation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Cell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Faction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.CrimeValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.VendorValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Rank_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FormList_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Outfit_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.PlacedObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Door_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ColorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HeadPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Part_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MaterialSwap_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SimpleModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Model_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BipedBodyTemplate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AnimationSoundTagSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Debris_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Explosion_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ImpactDataSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SoundMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SoundRepeat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AcousticSpace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BodyPartData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ReverbParameters_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Grass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LandscapeTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MaterialType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Effect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.EffectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Destructible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DestructableData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DestructionStage_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DestructionStageData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AVirtualMachineAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.VirtualMachineAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptObjectProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptStringProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptIntProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptFloatProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptBoolProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptObjectListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptStringListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptIntListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptFloatListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptBoolListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptFragment_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.IndexedScriptFragment_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptFragments_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Activator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.EquipType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Perk_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Spell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Water_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TalkingActivator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.VoiceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BodyTemplate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Icons_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Armor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ArmorModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ArmorAddon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ArtObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Footstep_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FootstepSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ResistanceDestructible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ArmorAddonModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ArmorResistance_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BookTeachTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BookActorValue_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BookPerk_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BookSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BookTeachesNothing_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Message_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MessageButton_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Quest_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Static_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Book_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ContainerEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ContainerItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ExtraData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.OwnerTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FactionOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NoOwner_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Container_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Npc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SoundOutputModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ANavigationMesh_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MiscItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MiscItemComponent_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.WeatherType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MusicTrack_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MusicTrackLoopData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MusicType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MusicTypeData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Region_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionArea_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionDataHeader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionSounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionMap_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionObjects_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionWeather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionGrasses_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionGrass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RegionLand_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Weather_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Worldspace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Ingredient_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Terminal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GodRays_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LensFlare_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Light_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.StaticCollection_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.StaticPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Placement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovableStatic_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.SeasonalIngredientProduction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Tree_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Flora_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Furniture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RankPlacement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Bone_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovementType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptEntryStruct_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptVariableProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptStructProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptVariableListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptStructListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ScriptPropertyStruct_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledNpc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledNpcEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledNpcEntryData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FilterKeywordChance_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledItem_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledItemEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.LeveledItemEntryData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Key_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Ingestible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RadioReceiver_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.InstanceNaming_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.InstanceNamingRule_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RuleSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RuleName_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Ammunition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.IdleAnimation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.IdleMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.CollisionLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Holotape_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModification_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.PlacedNpc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.APlacedTrap_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.KeyFrame_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Attack_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Hazard_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Race_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.RaceWeight_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.BipedObjectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovementDataOverride_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovementData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovementDirectionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MovementRotationData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FaceFxPhonemes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Phoneme_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HeadData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NeckFatAdjustmentsScale_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HeadPartReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TintGroup_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TintTemplateOption_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TintTemplateColor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MorphGroup_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MorphPreset_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FaceMorph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Subgraph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MorphValue_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.EquipmentSlot_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AttackData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectTemplateInclude_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.EffectShader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ColorFrame_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Projectile_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DualCastData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ImageSpaceAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectLightArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectBoundArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectSummonCreatureArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectGuideArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectSpawnHazardArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectCloakArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectWerewolfArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectVampireArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectEnhanceWeaponArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectPeakValueModArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.VisualEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Weapon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MagicEffectSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Condition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ConditionGlobal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ConditionFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FunctionConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.GetEventData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AObjectModProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectTemplate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModIntProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModFloatProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModBoolProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModStringProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModFormLinkIntProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ObjectModFormLinkFloatProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NavmeshTriangle_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.EdgeLink_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DoorTriangle_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NavmeshGeometry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.WorldspaceNavmeshParent_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.CellNavmeshParent_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NavmeshGrid_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NavmeshGridArray_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.MaterialObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ANavmeshParent_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.DistantLod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ConstructibleObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FurnitureMarkerEntryPoints_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.FurnitureMarkerParameters_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AimModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Zoom_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.WeaponDamageType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.WeaponExtraData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.ANpcLevel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcLevel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.PcLevelMult_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.PerkPlacement_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.CombatStyle_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcWeight_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcMorph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Package_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcFaceTintingLayer_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcBodyMorphRegionValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.NpcFaceMorph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.TemplateActors_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.AHolotapeData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HolotapeSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HolotapeVoice_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HolotapeProgram_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.HolotapeTerminal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Fallout4.Internals.Scene_Registration.Instance);
        }
    }
}
