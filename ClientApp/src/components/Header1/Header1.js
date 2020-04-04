import React from 'react';
import style from './index.css';

const Header1 = (props) => {
    const headerStyle = {
        color: props.color,
        fontSize: props.size,
        fontWeight: 'bold',
        textAlign: 'center',
    }


    return (
        <div style={headerStyle} className="default-font-style">
            {props.children}
            </div>
        )
}

export default Header1;