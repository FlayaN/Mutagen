using Mutagen.Bethesda.Skyrim;

namespace Loqui;

internal class ProtocolDefinition_Skyrim : IProtocolRegistration
{
    public static readonly ProtocolKey ProtocolKey = new("Skyrim");
    void IProtocolRegistration.Register() => Register();
    public static void Register()
    {
        LoquiRegistration.Register(
            GameSetting_Registration.Instance,
            GameSettingInt_Registration.Instance,
            GameSettingFloat_Registration.Instance,
            GameSettingString_Registration.Instance,
            Global_Registration.Instance,
            GlobalInt_Registration.Instance,
            GlobalShort_Registration.Instance,
            GlobalFloat_Registration.Instance,
            GameSettingBool_Registration.Instance,
            Keyword_Registration.Instance,
            LocationReferenceType_Registration.Instance,
            ActionRecord_Registration.Instance,
            ObjectBounds_Registration.Instance,
            TextureSet_Registration.Instance,
            Decal_Registration.Instance,
            Class_Registration.Instance,
            Relation_Registration.Instance,
            Faction_Registration.Instance,
            FormList_Registration.Instance,
            Outfit_Registration.Instance,
            PlacedObject_Registration.Instance,
            Rank_Registration.Instance,
            VendorValues_Registration.Instance,
            LocationTargetRadius_Registration.Instance,
            Condition_Registration.Instance,
            ConditionGlobal_Registration.Instance,
            ConditionFloat_Registration.Instance,
            FunctionConditionData_Registration.Instance,
            GetEventData_Registration.Instance,
            ConditionData_Registration.Instance,
            Model_Registration.Instance,
            AlternateTexture_Registration.Instance,
            HeadPart_Registration.Instance,
            Part_Registration.Instance,
            Hair_Registration.Instance,
            Eyes_Registration.Instance,
            Armor_Registration.Instance,
            Race_Registration.Instance,
            BodyTemplate_Registration.Instance,
            SkillBoost_Registration.Instance,
            VoiceType_Registration.Instance,
            ColorRecord_Registration.Instance,
            Attack_Registration.Instance,
            AttackData_Registration.Instance,
            BodyData_Registration.Instance,
            BodyPartData_Registration.Instance,
            SkyrimGroup_Registration.Instance,
            SkyrimModHeader_Registration.Instance,
            ModStats_Registration.Instance,
            SkyrimMajorRecord_Registration.Instance,
            SkyrimMod_Registration.Instance,
            RaceMovementType_Registration.Instance,
            SpeedOverrides_Registration.Instance,
            EquipType_Registration.Instance,
            FaceFxPhonemes_Registration.Instance,
            Phoneme_Registration.Instance,
            HeadData_Registration.Instance,
            HeadPartReference_Registration.Instance,
            AvailableMorphs_Registration.Instance,
            Npc_Registration.Instance,
            TintAssets_Registration.Instance,
            TintPreset_Registration.Instance,
            ArtObject_Registration.Instance,
            ImpactDataSet_Registration.Instance,
            MaterialType_Registration.Instance,
            MovementType_Registration.Instance,
            SoundDescriptor_Registration.Instance,
            SimpleModel_Registration.Instance,
            Morph_Registration.Instance,
            SoundMarker_Registration.Instance,
            ReverbParameters_Registration.Instance,
            Region_Registration.Instance,
            AcousticSpace_Registration.Instance,
            MagicEffect_Registration.Instance,
            AVirtualMachineAdapter_Registration.Instance,
            ScriptEntry_Registration.Instance,
            ScriptProperty_Registration.Instance,
            ScriptObjectProperty_Registration.Instance,
            ScriptStringProperty_Registration.Instance,
            ScriptIntProperty_Registration.Instance,
            ScriptFloatProperty_Registration.Instance,
            ScriptBoolProperty_Registration.Instance,
            ScriptObjectListProperty_Registration.Instance,
            ScriptStringListProperty_Registration.Instance,
            ScriptIntListProperty_Registration.Instance,
            ScriptFloatListProperty_Registration.Instance,
            ScriptBoolListProperty_Registration.Instance,
            Static_Registration.Instance,
            EffectShader_Registration.Instance,
            Light_Registration.Instance,
            MagicEffectArchetype_Registration.Instance,
            Explosion_Registration.Instance,
            MagicEffectLightArchetype_Registration.Instance,
            Projectile_Registration.Instance,
            DualCastData_Registration.Instance,
            ImageSpaceAdapter_Registration.Instance,
            Perk_Registration.Instance,
            Spell_Registration.Instance,
            MagicEffectSound_Registration.Instance,
            MagicEffectBoundArchetype_Registration.Instance,
            MagicEffectSummonCreatureArchetype_Registration.Instance,
            MagicEffectCloakArchetype_Registration.Instance,
            MagicEffectWerewolfArchetype_Registration.Instance,
            MagicEffectEnhanceWeaponArchetype_Registration.Instance,
            MagicEffectPeakValueModArchetype_Registration.Instance,
            Hazard_Registration.Instance,
            MagicEffectGuideArchetype_Registration.Instance,
            MagicEffectSpawnHazardArchetype_Registration.Instance,
            MagicEffectVampireArchetype_Registration.Instance,
            ObjectEffect_Registration.Instance,
            Grass_Registration.Instance,
            LandscapeTexture_Registration.Instance,
            CrimeValues_Registration.Instance,
            Effect_Registration.Instance,
            EffectData_Registration.Instance,
            Destructible_Registration.Instance,
            Scroll_Registration.Instance,
            DestructionStage_Registration.Instance,
            DestructionStageData_Registration.Instance,
            Debris_Registration.Instance,
            Activator_Registration.Instance,
            LeveledSpell_Registration.Instance,
            Shout_Registration.Instance,
            Water_Registration.Instance,
            DestructableData_Registration.Instance,
            TalkingActivator_Registration.Instance,
            ArmorModel_Registration.Instance,
            ArmorAddon_Registration.Instance,
            Book_Registration.Instance,
            BookTeachTarget_Registration.Instance,
            BookSkill_Registration.Instance,
            BookSpell_Registration.Instance,
            BookTeachesNothing_Registration.Instance,
            Container_Registration.Instance,
            AlchemicalApparatus_Registration.Instance,
            Ammunition_Registration.Instance,
            Ingestible_Registration.Instance,
            Ingredient_Registration.Instance,
            Key_Registration.Instance,
            LeveledItem_Registration.Instance,
            MiscItem_Registration.Instance,
            SoulGem_Registration.Instance,
            Weapon_Registration.Instance,
            ContainerEntry_Registration.Instance,
            ContainerItem_Registration.Instance,
            ExtraData_Registration.Instance,
            OwnerTarget_Registration.Instance,
            NpcOwner_Registration.Instance,
            FactionOwner_Registration.Instance,
            NoOwner_Registration.Instance,
            Door_Registration.Instance,
            MaterialObject_Registration.Instance,
            Lod_Registration.Instance,
            MoveableStatic_Registration.Instance,
            Tree_Registration.Instance,
            SeasonalIngredientProduction_Registration.Instance,
            Flora_Registration.Instance,
            Furniture_Registration.Instance,
            WorkbenchData_Registration.Instance,
            FurnitureMarker_Registration.Instance,
            EntryPoints_Registration.Instance,
            WeaponBasicStats_Registration.Instance,
            WeaponData_Registration.Instance,
            CriticalData_Registration.Instance,
            LeveledNpc_Registration.Instance,
            NpcConfiguration_Registration.Instance,
            ANpcLevel_Registration.Instance,
            NpcLevel_Registration.Instance,
            PcLevelMult_Registration.Instance,
            RankPlacement_Registration.Instance,
            PerkPlacement_Registration.Instance,
            AIData_Registration.Instance,
            CombatStyle_Registration.Instance,
            PlayerSkills_Registration.Instance,
            ANpcSoundDefinition_Registration.Instance,
            NpcInheritSound_Registration.Instance,
            NpcSoundTypes_Registration.Instance,
            NpcSoundType_Registration.Instance,
            NpcSound_Registration.Instance,
            Package_Registration.Instance,
            NpcFaceMorph_Registration.Instance,
            NpcFaceParts_Registration.Instance,
            TintLayer_Registration.Instance,
            ALocationTarget_Registration.Instance,
            LocationTarget_Registration.Instance,
            PlacedNpc_Registration.Instance,
            LocationCell_Registration.Instance,
            LocationObjectId_Registration.Instance,
            Cell_Registration.Instance,
            IdleMarker_Registration.Instance,
            LocationObjectType_Registration.Instance,
            LocationKeyword_Registration.Instance,
            LocationFallback_Registration.Instance,
            Icons_Registration.Instance,
            MountData_Registration.Instance,
            IdleAnimation_Registration.Instance,
            ConstructibleObject_Registration.Instance,
            CollisionLayer_Registration.Instance,
            LeveledItemEntry_Registration.Instance,
            LeveledItemEntryData_Registration.Instance,
            LeveledNpcEntry_Registration.Instance,
            LeveledNpcEntryData_Registration.Instance,
            AmbientColors_Registration.Instance,
            LensFlare_Registration.Instance,
            ShaderParticleGeometry_Registration.Instance,
            VisualEffect_Registration.Instance,
            VolumetricLighting_Registration.Instance,
            Weather_Registration.Instance,
            CloudLayer_Registration.Instance,
            WeatherColor_Registration.Instance,
            WeatherAlpha_Registration.Instance,
            WeatherSound_Registration.Instance,
            WeatherImageSpaces_Registration.Instance,
            WeatherVolumetricLighting_Registration.Instance,
            WeatherAmbientColorSet_Registration.Instance,
            Climate_Registration.Instance,
            WeatherType_Registration.Instance,
            MusicType_Registration.Instance,
            RegionArea_Registration.Instance,
            RegionData_Registration.Instance,
            RegionDataHeader_Registration.Instance,
            RegionSounds_Registration.Instance,
            RegionSound_Registration.Instance,
            RegionMap_Registration.Instance,
            RegionObjects_Registration.Instance,
            RegionObject_Registration.Instance,
            RegionWeather_Registration.Instance,
            Worldspace_Registration.Instance,
            RegionGrasses_Registration.Instance,
            RegionGrass_Registration.Instance,
            RegionLand_Registration.Instance,
            NavigationMesh_Registration.Instance,
            NavigationMeshInfoMap_Registration.Instance,
            NavigationMapInfo_Registration.Instance,
            LinkedDoor_Registration.Instance,
            IslandData_Registration.Instance,
            PreferredPathing_Registration.Instance,
            NavmeshSet_Registration.Instance,
            NavmeshNode_Registration.Instance,
            CellGrid_Registration.Instance,
            CellLighting_Registration.Instance,
            LightingTemplate_Registration.Instance,
            Location_Registration.Instance,
            CellWaterVelocity_Registration.Instance,
            EncounterZone_Registration.Instance,
            CellBlock_Registration.Instance,
            CellSubBlock_Registration.Instance,
            Landscape_Registration.Instance,
            SkyrimListGroup_Registration.Instance,
            APlacedTrap_Registration.Instance,
            LinkedReferences_Registration.Instance,
            WaterReflection_Registration.Instance,
            ActivateParent_Registration.Instance,
            EnableParent_Registration.Instance,
            PlacedPrimitive_Registration.Instance,
            Bounding_Registration.Instance,
            Portal_Registration.Instance,
            LightData_Registration.Instance,
            Alpha_Registration.Instance,
            TeleportDestination_Registration.Instance,
            Message_Registration.Instance,
            WaterVelocity_Registration.Instance,
            ActivateParents_Registration.Instance,
            LockData_Registration.Instance,
            NavigationDoorLink_Registration.Instance,
            ATopicReference_Registration.Instance,
            TopicReference_Registration.Instance,
            TopicReferenceSubtype_Registration.Instance,
            DialogTopic_Registration.Instance,
            Patrol_Registration.Instance,
            MapMarker_Registration.Instance,
            LinkedReferenceColor_Registration.Instance,
            NavmeshTriangle_Registration.Instance,
            EdgeLink_Registration.Instance,
            DoorTriangle_Registration.Instance,
            NavigationMeshData_Registration.Instance,
            PlacedArrow_Registration.Instance,
            PlacedBeam_Registration.Instance,
            PlacedFlame_Registration.Instance,
            PlacedCone_Registration.Instance,
            PlacedBarrier_Registration.Instance,
            PlacedTrap_Registration.Instance,
            PlacedHazard_Registration.Instance,
            PlacedMissile_Registration.Instance,
            WorldspaceBlock_Registration.Instance,
            WorldspaceSubBlock_Registration.Instance,
            WorldspaceGridReference_Registration.Instance,
            WorldspaceReference_Registration.Instance,
            WorldspaceMaxHeight_Registration.Instance,
            WorldspaceParent_Registration.Instance,
            WorldspaceLandDefaults_Registration.Instance,
            WorldspaceMap_Registration.Instance,
            BaseLayer_Registration.Instance,
            AlphaLayer_Registration.Instance,
            LayerHeader_Registration.Instance,
            DialogBranch_Registration.Instance,
            DialogResponses_Registration.Instance,
            Quest_Registration.Instance,
            PackageAdapter_Registration.Instance,
            PackageScriptFragments_Registration.Instance,
            ScriptFragment_Registration.Instance,
            VirtualMachineAdapter_Registration.Instance,
            DialogResponse_Registration.Instance,
            DialogResponsesUnknownData_Registration.Instance,
            SoundOutputModel_Registration.Instance,
            DialogResponseFlags_Registration.Instance,
            QuestAdapter_Registration.Instance,
            QuestScriptFragment_Registration.Instance,
            QuestFragmentAlias_Registration.Instance,
            QuestStage_Registration.Instance,
            QuestLogEntry_Registration.Instance,
            QuestObjective_Registration.Instance,
            QuestObjectiveTarget_Registration.Instance,
            QuestAlias_Registration.Instance,
            LocationAliasReference_Registration.Instance,
            ExternalAliasReference_Registration.Instance,
            CreateReferenceToObject_Registration.Instance,
            FindMatchingRefNearAlias_Registration.Instance,
            FindMatchingRefFromEvent_Registration.Instance,
            QuestTarget_Registration.Instance,
            APackageData_Registration.Instance,
            APackageTarget_Registration.Instance,
            PackageTargetSpecificReference_Registration.Instance,
            PackageTargetObjectID_Registration.Instance,
            PackageTargetObjectType_Registration.Instance,
            PackageTargetReference_Registration.Instance,
            PackageTargetAlias_Registration.Instance,
            PackageTargetUnknown_Registration.Instance,
            PackageTargetSelf_Registration.Instance,
            PackageBranch_Registration.Instance,
            PackageRoot_Registration.Instance,
            PackageFlagsOverride_Registration.Instance,
            PackageEvent_Registration.Instance,
            PackageDataBool_Registration.Instance,
            PackageDataInt_Registration.Instance,
            PackageDataFloat_Registration.Instance,
            PackageDataLocation_Registration.Instance,
            PackageDataTarget_Registration.Instance,
            PackageDataTopic_Registration.Instance,
            PackageIdles_Registration.Instance,
            PackageDataObjectList_Registration.Instance,
            CombatStyleMelee_Registration.Instance,
            CombatStyleCloseRange_Registration.Instance,
            CombatStyleFlight_Registration.Instance,
            LoadScreen_Registration.Instance,
            Int16MinMax_Registration.Instance,
            LeveledSpellEntry_Registration.Instance,
            LeveledSpellEntryData_Registration.Instance,
            AnimatedObject_Registration.Instance,
            DebrisModel_Registration.Instance,
            ImageSpace_Registration.Instance,
            ImageSpaceHdr_Registration.Instance,
            ImageSpaceCinematic_Registration.Instance,
            ImageSpaceTint_Registration.Instance,
            ImageSpaceDepthOfField_Registration.Instance,
            KeyFrame_Registration.Instance,
            ColorFrame_Registration.Instance,
            APerkEffect_Registration.Instance,
            PerkQuestEffect_Registration.Instance,
            PerkAbilityEffect_Registration.Instance,
            APerkEntryPointEffect_Registration.Instance,
            PerkCondition_Registration.Instance,
            PerkEntryPointModifyValue_Registration.Instance,
            PerkEntryPointAddRangeToValue_Registration.Instance,
            PerkEntryPointModifyActorValue_Registration.Instance,
            PerkEntryPointAbsoluteValue_Registration.Instance,
            PerkEntryPointAddLeveledItem_Registration.Instance,
            PerkEntryPointAddActivateChoice_Registration.Instance,
            PerkEntryPointSelectSpell_Registration.Instance,
            PerkEntryPointSelectText_Registration.Instance,
            PerkEntryPointSetText_Registration.Instance,
            PerkScriptFlag_Registration.Instance,
            DialogResponsesAdapter_Registration.Instance,
            ScriptFragments_Registration.Instance,
            PerkAdapter_Registration.Instance,
            PerkScriptFragments_Registration.Instance,
            IndexedScriptFragment_Registration.Instance,
            BodyPart_Registration.Instance,
            AddonNode_Registration.Instance,
            ActorValueInformation_Registration.Instance,
            ActorValueSkill_Registration.Instance,
            ActorValuePerkNode_Registration.Instance,
            CameraShot_Registration.Instance,
            CameraPath_Registration.Instance,
            Impact_Registration.Instance,
            ImpactData_Registration.Instance,
            FootstepSet_Registration.Instance,
            LocationReference_Registration.Instance,
            LocationCellUnique_Registration.Instance,
            LocationCellStaticReference_Registration.Instance,
            LocationCoordinate_Registration.Instance,
            LocationCellEnablePoint_Registration.Instance,
            MessageButton_Registration.Instance,
            DefaultObjectManager_Registration.Instance,
            DefaultObject_Registration.Instance,
            MusicTrack_Registration.Instance,
            MusicTypeData_Registration.Instance,
            Footstep_Registration.Instance,
            StoryManagerBranchNode_Registration.Instance,
            AStoryManagerNode_Registration.Instance,
            StoryManagerQuestNode_Registration.Instance,
            StoryManagerEventNode_Registration.Instance,
            StoryManagerQuest_Registration.Instance,
            MusicTrackLoopData_Registration.Instance,
            DialogView_Registration.Instance,
            WordOfPower_Registration.Instance,
            ShoutWord_Registration.Instance,
            AssociationType_Registration.Instance,
            Relationship_Registration.Instance,
            Scene_Registration.Instance,
            SceneAdapter_Registration.Instance,
            SceneScriptFragments_Registration.Instance,
            ScenePhaseFragment_Registration.Instance,
            ScenePhase_Registration.Instance,
            ScenePhaseUnusedData_Registration.Instance,
            SceneActor_Registration.Instance,
            SceneAction_Registration.Instance,
            AnimationChangeThresholds_Registration.Instance,
            SoundCategory_Registration.Instance,
            SoundLoopAndRumble_Registration.Instance,
            SoundOutputChannels_Registration.Instance,
            SoundOutputChannel_Registration.Instance,
            SoundOutputAttenuation_Registration.Instance,
            SoundOutputData_Registration.Instance,
            Placement_Registration.Instance,
            LandscapeVertexHeightMap_Registration.Instance,
            CellMaxHeightData_Registration.Instance,
            ANavmeshParent_Registration.Instance,
            WorldspaceNavmeshParent_Registration.Instance,
            CellNavmeshParent_Registration.Instance,
            PerkEntryPointModifyValues_Registration.Instance,
            ANavigationMapInfoParent_Registration.Instance,
            NavigationMapInfoWorldParent_Registration.Instance,
            NavigationMapInfoCellParent_Registration.Instance
        );
    }
}
