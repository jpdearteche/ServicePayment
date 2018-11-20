
1. Ejecutar archivo sql server "scriptinicial.sql" para crear el modelo de datos.
2. Ejecutar archivo SetupRabbitMQ.bat (para crear los distintos canales de comunicaci�n)
3. Poner como proyectos de arranque PaymentServices y Server (aplicaci�n de consola, para mostrar el fun
cionamiento del env�o de mensajes por RabbitMQ). (click derecho en la soluci�n del proyecto -> properties
-> multiple startup project -> seleccionar proyectos antes mencionados).
4. Ejecutar proyecto.
5. Hacer pruebas con postman.

Ejemplo de prueba: POST: http://localhost:50271/api/Payments/PostPayment en body, en x-www-form-urlencoded,
agregar los siguientes datos {"ClientCode": "0001", "TotalPayment":"10000", "OrderNumber":"0001", "CodePaymentType":"01"}

El resultado esperado ser�a un dto con los datos guardados en la base de datos y en la aplicaci�n de consola
deber�a verse el mensaje en la cola de mensajes.
