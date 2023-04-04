using Grpc.Core;
using Grpc.Net.Client;
using ImageTransferClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7037");
var client = new ImageTransferService.ImageTransferServiceClient(channel);
Boolean exit = false;
MyData.info();

while (!exit)
{

    Console.WriteLine("MENU:");
    Console.WriteLine("1: Wyœlij");
    Console.WriteLine("2: Odbierz");
    Console.WriteLine("Inne: WyjdŸ");

    string menuChoise = Console.ReadLine();

    Console.WriteLine("Podaj pe³n¹ œcie¿kê do pliku");
    string filepath = Console.ReadLine();

    switch (menuChoise)
    {
        case "1":
            try
            {
                using (var fileStream = File.OpenRead(filepath))
                {
                    using (var call = client.TransferToServer())
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await call.RequestStream.WriteAsync(new ImageTransferData { Data = Google.Protobuf.ByteString.CopyFrom(buffer, 0, bytesRead) });
                        }
                        await call.RequestStream.CompleteAsync();
                        await call.ResponseAsync;
                    }
                }
                Console.WriteLine("Wys³ano");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("B³êdna œcie¿ka lub brak dostêpu do pliku");
            }

            break;
        case "2":
            using (var call = client.TransferToClient(new Google.Protobuf.WellKnownTypes.Empty()))
            {
                try
                {
                    using (var fileStream = File.Create(filepath))
                    {
                        int dataPacket = 0;
                        Console.WriteLine("New incoming data");
                        while (await call.ResponseStream.MoveNext())
                        {
                            ImageTransferData imageData = call.ResponseStream.Current;
                            await fileStream.WriteAsync(imageData.Data.ToByteArray());
                            Console.WriteLine("Data packet recived: " + dataPacket);
                            dataPacket++;
                        }
                    }
                    Console.WriteLine("Odebrano");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("B³êdna œcie¿ka lub brak dostêpu do pliku");
                }
            }
            break;
        default:
            Console.WriteLine("Wyjœcie");
            exit = true;
            break;
    }
}

await channel.ShutdownAsync();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();