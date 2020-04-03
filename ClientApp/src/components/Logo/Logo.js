import React from 'react';
import logo from '../../assets/images/logoHopzone2.svg'; 

const Logo = (props) => {
    return (
        <span>
            <img width={props.width} src={logo} alt="hopzone logo" width="25%" height="10%" />
        </span>

        )
}

export default Logo;