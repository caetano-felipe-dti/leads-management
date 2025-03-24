import React, { useState, useEffect } from 'react';
import LeadCardInvited from '../components/LeadCardInvited';
import api from '../services/api';

const Invited = () => {
    const [leads, setLeads] = useState([]);

    useEffect(() => {
        api.get('/leads', { params: { leadStatus: 'invited' } })
            .then(response => setLeads(response.data.leads))
            .catch(error => console.error('Erro ao buscar leads aceitos:', error));
    }, []);

    const handleAccept = async (lead) => {
        try {
            await api.put(`/leads/accepted?leadId=${lead.id}`);
            setLeads(leads.filter(l => l.id !== lead.id));
        } catch (error) {
            console.error('Erro ao aceitar lead:', error);
        }
    };

    const handleDecline = async (lead) => {
        try {
            await api.put(`/leads/decline?leadId=${lead.id}`);
            setLeads(leads.filter(l => l.id !== lead.id));
        } catch (error) {
            console.error('Erro ao aceitar lead:', error);
        }
    };

    return (
        <div>
            <div className="lead-list">
                {leads.map(lead => (
                    <LeadCardInvited
                        key={lead.id}
                        lead={lead}
                        onAccept={handleAccept}
                        onDecline={handleDecline}
                    />
                ))}
            </div>
        </div>
    );
};

export default Invited;