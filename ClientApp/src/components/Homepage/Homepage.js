import './index.css';
import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import HomepageHeader from '../HomepageHeader/HomePageHeader';
import CardPrimary from '../CardPrimary/CardPrimary';
import Footer from '../Footer/Footer';
import footerImage from '../../assets/images/header-main-footer.svg';
import Header1 from '../Header1/Header1';



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
                                <CardPrimary width={'60%'} height={'400px'}>
                                    <p className="text-main-2">
                                        <Header1 color="#f1eeee" size="1.4rem">Let Other People Guide You</Header1>
                                        Our website gives you the ability to access the most popular routes and sight seeing places made by the well-traveled users of this website. 
                                        Sign up to get the most of our services and experience your journey here in real time.
                                        <br /><br />
                                        <Header1 color="#f1eeee" size="1.4rem">Give Other People Time of Their Life</Header1>
                                        Sign up right now and be the one who makes the impact by creating your routes filled with amazing places and sharing it with the users on this website.
                                        <br /><br />
                                        <Header1 color="#f1eeee" size="1.4rem">Make Traveling Fun Again</Header1>
                                        HopZone offers a variety of user-submitted travel paths as well as some amazing routes made by our team.
                                        Experience the whole new world of traveling, sightseeing, touring, exploring and many more.
                                        </p>
                                        </CardPrimary>
                            </div>
                            <div className="card-add-info">
                                <CardPrimary width={'60%'} height={'400px'}>
                                    <Header1 color="#f1eeee" size="2rem">Still trying to find great locations for pictures?</Header1>
                                    <Header1 color="#f1eeee" size="1.4rem">Why not try our website?</Header1>

                                    <p className="text-main-2">
                                        HopZone is a simple way for photographers to log, capture, and share the world’s most astonishing photographic locations.
                                        Discover new places to take pictures to upgrade your social status and gain knowledge before travelling abroad.
                                        Get inspiration from each location’s spot and learn insightful tips from other users that have been there before you.
                                        </p>
                                </CardPrimary>
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