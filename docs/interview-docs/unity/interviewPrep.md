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

1. **What components have you used in your project?**

2. Physics

- which collider cost lest

3. Animator

   - blend animation
   - blend top and bot anim
   - control animation

4. Light

   - different type of light
   - light probe, reflection probe

5. Shadow

- if shadow not showing, how would you solve it?

6. Particle System

- scaling

7. Rendering

- layer, camera, ui so on
- Understand batching and managing UI draw calls

8. Shader

- car crash

9. Audio & Texture compression

- different compression for pc, android, ios

10. **Optimizing**

    Check out my [Unity Optimization](../../unity-docs/unity-optimizing.md) page for more details

    - You can use **Frame debugger** to check draw call to check where/what being drawing each frame, combine sprite using **Sprite Atlas** to reduce draw call
    - You can use custom **Tick System** to replace normal **Update** in mono, this will reduce the update call for logic that doesnt need to be updated every frame
    - you can create a **Benchmark Tool** to test your code to measure its performance, this will help you identify where/what being slow
    - Using **Hash String** with animator. Animmator functions usually hash the string you pass in the parameter and this will cost some performant, we can reduce by using **Animator.StringToHash** from the start. Same thing with change shader property, we can use **Shader.PropertyToID** to hash the property name and change the shader property with the hash value.
    - Changing renderer pipeline setting, you can turn off setting like **Depth Texture** to reduce draw call.
    - For instantiate lots of object, you can use **Object Pooling System** to reuse the object and reduce garbage collection.
    - Compressing textures, sprites and audios. Change the compression setting to reduce the size of the texture, sprite and audio but make sure the quality is not degraded.

11. MonoBehaviour

- different between update, fixed update, late update

12. Couroutine

### C#

1. What is the difference between **struct** and **class** in C#?

2. is array, list big O or small O

---

## Questions to Ask

You will need to prepare some questions to ask during the interview. Do research about the company and their products.

Here some general questions that you can ask:

1.
