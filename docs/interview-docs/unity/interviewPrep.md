---
sidebar_position: 2
---

# Interview Prep

## Overview

This document serves as a guide for preparing for an interview in Unity. It provides tips and tricks to help you ace the interview and perform well in the process.

---

## Preparation

Your interview preparation for Unity should vary based on your experience and the position level. Adjust your focus and effort accordingly to match the role's requirements.

- Junior Developer: 90% coding, 10% behavior questions
- Mid-level Developer: 75% coding, 25% behavior questions
- Near Senior Developer: 40% coding, 20% system design, 20% behavior leadership questions
- Senior Developer: 30% coding, 30% system design, 40% behavior leadership questions

#### Some Notes

- The key to answering behavioral questions is to tell a compelling story, as it communicates multiple dimensions effectively. A great story highlights character development and showcases leadership, how you solve problem for your team and teamwork.

---

## Interview Questions

Some interview questions that may come up during the process:

### General

1. **Tell me about yourself**

   - Introduce your name > year of experience > your hobby - if align with the job > your current position & company - if employed > your main task in the company > your past experience/product (if any) > your goal in the future

2. Tell me where a time you strongly disagree with someone in your team

3. What are your product frameworks you have been using?

4. Describe one project in your portfolio

### Unity

**1. Component Questions**

#### What is the purpose of the Transform component? Can a GameObject exist without it?

- No, gameObject cant exist without transform. It automatically added when you create a gameObject
- Transform is used to position, rotate, scale, and parent gameObject

#### How do you attach and remove components at runtime using scripts?

- To add, use AddComponent method. To remove, use save reference to component and then use Destroy method

#### Can a GameObject have multiple components of the same type?

- Yes, you can have multiple components of the same type. For example, a gameObject can have a BoxCollider and a SphereCollider component depend on it shape

#### How do Canvas and RectTransform components work in Unity UI?

- All UI elements must be a child of a Canvas to be rendered. Rect

#### What is the EventSystem component?

- The EventSystem is a global Unity component that acts as the backbone for detecting and managing UI events, such as clicks, touches, and keyboard inputs.

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

**2. Physics Questions**

#### What are the differences between BoxCollider, SphereCollider, and MeshCollider? Which one is best for what?

- **SphereCollider:** Faster and more efficient for simple. It check the distance between the centers of two spheres and comparing it to the sum of their radii
- **BoxCollider:** Slightly more complex in terms of calculations but still highly efficient. It involves checking whether a point or another collider intersects with the 3D volume of the box
- **MeshCollider:** More complex than BoxCollider and SphereCollider, but it is more accurate and provides more detailed collision information.

| Feature            | BoxCollider           | SphereCollider           | MeshCollider                |
| ------------------ | --------------------- | ------------------------ | --------------------------- |
| **Shape**          | Box/rectangular prism | Sphere                   | Custom mesh                 |
| **Performance**    | Lightweight           | Lightweight              | Heavier, can be slower      |
| **Use Case**       | Simple objects, walls | Spherical objects, balls | Complex, detailed models    |
| **Complexity**     | Simple                | Simple                   | High (based on mesh detail) |
| **Static/Dynamic** | Works for both        | Works for both           | Preferably static (concave) |

#### Can two GameObjects with only colliders collide with each other? What happens if one of the colliders is set to "Trigger"?

- No, on of the gameObject must have a rigidbody component to collide with other gameObject (with collider)
- When collider is set to trigger, it will only detect collision but doesn't effect the physics

#### Difference Between `AddForce()` and `Velocity` Property in a Rigidbody

- `AddForce()` Applies a force to the Rigidbody, affecting its velocity over time based on mass and drag. It is used for forces like gravity, thrust, or wind.
- `Velocity` Directly sets the Rigidbody's speed and direction. It overrides physics simulation and sets the exact movement, which means it does not account for external forces.

#### Difference Between `ForceMode.Force` and `ForceMode.Impulse`?

- `ForceMode.Force` Applies a continuous force over time, making the Rigidbody accelerate gradually. This mode takes the Rigidbody's mass into account.
- `ForceMode.Impulse` Applies an instant force, changing the Rigidbody's velocity immediately. Ideal for sudden impacts or quick movements.

#### Scenario: A gun shoot at a target > we dont want the bullet to pass through the target > bullet reflect off the target

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

**3. Animator Questions**

IK - inverse kinematics

#### Scenario: Setting up the animtor for an NPC > we want NPC to transition from idle to walk smoothly > we want NPC to aim while walking > we want to aim at a moving target while walking

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

4. Light

   - different type of light
   - light probe, reflection probe
   - lgiht mapping
   - when light is backed how many time it will be rendered

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

5. Shadow

- if shadow not showing, how would you solve it?

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

6. Rendering

- layer, camera, ui so on
- Understand batching and managing UI draw calls
- static vs dynamic batching

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

7. Shader

- car crash

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

8. Particle System

- scaling

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

9. Audio & Texture compression

- different compression for pc, android, ios
- setting & option in texture and audio

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

10. **Optimizing**

    Check out my [Unity Optimization](../../unity-docs/unity-optimizing.md) page for more details

    - Combine sprite using **Sprite Atlas** to reduce draw call.
    - You can use custom **Tick System** to replace normal **Update** in mono to reduce update call.
    - you can create a **Benchmark Tool** to test your code to measure its performance, this will help you identify where/what being slow.
    - Using **Hash String** with for animator and shader property.
    - Changing renderer pipeline setting, you can turn off setting like **Depth Texture** to reduce draw call.
    - For instantiate lots of object, you can use **Object Pooling System** to reuse the object and reduce garbage collection.
    - Compressing textures, sprites and audios.
    - use LOD

    <hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

11. MonoBehaviour

- different between update, fixed update, late update
- how can we create something that behave like a singleton?
- abstract vs interface

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

12. Couroutine

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

13. Thread

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

14. ECS

<hr style={{ width: '400px', margin: '30px auto', border: '1px solid #edbb93' }} />

### C#

1. What is the difference between **struct** and **class** in C#?

passing class and struct as param

2. is array, list big O or small O - time complexity

3. A\* Algorithm

4. Design pattern

5. archetecture pattern

### IQ

---

## Questions to Ask

You will need to prepare some questions to ask during the interview. Do research about the company and their products.

Here some general questions that you can ask:

1.
