import './index.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'reactstrap';
import ButtonPrimary from '../ButtonPrimary/ButtonPrimary';
import CircleComponent from '../CircleComponent/CircleComponent';

const HomepageHeader = () => {

    const circleDesign = () => {
        let circleArray = [];

        for (let i = 0; i < 10; i++) {
            let randomTop = Math.floor((Math.random() * 300) + 100)
            let randomRight = Math.floor((Math.random() * (window.innerWidth - 100)) + 100)
            circleArray.push({
                top: randomTop,
                right: randomRight,
                radius: Math.floor(Math.random() * 100 + 50)
            })
        }

        return circleArray
    }

    return (
        <Container fluid={true}>
            <div className="header-main">
                <Row noGutters>
                    <Col>
                        <span className="circles">
                            {circleDesign().map(circle => <CircleComponent top={circle.top} right={circle.right} radius={circle.radius} />)}
                        </span>

                    <div className="main-header-signUp">
                        <ButtonPrimary> Sign Up </ButtonPrimary>
                    </div>
                    <Col sm={{ size: 'auto'}}>
                    <h1 className="main-header-text">
                            We offer incredible experience that many beginner travelers
                            and tourists will cherish for the rest of their trip.
                            From sightseeing to cruises, set forth on an adventure made by people worldwide.
            </h1>
                        </Col>
                        </Col>
                </Row>
            </div>
                </Container>

        )
}

export default HomepageHeader;