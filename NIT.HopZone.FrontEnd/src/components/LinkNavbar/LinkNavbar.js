import React from 'react';
import './index.css';


const LinkNavbar = (props) => {
    return (
        <li className="nav-item">
            <a href={props.path} className="link-navigation">{props.children}</a>
        </li>
        )
}


export default LinkNavbar;