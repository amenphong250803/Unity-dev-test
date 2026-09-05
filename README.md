# 3D Soccer Prototype

A 3D soccer gameplay prototype developed with **Unity and C#**.

The project focuses on experimenting with core soccer gameplay systems, including player control, ball interaction, automated goal targeting, dynamic camera behavior, contextual interaction, and gameplay feedback.

## Features

- Player movement and control.
- Ball interaction using Unity Rigidbody Physics.
- Automated nearest-goal targeting.
- Dynamic follow camera for player and ball.
- Contextual interaction system using trigger detection.
- Automatic ball selection and goal scoring.
- Particle effects and gameplay feedback.

## Gameplay Systems

### Player Controller

Implemented a player controller for movement and interaction with the ball.

The controller is designed to keep movement logic separate from other gameplay systems, making it easier to extend with additional actions.

### Ball Physics

Implemented ball interaction using **Unity Rigidbody Physics**.

The system uses physics-based movement to create more natural ball behavior during gameplay.

This project helped me practice:

- Rigidbody
- Collision detection
- Trigger detection
- Physics-based movement
- Applying forces
- Handling interactions between gameplay objects

### Automated Goal Targeting

Implemented automatic nearest-goal targeting for the ball.

The system determines the appropriate goal based on the current gameplay situation and uses that information during the scoring process.

This was an opportunity to practice:

- Distance calculation
- Target selection
- Runtime decision making
- Separating targeting logic from ball behavior

### Top-Down Dynamic Camera

Implemented a top-down camera system that dynamically follows the player and ball.

The camera behavior changes based on gameplay movement to keep important objects visible.

This helped me practice creating camera systems that respond to gameplay state instead of simply following a single transform.

### Interaction System

Implemented contextual interactions using Unity trigger detection.

Depending on the player's position and current gameplay situation, different interactions can become available.

This system was designed to keep interaction logic separate from individual gameplay objects.

### Automatic Ball Selection

Implemented an automatic ball selection system that identifies and selects the appropriate ball during gameplay.

This allows the player to interact with the ball without manually selecting it.

### Gameplay Feedback

Added particle effects and other gameplay feedback to improve the responsiveness of important interactions such as ball contact and scoring.

## Architecture & Programming

The project was developed using **C# and Unity's component-based architecture**.

I focused on creating reusable gameplay components and keeping individual systems responsible for specific gameplay behaviors.

Key concepts practiced:

- Object-Oriented Programming
- Component-based architecture
- Separation of responsibilities
- Reusable gameplay components
- Physics-based gameplay
- Runtime target selection
- Trigger-based interaction

## What I Learned

This project helped me understand how multiple gameplay systems can work together while maintaining separate responsibilities.

In particular, I gained practical experience with:

- Unity Physics
- Rigidbody
- Collision and Trigger systems
- Player Controllers
- Target selection logic
- Dynamic camera systems
- Gameplay interaction
- C# OOP

## Tech Stack

- **Engine:** Unity
- **Language:** C#
- **Physics:** Unity Rigidbody / Physics
- **Camera:** Unity Camera System
- **Version Control:** Git / GitHub
