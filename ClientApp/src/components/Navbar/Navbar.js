import './index.css';
import Logo from '../Logo/Logo';
import LinkNavbar from '../LinkNavbar/LinkNavbar';
//import logo from '../../assets/images/logoHopzone.svg';
import React from 'react';
import { Link } from 'react-router-dom';
import ResponsiveMenu from 'react-responsive-navbar';
import { MdMenu } from "react-icons/md";
import { MdClose } from "react-icons/md";


const Navbar = () => {

  const navStyle = {
    width: '100%',
    backgroundColor: '#3860ED',
    height: '50px',
    color: 'white',
    fontSize: '2rem',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center'
  }

  return (
    <div className="navigation-component">
      <ResponsiveMenu
        menuOpenButton={<div style={navStyle}>< MdMenu /></div>}
        menuCloseButton={< div style={navStyle}>< MdClose /></div>}
        changeMenuOn="740px"
        largeMenuClassName="large-menu-class"
        smallMenuClassName="small-menu-class"
        menu={
          <ul className="nav-list">
            <li className="nav-item-logo">
              <Link to="/"><Logo width={'20%'} /> </Link>
            </li>
            <LinkNavbar path="/">Home</LinkNavbar>
            <LinkNavbar path="/about">About</LinkNavbar>
            <LinkNavbar path="/destinations">Destinations</LinkNavbar>
            <LinkNavbar path="/contact">Contact</LinkNavbar>
            <li className="nav-item nav-primary"><a className="link-learn-more" href="#learn-more-content">Learn More</a></li>
          </ul>
        }
      />
    </div>
  )
}

export default Navbar;
