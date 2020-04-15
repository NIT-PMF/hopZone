import React from 'react';
import './index.css';
import placeholderImage from '../../../../assets/images/profile-image-placeholder.jpg';


const ProfileImage = () => {
    return (
        <img src={placeholderImage} className="profile-page-image" alt="profile picture"></img>
    )
}

export default ProfileImage;