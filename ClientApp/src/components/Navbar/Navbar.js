import './index.css';
//import logo from 'public/images/logoHopzone.svg'; 
import React from 'react';

const Navbar = () => {
    return (
        <div className="navigation-component">
            <ol className="nav-list">
                <li className="nav-item">
                    <img
                        //src={logo}
                        alt='website-logo'
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