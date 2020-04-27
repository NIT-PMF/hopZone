import React from 'react';
import '../index.css';
import CompanyLogo from '../../../assets/images/company-logo.svg';

const ContactLogo = () => {
    const paragraphStyle = {
        fontSize: '1.2rem',
        marginTop: '2rem',
    }

    return (
        <div className="contact-logo">
            <img className="company-logo-image" src={CompanyLogo} alt="Company Logo" />
            <p style={paragraphStyle} >Founded in 2019 by PMF students Irhad, Naser and Tarik.</p>
            <p style={paragraphStyle} >Get in touch with us.</p>
        </div>
    )
}

export default ContactLogo;