
1. Ejecutar archivo sql server "scriptinicial.sql" para crear el modelo de datos.
2. Ejecutar archivo SetupRabbitMQ.bat (para crear los distintos canales de comunicación)
3. Poner como proyectos de arranque PaymentServices y Server (aplicación de consola, para mostrar el fun
cionamiento del envío de mensajes por RabbitMQ). (click derecho en la solución del proyecto -> properties
-> multiple startup project -> seleccionar proyectos antes mencionados).
4. Ejecutar proyecto.
5. Hacer pruebas con postman.

Ejemplo de prueba: POST: http://localhost:50271/api/Payments/PostPayment en body, en x-www-form-urlencoded,
agregar los siguientes datos {"ClientCode": "0001", "TotalPayment":"10000", "OrderNumber":"0001", "CodePaymentType":"01"}

El resultado esperado sería un dto con los datos guardados en la base de datos y en la aplicación de consola
debería verse el mensaje en la cola de mensajes.
