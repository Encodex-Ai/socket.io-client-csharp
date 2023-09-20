using System;
using System.Threading.Tasks;

namespace SocketIOClient.Extensions
{
    internal static class SocketIOEventExtensions
    {
        public static void TryInvoke(this OnAnyHandler handler, string eventName, SocketIOResponse response)
        {
            handler(eventName, response);
        }

        public static void TryInvoke(this Action<SocketIOResponse> handler, SocketIOResponse response)
        {
            handler(response);
        }

        public static Task TryInvoke(this Func<SocketIOResponse, Task> handler, SocketIOResponse response)
        {
            return handler(response);
        }
    }
}