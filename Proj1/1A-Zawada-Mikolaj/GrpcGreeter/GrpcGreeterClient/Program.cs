using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

GrpcGreeterClient.MyData.info();

using var channel = GrpcChannel.ForAddress("http://10.8.0.4:5097");
var client = new Greeter.GreeterClient(channel);
Console.WriteLine("Jak masz na imię?");
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = Console.ReadLine() });
Console.WriteLine(reply.Message);
Console.ReadKey();