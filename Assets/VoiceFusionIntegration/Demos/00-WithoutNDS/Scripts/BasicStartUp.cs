using Fusion;
using UnityEngine;
using Photon.Realtime;
using Photon.Voice.Unity;
using UnityEngine.SceneManagement;

namespace Photon.Voice.Fusion.Demo {
    public class BasicStartUp : VoiceComponent {
        private NetworkRunner networkRunner;
        [SerializeField]
        private string voiceAppId, roomName;
        private GameMode gameMode = GameMode.AutoHostOrClient;

        private void Start() {
            this.StartGame(this.gameMode);
        }

        private async void StartGame(GameMode mode) {
            // Create the Fusion runner and let it know that we will be providing user input
            this.networkRunner = this.gameObject.AddComponent<NetworkRunner>();
            VoiceConnection voiceConnection = this.gameObject.AddComponent<VoiceConnection>();
            voiceConnection.LogLevel = this.LogLevel;
            voiceConnection.Settings = new AppSettings { AppIdVoice = voiceAppId };
            voiceConnection.PrimaryRecorder = this.gameObject.AddComponent<Recorder>();
            FusionVoiceBridge bridge = this.gameObject.AddComponent<FusionVoiceBridge>();
            bridge.LogLevel = this.LogLevel;
            this.networkRunner.ProvideInput = true;

            // Start or join (depends on gamemode) a session with a specific name
            await this.networkRunner.StartGame(new StartGameArgs {
                GameMode = mode,
                SessionName = roomName,
                Scene = SceneManager.GetActiveScene().buildIndex,
                SceneObjectProvider = this.gameObject.AddComponent<NetworkSceneManagerDefault>()
            });
        }
    }
}