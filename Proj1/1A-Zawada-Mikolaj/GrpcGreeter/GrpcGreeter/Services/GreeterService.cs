using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine("Zalogowany: "+ request.Name);

        return Task.FromResult(new HelloReply
        {
            Message = "Witaj " + request.Name + "\r\n" + DateTime.Now.ToString("dd MMMM, HH:mm:ss", new System.Globalization.CultureInfo("pl-PL"))
        }) ;
    }
}