# Gestión de Inventario (DINET)

Para la construcción del proyecto hice uso de ASP.NET MVC Framework con C# en el entorno de desarrollo Visual Studio 2019 y una base de datos de tipo SQL Server. 

Se siguieron los siguientes pasos para la solución:
- Para la conexión de la base de datos con el proyecto se utilizó el paquete "EntityFramework".
- Se creó una nueva base de datos denominada "InventarioDinet", se agregó la tabla "MOV_INVENTARIO", se insertó datos y se desarrollaron los "Stored Procedures" siguiendo los pasos mencionados en el ejercicio técnico.
- Se creó el modelo de base de datos (archivo edmx) dentro del proyecto en base a lo mencionado en el punto anterior y se utilizó una cadena de conexión a mi base de datos el cual se encuentra en el archivo "Web.config".
- Luego, se creó la clase "Inventory" y se colocaron los nombres de los datos de la tabla con los que se visualizan en pantalla.
- Posteriormente, se creó la clase "InventoryController" en donde se utilizaron los "Stored Procedures" en cada método de gestión de inventario correspondiente.
- Finalmente, se crearon las vistas de los métodos de gestión de inventario y se ajustaron para una mejor presentación.

A continuación, se presentan unas capturas de pantalla para evidenciar la funcionalidad:

![image](https://github.com/user-attachments/assets/3b8611b8-5d96-4187-9e40-6d91e62b2c34)

![image](https://github.com/user-attachments/assets/61f45753-1171-411b-865d-b4005b576e31)

![image](https://github.com/user-attachments/assets/6f973011-4cfc-4227-b707-c7bc6238cc6b)

Nota: Se han agregado los scripts de los "Stored Procedures" al repositorio.
