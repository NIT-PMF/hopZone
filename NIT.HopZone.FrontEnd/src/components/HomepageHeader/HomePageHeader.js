import "./index.css";
import React, { useEffect, useState } from "react";
import { Container, Row, Col } from "reactstrap";
import ButtonPrimary from "../ButtonPrimary/ButtonPrimary";
import CircleComponent from "../CircleComponent/CircleComponent";
import phoneLogo from "../../assets/images/phoneLogo.svg";
import mapPin from "../../assets/images/map-pin-image.svg";
import bubblesArray from "../../assets/javascript/bubbles";
import { Link } from "react-router-dom";
import { useOktaAuth } from "@okta/okta-react";

const HomepageHeader = () => {
  const { authState, authService } = useOktaAuth();
  const [userInfo, setUserInfo] = useState("");

  useEffect(() => {
    if (!authState.isAuthenticated) {
      // When user isn't authenticated, forget any user info
      setUserInfo(null);
    } else {
      authService.getUser().then((info) => {
        setUserInfo(info);
      });
    }
  }, [authState, authService]); // Update if authState changes

  return (
    <Container fluid={true}>
      <span className="background-image"></span>
      <span className="header-content">
        <div className="images-page-header">
          <img src={mapPin} className="map-pin-image" />
          <img src={phoneLogo} className="phone-image" />
        </div>
        <div className="header-main">
          <Row noGutters>
            <Col>
              <span>
                {bubblesArray.map((circle, index) => (
                  <CircleComponent
                    key={index}
                    radius={circle.radius}
                    top={circle.top}
                    left={circle.left}
                  />
                ))}
              </span>
              <Col sm={{ size: "auto" }}>
                <h1 className="main-header-text">
                  We offer incredible experience that many beginner travelers
                  and tourists will cherish for the rest of their trip. From
                  sightseeing to cruises, set forth on an adventure made by
                  people worldwide.
                </h1>
              </Col>
              <Col>
                {!userInfo && (
                  <div className="main-header-buttons">
                    <a href="https://dev-843663.okta.com/signin/register">
                      <ButtonPrimary> Sign Up </ButtonPrimary>
                    </a>
                    <Link to="/mappage">
                      <ButtonPrimary> Sign In </ButtonPrimary>
                    </Link>
                  </div>
                )}
              </Col>
            </Col>
          </Row>
        </div>
      </span>
    </Container>
  );
};

export default HomepageHeader;
