import { BrowserRouter, Route, Routes } from "react-router-dom";
import Login from "./pages/Login/Login";
import Orders from "./pages/Orders/Orders";

export default function App() {

  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login/>} />
          <Route path="*" element={<>PAGE NOT FOUNT</>} />
          <Route path="/orders" element={<Orders/>} />
        </Routes>
      </BrowserRouter>
    </div>
  )
}


