using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusiness.Rabbit
{
	public class RabbitSender : IDisposable
	{
		private const string HostName = "localhost";
		private const string UserName = "guest";
		private const string Password = "guest";
		private string QueueName;
		private const string ExchangeName = "";
		private const bool IsDurable = true;

		private ConnectionFactory _connectionFactory;
		private IConnection _connection;
		private IModel _model;

		public RabbitSender()
		{
            SetupRabbitMq();
		}
		private void SetupRabbitMq()
		{
			_connectionFactory = new ConnectionFactory()
			{
				HostName = HostName,
				UserName = UserName,
				Password = Password
			};
			_connection = _connectionFactory.CreateConnection();
			_model = _connection.CreateModel();
		}
		public void Send(string message, string queueName)
		{
			//Setup properties
			QueueName = queueName;
			var properties = _model.CreateBasicProperties();
			properties.Persistent = true;

			//Serialize
			byte[] messageBuffer = Encoding.Default.GetBytes(message);

			//Send message
			_model.BasicPublish(ExchangeName, QueueName, properties, messageBuffer);
		}
		public void Dispose()
		{
			if (_connection != null)
				_connection.Close();

			if (_model != null && _model.IsOpen)
				_model.Abort();

			_connectionFactory = null;

			GC.SuppressFinalize(this);
		}
	}
}
