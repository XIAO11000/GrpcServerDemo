using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace GrpcServerDemo.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderService : Order.OrderBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<OrderResponse> GetOrder(OrderRequest request, ServerCallContext context)
        {
            var list = new List<string> { "哈士奇", "草泥马", "河蟹", "雅蠛碟", "法颗油", "马杀鸡", "Hello World" };
            var rand = new Random(DateTime.Now.Millisecond);

            return Task.FromResult(new OrderResponse
            {
                OrderNo = request.OrderNo,
                Amonut = 10,
                CreateTime = 0,
                OrderType = OrderResponse.Types.OrderType.Unknown,
                Items =
                {
                    new[]
                    {
                        new OrderItem {GoodsName = list[rand.Next(0, list.Count)], Price = 3, Qty = 1},
                        new OrderItem {GoodsName = list[rand.Next(0, list.Count)], Price = 3, Qty = 1},
                        new OrderItem {GoodsName = list[rand.Next(0, list.Count)], Price = 4, Qty = 1},
                    }
                }
            });
        }
    }
}
