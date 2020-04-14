import React from 'react';
import './index.css';

const ProfileInfoMain = () => {
    const nameStyle = {
        fontSize: '2rem',
        fontWeight: 'bold'
    }

    const subheaderStyle = {
        padding: '5px',
        fontSize: '1.3rem',

    }

    return (

        <div className="profile-user-information">
            <div style={nameStyle}>
                Jessica Jones, 27
            </div>
            <div style={subheaderStyle}>
                Bosnia, Sarajevo
            </div>
            <div style={subheaderStyle}>
                Solution Manager - Creative Officer
                <span style={{ display: 'block', color: 'darkblue' }}>University of Colorado</span>
            </div>
            <div>
                I love Traveling!
            </div>
            <hr />
        </div>
    )
}

export default ProfileInfoMain;