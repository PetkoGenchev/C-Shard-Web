using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MyWebServer.Server;

namespace MyWebServer
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {
            var server = new HttpServer("127.0.0.1",8080);

            await server.Start();
        }
    }
}
