# Little Chaser

A 2D platformer game built in Unity where the player navigates through a side-scrolling level, collects tokens, defeats enemies, and reaches the victory zone.

🎮 **Play it online:** [Little Chaser on Unity Play](https://play.unity.com/en/games/de4c9422-ab80-4d3d-aab4-9f5eff0d4a53/little-chaser)

---

## How to Play

| Action | Key / Button |
|--------|-------------|
| Move left / right | `A` / `D` or Arrow keys |
| Jump | `Space` or `W` or Up arrow |
| Pause / Menu | `Escape` |

**Goal:** Reach the end of the level (the victory zone) while collecting as many tokens as possible. Avoid enemies — or jump on top of them to defeat them. Falling into death zones or getting hit too many times will respawn the player.

---

## Game Features

- Smooth 2D platformer movement with jump physics
- Collectible tokens scattered across the level
- Patrol-based enemy AI that the player can stomp to defeat
- Health system — taking hits reduces the player's lives
- Death zones (falls off-screen respawn the player)
- Victory zone that triggers the congratulations screen on level completion
- Parallax scrolling background for depth
- Full animation set: idle, run, jump, land, hurt, death, victory
- Background music and sound effects for all actions
- Main menu and in-game pause menu

---

## Built With

- **Engine:** [Unity 6](https://unity.com/) (version 6000.4.5f1)
- **Rendering:** Universal Render Pipeline (URP)
- **Camera:** Cinemachine 3 (version 3.1.6) — smooth follow camera
- **Input:** Unity Input System — keyboard and gamepad support
- **UI Text:** TextMesh Pro
- **Physics:** Unity 2D Physics (Rigidbody2D / kinematic character controller)
- **Language:** C# (.NET)

---

## Assets Used

All assets are from the **Unity 2D Platformer Microgame** template (v5.0.0), available on the Unity Asset Store.

### Sprites
| Asset | Description |
|-------|-------------|
| Player sprites | Idle, Run, Jump, Land, Hurt, Death, Victory, Spawn animations |
| Enemy sprites | Idle, Run, Hurt, Death animations |
| Token sprites | Spin and collected animations |
| Environment | Ground tiles, floating platform tiles, buildings, trees, clouds, hillsides, fences, houses, plants, mountains |
| Mod props | Archway, Cactus, Crystal, FirTree, Mushroom, Rocket, Pyramid, PalmTree and more |

### Color variants (Mod Assets)
Environment tiles are available in 6 color themes: **Default**, **Brown**, **Gold**, **Green**, **Magenta**, and **Teal**.

### Audio
| File | Use |
|------|-----|
| `Music.wav` | Background music |
| `jump.wav` | Player jump |
| `Walk01.wav`, `Walk02.wav` | Footstep sounds |
| `LandOnGround.wav` | Landing sound |
| `LandOnEnemy.wav` | Stomping an enemy |
| `Hurt.wav` | Player taking damage |
| `Death.wav` | Player death |
| `Collectable.wav` | Collecting a token |

### Fonts
- **LiberationSans** (SIL Open Font License) — used by TextMesh Pro

---

## Project Structure

```
Assets/
├── Scenes/
│   └── SampleScene.unity       # Main game scene
├── Scripts/
│   ├── Core/                   # Simulation / event system
│   ├── Mechanics/              # Player, enemy, token, zones
│   ├── Gameplay/               # Simulation events (jump, death, victory…)
│   ├── UI/                     # Main menu, HUD, victory screen
│   ├── View/                   # Parallax, animated tiles
│   └── Model/                  # PlatformerModel data container
├── Prefabs/                    # Player, tiles, camera prefabs
├── Character/Sprites/          # Character sprite sheets
├── Environment/                # Level tile sprites and tile assets
├── Audio/                      # All sound files
├── Tiles/                      # Unity Tile assets used in Tilemaps
├── Settings/                   # URP, Input System, renderer settings
├── Mod Assets/                 # Extra props, colored variants, shaders
└── Documentation/              # PDF user guide
```

---

## Similar Games

- **Super Mario Bros.** — classic 2D platformer; Little Chaser follows the same run/jump/stomp formula but is a shorter single-level experience
- **Celeste** — precision platformer; Little Chaser is more casual with a simpler level design
- **Unity Platformer Microgame** — this project is based on that template but customised with a unique level layout, custom token placement, and UI additions including the congratulations screen

---

## Authors

**Luka Dermendziev**  
**Izabela Eftimova**
