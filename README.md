# portafolio_api.NETCore6

### Related Projects
- [App Deploy](#) 
- [Api Deploy](https://bsite.net/metalflap/index.html) 

- [App Repo](https://github.com/TheNefelin/guias-juegos-next13-ts) 
- [Api Repo](https://github.com/TheNefelin/portafolio_api.NETCore6) 
- [SQL Server Repo](https://github.com/TheNefelin/SQLServer) 

* Base de Datos: (SQL Server)
	https://github.com/TheNefelin/portafolio-SQL-Server.git

para que corra correctamente se debe agregar en el proyecto de WebApi el archivo "appsettings.json" en la raiz con la configuracion del origen de datos
1. Data Source={nombre de tu servidor SQL}
2. Initial Catalog=DataBase{Nombre de la Base de Datos}
3. User ID={Tu Usuario SQL (sa u otro)}
4. Password={Tu Contraseña de tu usuario SQL}

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "RutaSQL": "Data Source=Server; Initial Catalog=DataBase; User ID=User; Password=PassWord"
  }
}
```