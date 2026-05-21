import { Routes, Route } from "react-router-dom";
import Layout from "./pages/Layout.jsx";
import Login from "./pages/Login.jsx";
import Register from "./pages/Register.jsx";
import Parches from "./pages/Parches.jsx";
import Planes from "./pages/Planes.jsx";
import Ranking from "./pages/Ranking.jsx";
import Asistencias from "./pages/Asistencias.jsx";
import Votos from "./pages/Votos.jsx";

function App() {
  return (
    <Routes>
      <Route path="/" element={<Layout />}>
        <Route index element={<h2>Bienvenido a ParchePlanU 🎉</h2>} />
        <Route path="parches" element={<Parches />} />
        <Route path="planes" element={<Planes />} />
        <Route path="ranking" element={<Ranking />} />
        <Route path="asistencias" element={<Asistencias />} />
        <Route path="votos" element={<Votos />} />
        <Route path="login" element={<Login />} />
        <Route path="register" element={<Register />} />
      </Route>
    </Routes>
  );
}

export default App;
