using Microsoft.AspNetCore.SignalR;

namespace HortiDot.Chat
{
    public class Chat : Hub
    {
        public void NovaMensagem(string txt, string userID)
        {
            Clients.All.SendAsync("msg", txt, userID);
        }

    }
}
