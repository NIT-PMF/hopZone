import React from "react";
import "./styles.scss";

const ProfileMain = () => {
  const fontStyle = {
    padding: "5px",
    marginBottom: "10px",
  };

  return (
    <React.Fragment>
      <div className="user-description">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et nibh sed
        massa ultrices ullamcorper sit amet ut purus. Etiam porta maximus
        posuere. Curabitur vehicula orci sed lacus congue gravida. Morbi ut
        magna pulvinar, faucibus turpis id, euismod erat. Nunc condimentum
        auctor vehicula. Donec ac augue lacinia diam bibendum vulputate ut nec
        nisl. Donec vitae accumsan tellus, quis dictum erat. F usce id risus a
        eros placerat eleifend. Ut bibendum et dolor eu viverra. Integer
        pulvinar cursus arcu a faucibus. Phasellus eu venenatis ante.
        Pellentesque euismod tincidunt urna, ac viverra lectus pellentesque et.
        Vestibulum tempor, lectus vel consequat pellentesque, mi eros facilisis
        nulla, ut imperdiet lorem dolor in nisl. Morbi sed ante interdum,
      </div>

      <div className="user-content">
        <span style={fontStyle}>My Socials:</span>
        <div style={{ display: "flex", margin: "auto" }}>
          <div class="button-wrap facebook">
            <div class="button-inner-wrap">
              <i class="icon-facebook inactive"></i>
              <i class="icon-facebook active"></i>
            </div>
          </div>

          <div class="button-wrap dribbble">
            <div class="button-inner-wrap">
              <i class="icon-dribbble inactive"></i>
              <i class="icon-dribbble active"></i>
            </div>
          </div>

          <div class="button-wrap twitter">
            <div class="button-inner-wrap">
              <i class="icon-twitter inactive"></i>
              <i class="icon-twitter active"></i>
            </div>
          </div>

          <div class="button-wrap pinterest">
            <div class="button-inner-wrap">
              <i class="icon-pinterest inactive"></i>
              <i class="icon-pinterest active"></i>
            </div>
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default ProfileMain;
