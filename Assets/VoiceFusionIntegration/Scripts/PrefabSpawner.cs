using Fusion;
using Fusion.Sockets;

namespace Photon.Voice.Fusion.Demo
{
    using UnityEngine;
    using System.Collections.Generic;
    using System;

    public class PrefabSpawner : MonoBehaviour, INetworkRunnerCallbacks
    {
        [SerializeField]
        private NetworkObject prefab;

        private NetworkObject instance;

        #region INetworkRunnerCallbacks

        void INetworkRunnerCallbacks.OnPlayerJoined(NetworkRunner runner, PlayerRef player)
        {
            this.instance = runner.Spawn(this.prefab, Vector3.zero, Quaternion.identity, player);
        }

        void INetworkRunnerCallbacks.OnPlayerLeft(NetworkRunner runner, PlayerRef player)
        {
            if (this.instance)
            {
                runner.Despawn(this.instance);
            }
        }

        void INetworkRunnerCallbacks.OnInput(NetworkRunner runner, NetworkInput input)
        {
        }

        void INetworkRunnerCallbacks.OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
        {
        }

        void INetworkRunnerCallbacks.OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
        {
        }

        void INetworkRunnerCallbacks.OnConnectedToServer(NetworkRunner runner)
        {
        }

        void INetworkRunnerCallbacks.OnDisconnectedFromServer(NetworkRunner runner)
        {
        }

        void INetworkRunnerCallbacks.OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
        {
        }

        void INetworkRunnerCallbacks.OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
        {
        }

        void INetworkRunnerCallbacks.OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
        {
        }
        
        void INetworkRunnerCallbacks.OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) 
        {
        }

        void INetworkRunnerCallbacks.OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
        {
        }

        void INetworkRunnerCallbacks.OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
        {
        }

        void INetworkRunnerCallbacks.OnSceneLoadDone(NetworkRunner runner)
        {
        }

        void INetworkRunnerCallbacks.OnSceneLoadStart(NetworkRunner runner)
        {
        }

        #endregion
    }
}
