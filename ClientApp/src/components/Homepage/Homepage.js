import './index.css';
import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import HomepageHeader from '../HomepageHeader/HomePageHeader';


const Homepage = () => {
    return (
        <header className="homepage-main">
                <Row>
                    <HomepageHeader />
            </Row>
            <Container fluid className="main-container-homepage">
                <Row>
                    <Col xs="auto">
                    <main>
                            Ovo je main page
                    </main>
                        </Col>
                </Row>
            </Container>
        </header>
    )
}

export default Homepage;