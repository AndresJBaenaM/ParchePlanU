import { useState } from "react";
import axios from "axios";

function Register() {
  const [formData, setFormData] = useState({
    FullName: "",
    Email: "",
    Programa: "",
    Password: "",
    URLAvatar: ""
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post("http://localhost:5047/api/auth/register", formData);
      alert("Registro exitoso ✅");
      console.log(response.data);
    } catch (error) {
      console.error(error);
      alert("Error en el registro ❌");
    }
  };

  return (
    <div className="flex items-center justify-center min-h-screen bg-gradient-to-r from-pink-500 via-red-500 to-yellow-500">
      <div className="bg-white p-8 rounded-lg shadow-lg w-96">
        <h2 className="text-2xl font-bold mb-6 text-center">Crear cuenta</h2>
        <form className="space-y-4" onSubmit={handleSubmit}>
          <input
            type="text"
            name="FullName"
            placeholder="Nombre completo"
            value={formData.FullName}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-pink-400"
          />
          <input
            type="email"
            name="Email"
            placeholder="Correo"
            value={formData.Email}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-pink-400"
          />
          <input
            type="text"
            name="Programa"
            placeholder="Programa académico"
            value={formData.Programa}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-pink-400"
          />
          <input
            type="password"
            name="Password"
            placeholder="Contraseña"
            value={formData.Password}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-pink-400"
          />
          <input
            type="text"
            name="URLAvatar"
            placeholder="URL del avatar (opcional)"
            value={formData.URLAvatar}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-pink-400"
          />
          <button
            type="submit"
            className="w-full bg-pink-600 text-white py-2 rounded-lg hover:bg-pink-700"
          >
            Registrarse
          </button>
        </form>
      </div>
    </div>
  );
}

export default Register;
