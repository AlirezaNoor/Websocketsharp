namespace testws;

using System;
using WebSocketSharp;
using WebSocketSharp.Server;

public class WS : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        // JsonSerializer.Deserialize()
        Console.WriteLine(e.Data);
        // Send(msg);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var wssv = new WebSocketServer(3000);
        wssv.AddWebSocketService<WS>("/");
        wssv.Start();
        Console.WriteLine("ws server run on port 3000...");
        Console.ReadKey();
    }
}