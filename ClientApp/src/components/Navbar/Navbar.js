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
                <LinkNavbar path="/">Home</LinkNavbar>
                <LinkNavbar path="/about">About</LinkNavbar>
                <LinkNavbar path="/destinations">Destinations</LinkNavbar>
                <LinkNavbar path="/contact">Contact</LinkNavbar>
                <li className="nav-item nav-primary">Learn More</li>
                </ol>
        </div>
    )
}

export default Navbar;