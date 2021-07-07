# FusionVoiceIntegration

First attempt to make an integration between Photon Voice and Photon Fusion

Main two components:

- `FusionVoiceBridge` - requires `NetworkRunner` and `VoiceConnection`.
- `VoiceNetworkObject` - `NetworkBehaviour`.

For test scene we added `PrefabSpawner` and dummy prefab that will playback .wav file via server set in `Recorder` (PrimaryRecorder).

How to use:

1. Import Fusion [here](https://doc.photonengine.com/en-us/fusion/current/getting-started/sdk-download). (project tested with 0.5.0-Beta-Nightly-230)
2. Import Photon Voice 2 using Unity Package Manager or from [Unity Asset Store](https://assetstore.unity.com/packages/tools/audio/photon-voice-2-130518): 
    - project requires 2.26.1 or higher.
    - Uncheck "Photon\PhotonChat" and "Photon\PhotonUnityNetworking" and "Photon\PhotonRealtime" folders.
    - Uncheck "Photon\PhotonVoice\Code\Pun" and "Photon\PhotonVoice\Demos" folders.
3. Open the Photon App Settings using the menu item at `Fusion\Realtime Settings`:
    1. Get AppId of type Fusion and set it in Realtime Settings: Realtime AppId.
    2. Get AppId of type Voice and set it in Realtime Settings: Voice AppId.

---

4. Open the Fusion Network Project Settings using the menu item at `Fusion\Network Project Config`:
    1. Click at `Rebuild Object Table`, so Fusion is aware of the Voice Prefab.
    2. Click at `Import Scenes from Build Settings`, so Fusion update the list of known Scenes.
5. Build a Standalone Executable of the project.
    1. Run one instance as a Host;
    2. Run another instante as a Client;
6. Once both are connected, you should be able to talk be heard on the other end.
