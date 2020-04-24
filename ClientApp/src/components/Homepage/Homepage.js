import './index.css';
import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import HomepageHeader from '../HomepageHeader/HomePageHeader';
import CardPrimary from '../CardPrimary/CardPrimary';
import footerImage from '../../assets/images/header-main-footer.svg';
import Header1 from '../Header1/Header1';

import { MdPersonAdd } from 'react-icons/md';
import { FaHandsHelping } from 'react-icons/fa';
import { FaLaughBeam } from 'react-icons/fa';
import { FaCamera } from 'react-icons/fa';


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
                                <CardPrimary left={'0'} top={'-15vh'} shape={true} width={'60%'} height={'1000px'}>
                                    <a id="learn-more-content"></a>
                                    <div className="text-main-2">
                                        <div className="feature-container">
                                            <FaHandsHelping size="15rem" />
                                            <div className="feature-content">
                                                <Header1 color="#f1eeee" size="1.4rem">Let Other People Guide You</Header1>
                                                <hr />
                                                <div className="feature-text">
                                                    Our website gives you the ability to access the most popular routes and sight seeing places made by the well-traveled users of this website.
                                                    Sign up to get the most of our services and experience your journey here in real time.</div>
                                                <br />
                                            </div>
                                        </div>

                                        <div className="feature-container">
                                            <MdPersonAdd size="11rem" />
                                            <div className="feature-content">
                                                <Header1 color="#f1eeee" size="1.4rem">Offer Other People Time of Their Life</Header1>
                                                <hr />
                                                <div className="feature-text">
                                                    Sign up right now and be the one who makes the impact by creating your routes filled with amazing places and sharing it with the users on this website.
                                                    </div>
                                                <br />
                                            </div>
                                        </div>

                                        <div className="feature-container">
                                            <FaLaughBeam size="15rem" />
                                            <div className="feature-content">
                                                <Header1 color="#f1eeee" size="1.4rem">Make Traveling Fun Again</Header1>
                                                <hr />
                                                <div className="feature-text">
                                                    HopZone offers a variety of user-submitted travel paths as well as some amazing routes made by our team.
                                                    Experience the whole new world of traveling, sightseeing, touring, exploring and many more.
                                                    </div>
                                            </div>
                                        </div>

                                    </div>
                                </CardPrimary>
                            </div>
                            <div className="card-add-info">
                                <CardPrimary left={'44vw'} top={'20vh'} shape={false} width={'60%'} height={'800px'}>
                                    <div className="card-info-content">
                                        <Header1 color="#f1eeee" size="1.6rem">Still trying to find great locations for pictures?</Header1>
                                        <FaCamera size="5rem" color="#fff" />
                                        <Header1 color="#f1eeee" size="1.4rem">Why not try our website?</Header1>
                                        <hr width="80%" />

                                        <p className="text-decor">
                                            HopZone is a simple way for photographers to log, capture, and share the world’s most astonishing photographic locations.
                                            Discover new places to take pictures to upgrade your social status and gain knowledge before travelling abroad.
                                            Get inspiration from each location’s spot and learn insightful tips from other users that have been there before you.
                                        </p>
                                    </div>
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
