import React, { useState, useEffect } from "react";
import "./index.css";

import ProfileImage from "./components/ProfileImage";
import ProfileHeader from "./components/ProfileHeader";
import ProfileContainer from "./components/ProfileContainer";
import ProfileInfoMain from "./components/ProfileInfoMain";
import ProfileMain from "./components/ProfileMain";
import { useOktaAuth } from "@okta/okta-react";

const ProfilePage = () => {
  const { authState, authService } = useOktaAuth();
  const [userInfo, setUserInfo] = useState("");
  const [getUser, setUser] = useState("");

  useEffect(() => {
    if (!authState.isAuthenticated) {
      // When user isn't authenticated, forget any user info
      setUserInfo(null);
    } else {
      authService.getUser().then((info) => {
        setUserInfo(info);
        setUser(info);
      });
    }
  }, [authState, authService]); // Update if authState changes

  document.title = "HopZone | Profile Page";

  return (
    <div className="profile-page-container">
      {getUser && console.log(getUser)}
      <ProfileImage />
      <ProfileHeader info={getUser} />
      <ProfileContainer>
        <ProfileInfoMain info={getUser} />
        <ProfileMain info={getUser} />
      </ProfileContainer>
    </div>
  );
};

export default ProfilePage;
