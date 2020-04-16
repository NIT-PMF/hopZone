﻿import React from 'react';
import '../index.css';

const ContactForm = () => {
    return (
        <div className="contact-info">
            <form className="contact-form">
                <label htmlFor="edit-name">Name</label>
                <input type="text" name="name" placeholder="Your name" required autoFocus /><span></span>
                <label htmlFor="edit-mail">E-mail address</label>
                <input type="email" name="email" placeholder="Your e-mail address" required /><span></span>
                <label htmlFor="edit-subject">Subject</label>
                <input type="text" name="subject" placeholder="A short subject" required /><span></span>
                <label htmlFor="edit-message">Message</label>
                <textarea name="message" rows="5" placeholder="The messages goes here…" required></textarea><span></span>
                <button type="submit" name="submit" className="form-submit" disabled>Send message</button>
            </form>
        </div>
    )
}

export default ContactForm;