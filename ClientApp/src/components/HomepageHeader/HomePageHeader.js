import './index.css';
import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import ButtonPrimary from '../ButtonPrimary/ButtonPrimary';

const HomepageHeader = () => {
    return (
        <div className="header-main">
            <Container>
                <Row>
                    <Col>
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
                </Container>
            </div>
        )
}

export default HomepageHeader;