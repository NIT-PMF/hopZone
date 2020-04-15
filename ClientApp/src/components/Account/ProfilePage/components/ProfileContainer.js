import React from 'react';
import './index.css';

const ProfileContainer = ({ children }) => {
    return (
        <div className="profile-main-container">
            {children}
        </div>
    )
}

export default ProfileContainer;
