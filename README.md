Añadir cadena de conexion en appsettings.json o en secretos de usuario:

```{
  "ConnectionStrings": {
    "SqlDatabase": "..."
  }
}
```
Ejecutar el comando ``` Update-Database ``` desde la consola del administrador de paquetes para aplicar las migraciones.
