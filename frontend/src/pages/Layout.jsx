import { Link, Outlet } from "react-router-dom";

function Layout() {
  return (
    <div className="min-h-screen flex flex-col">
      {/* Navbar */}
      <nav className="bg-gradient-to-r from-indigo-600 via-purple-600 to-pink-600 text-white px-6 py-4 flex justify-between items-center shadow-md">
        <h1 className="text-2xl font-bold">ParchePlanU</h1>
        <ul className="flex space-x-6">
          <li>
            <Link to="/" className="hover:text-yellow-300">Inicio</Link>
          </li>
          <li>
            <Link to="/parches" className="hover:text-yellow-300">Parches</Link>
          </li>
          <li>
            <Link to="/planes" className="hover:text-yellow-300">Planes</Link>
          </li>
          <li>
            <Link to="/ranking" className="hover:text-yellow-300">Ranking</Link>
          </li>
          <li>
            <Link to="/asistencias" className="hover:text-yellow-300">Asistencias</Link>
          </li>
          <li>
            <Link to="/votos" className="hover:text-yellow-300">Votos</Link>
          </li>
          <li>
            <Link to="/login" className="hover:text-yellow-300">Login</Link>
          </li>
          <li>
            <Link to="/register" className="hover:text-yellow-300">Registro</Link>
          </li>
        </ul>
      </nav>

      {/* Contenido dinámico */}
      <main className="flex-1 p-6 bg-gray-100">
        <Outlet />
      </main>

      {/* Footer */}
      <footer className="bg-gray-800 text-white text-center py-4">
        <p>© 2026 ParchePlanU - Todos los derechos reservados</p>
      </footer>
    </div>
  );
}

export default Layout;
