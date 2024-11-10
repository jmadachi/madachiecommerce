import { BrowserRouter, Navigate, Route } from "react-router-dom";
import { PrivateRoutes, PublicRoutes } from "./routes";
import { AuthGuard } from "./guards";
import { lazy, Suspense } from "react";
import store from "./redux/store";
import { Provider } from "react-redux";
import './App.css';
import RoutesNotFound from "./tools/RoutesNotFound/RoutesNotFound.utility";
import Logout from "./components/Logout/Logout";

const Login = lazy(() => import('./pages/Login/Login'));
const OrderManagement = lazy(() => import('./pages/OrderManagement/OrderManagement'));

export default function App() {
  return (
    <div className="App">
      <Suspense fallback={<>Loadding...</>}>
        <Provider store={store}>
          <BrowserRouter>
            <Logout/>
            <RoutesNotFound>
              <Route path="/" element={<Navigate to={PrivateRoutes.ORDER_MANAGEMENT} />} />
              <Route path={PublicRoutes.LOGIN} element={<Login/>} />
              <Route element={<AuthGuard/>} >
                <Route path={`${PrivateRoutes.ORDER_MANAGEMENT}/*`} element={<OrderManagement/>} />
              </Route>
            </RoutesNotFound>
          </BrowserRouter>
        </Provider>
      </Suspense>
    </div>
  )
}


