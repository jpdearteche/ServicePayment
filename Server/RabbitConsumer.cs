using RabbitMQ.Client;
using System;
using RabbitMQ.Client.Events;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	public class RabbitConsumer : IDisposable
	{
		private const string HostName = "localhost";
		private const string UserName = "guest";
		private const string Password = "guest";
		private const string QueueName1 = "payment-create";
		private const string QueueName2 = "payment-cancel";
		private const string ExchangeName = "";
		private const bool IsDurable = true;

		public delegate void OnReceiveMessage(string message);
		public bool Enabled { get; set; }
		private ConnectionFactory _connectionFactory;
		private IConnection _connection;
		private IModel _model;

		public RabbitConsumer()
		{
			DisplaySetting();
			_connectionFactory = new ConnectionFactory()
			{
				HostName = HostName,
				UserName = UserName,
				Password = Password
			};
			_connection = _connectionFactory.CreateConnection();
			_model = _connection.CreateModel();
			_model.BasicQos(0, 1, false);
		}

		private void DisplaySetting()
		{
			Console.WriteLine($"Host: {HostName}");
			Console.WriteLine($"Username: {UserName}");
			Console.WriteLine($"Password: {Password}");
			Console.WriteLine($"ExchangeName: {ExchangeName}");
			Console.WriteLine($"Is Durable: {IsDurable}");
		}

		public void Start()
		{
			ShowMessage(QueueName1);
			ShowMessage(QueueName2);
		}

		private void ShowMessage(string queueName)
		{
			var consumer = new EventingBasicConsumer(_model);
			_model.BasicConsume(queueName, false, consumer);

			while (Enabled)
			{
				//Get next message
				consumer.Received += (model, ea) =>
				{
					var body = ea.Body;
					var props = ea.BasicProperties;
					try
					{
						var message = Encoding.Default.GetString(body);
						Console.WriteLine($"Message Recieved - {message}");
						_model.BasicAck(ea.DeliveryTag, false);
					}
					catch (Exception e)
					{
						Console.WriteLine(" [.] " + e.Message);
					}
				};
				Console.WriteLine(" Press [enter] to exit.");
				Console.ReadLine();
			}
		}

		public void Dispose()
		{
			if (_model != null)
				_model.Dispose();
			if (_connection != null)
				_connection.Dispose();

			_connectionFactory = null;

			GC.SuppressFinalize(this);
		}
	}
}
