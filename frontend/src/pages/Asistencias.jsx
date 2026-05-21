import { useEffect, useState } from "react";
import axios from "axios";

function Asistencias() {
  const [asistencias, setAsistencias] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchAsistencias = async () => {
      try {
        const token = localStorage.getItem("token");
        const response = await axios.get("http://localhost:5047/api/asistencias", {
          headers: { Authorization: `Bearer ${token}` }
        });
        setAsistencias(response.data);
      } catch (error) {
        console.error("Error al cargar asistencias:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchAsistencias();
  }, []);

  if (loading) {
    return <p className="text-center mt-6">Cargando asistencias...</p>;
  }

  return (
    <div>
      <h2 className="text-3xl font-bold mb-6">Asistencias ✅</h2>
      {asistencias.length === 0 ? (
        <p>No hay asistencias registradas.</p>
      ) : (
        <table className="min-w-full bg-white rounded-lg shadow-md overflow-hidden">
          <thead className="bg-gradient-to-r from-green-400 via-teal-500 to-blue-500 text-white">
            <tr>
              <th className="py-3 px-4 text-left">Usuario</th>
              <th className="py-3 px-4 text-left">Plan</th>
              <th className="py-3 px-4 text-left">Fecha</th>
              <th className="py-3 px-4 text-left">Estado</th>
            </tr>
          </thead>
          <tbody>
            {asistencias.map((item) => (
              <tr
                key={item.id}
                className="border-b hover:bg-gray-100 transition"
              >
                <td className="py-2 px-4">{item.usuarioNombre}</td>
                <td className="py-2 px-4">{item.planNombre}</td>
                <td className="py-2 px-4">
                  {new Date(item.fecha).toLocaleDateString()}
                </td>
                <td className="py-2 px-4">
                  {item.confirmado ? "Confirmado" : "Pendiente"}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}

export default Asistencias;
