import React from 'react';
import './index.css';

import ProfileImage from './components/ProfileImage'
import ProfileHeader from './components/ProfileHeader'
import ProfileContainer from './components/ProfileContainer';
import ProfileInfoMain from './components/ProfileInfoMain';
import ProfileMain from './components/ProfileMain';

const ProfilePage = () => {
    return (
        <div className="profile-page-container">
            <ProfileImage />
            <ProfileHeader />
            <ProfileContainer>
                <ProfileInfoMain />
                <ProfileMain />
            </ProfileContainer>
        </div>
        )
}

export default ProfilePage;