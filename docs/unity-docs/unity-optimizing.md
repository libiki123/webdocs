---
sidebar_position: 7
---

# Optimizing

## Purpose

[Ref 1](https://www.youtube.com/watch?v=kJ5I9md9NG4)

## Optimization Options

### Reduce Draw Call

- You can use **Window > Analysis > Frame debugger** to check draw call, this help you identify where/what being render each frame.
- Some sprites can be combine using sprite Atlas **R-Click > Create > 2D > Sprite Atlas** to reduce draw call significantly.

### Using Custome Update

- You can use a **Tick System** with custom tick rate to replace normal **Update** in mono, this will reduce the update call for logic that doesnt need to be updated every frame.

- lightweight pattern

  - You can use **Frame debugger** to check draw call to check where/what being drawing each frame, combine sprite using **Sprite Atlas** to reduce draw call
  - You can use custom **Tick System** to replace normal **Update** in mono, this will reduce the update call for logic that doesnt need to be updated every frame
  - you can create a **Benchmark Tool** to test your code to measure its performance, this will help you identify where/what being slow
  - Using **Hash String** with animator. Animmator functions usually hash the string you pass in the parameter and this will cost some performant, we can reduce by using **Animator.StringToHash** from the start. Same thing with change shader property, we can use **Shader.PropertyToID** to hash the property name and change the shader property with the hash value.
  - Changing renderer pipeline setting, you can turn off setting like **Depth Texture** to reduce draw call.
  - For instantiate lots of object, you can use **Object Pooling System** to reuse the object and reduce garbage collection.
  - Compressing textures, sprites and audios. Change the compression setting to reduce the size of the texture, sprite and audio but make sure the quality is not degraded.
  - use LOD
