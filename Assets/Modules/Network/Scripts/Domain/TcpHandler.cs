using Mirror;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class TcpHandler
    {
        public TcpHandler(TelepathyTransport transport)
        {
            transport.OnClientConnected.AddListener(OnClientConnected);
            transport.OnClientDisconnected.AddListener(OnClientDisconnected);
        }

        private void OnClientDisconnected()
        {
        }

        private void OnClientConnected()
        {
        }
    }
}