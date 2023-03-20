using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

GrpcGreeterClient.MyData.info();

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5097");
var client = new Greeter.GreeterClient(channel);
Console.WriteLine("Jak masz na imię?");
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = Console.ReadLine() });
Console.WriteLine(reply.Message);
Console.ReadKey();