import './index.css';
import Logo from '../Logo/Logo';
import LinkNavbar from '../LinkNavbar/LinkNavbar';
//import logo from '../../assets/images/logoHopzone.svg';
import React, { useState, useEffect }  from 'react';
import { Link } from 'react-router-dom';
import ResponsiveMenu from 'react-responsive-navbar';
import { MdMenu } from "react-icons/md";
import { MdClose } from "react-icons/md";
import { useOktaAuth } from '@okta/okta-react';

const Logout = () => {
  const { authService } = useOktaAuth();

  const logout = async () => {
    authService.logout('https://localhost:44309');
  };

  return (
    <a onClick={logout}>Logout</a>
  );
};

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
  const { authState, authService } = useOktaAuth();
  const [userInfo, setUserInfo] = useState(null);


  useEffect(() => {
    if (!authState.isAuthenticated) {
      // When user isn't authenticated, forget any user info
      setUserInfo(null);
    } else {
      authService.getUser().then((info) => {
        setUserInfo(info);
      });
    }
  }, [authState, authService]); // Update if authState changes

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
            {userInfo &&
              <div style={{ background: "white" }}>
              <p>Welcome back, {userInfo.name}!</p>
              <Logout />
            </div>
            }
          </ul>
        }
      />
    </div>
  )
}

export default Navbar;
