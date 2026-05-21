import { useEffect, useState } from "react";
import axios from "axios";

function Votos() {
  const [votos, setVotos] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchVotos = async () => {
      try {
        const token = localStorage.getItem("token");
        const response = await axios.get("http://localhost:5047/api/votos", {
          headers: { Authorization: `Bearer ${token}` }
        });
        setVotos(response.data);
      } catch (error) {
        console.error("Error al cargar votos:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchVotos();
  }, []);

  if (loading) {
    return <p className="text-center mt-6">Cargando votos...</p>;
  }

  return (
    <div>
      <h2 className="text-3xl font-bold mb-6">Votos 🗳️</h2>
      {votos.length === 0 ? (
        <p>No hay votos registrados.</p>
      ) : (
        <table className="min-w-full bg-white rounded-lg shadow-md overflow-hidden">
          <thead className="bg-gradient-to-r from-purple-500 via-pink-500 to-red-500 text-white">
            <tr>
              <th className="py-3 px-4 text-left">Usuario</th>
              <th className="py-3 px-4 text-left">Plan/Parche</th>
              <th className="py-3 px-4 text-left">Voto</th>
              <th className="py-3 px-4 text-left">Fecha</th>
            </tr>
          </thead>
          <tbody>
            {votos.map((item) => (
              <tr
                key={item.id}
                className="border-b hover:bg-gray-100 transition"
              >
                <td className="py-2 px-4">{item.usuarioNombre}</td>
                <td className="py-2 px-4">{item.planNombre || item.parcheNombre}</td>
                <td className="py-2 px-4">
                  {item.valor === 1 ? "👍 A favor" : "👎 En contra"}
                </td>
                <td className="py-2 px-4">
                  {new Date(item.fecha).toLocaleDateString()}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}

export default Votos;
