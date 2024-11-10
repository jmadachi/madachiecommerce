import { Navigate, Route } from "react-router-dom";
import { PrivateRoutes } from "../../routes";
import CreateOrder from "./CreateOrder/CreateOrder";
import Orders from "./Orders/Orders";
import RoutesNotFound from "../../tools/RoutesNotFound/RoutesNotFound.utility";
import Products from "./Products/Products";

export default function OrderManagent() {
  return (
    <RoutesNotFound>
      <Route path="/" element={<Navigate to={PrivateRoutes.PRODUCTS} />} />
      <Route path={PrivateRoutes.PRODUCTS} element={<Products/>} />
      <Route path={PrivateRoutes.ORDERS} element={<Orders/>} />
      <Route path={PrivateRoutes.CREATE_ORDER} element={<CreateOrder/>} />
    </RoutesNotFound>
  )
}