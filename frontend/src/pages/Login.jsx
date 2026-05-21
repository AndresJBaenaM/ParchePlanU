import { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";

function Login() {
  const [formData, setFormData] = useState({
    Email: "",
    Password: ""
  });

  const navigate = useNavigate();

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      // Ajusta la URL al endpoint real de tu backend
      const response = await axios.post("http://localhost:5047/api/auth/login", formData);

      // Guardamos el token en localStorage
      localStorage.setItem("token", response.data.token);

      alert("Inicio de sesión exitoso ✅");
      // Redirigimos al dashboard
      navigate("/");
    } catch (error) {
      console.error(error);
      if (error.response && error.response.data) {
        alert("Error: " + JSON.stringify(error.response.data));
      } else {
        alert("Error de conexión ❌");
      }
    }
  };

  return (
    <div className="flex items-center justify-center min-h-screen bg-gradient-to-r from-indigo-500 via-purple-500 to-pink-500">
      <div className="bg-white p-8 rounded-lg shadow-lg w-96">
        <h2 className="text-2xl font-bold mb-6 text-center">Iniciar sesión</h2>
        <form className="space-y-4" onSubmit={handleSubmit}>
          <input
            type="email"
            name="Email"
            placeholder="Correo"
            value={formData.Email}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-indigo-400"
          />
          <input
            type="password"
            name="Password"
            placeholder="Contraseña"
            value={formData.Password}
            onChange={handleChange}
            className="w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-indigo-400"
          />
          <button
            type="submit"
            className="w-full bg-indigo-600 text-white py-2 rounded-lg hover:bg-indigo-700"
          >
            Entrar
          </button>
        </form>
      </div>
    </div>
  );
}

export default Login;
