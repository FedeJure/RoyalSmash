using System;
using Mirror;
using Mirror.Websocket;
using UnityEngine;


namespace Modules.Network.Scripts.Server
{
    [RequireComponent(typeof(NetworkManager))]
    [RequireComponent(typeof(NetworkManagerHUD))]
    [RequireComponent(typeof(TelepathyTransport))]
    [RequireComponent(typeof(WebsocketTransport))]
    public class Server : NetworkManager
    {
        private NetworkManager networkManager;
        private NetworkManagerHUD networkManagerHud;
        private TelepathyTransport tpcTransport;
        private WebsocketTransport wsTransport;
        public override void Awake()
        {
            base.Awake();
            networkManager = GetComponent<NetworkManager>();
            networkManagerHud = GetComponent<NetworkManagerHUD>();
            tpcTransport = GetComponent<TelepathyTransport>();
            wsTransport = GetComponent<WebsocketTransport>();
        }

        public override void OnClientConnect(NetworkConnection conn)
        {
            base.OnClientConnect(conn);
        }


        public override void Start()
        {
            base.Start();
        }
    }
}
