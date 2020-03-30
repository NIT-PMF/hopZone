import './index.css';
import React from 'react';
import { Container, Row } from 'reactstrap';

const Homepage = () => {
    return (
        <div className="homepage-main">
            <Container fluid>
                <Row>
                    <main>
                        Ovo je main page
                    </main>
                </Row>
            </Container>
        </div>
    )
}

export default Homepage;