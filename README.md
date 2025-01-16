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

![image](https://github.com/user-attachments/assets/53ad0c53-4ab1-41f8-a371-3a0eee822f65)

![image](https://github.com/user-attachments/assets/69aae88c-5438-459e-a456-a9889440069b)

![image](https://github.com/user-attachments/assets/318c72e1-51f5-45e9-8828-198ddd38c44c)

Nota: Se han agregado los scripts de los "Stored Procedures" al repositorio.
