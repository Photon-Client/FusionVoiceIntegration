# FusionVoiceIntegration

First attempt to make an integration between Photon Voice and Photon Fusion

Main two components:

- `FusionVoiceBridge` - requires `NetworkRunner` and `VoiceConnection`.
- `VoiceNetworkObject` - `NetworkBehaviour`.

For test scene we added `PrefabSpawner` and dummy prefab that will playback .wav file via server set in `Recorder` (PrimaryRecorder).

How to use:

1. Import Fusion [here](https://doc.photonengine.com/en-us/fusion/current/getting-started/sdk-download). (project tested with 0.7.0-Beta-Nightly-298)
2. Import Photon Voice 2 using Unity Package Manager or from [Unity Asset Store](https://assetstore.unity.com/packages/tools/audio/photon-voice-2-130518) (project tested with 2.26): 
    - Uncheck "Photon\PhotonChat" and "Photon\PhotonUnityNetworking" folders.
    - Uncheck "Photon\PhotonVoice\Code\Pun" and "Photon\PhotonVoice\Demos" folders.
3. Open the Photon App Settings using the menu item at `Fusion\Realtime Settings`. Get AppId of type Fusion and set it in Realtime Settings: "App Id Fusion".
4. Get AppId of type Voice and set it in VoiceConnection component (under AppSettings) in prefab "Assets/VoiceFusionIntegration/Prefabs/Runner + Voice.prefab".

---

5. Open the Fusion Network Project Settings using the menu item at `Fusion\Network Project Config`:
    - Click at `Rebuild Object Table`, so Fusion is aware of the Voice Prefab.
    - Click at `Import Scenes from Build Settings`, so Fusion update the list of known Scenes.
6. Start an Host instance in Unity Editor by entering playmode (`FusionVoiceGameScene`): you are able to hear a recorded audio clip transmitted via Photon Voice.

---

7. Disable 'Debug Echo' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
8. Change 'Input Source Type' to 'Microphobe' from Recorder component in PrimaryRecorder prefab ("Assets\VoiceFusionIntegration\Prefabs").
9. Build a Standalone Executable of the project:
     - Run one instance as a Host;
     - Run another instante as a Client;
10. Once both are connected, you should be able to talk and be heard on the other end.
