import { User } from "./user.model";

export interface Customer{
    id: number;
    user: User;
    documentNumber: string;
    name: string;
}