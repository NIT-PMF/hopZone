import './index.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'reactstrap';
import ButtonPrimary from '../ButtonPrimary/ButtonPrimary';
import CircleComponent from '../CircleComponent/CircleComponent';
import phoneLogo from '../../assets/images/phoneLogo.svg';
import mapPin from '../../assets/images/map-pin-image.svg';
import bubblesArray from '../../assets/javascript/bubbles';
import { Link } from 'react-router-dom';


const HomepageHeader = () => {
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
                            <span classname="circles">
                                {bubblesArray.map(circle => <CircleComponent radius={circle.radius} top={circle.top} left={circle.left} />)}
                            </span>
                            <Col sm={{ size: 'auto' }}>
                                <h1 className="main-header-text">
                                    We offer incredible experience that many beginner travelers
                                    and tourists will cherish for the rest of their trip.
                                    From sightseeing to cruises, set forth on an adventure made by people worldwide.
            </h1>
                            </Col>
                            <Col>
                                <div className="main-header-buttons">
                                    <Link to='/account/signup'><ButtonPrimary> Sign Up </ButtonPrimary></Link>
                                    <Link to='/account/login'><ButtonPrimary> Sign In </ButtonPrimary></Link>
                                </div>
                            </Col>
                        </Col>
                    </Row>
                </div>
            </span>
        </Container>

    )
}

export default HomepageHeader;