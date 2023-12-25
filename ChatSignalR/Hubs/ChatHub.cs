using Microsoft.AspNetCore.SignalR;


namespace ChatSignalR.Hubs


{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string fromUser,string message)
        {
            await Clients.All.SendAsync("ReceiverMessage",fromUser, message);
        }
    }
}
