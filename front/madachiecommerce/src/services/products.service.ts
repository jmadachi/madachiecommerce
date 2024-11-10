import axios from "axios";
import { Product } from "../models";

const baseUrlApi = `https://localhost:7090/api/`;
const listProductsEndpoint = baseUrlApi + 'products';

export const listProducts = () => {
    return axios.get<Product[]>(listProductsEndpoint).then(res => res.data)
};