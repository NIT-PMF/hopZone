import React from 'react';
import './index.css';

import ContactPage from './ContactPage/ContactPage';
import ContactForm from './ContactForm/ContactForm';
import ContactLogo from './ContactLogo/ContactLogo';
import ContactCard from './ContactCard/ContactCard';


const Contact = () => {
    return (
        <div className="contact-page-container">
            <ContactPage>
                <ContactCard >
                    <ContactForm />
                    <ContactLogo />
                </ContactCard>
            </ContactPage>
        </div>
    )
}

export default Contact;