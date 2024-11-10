import {OrderHeader} from "./orderHeader.model";
import {Product} from "./product.model";

export interface OrderDetail{
    id: number;
    OrderHeader: OrderHeader;
    product: Product;
    amount: number;
}