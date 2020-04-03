import './index.css';
import Logo from '../Logo/Logo'; 
import LinkNavbar from '../LinkNavbar/LinkNavbar';
import logo from '../../assets/images/logoHopzone.svg';
import React from 'react';

const Navbar = () => {
    return (
        <div className="navigation-component">
            <ol className="nav-list">
                <li className="nav-item-logo">
                    <Logo width={'15%'} />
                </li>
                <LinkNavbar>Home</LinkNavbar>
                <LinkNavbar>About</LinkNavbar>
                <LinkNavbar>Destinations</LinkNavbar>
                <LinkNavbar>Contact</LinkNavbar>
                <li className="nav-item nav-primary">Learn More</li>
                </ol>
        </div>
    )
}

export default Navbar;