import React from 'react';
import './index.css';

const Footer = (props) => {

    return (
        <div className="footer-main">
            <div className="footer-content">{props.children}</div>
        </div>
    )
}

export default Footer;