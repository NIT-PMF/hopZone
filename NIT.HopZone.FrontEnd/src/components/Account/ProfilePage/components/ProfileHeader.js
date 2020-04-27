import React from 'react';
import './index.css';

const ProfileHeader = () => {
    return (
        <div className="profile-page-header">
            <div>
                Followers: 2213
            </div>
            <div>
                Rating: 4.5
            </div>
            <span className="header-horizontal-divider"></span>
            <div>
                Routes: 23
            </div>
            <div>
                Joined: 20-20-2018
            </div>
        </div>
    )
}

export default ProfileHeader;