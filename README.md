# FusionVoiceIntegration

First attempt to make an integration between Photon Voice and Photon Fusion

Main two components:

- `FusionVoiceBridge` - requires `NetworkRunner` and `VoiceConnection`.
- `VoiceNetworkObject` - `NetworkBehaviour`.

For test scene we added `PrefabSpawner` and dummy prefab that will playback .wav file via server set in `Recorder` (PrimaryRecorder).

How to use:

1. Import Fusion [here](https://doc.photonengine.com/en-us/fusion/current/getting-started/sdk-download). (project tested with 0.5.0-Beta-Nightly-226)
2. Get AppId of type Fusion and set it in Realtime Settings: Realtime AppId. 
3. Get AppId of type Voice and set it in Realtime Settings: Voice AppId.
4. Import Photon Voice 2 using Unity Package Manager or from [Unity Asset Store](https://assetstore.unity.com/packages/tools/audio/photon-voice-2-130518). (project tested with 2.26)
5. Open and run "FusionVoiceIntegration/Test" scene.