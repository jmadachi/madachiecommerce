import { Navigate, Route } from "react-router-dom";
import { PrivateRoutes } from "../../routes";
import CreateOrder from "./CreateOrder/CreateOrder";
import { RoutesNotFound } from "../../tools";
import Orders from "./Orders/Orders";

export default function OrderManagent() {
  return (
    <RoutesNotFound>
      <Route path="/" element={<Navigate to={PrivateRoutes.ORDERS} />} />
      <Route path={PrivateRoutes.ORDERS} element={<Orders/>} />
      <Route path={PrivateRoutes.CREATE_ORDER} element={<CreateOrder/>} />
    </RoutesNotFound>
  )
}