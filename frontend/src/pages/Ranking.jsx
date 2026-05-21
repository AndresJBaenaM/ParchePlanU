import { useEffect, useState } from "react";
import axios from "axios";

function Ranking() {
  const [ranking, setRanking] = useState([]);
  const [loading, setLoading] = useState(true);

  // Mock data de respaldo
  const mockRanking = [
    { id: 1, nombre: "Andres", puntos: 120 },
    { id: 2, nombre: "María", puntos: 95 },
    { id: 3, nombre: "Carlos", puntos: 80 }
  ];

  useEffect(() => {
    const fetchRanking = async () => {
      try {
        const token = localStorage.getItem("token");
        const response = await axios.get("http://localhost:5047/api/ranking", {
          headers: { Authorization: `Bearer ${token}` }
        });

        // Si el backend devuelve datos, los usamos
        if (response.data && response.data.length > 0) {
          setRanking(response.data);
        } else {
          // Si no hay datos, usamos mock
          setRanking(mockRanking);
        }
      } catch (error) {
        console.error("Error al cargar ranking, usando mock:", error);
        setRanking(mockRanking); // fallback
      } finally {
        setLoading(false);
      }
    };

    fetchRanking();
  }, []);

  if (loading) {
    return <p className="text-center mt-6">Cargando ranking...</p>;
  }

  return (
    <div>
      <h2 className="text-3xl font-bold mb-6">Ranking 🏆</h2>
      {ranking.length === 0 ? (
        <p>No hay datos de ranking disponibles.</p>
      ) : (
        <table className="min-w-full bg-white rounded-lg shadow-md overflow-hidden">
          <thead className="bg-gradient-to-r from-yellow-400 via-orange-500 to-red-500 text-white">
            <tr>
              <th className="py-3 px-4 text-left">Posición</th>
              <th className="py-3 px-4 text-left">Nombre</th>
              <th className="py-3 px-4 text-left">Puntos</th>
            </tr>
          </thead>
          <tbody>
            {ranking.map((item, index) => (
              <tr
                key={item.id}
                className="border-b hover:bg-gray-100 transition"
              >
                <td className="py-2 px-4 font-semibold">{index + 1}</td>
                <td className="py-2 px-4">{item.nombre}</td>
                <td className="py-2 px-4">{item.puntos}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}

export default Ranking;
