import React from 'react';
import './index.css';

const ButtonPrimary = (props) => {
    return (
        <div className="btn-primary-design">
            <div className="btn-primary-text">{props.children}</div>
        </div>
    )
}

export default ButtonPrimary;