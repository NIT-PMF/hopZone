import './index.css';
import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import HomepageHeader from '../HomepageHeader/HomePageHeader';
import CardPrimary from '../CardPrimary/CardPrimary';
import Footer from '../Footer/Footer';
import footerImage from '../../assets/images/header-main-footer.svg';



const Homepage = () => {
    return (
        <div>
        <header className="homepage-main">
                <Row>
                    <HomepageHeader />
            </Row>
        </header>
            <Container fluid className="main-container-homepage">
                <Row>
                    <Col xs="auto">
                        <main className="main-content">
                            <div className="card-features" >
                                <CardPrimary width={'60%'} height={'400px'}>Ovo je Tekst 1 </CardPrimary>
                            </div>
                            <div className="card-add-info">
                                <CardPrimary width={'60%'} height={'400px'}>Ovo je Tekst 2 </CardPrimary>
                                </div>
                        </main>
                        </Col>
                </Row>
            </Container>

            <div className="footer-homepage">
                <img className="footer-image" src={footerImage} alt="Website Footer" />
                </div>
            </div>

    )
}

export default Homepage;