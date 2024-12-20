---
sidebar_position: 2
---

# Unity

## Interview Questions

Some Unity interview questions that may come up during the process:

### Component

**1.1 What is the purpose of the Transform component? Can a GameObject exist without it?**

- No, gameObject cant exist without transform. It automatically added when you create a gameObject
- Transform is used to position, rotate, scale, and parent gameObject

**1.2 How do you attach and remove components at runtime using scripts?**

- To add, use AddComponent method. To remove, use save reference to component and then use Destroy method

**1.3 Can a GameObject have multiple components of the same type?**

- **Yes**, you can have multiple components of the same type. For example, a gameObject can have a BoxCollider and a SphereCollider component depend on it shape

**1.4 How do Canvas and RectTransform components work in Unity UI?**

- All UI elements must be a child of a Canvas to be rendered, it determines how UI elements are drawn and can render in Screen Space/World Space.
- RectTransform is a Transform for UI elements, controlling position, size, and anchors. It allows flexible layouts that adapt to different screen sizes.

**1.5 What is the EventSystem component?**

- The EventSystem is a global Unity component that acts as the backbone for detecting and managing UI events, such as clicks, touches, and keyboard inputs.

---

### Physics

**2.1 What are the differences between BoxCollider, SphereCollider, and MeshCollider? Which one is best for what?**

- **SphereCollider:** Faster and more efficient for simple. It check the distance between the centers of two spheres and comparing it to the sum of their radii
- **BoxCollider:** Slightly more complex in terms of calculations but still highly efficient. It involves checking whether a point or another collider intersects with the 3D volume of the box
- **MeshCollider:** More complex than BoxCollider and SphereCollider, but it is more accurate and provides more detailed collision information.

**2.2 Can two GameObjects with only colliders collide with each other? What happens if one of the colliders is set to "Trigger"?**

- No, on of the gameObject must have a rigidbody component to collide with other gameObject (with collider)
- When collider is set to trigger, it will only detect collision but doesn't effect the physics

**2.3 Difference Between `AddForce()` and `Velocity` Property in a Rigidbody**

- `AddForce()` Applies a force to the Rigidbody, affecting its velocity over time based on mass and drag. It is used for forces like gravity, thrust, or wind.
- `Velocity` Directly sets the Rigidbody's speed and direction. It overrides physics simulation and sets the exact movement, which means it does not account for external forces.

**2.4 Difference Between `ForceMode.Force` and `ForceMode.Impulse`?**

- `ForceMode.Force` Applies a continuous force over time, making the Rigidbody accelerate gradually. This mode takes the Rigidbody's mass into account.
- `ForceMode.Impulse` Applies an instant force, changing the Rigidbody's velocity immediately. Ideal for sudden impacts or quick movements.

**2.5 Scenario: Setup a gun shooting at a target > The bullet can't pass though target > The Bullet can reflect off the target**

- **Setup bullet and target:**

  - **Bullet**: Attach RigidBody and Collider to the bullet. Ensure isKinematic is set to false and detection to Continuous.
  - **Target**: Same thing but have the isKinematic set to true and toggle if you want target to move

- **Collision Detection and Response:**

  - Make you bullet collider detection to Continuous to avoid missed collisions, especially for fast-moving bullets.
  - Use `collision.contacts` and `Vector3.Reflect(transform.forward, contact.normal)` to calculate the reflected direction.
  - Apply a Physics Material to the bullet or target to control the friction and bounciness.

---

### Animation

**3.1 What is inverse kinematics (IK)?**

- IK adjusts parts of a character’s skeleton to match target positions dynamically (e.g., make hands touch a door handle)

**3.2 Scenario: Setup an NPC > NPC to transition from Idle to walk to Run > NPC to shooting while walking > NPC aim and shott at a moving target while moving**

- **Setup walk and Run animations on the NPC:**

  - Assign `Animator` to the NPC and create a `Animatior Controller` component.
  - Create a `Blend Tree` with a Speed parameter.

- **Aim while walking/Running:**

  - In the Animator Controller, create a new Layer for aiming.
  - Add an "Aim" animation and set it to override the base layer (set "Weight" to 1).
  - Ensure the "Aim" animation affects only the upper body by using an Avatar Mask.

- **Aim at a Moving Target While Walking:**

  - Set up IK for aiming by enable IK in the animator component.
  - Implement the lookAt in your script.

  ```cs
   void OnAnimatorIK(int layerIndex) {
      if (isAiming) {
      animator.SetLookAtWeight(1.0f); // Adjust weight for smoothness
      animator.SetLookAtPosition(target.position); // Set target position
      }
   }
  ```

---

### Lighting & Shadow

**4.1 What is global illumination (GI), and how does Unity implement it?**

- Global Illumination (GI) simulates how light bounces off surfaces and indirectly illuminates the scene. Unity implements GI using Precomputed Realtime GI (calculated dynamically) and Baked GI (calculated offline and stored in lightmaps).

**4.2 What are light probes and reflection probes, and how are they used in Unity?**

- **Light probes:**

  - Light probes capture lighting information in a scene and provide indirect lighting for dynamic or moving objects.
  - Use case: When an object moves between lit and shadowed areas, light probes ensure the object reflects the lighting correctly without rebaking the entire scene.

- **Reflection probes:**
  - Reflection probes capture a 360-degree snapshot of their environment and apply this as reflections to objects with reflective materials.
  - Use case: Reflection probes are essential for adding realistic reflections to glossy surfaces like water, mirrors, or polished floors.

**4.3 What is light mapping in Unity? How many time light get render after baking?**

- Light mapping is the process of precomputing lighting and **baking** it into textures, known as lightmaps, to reduce runtime lighting calculations andf improve performance. However, lightmaps increase memory usage and require preprocessing.
- Once baked, the lighting information is rendered once during the baking process and stored in the lightmap.

**4.4 What is the difference between forward rendering and deferred rendering? How do they affect lighting calculations?**

- Forward Rendering: Calculates lighting per object. Best for scenes with fewer lights.
- Deferred Rendering: Calculates lighting per pixel. Best for scenes with many lights. Supports advanced effects like dynamic shadows and multiple light sources but is more memory-intensive.

**4.5 What is ambient lighting, and how is it configured in Unity?**

- Ambient lighting provides general, indirect light to all objects in a scene, simulating light scattering from the environment. It’s configured in the Lighting Settings under the Environment Lighting section

**4.6 How do you troubleshoot light bleeding or artifacts in a Unity scene?**

- Increase lightmap resolution.
- Ensure proper UV layout to prevent lightmap seams.
- Use shadow bias to prevent overlapping light calculations.
- Reduce the number of indirect samples in light settings.

**4.7 How does Unity handle shadows, and what are the different shadow settings available?**

- Unity supports **hard, soft, and contact shadows**. Key shadow settings include:
  - **Distance:** Controls the shadow draw distance.
  - **Resolution:** Sets shadow map resolution.
  - **Bias:** Adjusts shadow positioning to avoid artifacts.
  - **Cascades:** Uses multiple shadow maps for improved quality at different distances, especially in large scenes.

**4.8 Troubleshooting Shadows. If a shadow is not showing in Unity, how would you solve it?**

- **Check Light Settings:** Ensure the light has shadows enabled (Hard or Soft).
- **Shadow Distance:** Verify the shadow distance in the Quality Settings (Edit > Project Settings > Quality).
- **Object Settings:** Ensure the object casting or receiving shadows is not marked as Static if shadows are needed dynamically.
- **Graphics Settings:** Ensure the renderer supports shadows and the appropriate settings (e.g., Forward or Deferred rendering).
- **Bias and Normal Bias:** Adjust shadow bias settings in the Light component to prevent shadows from disappearing due to incorrect calculations.

---

### Rendering and Camera

**5.1 What are Occlusion Culling, Frustum Culling, and LOD (Level of Detail) in Unity?**

- **Occlusion Culling** is use to optimize rendering by not drawing objects hidden behind others. It works by precomputing visibility data during baking in the Occlusion Culling window.
- **Frustum culling** is a technique where objects outside the camera's view are not rendered. Unity implements it automatically for objects outside the camera’s frustum (view cone).
- **LOD (Level of Detail):** allows objects to switch to lower-detail models based on their distance from the camera.

**5.2 Static vs Dynamic Batching**

- **Static Batching**
  - Combines non-moving objects into a single batch.
  - Requires objects to be marked as Static in the Inspector.
  - Precomputed at build time; reduces runtime overhead.
  - No vertex limit, but uses more memory.
- **Dynamic Batching**
  - Combines small, moving objects at runtime.
  - Limited to objects with < 300 vertices and the same material.
  - Saves draw calls but increases CPU overhead.

**5.3 What is GPU instancing?**

- GPU instancing allows rendering multiple instances of the same mesh/material combination with one draw call.

**5.4 How would you create a split-screen or multi-camera setup in Unity?**

- You can create multiple cameras and set their Viewport Rect to define the screen space they occupy. Adjust the position and size of each viewport for split-screen functionality.

**5.5 Camera Rendering Order in 2D vs 3D**

- **2D Rendering Order**

  - **Sorting Layers** and **Order in Layer** determine which objects appear on top.
  - **Camera Depth:** Higher depth values render on top of lower ones.

- **3D Rendering Order**
  - **Camera Depth:** Higher depth values render after lower ones.
  - **Z-buffer:** Ensures objects closer to the camera are rendered in front of farther ones.
  - **Render Queue:** Defines the order of rendering materials (e.g., opaque first, then transparent).

---

### Particle System

**6.1 How do you scale a particle system in Unity? What if transform scaling not work?**

- Easiest way to scale a particle system is to adjust the Transform scale of the particle system GameObject.
- You can also adjust the scale within the Renderer module if you need specific visual adjustments
- Last option is to loop through all particles and scale them individually by adjusting `Start Size` or `Size over Lifetime` parameters

---

### Shader

**7.1 Differences Between Vertex and Fragment Shaders**

- **Vertex Shaders:** Process vertices, transform positions, and pass data to the fragment shader.
- **Fragment Shaders:** Determine the final color of each pixel, handling texture, lighting, and effects.

**7.2 Purpose of Normal Maps**

- Normal maps simulate detailed surface features without adding geometry by altering how light interacts with a surface, making it appear bumpy or detailed.

**7.3 Senario: Dropping a Boulder on a Car and Having the Car Dent Based on the Impact**

- **Mesh Deformation**

  - Use a mesh deformation technique to alter the car's mesh at the point of impact. This can be done with a script that modifies the vertices of the car mesh to create a dent.

- **Normal Map and Shader**

  - Apply a shader that uses a normal map or a displacement effect to simulate the dent without altering the actual geometry.

---

### Optimization

**8.1 Common Optimization Techniques**

Check out my [Unity Optimization](../../unity-docs/unity-optimizing.md) page for more details

- Combine sprite using **Sprite Atlas** to reduce draw call.
- You can use custom **Tick System** to replace normal **Update** in mono to reduce update call.
- you can create a **Benchmark Tool** to test your code to measure its performance, this will help you identify where/what being slow.
- Using **Hash String** with for animator and shader property.
- Changing renderer pipeline setting, you can turn off setting like **Depth Texture** to reduce draw call.
- For instantiate lots of object, you can use **Object Pooling System** to reuse the object and reduce garbage collection.
- **Compressing** textures, sprites and audios.
- Use **Occlusion Culling, Frustum Culling, and LOD** to reduce draw call by not rendering unseen objects.

**8.2 Texture Compression**

- **Important Settings**

  - **Texture Size:** Keep texture sizes as small as possible without sacrificing visual quality (e.g., 512x512, 1024x1024).
  - **Compression Quality:** Choose high, medium, or low quality settings in Unity.
  - **Mipmaps:** Improves performance and reduces aliasing when textures are viewed at smaller sizes.
  - **Alpha Channel Compression:** Use formats like BC7 or ETC2 for textures with transparency.

- **Unity Import Settings**

  - **Texture Type:**

    - **Default:** For general use like 3D models and UI elements.
    - **Sprite:** Used for 2D game assets.
    - **Normal Map:** Compresses normal maps to improve detail and save memory.
    - **Lightmap:** Special compression for lightmaps to optimize memory.

  - **Compression Format:**

    - **For Mobile:** Use ETC1 or ETC2 for general use; PVRTC for iOS; ASTC for high quality.
    - **For PC/Console:** Use DXT1/5 or BC7 for better quality and performance.

- **Choosing Compression for Use Cases**

  - **2D Assets:** Use ETC2 or ASTC for mobile; DXT1 for PC.
  - **3D Models and UI:** Use DXT1/5 (with or without alpha) for PC/console; ETC2 or ASTC for mobile.
  - **Normal Maps:** Use BC5 or DXT5 for best detail and performance.

- **Best Practices**
  - Use mipmaps for textures viewed from various distances.
  - Optimize texture size and compression format based on the platform (mobile, PC, console).
  - Choose formats that minimize artifacts (e.g., ASTC for high quality on newer devices).
  - Test different formats and settings to balance quality and memory usage.

**8.3 Audio Compression**

- **Important Settings**

  - **Bit Rate:** Affects audio quality and file size; higher = better quality but larger size.
  - **Sample Rate:** 44.1kHz (standard) or 48kHz (higher quality, video/film); lower sample rates reduce size but also quality.
  - **Compression Quality:** Choose low, medium, or high for a balance between quality and file size.

- **Unity Import Settings**

  - **Load Type**
    - **Decompress On Load:** Best for short audio clips that need to play immediately.
    - **Streaming:** Good for long audio tracks to save memory.
    - **Compressed in Memory:** Compressed on load, decompressed during playback.
  - **Compression Format**
    - Vorbis (OGG) and MP3 for background music or non-essential audio.
    - ADPCM for older audio formats with moderate quality.

- **Choosing Compression for Use Cases**

  - **Background Music:** Use MP3/OGG with a medium bit rate (128-192 kbps).
  - **Sound Effects:** Use PCM/ADPCM or OGG for better performance and smaller file sizes.
  - **Mobile Games:** Prioritize OGG for a balance of file size and quality.

- **Best Practices**

  - Optimize import settings based on how the audio is used in your game (e.g., short clips vs. long background music).
  - Avoid using overly high bit rates for background audio, especially on mobile, as they can impact performance.
  - Use mipmaps or audio stream compression for efficient memory usage.

---

### MonoBehaviour

**9.1 Difference between Update, FixedUpdate, and LateUpdate**

- **Update:** Called once per frame. Used for regular tasks like input checks or movement.

- **FixedUpdate:** Called at fixed intervals (independent of frame rate). Used for physics calculations.

- **LateUpdate:** Called after all Update calls. Used for tasks that must execute last, like camera positioning.

**9.2 Scenario: If the game is running at 60 FPS but lagging, how will FixedUpdate behave?**

- FixedUpdate in Unity is tied to the physics simulation and runs at a fixed interval, independent of the frame rate.

- **Example Scenario**

  - Game target: 60 FPS (frame time = 16.67ms).
  - FixedUpdate interval: 20ms (50 Hz) | 0.02 seconds (50 times per second).
  - If fps drop to 25, frame time will drop to 40ms,
    - Unity will call FixedUpdate twice during that frame to catch up.

- **Summary**

  - FixedUpdate ensures stable physics even during performance drops, but excessive calls in one frame, this can impact overall game smoothness.

**9.3 what are Coroutines in MonoBehaviour, and how do they compare to threads?**

| Feature   | Coroutine                       | Thread                            |
| --------- | ------------------------------- | --------------------------------- |
| Execution | Runs on Unity’s main thread     | Runs in parallel, separate thread |
| Use Case  | Sequential, frame-based actions | Heavy, parallel computations      |
| APIs      | Works with Unity APIs           | Cannot call Unity APIs            |
| Ease      | Simple, lightweight             | Requires synchronization          |

<!-- ---

### ECS

**1. What is ECS, and how does it differ from traditional object-oriented programming (OOP)?**

- ECS (Entity-Component-System) is an architectural pattern used to create scalable and high-performance applications. Unlike OOP, which uses inheritance and classes to model behavior, ECS uses entities (unique IDs), components (data), and systems (logic) to create a flexible and data-oriented design.

**2. What are the main components of an ECS architecture?**

- **ECS consists of**

  - **Entities:** Unique identifiers that represent objects in the game.
  - **Components:** Data containers that hold information about entities (e.g., position, health).
  - **Systems:** Logic that processes entities with specific components and performs updates or behaviors. -->

---

### System Design

**10.1 How do you set up a simple multiplayer game?**

- Choose Networking Tool: Use Unity Netcode, Photon, or Mirror.
- Setup Network Manager: Add a NetworkManager and configure it for hosting and joining games.
- Define Network Objects: Mark player and shared objects as networked (e.g., add NetworkObject in Unity Netcode).
- Sync Game State: Use network variables or RPCs for actions and updates.
- Spawn Players: Auto-spawn player prefabs on client connect.
- Test & Deploy: Test locally, then host using a dedicated server or cloud service.
