# ParchePlan U
## Integrantes
Miguel Gómez y Andres Baena 

## Introduccion 
ParchePlan U es una aplicacion web diseñada para los estudiantes universitarios que necesitan un unico lugar donde organizar sus parches con amigos o compañeros 
El problema que se resuelve es simple. La idea es coordinar un plan entre varios estudiantes evitando los probelmas que surgen cuando se quiere hacer un parche, muchos chats, opiniones diferentes etc. 
Lo que hace ParchePlan U es centralizar todo este proceso desde la creacion de grupo hasta la confirmacion de asistencia. 

## Funcion de la plataforma 

- **Autenticación** — Registro e inicio de sesión con JWT
- **Parches** — Crea grupos, únete con código de invitación, gestiona miembros
- **Planes** — Propón actividades con múltiples opciones de lugar y hora
- **Votación** — Los miembros votan por su opción favorita; se calcula el ganador automáticamente
- **Asistencia** — Confirma si vas, no vas o quizás (Yes / No / Maybe)
- **Rankings** — Puntaje por organización y asistencia dentro de cada parche

## Tecnologías utilizadas
ASP.NET Core | Framework principal de la API 
Entity Framework Core | ORM y migraciones de base de datos 
SQL Server | Base de datos relacional 
ASP.NET Identity | Autenticación y gestión de usuarios 
JWT (JSON Web Tokens) | Autorización segura por token 
Scalar | Documentación interactiva de la API 

