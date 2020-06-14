import React, { useState } from "react";
import "../index.css";
import gql from "graphql-tag";
import { Mutation } from "@apollo/react-components";
import { css } from "@emotion/core";
import ClipLoader from "react-spinners/ClipLoader";

const override = css`
  display: block;
  margin: 0 auto;
  border-color: white;
`;

const ADD_CONTACT = gql`
  mutation($contact: ContactInputType!) {
    addContact(contact: $contact) {
      username
      subject
      body
      email
    }
  }
`;

const ContactForm = () => {
  const [contactInfo, setContact] = useState({});

  const handleChange = (e) => {
    const { name, value } = e.target;
    setContact({
      ...contactInfo,
      [name]: value,
    });
  };

  return (
    <Mutation mutation={ADD_CONTACT}>
      {(addContact, { loading, error }) => (
        <div className="contact-info">
          <form
            className="contact-form"
            onSubmit={(e) => {
              e.preventDefault();
              if (Object.keys(contactInfo).length > 3)
                addContact({ variables: { contact: contactInfo } });
              setContact({});
            }}
          >
            <label htmlFor="edit-name">Name</label>
            <input
              type="text"
              name="username"
              placeholder="Your name"
              className="contact__form_input_textarea"
              onChange={handleChange}
              required
              autoFocus
            />
            <span></span>
            <label htmlFor="edit-mail">E-mail address</label>
            <input
              type="email"
              name="email"
              placeholder="Your e-mail address"
              onChange={handleChange}
              className="contact__form_input_textarea"
              required
            />
            <span></span>
            <label htmlFor="edit-subject">Subject</label>
            <input
              type="text"
              name="subject"
              placeholder="A short subject"
              onChange={handleChange}
              className="contact__form_input_textarea"
              required
            />
            <span></span>
            <label htmlFor="edit-message">Message</label>
            <textarea
              name="body"
              rows="5"
              placeholder="The messages goes here…"
              onChange={handleChange}
              className="contact__form_input_textarea"
              required
            ></textarea>
            <span></span>
            <button type="submit" name="submit" className="form-submit">
              <ClipLoader
                css={override}
                size={20}
                color={"#000000"}
                loading={loading}
              />
              {!loading && "Send Message"}
            </button>
            {error && <p style={{ color: "white" }}>{error}</p>}
          </form>
        </div>
      )}
    </Mutation>
  );
};

export default ContactForm;
