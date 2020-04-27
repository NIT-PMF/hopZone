import React from 'react';
import logo from '../../assets/images/logoHopzone2.svg'; 

const Logo = ({ width }) => {
    return (
        <span>
            <img width={width} src={logo} alt="hopzone logo" />
        </span>

        )
}

export default Logo;