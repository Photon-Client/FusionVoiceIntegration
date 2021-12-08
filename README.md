# FusionVoiceIntegration

## Intro

First attempt to make an integration between Photon Voice and Photon Fusion

Main two components:

- (required: scene) `FusionVoiceBridge` - requires `NetworkRunner` and `VoiceConnection`.
- (optional: prefab) `VoiceNetworkObject` - `NetworkBehaviour`.

## Setup

### Import

1. Import Fusion [here](https://doc.photonengine.com/en-us/fusion/current/getting-started/sdk-download). (project tested with 0.12.0-RC-357)
2. Import Photon Voice 2 using Unity Package Manager or from [Unity Asset Store](https://assetstore.unity.com/packages/tools/audio/photon-voice-2-130518) (project tested with 2.28.2): 
    - Uncheck "Photon\PhotonChat" and "Photon\PhotonUnityNetworking" folders.
    - Uncheck "Photon\PhotonVoice\Code\Pun" and "Photon\PhotonVoice\Demos" folders.
3. Open the Photon App Settings using the menu item at `Fusion\Realtime Settings`.
4. Get AppId of type Fusion and set it in Realtime Settings: "App Id Fusion".

### Voice Integration

1. Add VoiceConnection next to Runner.
2. Add FusionVoiceBridge next to VoiceConnection and Runnder.
3. Set VoiceAppId in VoiceConnection.Settings.
4. Add Recorder and initialize it using VoiceConnection, or set it as PrimaryRecorder in VoiceConnection.

## Demos

### 0-Minimal

#### How To Use Demo

4. Get AppId of type Voice and set it in VoiceConnection component (under AppSettings) in prefab "Assets\VoiceFusionIntegration\Demos\0-Minimal\Prefabs\Runner + Voice (0).prefab".

---

6. Start an instance ("Host" or "Shared Client") in Unity Editor by entering playmode: you are able to hear a recorded audio clip transmitted via Photon Voice.

---

7. Disable 'Debug Echo' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
8. Change 'Input Source Type' to 'Microphobe' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
9. Build a Standalone Executable of the project.
10. Run multiple instances in different modes (one could be the Unity Editor):
     10.A.
         - Run at last one instance as a "Host" or "Server";
         - Run two or more instances as a "Client";
     10.B. Run two or more instances as "Shared Client".
11. Once enough instances connected, you should be able to talk and be heard on the other end.

### 00-WithoutNDS

#### How To Use Demo

4. Get AppId of type Voice and set it in `BasicStartUp` in scene "Assets\VoiceFusionIntegration\Demos\00-WithoutNDS\Scenes\WithoutNDS.unity".

---

6. Start an instance ("Host" or "Shared Client") in Unity Editor by entering playmode.
7. In Recorder component from inspector check DebugEcho: you will be able to talk and hear yourself.

---

7. Disable 'Debug Echo' from Recorder.
9. Build a Standalone Executable of the project.
10. Run multiple instances in different modes (one could be the Unity Editor):
     10.A.
         - Run at last one instance as a "Host" or "Server";
         - Run two or more instances as a "Client";
     10.B. Run two or more instances as "Shared Client".
11. Once enough instances connected, you should be able to talk and be heard on the other end.

### 1-SpeakerPrefab

#### How To Use Demo

4. Get AppId of type Voice and set it in VoiceConnection component (under AppSettings) in prefab "Assets\VoiceFusionIntegration\Demos\1-SpeakerPrefab\Prefabs\Runner + Voice (1).prefab".

---

6. Start an instance ("Host" or "Shared Client") in Unity Editor by entering playmode: you are able to hear a recorded audio clip transmitted via Photon Voice.

---

7. Disable 'Debug Echo' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
8. Change 'Input Source Type' to 'Microphobe' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
9. Build a Standalone Executable of the project.
10. Run multiple instances in different modes (one could be the Unity Editor):
     10.A.
         - Run at last one instance as a "Host" or "Server";
         - Run two or more instances as a "Client";
     10.B. Run two or more instances as "Shared Client".
11. Once enough instances connected, you should be able to talk and be heard on the other end.

### 2-FusionPrefabDemo

In this demo we added `PrefabSpawner` and a dummy cube prefab with `VoiceNetworkObject` that will initially playback .wav file via server set in `Recorder` (PrimaryRecorder).

#### How To Use Demo

4. Get AppId of type Voice and set it in VoiceConnection component (under AppSettings) in prefab "Assets\VoiceFusionIntegration\Demos\2-FusionPrefab\Prefabs\Runner + Voice (2).prefab".

---

5. Open the Fusion Network Project Settings using the menu item at `Fusion\Network Project Config`:
    - Click at `Rebuild Object Table`, so Fusion is aware of the Voice Prefab.
6. Start an instance ("Host" or "Shared Client") in Unity Editor by entering playmode: you are able to hear a recorded audio clip transmitted via Photon Voice.

---

7. Disable 'Debug Echo' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
8. Change 'Input Source Type' to 'Microphobe' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
9. Build a Standalone Executable of the project.
10. Run multiple instances in different modes (one could be the Unity Editor):
     10.A.
         - Run at last one instance as a "Host" or "Server";
         - Run two or more instances as a "Client";
     10.B. Run two or more instances as "Shared Client".
11. Once enough instances connected, you should be able to talk and be heard on the other end.
