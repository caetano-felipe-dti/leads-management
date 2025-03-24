import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faMapMarkerAlt, faBriefcase, faPhone, faEnvelope } from '@fortawesome/free-solid-svg-icons';

const LeadCardAccepted = ({ lead }) => {
return (
  <div className="lead-card accepted">
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
        <span className="price-inline">${lead.price.toFixed(2)} Lead Invitation</span>
      </p>
    </div>

    <div className="lead-contact">
      <p>
        <span className="icon-footer"><FontAwesomeIcon icon={faPhone} /></span> <span className="contact-phone">{lead.phoneNumber}</span>
        <span className="icon-footer"><FontAwesomeIcon icon={faEnvelope} /></span> <span className="contact-email">{lead.email}</span>
      </p>
    </div>

    <div className="lead-description">
      <p>{lead.description}</p>
    </div>
  </div>
);
};

export default LeadCardAccepted;