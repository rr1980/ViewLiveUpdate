using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ViewLiveUpdate.WebSocketManager.Interfaces
{
    public interface IWebSocketHandler
    {
        Task OnConnected(WebSocket socket);
        Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer);
        Task OnDisconnected(WebSocket socket);
    }
}
