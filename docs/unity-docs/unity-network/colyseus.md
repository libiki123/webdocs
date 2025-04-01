---
sidebar_position: 1
---

# Colyseus

## Introduction - Multiplayer Game Framework

Colyseus is a lightweight but powerful framework for creating multiplayer games. It provides an authoritative game server written in Node.js/TypeScript and client SDKs for various platforms including Unity.

- [Official Documentation](https://docs.colyseus.io/)
- [Unity SDK Repository](https://github.com/colyseus/colyseus-unity3d)

## Key Features

- Authoritative server architecture
- Real-time state synchronization
- Built-in room management
- Schema-based state serialization
- WebSocket transport
- TypeScript support
- Cross-platform compatibility

## Basic Setup

### Server Setup

1. Install Node.js and create a new project:

```bash
npm init
npm install colyseus
```

2. Create basic server structure:

```typescript
import { Server } from "colyseus";
import { createServer } from "http";

const port = 2567;
const gameServer = new Server({
  server: createServer(),
});

gameServer.listen(port);
```

### Unity Client Setup

1. Install the Colyseus SDK:

   - Open Unity Package Manager
   - Click the + button
   - Add package from git URL
   - Enter: `https://github.com/colyseus/colyseus-unity3d.git#upm`

2. Basic client connection:

```csharp
using Colyseus;

public class GameClient : MonoBehaviour
{
    Client client;
    Room<YourState> room;

    async void Start()
    {
        client = new Client("ws://localhost:2567");
        try
        {
            room = await client.JoinOrCreate<YourState>("game_room");
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}
```

## Common Use Cases

- Real-time multiplayer games
- Turn-based games
- MMO games
- Competitive games
- Co-op games
- Game state persistence
- Matchmaking systems
