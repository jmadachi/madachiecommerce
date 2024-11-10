import { Customer } from "./customer.model";
import { OrderDetail } from "./orderDetail.model";

export interface Order{
    id: number;
    customer: Customer;
    orderNumber: string;
    date: Date;
    details: Array<OrderDetail>[];
}