import './index.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'reactstrap';
import ButtonPrimary from '../ButtonPrimary/ButtonPrimary';
import CircleComponent from '../CircleComponent/CircleComponent';
import phoneLogo from '../../assets/images/phoneLogo.svg';
import mapPin from '../../assets/images/map-pin-image.svg';

const HomepageHeader = () => {

    const circleDesign = () => {
        let circleArray = [];

        let circle1Top = 0;
        let circle1Right = window.innerWidth/1.2;
        circleArray.push({
            top: circle1Top,
            right: circle1Right,
            radius: 200
        });
        let circle2Top = window.innerHeight/15;
        let circle2Right = window.innerWidth /1.29;
        circleArray.push({
            top: circle2Top,
            right: circle2Right,
            radius: 100
        });

        let circle3Top = 0;
        let circle3Right = window.innerWidth / 1.2;
        circleArray.push({
            top: circle1Top,
            right: circle1Right,
            radius: 200
        });
        let circle4Top = window.innerHeight / 15;
        let circle4Right = window.innerWidth / 1.29;
        circleArray.push({
            top: circle2Top,
            right: circle2Right,
            radius: 100
        });


        

        return circleArray
    }

    return (
        <Container fluid={true}>
            <span className="background-image"></span>
            <img src={mapPin} className="map-pin-image" />
            <img src={phoneLogo} className="phone-image" />
            <div className="header-main">
                <Row noGutters>
                    <Col>
                        <span className="circles">
                            <div className="circle">
                            </div>
                            <div className="circle2">
                            </div>
                            <div className="circle3">
                            </div>
                            <div className="circle4">
                            </div>
                            <div className="circle-mob">
                            </div>
                            <div className="circle-mob2">
                            </div>
                            <div className="circle-text">
                            </div>
                            <div className="circle-text2">
                            </div>

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
                            <ButtonPrimary> Sign Up </ButtonPrimary>
                            <ButtonPrimary> Login </ButtonPrimary>
                            </div>
                        </Col>
                    </Col>
                </Row>
            </div>
        </Container>

    )
}

export default HomepageHeader;