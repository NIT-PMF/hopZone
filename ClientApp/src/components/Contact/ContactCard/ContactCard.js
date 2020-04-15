import React from 'react';
import '../index.css';

const ContactCard = ({ children }) => {
    return (
        <div className="contact-card">
            {children}
        </div>
    )
}

export default ContactCard;