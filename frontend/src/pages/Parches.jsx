import { useEffect, useState } from "react";
import axios from "axios";

function Parches() {
  const [parches, setParches] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchParches = async () => {
      try {
        const token = localStorage.getItem("token");
        const response = await axios.get("http://localhost:5047/api/parches", {
          headers: { Authorization: `Bearer ${token}` }
        });
        setParches(response.data);
      } catch (error) {
        console.error("Error al cargar parches:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchParches();
  }, []);

  if (loading) {
    return <p className="text-center mt-6">Cargando parches...</p>;
  }

  return (
    <div>
      <h2 className="text-3xl font-bold mb-6">Lista de Parches 🎉</h2>
      {parches.length === 0 ? (
        <p>No hay parches disponibles.</p>
      ) : (
        <ul className="space-y-4">
          {parches.map((parche) => (
            <li
              key={parche.id}
              className="bg-white p-4 rounded-lg shadow-md hover:shadow-lg transition"
            >
              <h3 className="text-xl font-semibold">{parche.nombre}</h3>
              <p className="text-gray-600">{parche.descripcion}</p>
              <p className="text-sm text-gray-500">
                Fecha: {new Date(parche.fecha).toLocaleDateString()}
              </p>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export default Parches;
