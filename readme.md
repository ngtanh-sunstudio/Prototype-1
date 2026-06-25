# Prototype 1

A simple driving prototype completed during the Unity Junior Programmer pathway.

## What I Learned

### [Lesson 1.1 - Start Your 3D Engines](https://learn.unity.com/pathway/junior-programmer/unit/player-control/tutorial/lesson-1-1-start-your-3d-engines?version=6.3)

**New functionality**

- Project set up with assets imported.
- Vehicle positioned at the start of the road.
- Obstacles positioned in front of the vehicle.
- Camera positioned behind the vehicle.

**New concepts & skills**

- Create a new project in Unity.
- Import assets.
- Add objects to the scene.
- **Game view vs. Scene view:** the Scene view is used to edit the world, while the Game view shows what the camera displays.
- **Project, Hierarchy, and Inspector windows:**
  - **Project:** manages assets stored in the project.
  - **Hierarchy:** lists objects in the current scene.
  - **Inspector:** displays and edits the selected object's components and properties.
- **Navigate 3D space:** pan, orbit, zoom, and focus the Scene view to inspect and edit objects.
- **Move and Rotate tools:** change an object's position and orientation in the scene.
- **Customize the Editor layout:** moved around the Unity Editor's windows to a personalized layout. 

### [Lesson 1.2 - Pedal to the Metal](https://learn.unity.com/pathway/junior-programmer/unit/player-control/tutorial/1-2-move-the-vehicle-with-your-first-line-of-c?version=6.3)

**New functionality**

- **Vehicle moves down the road at a constant speed:** implemented forward movement in [PlayerController](Assets/Scripts/PlayerController.cs).
- **Vehicle collides with obstacles:** added Rigidbody and Collider components so collisions use Unity physics.

**New concepts & skills**

- C# scripts.
- `Start` vs. `Update`: initialization (`Start`) runs once, while frame-based logic (`Update`) runs repeatedly.
- Comments.
- Methods.
- Pass parameters.
- `Time.deltaTime`: keeps movement speed consistent across different frame rates.
- Multiply (`*`) operator.
- **Components:** add data and behavior to a GameObject.
- **`Collider` and `Rigidbody`:** a Collider defines the collision shape, while a Rigidbody enables physics-based movement and reactions.

### [Lesson 1.3 - High Speed Chase](https://learn.unity.com/pathway/junior-programmer/unit/player-control/tutorial/1-3-make-the-camera-follow-the-vehicle-with-variables?version=6.3)

**New functionality**

- **Camera follows the vehicle at a set offset:** updates the camera after vehicle movement in [FollowPlayer](Assets/Scripts/FollowPlayer.cs).

**New concepts & skills**

- Variables.
- Data types.
- **Access modifiers:** control where a variable or method can be accessed.
- Declare and initialize variables.

### [Lesson 1.4 - Step into the Driver's Seat](https://learn.unity.com/pathway/junior-programmer/unit/player-control/tutorial/lesson-1-4-use-user-input-to-control-the-vehicle?version=6.3)

**New functionality**

- **Up/down input moves the vehicle forward and backward:** reads vertical input in [PlayerController](Assets/Scripts/PlayerController.cs).
- **Left/right input turns the vehicle:** rotates it around the Y axis in [PlayerController](Assets/Scripts/PlayerController.cs).

**New concepts & skills**

- Empty objects.
- **Get user input:** read a two-axis movement action through Unity's new Input System.
- **Translate vs. Rotate:** `Translate` changes position, while `Rotate` changes orientation.

## Extra

- Press `F` to switch between the chase and front-facing camera positions.
