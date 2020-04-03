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

        circleArray.push({
            top: '12%',
            left: '6%',
            radius: 185
        });

        circleArray.push({
            top: '18%',
            left: '65%',
            radius: 100
        });

        circleArray.push({
            top: '6%',
            left: '40%',
            radius: 175
        });

        circleArray.push({
            top: '80%',
            left: '80%',
            radius: 80
        });

        circleArray.push({
            top: '90%',
            left: '88%',
            radius: 95
        });

        circleArray.push({
            top: '86%',
            left: '1%',
            radius: 85
        });

        circleArray.push({
            top: '90%',
            left: '6%',
            radius: 100
        });



        return circleArray
    }

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
                            {circleDesign().map(circle => <CircleComponent radius={circle.radius} top={circle.top} left={circle.left} />)}
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
                </span>
        </Container>

    )
}

export default HomepageHeader;