import axios from 'axios';

const api = axios.create({
baseURL: 'https://localhost:5001/api', // URL da sua API .Net Core
});

export default api;