import React from 'react';
import DeveloperAbout from '../misc/DeveloperAbout';
import { Container, Row, Col } from 'react-bootstrap';

/* Images */
import Red from "./../images/Red.png";
import Escape from "./../images/escape.png";
import Joseph_Fleming from "./../images/profile_pic/Joseph_Fleming.jpeg"
import Christine_Lin from "./../images/profile_pic/Christine_Lin.jpeg"
import Kelly_Chen from "./../images/profile_pic/Kelly_Chen.jpeg"
import Radoslav_Savenkov from "./../images/profile_pic/Radoslav_Savenkov.jpeg"
import Moojin_Ahn from "./../images/profile_pic/Moojin_Ahn.jpeg"


const About = () => {
  
  return (
    <Container>
      <div align="center" >
        <h1 style={{ paddingTop: '2.5rem', paddingBottom: '0.5rem', fontWeight: 'bold' }}> About the Developers </h1>
        <p style={{ maxWidth: '40rem', fontSize: "1.3rem"}}>
          This game and website were made for UF's Senior Project class in the Department of Computer Science. Here are the Developers!
        </p>
        <Row style={{marginLeft: "-150px"}}>
          <Col xs={12} sm={6} md={3} lg={1} style={{margin: "20px", paddingRight: "280px"}}>
            <DeveloperAbout name={"Christine Lin"} major={"Computer Science"} funFact={"Chicken Nugget"} pic={Christine_Lin} linkedinUrl={"https://www.linkedin.com/in/lin-christine/"}/>
          </Col>
          <Col xs={12} sm={6} md={3} lg={1} style={{margin: "20px",paddingRight: "280px"}} >
            <DeveloperAbout name={"Joseph Fleming"} major={"Computer Science"} funFact={"McChicken"} pic={Joseph_Fleming} linkedinUrl={"https://www.linkedin.com/in/josephpfleming/"}/>
          </Col>
          <Col xs={12} sm={6} md={3} lg={1} style={{margin: "20px",paddingRight: "280px"}}>
            <DeveloperAbout name={"Kelly Chen"} major={"Computer Science"} funFact={"Big Mac"} pic={Kelly_Chen} linkedinUrl={"https://www.linkedin.com/in/kelly--chen/"}/>
          </Col>
          <Col xs={12} sm={6} md={3} lg={1} style={{margin: "20px",paddingRight: "280px"}}>
            <DeveloperAbout name={"Moojin Ahn"} major={"Computer Science"} funFact={"Potato"} pic={Moojin_Ahn} linkedinUrl={"https://www.linkedin.com/in/moojin-ahn/"}/>
          </Col>
          <Col xs={12} sm={6} md={3} lg={1} style={{marginTop: "20px"}}>
            <DeveloperAbout name={"Radoslav Savenkov"} major={"Computer Science"} funFact={"Sandwich"} pic={Radoslav_Savenkov} linkedinUrl={"https://www.linkedin.com/in/radoslav-savenkov/"}/>
          </Col>
        </Row>

        <hr className="text-dark bg-dark" style={{width:'40%', marginTop: '4rem' }}/>

        <h1 style={{ paddingTop: '3rem', paddingBottom: '0.5rem', fontWeight: 'bold' }}> About the Game</h1>

        <Row className="align-items-center" style={{paddingBottom: '10rem'}}>
          <Col xs={12} md={6}>
            <img src={Escape} alt="Game Screenshot" className="img-fluid" style={{ maxWidth: '100%' }}/>
          </Col>
          <Col xs={12} md={6}>
            <p style={{ fontSize: "1.5rem", textAlign: 'left'}}>
              This game is powered by Unity and linked with React to this website. 
              Aspects of the website may be more than what they seem.
              Can you make it to the end in the fastest time possible?
            </p>
          </Col>
        </Row>
      </div>
    </Container>
  );
}

export default About;
