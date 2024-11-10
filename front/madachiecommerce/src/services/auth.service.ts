import axios from "axios";
import { Login } from "../models";

const baseUrlApi = `https://localhost:7090/api/`;
const loginEndpoint = baseUrlApi + 'users/login';

export const login = (credenciales: Login) => {
    return axios.post(loginEndpoint, credenciales).then(res => res.data)
};