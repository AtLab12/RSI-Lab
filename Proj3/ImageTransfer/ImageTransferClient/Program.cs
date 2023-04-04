using Grpc.Core;
using Grpc.Net.Client;
using ImageTransferClient;

using var channel = GrpcChannel.ForAddress("http://10.8.0.7:5097");
var client = new ImageTransferService.ImageTransferServiceClient(channel);
Boolean exit = false;
MyData.info();

while (!exit)
{

    Console.WriteLine("MENU:");
    Console.WriteLine("1: Wy�lij");
    Console.WriteLine("2: Odbierz");
    Console.WriteLine("Inne: Wyjd�");

    string menuChoise = Console.ReadLine();

    Console.WriteLine("Podaj pe�n� �cie�k� do pliku");
    string filepath = Console.ReadLine();

    switch (menuChoise)
    {
        case "1":
            try
            {
                using (var fileStream = File.OpenRead(filepath))
                {
                    int dataPacket = 0;
                    Console.WriteLine("New outgoing data");
                    using (var call = client.TransferToServer())
                    {
                        byte[] buffer = new byte[1024];
                        int dataAmount;
                        while ((dataAmount = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await call.RequestStream.WriteAsync(new ImageTransferData { Data = Google.Protobuf.ByteString.CopyFrom(buffer, 0, dataAmount) });
                        }
                        Console.WriteLine("Data packet sended: " + dataPacket);
                        await call.RequestStream.CompleteAsync();
                        await call.ResponseAsync;
                    }
                }
                Console.WriteLine("Wys�ano");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("B��dna �cie�ka lub brak dost�pu do pliku");
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
                    Console.WriteLine("B��dna �cie�ka lub brak dost�pu do pliku");
                }
            }
            break;
        default:
            Console.WriteLine("Wyj�cie");
            exit = true;
            break;
    }
}

await channel.ShutdownAsync();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();