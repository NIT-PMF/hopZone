import React from 'react';
import './index.css';
import footerImage from '../../assets/images/header-main-footer.svg';

const Footer = (props) => {

    return (
        <div className="footer-main">
            <img className="footer-image" src={footerImage} alt="Website Footer" />
            <div className="footer-content">{props.children}</div>
        </div>
    )
}

export default Footer;