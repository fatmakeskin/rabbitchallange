using RabbitMq;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitmqProducer
{
    public class Producer
    {
        RabbitmqService rabbitmqService;
        public Producer(string queueName, string message)
        {
            rabbitmqService = new RabbitmqService();
            using (var Connection = rabbitmqService.getConnection())
            {
                using (var channel = Connection.CreateModel())
                {
                    channel.QueueDeclare(queueName, false, false, false, null);

                    channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

                    Console.WriteLine("{0} queue'su üzerine, \"{1}\" mesajı yazıldı.", queueName, message);
                }
            }
        }
    }
}
