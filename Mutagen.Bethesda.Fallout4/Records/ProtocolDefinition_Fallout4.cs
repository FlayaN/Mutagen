using Mutagen.Bethesda.Fallout4;

namespace Loqui;

internal class ProtocolDefinition_Fallout4 : IProtocolRegistration
{
    public static readonly ProtocolKey ProtocolKey = new("Fallout4");
    void IProtocolRegistration.Register() => Register();
    public static void Register()
    {
        LoquiRegistration.Register(
            Fallout4MajorRecord_Registration.Instance,
            Fallout4Mod_Registration.Instance,
            Fallout4ModHeader_Registration.Instance,
            ModStats_Registration.Instance,
            Fallout4Group_Registration.Instance,
            GameSetting_Registration.Instance,
            GameSettingInt_Registration.Instance,
            GameSettingFloat_Registration.Instance,
            GameSettingString_Registration.Instance,
            GameSettingBool_Registration.Instance,
            GameSettingUInt_Registration.Instance,
            TransientType_Registration.Instance,
            AttractionRule_Registration.Instance,
            Keyword_Registration.Instance,
            LocationReferenceType_Registration.Instance,
            ActionRecord_Registration.Instance,
            Transform_Registration.Instance,
            ObjectBounds_Registration.Instance,
            Component_Registration.Instance,
            Global_Registration.Instance,
            SoundDescriptor_Registration.Instance,
            Decal_Registration.Instance,
            TextureSet_Registration.Instance,
            GlobalInt_Registration.Instance,
            GlobalShort_Registration.Instance,
            GlobalFloat_Registration.Instance,
            GlobalBool_Registration.Instance,
            ActorValueInformation_Registration.Instance,
            ADamageType_Registration.Instance,
            DamageType_Registration.Instance,
            DamageTypeIndexed_Registration.Instance,
            ObjectProperty_Registration.Instance,
            Class_Registration.Instance,
            LocationTargetRadius_Registration.Instance,
            ALocationTarget_Registration.Instance,
            LocationTarget_Registration.Instance,
            LocationCell_Registration.Instance,
            LocationObjectId_Registration.Instance,
            LocationObjectType_Registration.Instance,
            LocationKeyword_Registration.Instance,
            LocationFallback_Registration.Instance,
            Relation_Registration.Instance,
            Faction_Registration.Instance,
            CrimeValues_Registration.Instance,
            VendorValues_Registration.Instance,
            Rank_Registration.Instance,
            FormList_Registration.Instance,
            Outfit_Registration.Instance,
            PlacedObject_Registration.Instance,
            Door_Registration.Instance,
            ColorRecord_Registration.Instance,
            HeadPart_Registration.Instance,
            Part_Registration.Instance,
            MaterialSwap_Registration.Instance,
            SimpleModel_Registration.Instance,
            Model_Registration.Instance,
            BipedBodyTemplate_Registration.Instance,
            AnimationSoundTagSet_Registration.Instance,
            Debris_Registration.Instance,
            Explosion_Registration.Instance,
            LeveledSpell_Registration.Instance,
            SoundMarker_Registration.Instance,
            SoundRepeat_Registration.Instance,
            AcousticSpace_Registration.Instance,
            BodyPartData_Registration.Instance,
            ReverbParameters_Registration.Instance,
            Grass_Registration.Instance,
            LandscapeTexture_Registration.Instance,
            MaterialType_Registration.Instance,
            Effect_Registration.Instance,
            EffectData_Registration.Instance,
            MagicEffect_Registration.Instance,
            ObjectEffect_Registration.Instance,
            Destructible_Registration.Instance,
            DestructableData_Registration.Instance,
            DestructionStage_Registration.Instance,
            DestructionStageData_Registration.Instance,
            AVirtualMachineAdapter_Registration.Instance,
            VirtualMachineAdapter_Registration.Instance,
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
            ScriptFragment_Registration.Instance,
            ScriptFragmentIndexed_Registration.Instance,
            ScriptFragments_Registration.Instance,
            Activator_Registration.Instance,
            EquipType_Registration.Instance,
            Perk_Registration.Instance,
            Spell_Registration.Instance,
            Water_Registration.Instance,
            TalkingActivator_Registration.Instance,
            VoiceType_Registration.Instance,
            BodyTemplate_Registration.Instance,
            Icons_Registration.Instance,
            Armor_Registration.Instance,
            ArmorModel_Registration.Instance,
            ArmorAddon_Registration.Instance,
            ArtObject_Registration.Instance,
            Footstep_Registration.Instance,
            FootstepSet_Registration.Instance,
            ResistanceDestructible_Registration.Instance,
            ArmorAddonModel_Registration.Instance,
            ArmorResistance_Registration.Instance,
            BookTeachTarget_Registration.Instance,
            BookActorValue_Registration.Instance,
            BookPerk_Registration.Instance,
            BookSpell_Registration.Instance,
            BookTeachesNothing_Registration.Instance,
            Message_Registration.Instance,
            MessageButton_Registration.Instance,
            Quest_Registration.Instance,
            Static_Registration.Instance,
            Book_Registration.Instance,
            ContainerEntry_Registration.Instance,
            ContainerItem_Registration.Instance,
            ExtraData_Registration.Instance,
            OwnerTarget_Registration.Instance,
            NpcOwner_Registration.Instance,
            FactionOwner_Registration.Instance,
            NoOwner_Registration.Instance,
            Container_Registration.Instance,
            Npc_Registration.Instance,
            SoundOutputModel_Registration.Instance,
            NavigationMesh_Registration.Instance,
            MiscItem_Registration.Instance,
            MiscItemComponent_Registration.Instance,
            WeatherType_Registration.Instance,
            MusicTrack_Registration.Instance,
            MusicTrackLoopData_Registration.Instance,
            MusicType_Registration.Instance,
            MusicTypeData_Registration.Instance,
            Region_Registration.Instance,
            RegionArea_Registration.Instance,
            RegionData_Registration.Instance,
            RegionDataHeader_Registration.Instance,
            RegionSounds_Registration.Instance,
            RegionSound_Registration.Instance,
            RegionMap_Registration.Instance,
            RegionObjects_Registration.Instance,
            RegionObject_Registration.Instance,
            RegionWeather_Registration.Instance,
            RegionGrasses_Registration.Instance,
            RegionGrass_Registration.Instance,
            RegionLand_Registration.Instance,
            Weather_Registration.Instance,
            Worldspace_Registration.Instance,
            Ingredient_Registration.Instance,
            Terminal_Registration.Instance,
            GodRays_Registration.Instance,
            LensFlare_Registration.Instance,
            Light_Registration.Instance,
            StaticCollection_Registration.Instance,
            StaticPart_Registration.Instance,
            StaticPlacement_Registration.Instance,
            MovableStatic_Registration.Instance,
            SeasonalIngredientProduction_Registration.Instance,
            Tree_Registration.Instance,
            Flora_Registration.Instance,
            Furniture_Registration.Instance,
            RankPlacement_Registration.Instance,
            Bone_Registration.Instance,
            MovementType_Registration.Instance,
            ScriptEntryStruct_Registration.Instance,
            ScriptVariableProperty_Registration.Instance,
            ScriptStructProperty_Registration.Instance,
            ScriptVariableListProperty_Registration.Instance,
            ScriptStructListProperty_Registration.Instance,
            ScriptPropertyStruct_Registration.Instance,
            LeveledNpc_Registration.Instance,
            LeveledNpcEntry_Registration.Instance,
            LeveledNpcEntryData_Registration.Instance,
            FilterKeywordChance_Registration.Instance,
            LeveledItem_Registration.Instance,
            LeveledItemEntry_Registration.Instance,
            LeveledItemEntryData_Registration.Instance,
            Key_Registration.Instance,
            Ingestible_Registration.Instance,
            RadioReceiver_Registration.Instance,
            InstanceNaming_Registration.Instance,
            InstanceNamingRule_Registration.Instance,
            RuleSet_Registration.Instance,
            RuleName_Registration.Instance,
            Ammunition_Registration.Instance,
            IdleAnimation_Registration.Instance,
            IdleMarker_Registration.Instance,
            CollisionLayer_Registration.Instance,
            Holotape_Registration.Instance,
            ObjectModification_Registration.Instance,
            PlacedNpc_Registration.Instance,
            KeyFrame_Registration.Instance,
            Attack_Registration.Instance,
            Hazard_Registration.Instance,
            Race_Registration.Instance,
            RaceWeight_Registration.Instance,
            BodyData_Registration.Instance,
            BipedObjectData_Registration.Instance,
            MovementDataOverride_Registration.Instance,
            MovementData_Registration.Instance,
            MovementDirectionData_Registration.Instance,
            MovementRotationData_Registration.Instance,
            FaceFxPhonemes_Registration.Instance,
            Phoneme_Registration.Instance,
            HeadData_Registration.Instance,
            NeckFatAdjustmentsScale_Registration.Instance,
            HeadPartReference_Registration.Instance,
            TintGroup_Registration.Instance,
            TintTemplateOption_Registration.Instance,
            TintTemplateColor_Registration.Instance,
            MorphGroup_Registration.Instance,
            MorphPreset_Registration.Instance,
            FaceMorph_Registration.Instance,
            Subgraph_Registration.Instance,
            MorphValue_Registration.Instance,
            EquipmentSlot_Registration.Instance,
            AttackData_Registration.Instance,
            ObjectTemplateInclude_Registration.Instance,
            EffectShader_Registration.Instance,
            ColorFrame_Registration.Instance,
            Projectile_Registration.Instance,
            DualCastData_Registration.Instance,
            ImageSpaceAdapter_Registration.Instance,
            MagicEffectArchetype_Registration.Instance,
            MagicEffectLightArchetype_Registration.Instance,
            MagicEffectBoundArchetype_Registration.Instance,
            MagicEffectSummonCreatureArchetype_Registration.Instance,
            MagicEffectGuideArchetype_Registration.Instance,
            MagicEffectSpawnHazardArchetype_Registration.Instance,
            MagicEffectCloakArchetype_Registration.Instance,
            MagicEffectWerewolfArchetype_Registration.Instance,
            MagicEffectVampireArchetype_Registration.Instance,
            MagicEffectEnhanceWeaponArchetype_Registration.Instance,
            MagicEffectPeakValueModArchetype_Registration.Instance,
            VisualEffect_Registration.Instance,
            Weapon_Registration.Instance,
            MagicEffectSound_Registration.Instance,
            Condition_Registration.Instance,
            ConditionGlobal_Registration.Instance,
            ConditionFloat_Registration.Instance,
            ConditionData_Registration.Instance,
            FunctionConditionData_Registration.Instance,
            GetEventData_Registration.Instance,
            AObjectModProperty_Registration.Instance,
            ObjectTemplate_Registration.Instance,
            ObjectModIntProperty_Registration.Instance,
            ObjectModFloatProperty_Registration.Instance,
            ObjectModBoolProperty_Registration.Instance,
            ObjectModStringProperty_Registration.Instance,
            ObjectModFormLinkIntProperty_Registration.Instance,
            ObjectModFormLinkFloatProperty_Registration.Instance,
            NavmeshTriangle_Registration.Instance,
            EdgeLink_Registration.Instance,
            DoorTriangle_Registration.Instance,
            NavmeshGeometry_Registration.Instance,
            WorldspaceNavmeshParent_Registration.Instance,
            CellNavmeshParent_Registration.Instance,
            NavmeshGridArray_Registration.Instance,
            MaterialObject_Registration.Instance,
            ANavmeshParent_Registration.Instance,
            DistantLod_Registration.Instance,
            ConstructibleObject_Registration.Instance,
            FurnitureMarkerEntryPoints_Registration.Instance,
            FurnitureMarkerParameters_Registration.Instance,
            AimModel_Registration.Instance,
            Zoom_Registration.Instance,
            WeaponDamageType_Registration.Instance,
            WeaponExtraData_Registration.Instance,
            ANpcLevel_Registration.Instance,
            NpcLevel_Registration.Instance,
            PcLevelMult_Registration.Instance,
            PerkPlacement_Registration.Instance,
            CombatStyle_Registration.Instance,
            NpcWeight_Registration.Instance,
            NpcSound_Registration.Instance,
            NpcMorph_Registration.Instance,
            Package_Registration.Instance,
            NpcFaceTintingLayer_Registration.Instance,
            NpcBodyMorphRegionValues_Registration.Instance,
            NpcFaceMorph_Registration.Instance,
            TemplateActors_Registration.Instance,
            AHolotapeData_Registration.Instance,
            HolotapeSound_Registration.Instance,
            HolotapeVoice_Registration.Instance,
            HolotapeProgram_Registration.Instance,
            HolotapeTerminal_Registration.Instance,
            Scene_Registration.Instance,
            BendableSpline_Registration.Instance,
            VirtualMachineAdapterIndexed_Registration.Instance,
            ScriptFragmentsIndexed_Registration.Instance,
            TerminalHolotapeEntry_Registration.Instance,
            TerminalBodyText_Registration.Instance,
            TerminalMenuItem_Registration.Instance,
            AmbientColors_Registration.Instance,
            GodRay_Registration.Instance,
            ShaderParticleGeometry_Registration.Instance,
            CloudLayer_Registration.Instance,
            WeatherColor_Registration.Instance,
            WeatherAlpha_Registration.Instance,
            WeatherAmbientColorSet_Registration.Instance,
            WeatherSound_Registration.Instance,
            WeatherMagic_Registration.Instance,
            WeatherGodRays_Registration.Instance,
            Climate_Registration.Instance,
            NavigationMeshInfoMap_Registration.Instance,
            NavigationMapInfo_Registration.Instance,
            LinkedDoor_Registration.Instance,
            IslandData_Registration.Instance,
            PreferredPathing_Registration.Instance,
            NavmeshSet_Registration.Instance,
            NavmeshNode_Registration.Instance,
            Fallout4ListGroup_Registration.Instance,
            CellBlock_Registration.Instance,
            CellSubBlock_Registration.Instance,
            Cell_Registration.Instance,
            CellGrid_Registration.Instance,
            CellLighting_Registration.Instance,
            Ownership_Registration.Instance,
            CellWaterVelocity_Registration.Instance,
            CellMaxHeightData_Registration.Instance,
            CellExteriorLod_Registration.Instance,
            CellCombinedMeshReference_Registration.Instance,
            EncounterZone_Registration.Instance,
            ImageSpace_Registration.Instance,
            LightingTemplate_Registration.Instance,
            Location_Registration.Instance,
            ActivateParents_Registration.Instance,
            ActivateParent_Registration.Instance,
            EnableParent_Registration.Instance,
            LinkedReferences_Registration.Instance,
            WaterReflection_Registration.Instance,
            Layer_Registration.Instance,
            APlacedTrap_Registration.Instance,
            PlacedArrow_Registration.Instance,
            PlacedBeam_Registration.Instance,
            PlacedFlame_Registration.Instance,
            PlacedCone_Registration.Instance,
            PlacedBarrier_Registration.Instance,
            PlacedTrap_Registration.Instance,
            PlacedHazard_Registration.Instance,
            PlacedMissile_Registration.Instance,
            ReferenceGroup_Registration.Instance,
            PreCutMapEntry_Registration.Instance,
            Patrol_Registration.Instance,
            ATopicReference_Registration.Instance,
            TopicReference_Registration.Instance,
            TopicReferenceSubtype_Registration.Instance,
            DialogTopic_Registration.Instance,
            SplineConnection_Registration.Instance,
            PlacedPrimitive_Registration.Instance,
            Portal_Registration.Instance,
            Bounding_Registration.Instance,
            PlacedObjectLighting_Registration.Instance,
            Alpha_Registration.Instance,
            TeleportDestination_Registration.Instance,
            WaterVelocity_Registration.Instance,
            PlacedObjectRadio_Registration.Instance,
            PlacedObjectSpline_Registration.Instance,
            ProjectedDecal_Registration.Instance,
            LockData_Registration.Instance,
            NavigationDoorLink_Registration.Instance,
            PlacedObjectMapMarker_Registration.Instance,
            SplineLink_Registration.Instance,
            PowerGridConnection_Registration.Instance,
            NavmeshWaypoint_Registration.Instance,
            WorldspaceMaxHeight_Registration.Instance,
            WorldspaceParent_Registration.Instance,
            WorldspaceLandDefaults_Registration.Instance,
            WorldspaceMap_Registration.Instance,
            WorldDefaultLevelData_Registration.Instance,
            WorldspaceBlock_Registration.Instance,
            WorldspaceSubBlock_Registration.Instance,
            Landscape_Registration.Instance,
            WorldspaceGridReference_Registration.Instance,
            WorldspaceReference_Registration.Instance,
            BaseLayer_Registration.Instance,
            AlphaLayer_Registration.Instance,
            LayerHeader_Registration.Instance,
            LandscapeVertexHeightMap_Registration.Instance,
            LandscapeMPCD_Registration.Instance,
            QuestAdapter_Registration.Instance,
            QuestScriptFragment_Registration.Instance,
            QuestFragmentAlias_Registration.Instance,
            QuestStage_Registration.Instance,
            QuestLogEntry_Registration.Instance,
            QuestObjective_Registration.Instance,
            QuestObjectiveTarget_Registration.Instance,
            AQuestAlias_Registration.Instance,
            QuestReferenceAlias_Registration.Instance,
            QuestLocationAlias_Registration.Instance,
            QuestCollectionAlias_Registration.Instance,
            CollectionAlias_Registration.Instance,
            LocationAliasReference_Registration.Instance,
            ReferenceAliasLocation_Registration.Instance,
            ExternalAliasReference_Registration.Instance,
            CreateReferenceToObject_Registration.Instance,
            FindMatchingRefNearAlias_Registration.Instance,
            FindMatchingRefFromEvent_Registration.Instance,
            ExternalAliasLocation_Registration.Instance,
            LinkedAlias_Registration.Instance,
            DialogBranch_Registration.Instance,
            CameraPath_Registration.Instance,
            DialogResponses_Registration.Instance,
            DialogResponseFlags_Registration.Instance,
            DialogResponsesAdapter_Registration.Instance,
            DialogResponse_Registration.Instance,
            DialogSetParentQuestStage_Registration.Instance,
            SceneAdapter_Registration.Instance,
            SceneScriptFragments_Registration.Instance,
            ScenePhaseFragment_Registration.Instance,
            ScenePhase_Registration.Instance,
            SceneSetParentQuestStage_Registration.Instance,
            SceneActor_Registration.Instance,
            SceneAction_Registration.Instance,
            ScenePhaseUnusedData_Registration.Instance,
            ASceneActionType_Registration.Instance,
            SceneActionTypicalType_Registration.Instance,
            SceneActionStartScene_Registration.Instance,
            StartScene_Registration.Instance,
            SceneCamera_Registration.Instance,
            PackageAdapter_Registration.Instance,
            PackageScriptFragments_Registration.Instance,
            PackageIdles_Registration.Instance,
            APackageData_Registration.Instance,
            PackageBranch_Registration.Instance,
            PackageEvent_Registration.Instance,
            PackageDataBool_Registration.Instance,
            PackageDataInt_Registration.Instance,
            PackageDataFloat_Registration.Instance,
            PackageDataObjectList_Registration.Instance,
            PackageDataLocation_Registration.Instance,
            PackageDataTarget_Registration.Instance,
            PackageDataTopic_Registration.Instance,
            APackageTarget_Registration.Instance,
            PackageTargetSpecificReference_Registration.Instance,
            PackageTargetObjectID_Registration.Instance,
            PackageTargetObjectType_Registration.Instance,
            PackageTargetReference_Registration.Instance,
            PackageTargetAlias_Registration.Instance,
            PackageTargetSelf_Registration.Instance,
            PackageFlagsOverride_Registration.Instance,
            PackageRoot_Registration.Instance,
            PackageTargetInterruptData_Registration.Instance,
            PackageTargetKeyword_Registration.Instance,
            PackageTargetUnknown_Registration.Instance,
            LoadScreen_Registration.Instance,
            LoadScreenRotation_Registration.Instance,
            LoadScreenZoom_Registration.Instance,
            AnimatedObject_Registration.Instance,
            WaterNoiseProperties_Registration.Instance,
            AddonNode_Registration.Instance,
            DebrisModel_Registration.Instance,
            PerkAdapter_Registration.Instance,
            PerkScriptFragments_Registration.Instance,
            PerkScriptFragment_Registration.Instance,
            APerkEffect_Registration.Instance,
            PerkQuestEffect_Registration.Instance,
            PerkAbilityEffect_Registration.Instance,
            APerkEntryPointEffect_Registration.Instance,
            PerkEntryPointModifyValue_Registration.Instance,
            PerkEntryPointAddRangeToValue_Registration.Instance,
            PerkEntryPointModifyActorValue_Registration.Instance,
            PerkEntryPointAbsoluteValue_Registration.Instance,
            PerkEntryPointAddLeveledItem_Registration.Instance,
            PerkEntryPointAddActivateChoice_Registration.Instance,
            PerkEntryPointSelectSpell_Registration.Instance,
            PerkEntryPointSelectText_Registration.Instance,
            PerkEntryPointSetText_Registration.Instance,
            PerkCondition_Registration.Instance,
            BodyPart_Registration.Instance,
            CameraShot_Registration.Instance,
            Impact_Registration.Instance,
            ImpactDataSet_Registration.Instance,
            ImpactData_Registration.Instance,
            LocationReference_Registration.Instance,
            LocationCellUnique_Registration.Instance,
            LocationCellStaticReference_Registration.Instance,
            LocationCoordinate_Registration.Instance,
            LocationCellEnablePoint_Registration.Instance,
            DefaultObjectManager_Registration.Instance,
            DefaultObjectUse_Registration.Instance,
            DefaultObject_Registration.Instance,
            AStoryManagerNode_Registration.Instance,
            StoryManagerBranchNode_Registration.Instance,
            StoryManagerQuestNode_Registration.Instance,
            StoryManagerQuest_Registration.Instance,
            StoryManagerEventNode_Registration.Instance,
            DialogView_Registration.Instance,
            AssociationType_Registration.Instance,
            Relationship_Registration.Instance
        );
    }
}
