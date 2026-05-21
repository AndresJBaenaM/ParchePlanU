📘 ParchePlanU
Aplicación web desarrollada con ASP.NET Core (C#) en el backend y React + Vite en el frontend.
El proyecto permite gestionar parches, planes, ranking, asistencias y votos, con autenticación mediante JWT y base de datos en SQL Server.

🚀 Requisitos previos
Antes de ejecutar el proyecto, asegúrate de tener instalado:

Node.js (versión 18 o superior)

npm o yarn

.NET 8 SDK

SQL Server (microsoft.com in Bing) (local o remoto)

Git

📂 Clonar el repositorio
bash
git clone https://github.com/AndresJBaenaM/ProyectoIngWeb.git
cd ProyectoIngWeb
⚙️ Configuración del Backend (ASP.NET Core)
Ve a la carpeta del backend:

bash
cd ApiParchePlanU
Configura la cadena de conexión en appsettings.json:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ParchePlanU;Trusted_Connection=True;TrustServerCertificate=True;"
}
Aplica las migraciones de Entity Framework:

bash
dotnet ef database update
Ejecuta el backend:

bash
dotnet run
👉 El backend se levantará en:

http://localhost:5047 (HTTP)

https://localhost:7163 (HTTPS, certificado de desarrollo)

🎨 Configuración del Frontend (React + Vite)
Ve a la carpeta del frontend:

bash
cd ParchePlanU-Frontend
Instala las dependencias:

bash
npm install
Ejecuta el servidor de desarrollo:

bash
npm run dev
👉 El frontend se levantará en http://localhost:5173.

🔑 Autenticación
El sistema usa JWT para proteger las rutas del backend.

Al iniciar sesión, el token se guarda en localStorage.

Las peticiones protegidas deben incluir el header:

http
Authorization: Bearer <token>
📌 Rutas principales
/login → Iniciar sesión

/register → Registro de usuario

/parches → Listado de parches

/planes → Listado de planes

/ranking → Ranking de usuarios/parches

/asistencias → Confirmaciones de asistencia

/votos → Votos de los usuarios

🛠️ Tecnologías usadas
Backend: ASP.NET Core, Entity Framework, SQL Server, Identity, JWT

Frontend: React, Vite, TailwindCSS, Axios, React Router

DevOps: GitHub, Git

✅ Ejecución completa
Arranca el backend con dotnet run.

Arranca el frontend con npm run dev.

Abre http://localhost:5173 en tu navegador.

Regístrate, inicia sesión y comienza a usar la aplicación 🎉.