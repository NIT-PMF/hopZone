import React from "react";
import "./index.css";

function timeConverter(UNIX_timestamp) {
  var a = new Date(UNIX_timestamp * 1000);
  var months = [
    "Jan",
    "Feb",
    "Mar",
    "Apr",
    "May",
    "Jun",
    "Jul",
    "Aug",
    "Sep",
    "Oct",
    "Nov",
    "Dec",
  ];
  var year = a.getFullYear();
  var month = months[a.getMonth()];
  var date = a.getDate();
  var hour = a.getHours();
  var min = a.getMinutes();
  var sec = a.getSeconds();
  var time =
    date + " " + month + " " + year + " " + hour + ":" + min + ":" + sec;
  return time;
}

const ProfileHeader = ({ info }) => {
  return (
    <div className="profile-page-header">
      <div>Followers: 0</div>
      <div>Rating: 0</div>
      <span className="header-horizontal-divider"></span>
      <div>Routes: 0</div>
      <div>
        Joined:{" "}
        {info.updated_at !== null
          ? timeConverter(info.updated_at)
          : "Jessica Jones"}
      </div>
    </div>
  );
};

export default ProfileHeader;
