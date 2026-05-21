import { useEffect, useState } from "react";
import axios from "axios";

function Planes() {
  const [planes, setPlanes] = useState([]);
  const [loading, setLoading] = useState(true);

  // Mock data de respaldo
  const mockPlanes = [
    { id: 1, nombre: "Salida al cine", descripcion: "Ver película en el centro comercial", fecha: "2026-05-21", lugar: "Cine Centro" },
    { id: 2, nombre: "Partido de fútbol", descripcion: "Jugar con amigos en la cancha", fecha: "2026-05-22", lugar: "Cancha municipal" },
    { id: 3, nombre: "Cena grupal", descripcion: "Salir a comer y conversar", fecha: "2026-05-23", lugar: "Restaurante El Buen Sabor" }
  ];

  useEffect(() => {
    const fetchPlanes = async () => {
      try {
        const token = localStorage.getItem("token");
        const response = await axios.get("http://localhost:5047/api/planes", {
          headers: { Authorization: `Bearer ${token}` }
        });

        // Si el backend devuelve datos, los usamos
        if (response.data && response.data.length > 0) {
          setPlanes(response.data);
        } else {
          // Si no hay datos, usamos mock
          setPlanes(mockPlanes);
        }
      } catch (error) {
        console.error("Error al cargar planes, usando mock:", error);
        setPlanes(mockPlanes); // fallback
      } finally {
        setLoading(false);
      }
    };

    fetchPlanes();
  }, []);

  if (loading) {
    return <p className="text-center mt-6">Cargando planes...</p>;
  }

  return (
    <div>
      <h2 className="text-3xl font-bold mb-6">Lista de Planes 📅</h2>
      {planes.length === 0 ? (
        <p>No hay planes disponibles.</p>
      ) : (
        <ul className="space-y-4">
          {planes.map((plan) => (
            <li
              key={plan.id}
              className="bg-white p-4 rounded-lg shadow-md hover:shadow-lg transition"
            >
              <h3 className="text-xl font-semibold">{plan.nombre}</h3>
              <p className="text-gray-600">{plan.descripcion}</p>
              <p className="text-sm text-gray-500">
                Fecha: {new Date(plan.fecha).toLocaleDateString()}
              </p>
              <p className="text-sm text-gray-500">
                Lugar: {plan.lugar}
              </p>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export default Planes;
