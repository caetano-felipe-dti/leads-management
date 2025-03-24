import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faMapMarkerAlt, faBriefcase } from '@fortawesome/free-solid-svg-icons';

const LeadCardInvited = ({ lead, onAccept, onDecline }) => {
return (
  <div className="lead-card invited">
    <div className="lead-header">
      <div className="lead-avatar">{lead.firstName.charAt(0)}</div>
      <div className="lead-info">
        <h3>{lead.firstName}</h3>
        <p>{new Date().toLocaleDateString()} @ {new Date().toLocaleTimeString()}</p>
      </div>
    </div>

    <div className="lead-details">
      <p>
        <span className="icon"><FontAwesomeIcon icon={faMapMarkerAlt} /></span> {lead.suburb}
        <span className="icon"><FontAwesomeIcon icon={faBriefcase} /></span> {lead.category}
        <span>Job ID: {lead.id}</span>
      </p>
    </div>

    <div className="lead-description">
      <p>{lead.description}</p>
    </div>

    <div className="lead-footer">
      <div>
        <button className="btn btn-accept" onClick={() => onAccept(lead)}>Accept</button>
        <button className="btn btn-decline" onClick={() => onDecline(lead)}>Decline</button>
      </div>
      <div className="lead-price">
        <span className="price-value">${lead.price.toFixed(2)}</span>
        <span className="price-text">Lead Invitation</span>
      </div>
    </div>
  </div>
);
};

export default LeadCardInvited;