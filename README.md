# Conociendo Colombia

## About the Project

**Conociendo Colombia** is a 2D video game prototype developed in Unity. Its purpose is to introduce players to Colombian culture through an interactive experience that combines exploration, collectible objects, and trivia.

The project uses a Colombian cultural setting to encourage players to discover information about the country's cultural heritage while completing gameplay challenges.

## Main Features

- **Player movement:** Control a character and explore the game environment.
- **Enemy behavior:** An enemy character follows the player.
- **Collectible objects:** Find and collect five objects throughout the level.
- **Timer:** Complete the collection challenge within the available 60 seconds.
- **Collectible counter:** Track the number of collected objects.
- **Trivia:** Collecting all five objects activates a trivia interaction.
- **Game states:** The prototype includes victory and game-over interface panels.
- **Audio assets:** The project includes music and sound-effect resources.

## Gameplay

The player explores the level while collecting five objects. A countdown timer provides a time-based challenge. When all five objects are collected, the trivia interaction is activated.

The prototype includes interface elements to display the collection progress, remaining time, and game results.

## Technologies and Tools

- Unity
- C#
- TextMesh Pro
- Unity Input System
- GitHub
- GitHub Desktop

## Project Structure

```text
Assets/
├── Art/
├── Audio/
├── Input/
├── Scripts/
├── Scenes/
├── Settings/
├── SPUM/
└── TextMesh Pro/
```

## Main Scripts

| Script | Responsibility |
|---|---|
| PlayerMovement.cs | Player movement |
| EnemyFollow.cs | Enemy following behavior |
| GameController.cs | Timer, collectible counter, and game states |
| ItemPickup.cs | Collectible object interaction |
| MenuPrincipal.cs | Main menu behavior |
| TriviaManager.cs | Trivia interaction |
| Reiniciar.cs | Game restart behavior |

## How to Open the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Add Project** and choose the project folder.
4. Open the project using the Unity version configured for it.
5. Open the `Menu Principal` or `Nivel1` scene from the `Assets/Scenes` folder.

## Development

This project was developed as part of the **Programming for Video Games** course.

**Course:** Programación para Videojuegos  
**Institution:** Universidad Nacional Abierta y a Distancia (UNAD)  
**Project:** Conociendo Colombia  
**Author / Team:** Diego Caicedo Ramirez  
**Unity Version:** Unity 6.3 LTS - 6000.3.11f1

## Repository

Source code and project resources are available in this GitHub repository:

https://github.com/DiegoGCR/ConociendoColombiaEtapa3