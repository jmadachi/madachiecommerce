import { BrowserRouter, Navigate, Route } from "react-router-dom";
import { PrivateRoutes, PublicRoutes } from "./routes";
import { AuthGuard } from "./guards";
import { RoutesNotFound } from "./tools";
import { lazy, Suspense } from "react";
import { Provider } from "react-redux";
import store from "./redux/store";

const Login = lazy(() => import('./pages/Login/Login'));
const OrderManagement = lazy(() => import('./pages/OrderManagement/OrderManagement'));

export default function App() {
  return (
    <div className="App">
      <Suspense fallback={<>Loadding...</>}>
        <Provider store={store}>
          <BrowserRouter>
            <RoutesNotFound>
              <Route path="/" element={<Navigate to={PrivateRoutes.ORDERS} />} />
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


