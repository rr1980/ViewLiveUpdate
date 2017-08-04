using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using ViewLiveUpdate.WebSocketManager.Interfaces;

namespace ViewLiveUpdate.WebSocketManager
{
    public class NotificationsMessageHandler : IWebSocketHandler
    {
        public async Task OnConnected(WebSocket socket)
        {
            Debug.WriteLine("OnConnected");
        }

        public async Task OnDisconnected(WebSocket socket)
        {
            Debug.WriteLine("OnDisconnected");
        }

        public async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);

            Debug.WriteLine("ReceiveAsync");
            Debug.WriteLine(message);
        }
    }
}
