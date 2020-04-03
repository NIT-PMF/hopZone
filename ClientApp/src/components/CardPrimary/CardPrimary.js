import React from 'react';
import './index.css';

const CardPrimary = (props) => {
    const cardStyle = {
        width: props.width,
        height: props.height
    }

    return (
        <div style={cardStyle} className="card-primary-design">
            <div className="card-primary-text">{props.children}</div>
        </div>
    )
}

export default CardPrimary;