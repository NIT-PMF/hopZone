﻿import './index.css';
import Logo from '../Logo/Logo'; 
import LinkNavbar from '../LinkNavbar/LinkNavbar';
//import logo from '../../assets/images/logoHopzone.svg';
import React from 'react';
import { Link } from 'react-router-dom';

const Navbar = () => {

    return (
        <div className="navigation-component">
            <ol className="nav-list">
                <li className="nav-item-logo">
                    <Link to="/"><Logo width={'20%'} /> </Link>
                </li>
                <LinkNavbar path="/">Home</LinkNavbar>
                <LinkNavbar path="/about">About</LinkNavbar>
                <LinkNavbar path="/destinations">Destinations</LinkNavbar>
                <LinkNavbar path="/contact">Contact</LinkNavbar>
                <li className="nav-item nav-primary"><a className="link-learn-more" href="#learn-more-content">Learn More</a></li>
                </ol>
        </div>
    )
}

export default Navbar;