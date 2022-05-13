using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MyWebServer.Server;
using MyWebServer.Server.Http;
using MyWebServer.Server.Responses;

namespace MyWebServer
{
    public class StartUp
    {
        static async Task Main()
            => await new HttpServer(routes => routes
                    .MapGet("/", new TextResponse("Hello from Ivo!"))
                    .MapGet("/Cats", new TextResponse("Hello from the cats!")))
            .Start();

    }
}

//"127.0.0.1", 8080,