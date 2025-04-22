CONFIGURACIÓN DEL PROYECTO
1. se Crea un nuevo proyecto de tipo "ASP.NET Core Web API".

2. Configuración Swagger para la documentación automática de la API.
MODELO DE DATOS
3. Crear una clase Product con las siguientes propiedades:
o
Id (int, auto-incremental)
o
Name (string, requerido)
o
Price (decimal, requerido)
o
Quantity (int, requerido)
OPERACIONES CRUD
4.
Implementar las siguientes operaciones en la API:
o
GET /api/products: Obtener una lista de todos los productos.
o
GET /api/products/{id}: Obtener un producto por su ID.
o
POST /api/products: Crear un nuevo producto. El cuerpo de la solicitud debe incluir Name, Price y Quantity.
o
PUT /api/products/{id}: Actualizar un producto existente.
o
DELETE /api/products/{id}: Eliminar un producto por su ID.
