namespace GrpcWebApp.Client.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly Greeter.GreeterClient _grpcClient;
        public GreeterService(Greeter.GreeterClient grpcClient)
        {
            _grpcClient = grpcClient;
        }
        public  Task Get()
        {
            var response =  _grpcClient.SayHello(new HelloRequest { Name = "Serhii" });

            return Task.FromResult(response.ToString());
        }
        //public override async Task SayHellos(HelloRequest request,
        //IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
        //{
        //    // Forward the call on to the greeter service
        //    using (var call = _grpcClient.SayHello(request))
        //    {
        //        await foreach (var response in call.ResponseStream.ReadAllAsync())
        //        {
        //            await responseStream.WriteAsync(response);
        //        }
        //    }
        //}
    }
}
