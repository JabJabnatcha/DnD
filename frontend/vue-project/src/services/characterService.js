import axios from 'axios';

const apiClient = axios.create({
  baseURL: 'http://localhost:5199/api', // backend URL
  headers: {
    'Content-Type': 'application/json',
  },
});

export default {
  getCharacters() {
    return apiClient.get('/Character');
  },
  getCharacter(id) {
    return apiClient.get(`/Character/${id}`);
  },
  createCharacter(character) {
    return apiClient.post('/Character', character);
  },
  updateCharacter(id, character) {
    return apiClient.put(`/Character/${id}`, character);
  },
  deleteCharacter(id) {
    return apiClient.delete(`/Character/${id}`);
  },
};
