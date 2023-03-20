using System.Net;
using GPSDistanceClient;
using GPSDistanceClient.Services;
using Grpc.Net.Client;

GPSDistanceClient.MyData.info();

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5097");
var client = new Distancer.DistancerClient(channel);

while (true)
{
    Console.WriteLine("Punkt P1:");
    var point1 = ReadPointData();

    Console.WriteLine("Punkt P2:");
    var point2 = ReadPointData();

    Console.WriteLine("Chcesz podać współrzędne punktu P3? (t/n)");
    var addThirdPoint = Console.ReadLine().ToLower() == "t";

    DistancerRequest.Types.Point point3 = null;

    if (addThirdPoint)
    {
        Console.WriteLine("Punkt P3:");
        point3 = ReadPointData();
    }

    var request = new DistancerRequest { Point1 = point1, Point2 = point2, Point3 = point3 };
    var response = await client.CalculateDistanceAsync(request);

    Console.WriteLine($"Dystans: {response.Distance / 1000} km");
    Console.WriteLine("Naciśnij Enter, aby kontynuować...");
    Console.ReadLine();
    Console.Clear();
}

static DistancerRequest.Types.Point ReadPointData()
{
    Console.Write("Nazwa miasta: ");
    string city = Console.ReadLine();

    Console.Write("Szerokość geograficzna: ");
    double latitude = double.Parse(Console.ReadLine());

    Console.Write("Długość geograficzna: ");
    double longitude = double.Parse(Console.ReadLine());

    return new DistancerRequest.Types.Point { City = city, Latitude = latitude, Longitude = longitude };
}