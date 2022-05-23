using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace consumer
{
    public class rabbitmqservice
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
