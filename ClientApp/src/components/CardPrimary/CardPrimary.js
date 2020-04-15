import React from 'react';
import './index.css';
import BlobImg1 from '../../assets/images/containers/blob-shape-small.svg';
import BlobImg2 from '../../assets/images/containers/blob-shape-1.svg';

const CardPrimary = (props) => {
    const cardStyle = {
        background: `url('${(props.shape) ? BlobImg1 : BlobImg2}')`,
        width: props.width,
        height: props.height,
        backgroundPosition: 'center',
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        top: props.top,
        left: props.left
    }

    return (
        <div style={cardStyle} className="card-primary-design">
            <div className="card-primary-text">{props.children}</div>
        </div>
    )
}

export default CardPrimary;