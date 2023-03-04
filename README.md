# portafolio_api.NETCore6

Este proyecto esta relacionado con los siguentes proyectos de GitHub

* Sitio Web: (Html5, CSS3, JS)
	https://github.com/TheNefelin/portafolio-site.git
* WebApi: (.NET Core 6 C#)
	https://github.com/TheNefelin/portafolio_api.NETCore6.git
* Base de Datos: (SQL Server)
	https://github.com/TheNefelin/portafolio-SQL-Server.git

para que corra correctamente se debe agregar en el proyecto de WebApi el archivo "appsettings.json" con la configuracion del origen de datos
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