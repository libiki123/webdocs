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

1. **Tell me about yourself**

2. Tell me where a time you strongly disagree with someone in your team

. What are your product frameworks you have been using?

. Describe one project in your portfolio

6. **How would you optimize code, scene, material, shader to make it compatible with even low end phone?**

   Check out my [Unity Optimization](../../unity-docs/unity-optimizing.md) page for more details

   - You can use **Frame debugger** to check draw call to check where/what being drawing each frame, combine sprite using **Sprite Atlas** to reduce draw call
   - You can use custom **Tick System** to replace normal **Update** in mono, this will reduce the update call for logic that doesnt need to be updated every frame
   - you can create a **Benchmark Tool** to test your code to measure its performance, this will help you identify where/what being slow
   - Using **Hash String** with animator. Animmator functions usually hash the string you pass in the parameter and this will cost some performant, we can reduce by using **Animator.StringToHash** from the start. Same thing with change shader property, we can use **Shader.PropertyToID** to hash the property name and change the shader property with the hash value.
   - Changing renderer pipeline setting, you can turn off setting like **Depth Texture** to reduce draw call.
   - For instantiate lots of object, you can use **Object Pooling System** to reuse the object and reduce garbage collection.
   - Compressing textures, sprites and audios. Change the compression setting to reduce the size of the texture, sprite and audio but make sure the quality is not degraded.

. Do you know how to use profiler?

. How do you reduce size of the game without satisfied the quality?

. Which programming pattern you implement in your project?

. Have you play this \*\*\*\* game? can do deconstruct and explain how this game works?

. Do you know about addressable and assetBundle?

---

## Questions to Ask

You will need to prepare some questions to ask during the interview. Do research about the company and their products.
