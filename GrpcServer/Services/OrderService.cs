using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcServer.Services
{
    public class OrderService : OrderGrpc.OrderGrpcBase
    {
        private readonly ILogger<OrderService> _logger;

        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public override Task<CreateOrderReply> CreateOrder(CreateOrderRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Create order by {BuyId}...", request.BuyId);

            throw new Exception("报错啦。。。");

            return Task.FromResult(new CreateOrderReply{ OrderId=24});
        }
    }
}
