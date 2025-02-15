# Link Interfaces
Link Interfaces are used by FormLinks to point to several record types at once.  For example, a Container record might be able to contain Armors, Weapons, Ingredients, etc.

An interface would be defined such as 'IItem', which all Armor, Weapon, Ingredients would all implement.

A `FormLink<IItem>` could then point to all those record types by pointing to the interface instead.
## Interfaces to Concrete Classes
### IAliasVoiceType
- Faction
- FormList
- Npc
- VoiceType
### IBindableEquipment
- Armor
### IComplexLocation
- Cell
- Worldspace
### IConstructible
- Armor
- Book
- Furniture
- Ingestible
- Ingredient
- Key
- Light
- MiscItem
### IConstructibleObjectTarget
- Activator
- Ammunition
- AObjectModification
- Armor
- Book
- Container
- Door
- Flora
- FormList
- Furniture
- Holotape
- Ingestible
- Ingredient
- Key
- LeveledItem
- Light
- MiscItem
- MovableStatic
- Npc
- Static
- StaticCollection
- Terminal
- Weapon
### IEffectRecord
- ObjectEffect
- Spell
### IEmittance
- Light
- Region
### IExplodeSpawn
- AcousticSpace
- Activator
- AddonNode
- Ammunition
- Armor
- ArmorAddon
- ArtObject
- BendableSpline
- Book
- Component
- Container
- Door
- DualCastData
- Explosion
- Flora
- Furniture
- Grass
- Hazard
- Holotape
- IdleMarker
- Ingestible
- Ingredient
- Key
- LeveledItem
- LeveledNpc
- LeveledSpell
- Light
- MiscItem
- MovableStatic
- Npc
- ObjectEffect
- PlacedObject
- Projectile
- SoundMarker
- Spell
- Static
- TalkingActivator
- Terminal
- TextureSet
- Tree
- Weapon
### IFurnitureAssociation
- Armor
- Hazard
- Perk
- Spell
- Weapon
### IHarvestTarget
- Ammunition
- Armor
- Book
- ConstructibleObject
- Holotape
- Ingestible
- Ingredient
- Key
- LeveledItem
- LeveledItem
- Light
- MiscItem
- Weapon
### IIdleRelation
- ActionRecord
- IdleAnimation
### IItem
- Ammunition
- Armor
- Book
- Component
- ConstructibleObject
- Holotape
- Ingestible
- Ingredient
- Key
- LeveledItem
- Light
- MiscItem
- Weapon
### IKeywordLinkedReference
- APlacedTrap
- Keyword
### ILinkedReference
- APlacedTrap
- PlacedNpc
- PlacedObject
### ILocationRecord
- Location
- LocationReferenceType
### ILockList
- FormList
- Npc
### INpcSpawn
- LeveledNpc
- Npc
### IObjectId
- Activator
- Ammunition
- AObjectModification
- Armor
- Book
- Container
- Door
- Faction
- FormList
- Furniture
- Holotape
- IdleMarker
- Ingestible
- Ingredient
- Key
- Light
- MiscItem
- MovableStatic
- Npc
- Projectile
- Spell
- Static
- TextureSet
- Weapon
### IOutfitTarget
- Armor
- LeveledItem
### IOwner
- Faction
- Npc
### IPlaceableObject
- AcousticSpace
- Activator
- AddonNode
- Ammunition
- AObjectModification
- Armor
- ArtObject
- BendableSpline
- Book
- Component
- ConstructibleObject
- Container
- Debris
- Door
- Explosion
- Flora
- FormList
- Furniture
- Holotape
- IdleMarker
- Ingestible
- Ingredient
- Key
- LeveledItem
- LeveledNpc
- LeveledSpell
- Light
- MiscItem
- MovableStatic
- Projectile
- SoundMarker
- Spell
- Static
- StaticCollection
- TalkingActivator
- Terminal
- TextureSet
- Tree
- Water
- Weapon
### IPlaced
- APlacedTrap
- PlacedNpc
- PlacedObject
### IPlacedSimple
- PlacedNpc
- PlacedObject
### IPlacedThing
- APlacedTrap
- PlacedObject
### IPlacedTrapTarget
- Hazard
- Projectile
### IPreCutMapEntryReference
- Landscape
- PlacedObject
### IReferenceableObject
- AcousticSpace
- Activator
- AddonNode
- Ammunition
- AObjectModification
- Armor
- ArtObject
- BendableSpline
- Book
- Component
- ConstructibleObject
- Container
- Debris
- Door
- Explosion
- Flora
- FormList
- Furniture
- Hazard
- Holotape
- IdleMarker
- Ingestible
- Ingredient
- Key
- LeveledItem
- LeveledNpc
- LeveledSpell
- Light
- MiscItem
- MovableStatic
- Npc
- Projectile
- SoundMarker
- Spell
- Static
- StaticCollection
- TalkingActivator
- Terminal
- TextureSet
- Tree
- Water
- Weapon
### IRegionTarget
- Flora
- LandscapeTexture
- MovableStatic
- Tree
### IRelatable
- Faction
- Race
### ISound
- SoundDescriptor
- SoundMarker
### ISpellRecord
- LeveledSpell
- Spell
### IStaticObject
- Static
- StaticCollection
### IStaticTarget
- Activator
- Ammunition
- Book
- Container
- Door
- Flora
- Furniture
- Ingestible
- MiscItem
- MovableStatic
- Static
- Terminal
- Weapon
## Concrete Classes to Interfaces
### AcousticSpace
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### ActionRecord
- IIdleRelation
### Activator
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### AddonNode
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### Ammunition
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### AObjectModification
- IConstructibleObjectTarget
- IObjectId
- IPlaceableObject
- IReferenceableObject
### APlacedTrap
- IKeywordLinkedReference
- ILinkedReference
- IPlaced
- IPlacedThing
### Armor
- IBindableEquipment
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IFurnitureAssociation
- IHarvestTarget
- IItem
- IObjectId
- IOutfitTarget
- IPlaceableObject
- IReferenceableObject
### ArmorAddon
- IExplodeSpawn
### ArtObject
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### BendableSpline
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### Book
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### Cell
- IComplexLocation
### Component
- IExplodeSpawn
- IItem
- IPlaceableObject
- IReferenceableObject
### ConstructibleObject
- IHarvestTarget
- IItem
- IPlaceableObject
- IReferenceableObject
### Container
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### Debris
- IPlaceableObject
- IReferenceableObject
### Door
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### DualCastData
- IExplodeSpawn
### Explosion
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### Faction
- IAliasVoiceType
- IObjectId
- IOwner
- IRelatable
### Flora
- IConstructibleObjectTarget
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
- IRegionTarget
- IStaticTarget
### FormList
- IAliasVoiceType
- IConstructibleObjectTarget
- ILockList
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Furniture
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### Grass
- IExplodeSpawn
### Hazard
- IExplodeSpawn
- IFurnitureAssociation
- IPlacedTrapTarget
- IReferenceableObject
### Holotape
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
### IdleAnimation
- IIdleRelation
### IdleMarker
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Ingestible
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### Ingredient
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Key
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Keyword
- IKeywordLinkedReference
### Landscape
- IPreCutMapEntryReference
### LandscapeTexture
- IRegionTarget
### LeveledItem
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IHarvestTarget
- IItem
- IOutfitTarget
- IPlaceableObject
- IReferenceableObject
### LeveledNpc
- IExplodeSpawn
- INpcSpawn
- IPlaceableObject
- IReferenceableObject
### LeveledSpell
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
- ISpellRecord
### Light
- IConstructible
- IConstructibleObjectTarget
- IEmittance
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Location
- ILocationRecord
### LocationReferenceType
- ILocationRecord
### MiscItem
- IConstructible
- IConstructibleObjectTarget
- IExplodeSpawn
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### MovableStatic
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IRegionTarget
- IStaticTarget
### Npc
- IAliasVoiceType
- IConstructibleObjectTarget
- IExplodeSpawn
- ILockList
- INpcSpawn
- IObjectId
- IOwner
- IReferenceableObject
### ObjectEffect
- IEffectRecord
- IExplodeSpawn
### Perk
- IFurnitureAssociation
### PlacedNpc
- ILinkedReference
- IPlaced
- IPlacedSimple
### PlacedObject
- IExplodeSpawn
- ILinkedReference
- IPlaced
- IPlacedSimple
- IPlacedThing
- IPreCutMapEntryReference
### Projectile
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IPlacedTrapTarget
- IReferenceableObject
### Race
- IRelatable
### Region
- IEmittance
### SoundDescriptor
- ISound
### SoundMarker
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
- ISound
### Spell
- IEffectRecord
- IExplodeSpawn
- IFurnitureAssociation
- IObjectId
- IPlaceableObject
- IReferenceableObject
- ISpellRecord
### Static
- IConstructibleObjectTarget
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticObject
- IStaticTarget
### StaticCollection
- IConstructibleObjectTarget
- IPlaceableObject
- IReferenceableObject
- IStaticObject
### TalkingActivator
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
### Terminal
- IConstructibleObjectTarget
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### TextureSet
- IExplodeSpawn
- IObjectId
- IPlaceableObject
- IReferenceableObject
### Tree
- IExplodeSpawn
- IPlaceableObject
- IReferenceableObject
- IRegionTarget
### VoiceType
- IAliasVoiceType
### Water
- IPlaceableObject
- IReferenceableObject
### Weapon
- IConstructibleObjectTarget
- IExplodeSpawn
- IFurnitureAssociation
- IHarvestTarget
- IItem
- IObjectId
- IPlaceableObject
- IReferenceableObject
- IStaticTarget
### Worldspace
- IComplexLocation
