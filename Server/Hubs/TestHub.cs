using Microsoft.AspNetCore.SignalR;

namespace BlazorAppNasa.Server.Hubs
{
    public class TestHub : Hub
    {
        public void Food()
        {
            Console.WriteLine("aadsad");
        }
    }
}
