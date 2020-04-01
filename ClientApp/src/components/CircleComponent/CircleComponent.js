import React from 'react';
import './index.css';

const CircleComponent = (props) => {

    const circlePosition = {
        top: props.top,
        right: props.right,
        height: (props.radius + 'px'),
        width: (props.radius + 'px')
    }

    return (
        <span style={circlePosition} className="circle-main">

        </span>
        )
}

export default CircleComponent;