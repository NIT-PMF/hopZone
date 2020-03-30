import './index.css';
import logo from '../../images/logoHopzone.svg'; 
import React from 'react';

const Navbar = () => {
    return (
        <div className="navigation-component">
            <ol className="nav-list">
                <li className="nav-item">
                    <img
                        src={logo}
                        alt='website-logo'
                        width="10%"
                    />
                </li>
                <li className="nav-item">Home</li>
                <li className="nav-item">About</li>
                <li className="nav-item">Sign Up</li>
                </ol>
        </div>
    )
}

export default Navbar;