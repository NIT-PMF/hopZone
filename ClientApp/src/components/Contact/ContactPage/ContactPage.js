import React from 'react';
import './index.css';
import ContactCard from '../ContactCard/ContactCard';

const ContactPage = ({ children }) => {
    return (
        <div className="contact-page">
            { children }
        </div>
        )
}

export default ContactPage;