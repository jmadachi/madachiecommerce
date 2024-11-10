import {Customer} from "./customer.model";

export interface OrderHeader{
    id: number;
    customer: Customer;
    orderNumber: string;
    date: Date;
}