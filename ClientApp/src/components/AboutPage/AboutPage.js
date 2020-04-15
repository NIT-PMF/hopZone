import React from 'react';
import Header1 from '../Header1/Header1';
import { Irhad, Naser, Tarik } from '../../assets/images/';
import './index.css';

const AboutPage = () => {

    document.title = "HopZone | About NIT";

    const styleMembers = {
        position: 'relative',
        display: 'flex',
        alignItems: 'flex - start',
        flex: '1 1 100 %',
    }
    const styleOneMember = {
        flex: '1',
        margin: '5px'
    }

    return (
        <div className="about-page-main">
            <div className="about-page-content">
                <Header1 size="2rem" color="white"> About Us </Header1>

                <p className="about-page-text general-info-text">
                    Our mission at NIT is creating a unique way to easily travel with innovation, originality and creativity.
                    NIT brings innovation and originality to everyone by creating a unique way to easily travel.
                    NIT is dedicated to the highest quality of user-friendly traveling application delivered with ingenuity, innovation and originality
                </p>
                <p className="about-page-text"> Our small team consists of people with different backgrounds,
                nationalities and personalities.
                    This combination makes it a strong team who will always collaborate to find quick and efficient methods to achieve great results </p>
                <br />
                <Header1 size="1.5rem" color="white"> We Are: </Header1>
                <div style={styleMembers} className="members-direction">
                    <div style={styleOneMember} className="member-naser">
                        <p className="about-page-text member-text member-naser">
                            <cite> "It is our choices, Harry, that show what we truly are, far more than our abilities." </cite>
                            <br />
                            <img className="members-image" src={Naser} alt="Naser" />
                            HopZone back-end Developer 
                            <br />
                            <strong>Naser Abd El-Ilah</strong>
                        </p>
                    </div>
                    <div style={styleOneMember} className="member-irhad">
                        <p className="about-page-text member-text">
                            <cite> "The way to get started is to quit talking and begin doing." </cite>
                            <br />
                            <img className="members-image" src={Irhad} alt="Irhad" />
                        HopZone Designer
                            <br />
                            <strong>Irhad Fejzić</strong>
                            </p>
                    </div>
                    <div style={styleOneMember} className="member-tarik">
                        <p className="about-page-text member-text">
                            <cite> "Don’t cry because it’s over, smile because it happened." </cite>
                            <br />
                            <img className="members-image" src={Tarik} alt="Tarik" />
                            HopZone Scrum Master 
                            <br />
                            <strong>Tarik Selimović</strong>
                            </p>
                    </div>
                    </div>
                </div>
                
                <div className="footer"> </div>
        </div>
    )
}

export default AboutPage;