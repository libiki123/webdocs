---
sidebar_position: 1
---

# Best Practices

## Key Considerations

### Performance Expectations

- Treat WebGL like a ~2015 mobile device in terms of capability
- Desktop/Android browsers perform reasonably well
- iOS devices require special attention and optimization
- Test thoroughly on iOS devices, as desktop testing alone isn't sufficient

### Platform-Specific Issues

#### iOS Specific Challenges

- Limited WebGL performance even with ANGLE WebGL 2.0
- Platform detection issues (especially for iPads)
- Audio playback problems
- UI interaction bugs after focus changes
- Texture compression complexity

### Technical Guidelines

#### Platform Detection

```csharp
// iPad detection requires custom .jslib solution
// Don't rely on Application.isMobilePlatform for iPads
```

#### Touch Input

```csharp
// Don't use:
if (Input.touchSupported) // Unreliable on WebGL

// Instead use:
if (Input.touchCount > 0)
```

#### Audio Handling

- Set AudioClips to "Decompress On Load"
- Minimize use of PlayOneShot()
- Implement custom audio pause handling:

```csharp
void OnApplicationFocus(bool hasFocus) // This wont work in Safari
```

#### UI Event System Fix

```csharp
using UnityEngine.EventSystems;

public class EventSystemWebGL : EventSystem
{
    #if UNITY_WEBGL
    protected override void OnApplicationFocus(bool hasFocus)
    {
        // Do Nothing
    }
    #endif
}
```

### Recommended Settings

#### Player Settings

- Code Optimization: Speed
- Code Generation: Faster runtime
- Run In Background: Enabled
- Code Stripping: High
- For maximum iOS compatibility:
  - WebGL 1.0 (Note: Will be removed in Unity 2023.x)
  - Gamma color space

#### Texture Handling

- Use ASTC format for small 2D games
- Implement Sprite Atlas for 2D games
- Consider dual DXT-ASTC builds for larger projects

## Common Pitfalls

1. Assuming desktop performance reflects mobile performance
2. Not testing extensively on iOS devices
3. Relying on default input detection methods
4. Complex audio setups
5. Not implementing proper focus handling

## Further Reading

- [Original Blog Post](https://www.blog.radiator.debacle.us/2023/01/unity-webgl-tips-advice-in-2023.html)
- [Unity WebGL Documentation](https://docs.unity3d.com/Manual/webgl.html)
