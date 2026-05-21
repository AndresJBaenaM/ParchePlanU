# ParchePlan U — Backend

ParchePlan U es una aplicación web diseñada para estudiantes universitarios que necesitan un único lugar donde organizar sus parches con amigos o compañeros.

El problema que resuelve es simple: coordinar un plan entre varios estudiantes evitando los problemas que surgen cuando se quiere hacer un parche — muchos chats, opiniones diferentes, etc. ParchePlan U centraliza todo este proceso desde la creación del grupo hasta la confirmación de asistencia.

## Integrantes

- Miguel Gómez Tobón

## Funcionalidades

- **Autenticación** — Registro e inicio de sesión con JWT
- **Parches** — Crea grupos, únete con código de invitación, gestiona miembros
- **Planes** — Propón actividades con múltiples opciones de lugar y hora
- **Votación** — Los miembros votan por su opción favorita.
- **Asistencia** — Confirma si vas, no vas o tal vez (Yes / No / Maybe)
- **Rankings** — Puntaje por organización y asistencia dentro de cada parche

## Tecnologías

| Tecnología | Uso |
|---|---|
| ASP.NET Core | Framework principal de la API |
| Entity Framework Core | ORM y migraciones de base de datos |
| SQL Server | Base de datos relacional |
| ASP.NET Identity | Autenticación y gestión de usuarios |
| JWT | Autorización segura por token |
| Scalar | Documentación interactiva de la API |

## Instalación y ejecución

1. Clona el repositorio
2. Configura la cadena de conexión en `appsettings.json`
3. Corre las migraciones:
```bash
Update-Database
```
4. Ejecuta el proyecto con **F5** en Visual Studio

La API queda en `https://localhost:7163`

La documentación interactiva en `https://localhost:7163/scalar/v1`

