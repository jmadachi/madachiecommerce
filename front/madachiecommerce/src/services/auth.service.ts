const baseUrlApi = `https://localhost:7090/api/`;
const loginEndpoint = baseUrlApi + 'login';

export const login = () => {
    return fetch(loginEndpoint).then(res => res.json());
};