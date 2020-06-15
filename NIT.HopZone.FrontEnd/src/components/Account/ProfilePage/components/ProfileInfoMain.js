import React from "react";
import "./index.css";

const ProfileInfoMain = ({ info }) => {
  const nameStyle = {
    fontSize: "2rem",
    fontWeight: "bold",
  };

  const subheaderStyle = {
    padding: "5px",
    fontSize: "1.3rem",
  };

  return (
    <div className="profile-user-information">
      <div style={nameStyle}>
        {info.given_name !== null && info.given_name}{" "}
        {info.family_name !== null && info.family_name}
      </div>
      <div style={subheaderStyle}>Bosnia, Sarajevo</div>
      <div style={subheaderStyle}>
        Solution Manager - Creative Officer
        <span style={{ display: "block", color: "black" }}>
          University of Colorado
        </span>
      </div>
      <div>
        Email: {info.preferred_username !== null && info.preferred_username}
      </div>
      <hr />
    </div>
  );
};

export default ProfileInfoMain;
