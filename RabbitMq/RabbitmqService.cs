using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMq
{
    public class RabbitmqService
    {
        private readonly string _hostName = "localhost";

        public IConnection getConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                HostName = _hostName
            };
            return factory.CreateConnection();
        }
    }
}
