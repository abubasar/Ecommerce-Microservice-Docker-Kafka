using Ecommerce.Model;
using Ecommerce.OrderService.Data;
using Ecommerce.OrderService.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Ecommerce.OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController(OrderDbContext dbContext,IKafkaProducer producer) : ControllerBase
    {
        [HttpGet]
        public async Task<List<OrderModel>> GetOrders()
        {
            return await dbContext.Orders.ToListAsync();
        }
        [HttpPost]
        public async Task<OrderModel> CreateOrder(OrderModel order)
        {
            order.OrderDate = DateTime.Now;
            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();

            //produce a message
            await producer.ProduceAsync("order-topic", new Confluent.Kafka.Message<string, string>
            {
                Key=order.Id.ToString(),
                Value=JsonConvert.SerializeObject(order)
            });
            return order;


        }
    }
}
