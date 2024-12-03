---
sidebar_position: 4
---

# Unity - Optimizing

## Purpose

[Ref 1](https://www.youtube.com/watch?v=kJ5I9md9NG4)

## Optimization Options

### Reduce Draw Call

- You can use **Window > Analysis > Frame debugger** to check draw call, this help you identify where/what being render each frame.
- Some sprites can be combine using sprite Atlas **R-Click > Create > 2D > Sprite Atlas** to reduce draw call significantly.

### Using Custome Update

- You can use a **Tick System** with custom tick rate to replace normal **Update** in mono, this will reduce the update call for logic that doesnt need to be updated every frame.

- lightweight pattern
