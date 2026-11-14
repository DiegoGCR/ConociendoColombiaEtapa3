# Technical Overview – Conociendo Colombia

## 1. Project Description

Conociendo Colombia is a 2D video game prototype developed in Unity. Its purpose is to introduce elements of Colombian culture through an interactive experience that combines exploration, collecting objects, time-based challenges, and trivia.

The game uses a setting inspired by traditional Colombian towns and their public spaces. The cultural and educational purpose is connected to the gameplay: players collect objects to advance and unlock a trivia activity related to the learning experience.

## 2. Main Gameplay Mechanics

### Player Movement
The player moves through the 2D environment using keyboard input. Movement allows the player to explore the level and collect the required objects while avoiding the enemy.

### Enemy Behavior
An enemy follows the player during gameplay. This creates a challenge that requires the player to pay attention to their surroundings while completing the objective.

### Collectible Objects
The level contains five collectible objects. When the player touches an object, it disappears and the collection counter is updated.

### Timer
The game includes a 60-second countdown. The timer creates a time-based objective and encourages the player to plan their movement.

### Trivia and Game Progression
After collecting all five objects, the game activates the trivia activity through the `TriviaManager` script.

### Victory and Game Over
The game includes different outcomes:
- The player advances to the victory state after completing the required objective and trivia flow.
- The game ends in a game-over state if the timer reaches zero or the enemy catches the player.

## 3. Technical Implementation

The prototype was developed with Unity and C#. TextMesh Pro is used for text-based interface elements, and the Unity Input System is included in the project.

The main scripts are:

| Script | Responsibility |
|---|---|
| `PlayerMovement.cs` | Player movement |
| `EnemyFollow.cs` | Enemy pursuit behavior |
| `GameController.cs` | Timer, counter, and game states |
| `ItemPickup.cs` | Collectible object interaction |
| `TriviaManager.cs` | Trivia activity |
| `MenuPrincipal.cs` | Main menu behavior |
| `Reiniciar.cs` | Restart behavior |

## 4. Art and Audio Resources

The project includes visual resources for the game environment, interface, and collectible objects. These assets support the visual presentation of the level and help the player identify important game elements.

The project also includes music and sound-effect files. Audio resources are part of the game's audiovisual presentation and are intended to support the player's experience.

## 5. Accessibility Considerations

The current prototype uses keyboard input and on-screen text elements, including the collection counter and timer.

These features provide basic ways to interact with and understand the game. However, the project still requires a more complete accessibility review. Alternative input methods, text readability, contrast, and feedback that does not depend exclusively on sound should be evaluated before claiming compliance with accessibility guidelines.

## 6. Development and Version Control

The project is maintained in GitHub. The repository structure separates scripts, artwork, audio, input configuration, scenes, and other Unity resources to make the project easier to understand and maintain.

GitHub Desktop is used to manage commits and synchronize changes with the remote repository.

## 7. Conclusion

Conociendo Colombia combines basic video game mechanics with a cultural and educational objective. Collecting objects, avoiding an enemy, managing time, and accessing trivia are intended to make cultural learning part of the player's progression rather than a separate decorative element.