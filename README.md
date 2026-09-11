# Game in Unity

Infinite / factory-style Unity gameplay prototype written in C#. This repo holds gameplay scripts, 3ds Max models, and a texture — not a full Unity project (no `ProjectSettings/` or scenes). Drop `Assets/` into a Unity project to use them.

## Features

- Factory machines (`zavodm` / `zavodh` / `zavodw`) spawn collectibles on a timer (`One_money`)
- Random “Broken” state on machines; click to repair (`brock`)
- Click-to-destroy collectibles (`click`) and score UI wiring (`Score`, money display via fold transform X)
- Countdown timer UI (`time`) with “Time's Up!”
- Car / transport motion helpers (`clickoncar`, `go_transport`, `cargravity`, `NewBehaviourScript`)
- Scene navigation: restart to build index 1 (`restart`), back to previous scene (`gomm`)
- Art sources: `SML.max`, `VOSK.max`, `PEHTextures.jpg`
- Unity `.meta` files kept next to assets for GUID continuity
- Apache License 2.0 (`license`)

## Tech Stack

- **Backend:** Unity MonoBehaviours (C#)
- **Frontend:** Unity UI (`UnityEngine.UI` Text) + scene objects in the editor
- **Database:** None
- **DevOps/Infrastructure:** None (local Unity Editor)

## System Architecture / Database Schema

No database. Intended runtime flow inside Unity:

```
Unity Scene(s) [not in this repo]
        │
        ├── Factory objects ── One_money (spawn) + brock (break/repair)
        ├── Collectibles     ── click (destroy on mouse down)
        ├── Transport/car    ── go_transport / clickoncar / cargravity
        ├── HUD              ── time + score labels
        └── Buttons          ── restart / gomm (SceneManager)
```

### Project layout

```
Assets/
  Scripts/     # C# MonoBehaviours (+ .meta)
  Models/      # SML.max, VOSK.max (+ .meta)
  Textures/    # PEHTextures.jpg (+ .meta)
.gitignore
README.md
license
.gitattributes
```

## Getting Started

### Prerequisites

- Unity Editor (any recent LTS that can import these scripts; scripts use classic `OnMouseDown` / `SceneManager`)
- Optional: Autodesk 3ds Max (or another tool) if you need to edit `.max` files before importing

### Running Locally

```bash
git clone https://github.com/ProgrammerKrot/Game-in-Unity.git
cd Game-in-Unity
```

1. Create a new Unity 3D project (or open an existing one).
2. Copy this repo’s `Assets/Scripts`, `Assets/Models`, and `Assets/Textures` into your project’s `Assets/` folder (merge if `Assets` already exists).
3. Import `.max` models / texture in the Editor as needed.
4. Attach scripts to GameObjects and wire public fields / UI Text references in the Inspector (names like `zavodm`, `fold3`, `fold4` are expected by the scripts).
5. Add at least two scenes if you use `gomm` / `restart` (build index 0 = menu, 1 = game, or adjust the scripts).
6. Press Play in the Editor.

There is no standalone build config in this repository.
