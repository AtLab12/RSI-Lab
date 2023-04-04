using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;
using Grpc.Core;
using ImageTransferServer;

namespace ImageTransferServer
{
    public class TransferService : ImageTransferService.ImageTransferServiceBase
    {
        public override async Task<Empty> TransferToServer(IAsyncStreamReader<ImageTransferData> requestStream, ServerCallContext context)
        {
            using (var fileStream = File.Create(@"Recived\received.png"))
            {
                int dataPacket = 0;
                Console.WriteLine("New incoming data");
                while (await requestStream.MoveNext())
                {
                    ImageTransferData imageData = requestStream.Current;
                    await fileStream.WriteAsync(imageData.Data.ToByteArray());
                    Console.WriteLine("Data packet recived: " + dataPacket);
                    dataPacket++;
                    Thread.Sleep(10);
                }
            }

            return new Empty();
        }

        public override async Task TransferToClient(Empty request, IServerStreamWriter<ImageTransferData> responseStream, ServerCallContext context)
        {
            using (var fileStream = File.OpenRead(@"Recived\received.png"))
            {
                byte[] buffer = new byte[1024];
                int dataAmount;
                int dataPacket = 0;

                Console.WriteLine("New outgoing data");


                while ((dataAmount = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    var imageData = new ImageTransferData { Data = ByteString.CopyFrom(buffer, 0, dataAmount) };
                    await responseStream.WriteAsync(imageData);
                    Console.WriteLine("Data packet sended: " + dataPacket);
                    dataPacket++;
                    Thread.Sleep(10);
                }
            }
        }
    }
}