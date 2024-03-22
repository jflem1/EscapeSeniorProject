import React from 'react';
import DeveloperAbout from '../misc/DeveloperAbout';
import Red from "./../images/Red.png";
import Escape from "./../images/escape.png";
import { Container, Row, Col } from 'react-bootstrap';
import Footer from '../Footer';

// Developers
import Joseph_Fleming from "./../images/profile_pic/Joseph_Fleming.jpeg"
import Christine_Lin from "./../images/profile_pic/Christine_Lin.jpeg"
import Kelly_Chen from "./../images/profile_pic/Kelly_Chen.jpeg"
import Radoslav_Savenkov from "./../images/profile_pic/Radoslav_Savenkov.jpeg"
import Moojin_Ahn from "./../images/profile_pic/Moojin_Ahn.jpeg"

const About = () => {
  
  return (
    <>
    <Container>
      <div align="center">
        <h1 style={{ paddingTop: '2.5rem', paddingBottom: '0.5rem', color: '#000000'}}> About the Developers </h1>
        <p style={{ maxWidth: '40rem', fontSize: "1.3rem", color: '#000000'}}>
          This game and website were made for UF's Senior Project class in the Department of Computer Science. Here are the Developers!
        </p>
        <Row className="justify-content-center">
        <Col xs={12} sm={6} md={4} lg={2}>
            <DeveloperAbout name={"Christine Lin"} major={"Computer Science"} funFact={"Chicken Nugget"} pic={Christine_Lin} linkedinUrl={"https://www.linkedin.com/in/lin-christine/"}/>
          </Col>
          <Col xs={12} sm={6} md={4} lg={2}>
              <DeveloperAbout name={"Joseph Fleming"} major={"Computer Science"} funFact={"McChicken"} pic={Joseph_Fleming} linkedinUrl={"https://www.linkedin.com/in/josephpfleming/"}/>
          </Col>
          <Col xs={12} sm={6} md={4} lg={2}>
              <DeveloperAbout name={"Kelly Chen"} major={"Computer Science"} funFact={"Big Mac"} pic={Kelly_Chen} linkedinUrl={"https://www.linkedin.com/in/kelly--chen/"}/>
          </Col>
          <Col xs={12} sm={6} md={4} lg={2}>
              <DeveloperAbout name={"Moojin Ahn"} major={"Computer Science"} funFact={"Potato"} pic={Moojin_Ahn} linkedinUrl={"https://www.linkedin.com/in/moojin-ahn/"}/>
          </Col>
          <Col xs={12} sm={6} md={4} lg={2}>
              <DeveloperAbout name={"Radoslav Savenkov"} major={"Computer Science"} funFact={"Sandwich"} pic={Radoslav_Savenkov} linkedinUrl={"https://www.linkedin.com/in/radoslav-savenkov/"}/>
          </Col>
        </Row>

        <hr style={{ width: '70%', height: '10%',marginTop: '4rem', color: '#000000'}}></hr>

        <h1 style={{ paddingTop: '2rem', paddingBottom: '0.5rem', color: '#000000'}}> About the Game</h1>

        <Row className="justify-content-center">
          <Col xs={12} md={6} style={{ margin: '20px' }}>
            <img src={Escape} style={{ width: '100%' }}/>
          </Col>
          <Col xs={12} md={8} style={{ margin: '20px' }}>
            <p style={{ fontSize: "30px", textAlign: 'center', color: '#000000'}}>
              This game is powered by Unity and linked with React to this website. 
              Aspects of the website may be more than what they seem.
            </p>
            <p style={{ fontSize: "30px", textAlign: 'center', color:'#F8A528'}}>
              Can YOU make it to the end in the fastest time possible?
            </p>
            <p> {""} </p>
          </Col>
        </Row>
      </div>
    </Container>

    <Footer/>
    </>
  );
};

export default About;
