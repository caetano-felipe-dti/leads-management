import React, { useState, useEffect } from 'react';
import LeadCardAccepted from '../components/LeadCardAccepted';
import api from '../services/api';

const Accepted = () => {
const [leads, setLeads] = useState([]);

useEffect(() => {
    api.get('/leads', { params: { leadStatus: 'accepted' } })
      .then(response => setLeads(response.data.leads))
      .catch(error => console.error('Erro ao buscar leads aceitos:', error));
  }, []);

return (
  <div>
    <div className="lead-list">
      {leads.map(lead => (
        <LeadCardAccepted 
          key={lead.id} 
          lead={lead} 
        />
      ))}
    </div>
  </div>
);
};

export default Accepted;