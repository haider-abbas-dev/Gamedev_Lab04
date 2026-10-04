# Game Development (CSC495) – Lab 4

Terrain, Character Movement, Skybox & Cinemachine Follow Camera — Unity 6.3 (URP).

## Contents
- **Terrain** – sculpted hills/valleys, smoothed, painted with grass and a dirt path
- **Character** – Mixamo Ch19_nonPBR with Dwarf Idle / Running (Animator, `Speed` float, transitions at 0.1)
- **Movement** – `Assets/scripts/CharacterMovment.cs` (W/A/S/D or arrow keys, rotates toward movement, follows terrain height)
- **Skybox** – `Assets/Enviroments/Skybox_Mat.mat` (Skybox/Procedural), assigned in Lighting → Environment
- **Camera** – Cinemachine 3 `CM_PlayerCamera` following the player (Follow + Rotation Composer)
- **Submission document** – `Lab4_Submission.docx` (screenshots and checklist)

## How to run
1. Open the folder in Unity Hub with Unity 6.3 (6000.3.x).
2. Open `Assets/Scenes/SampleScene.unity`.
3. Press Play and move with W/A/S/D or the arrow keys.
