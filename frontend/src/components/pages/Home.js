import React, {useState, useCallback,  useEffect} from 'react'
import { Card, Button, Container, Col, Row, Image, Form } from 'react-bootstrap';
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom';
import CarouselPic from '../misc/Carousel';
import Leaderboard from '../misc/Leaderboard';
import placeholder from '../images/PlaceHolder.png';
import Footer from '../Footer';
import TextBox from '../misc/textBox';
import './Home.css';

const Home = () => {
  const compButtonStyle = {
    backgroundColor: '#5f8cc6',
    border: 'none',
    marginTop: '30px',
    fontFamily: "'Anton', sans-serif",
    width: '150px',
    fontSize: '24px',
  };

  return (
    <>
      <div className="top-section landing">
        <div className="center">
          <p1 className="landingStatement">CAN YOU MAKE IT OUT WITHOUT GETTING </p1>
        </div>
        <div>
          <p1 className="chomped">CHOMPED?</p1>
        </div>
        <Button as={Link} to="/game" style={compButtonStyle}>Play!</Button>
        {/* <button as={Link} to="/game" style={compButtonStyle}>
          <img src={gatorButton} alt="Button Image"/>
        </button> */}
      </div>

    <div className="bottom-section leaderboard d-flex align-items-center justify-content-center">
    <Container>
        <Row className='d-flex justify-content-center'>
            <Col xs={12} sm={10} md={10} lg={6} style={{paddingTop: '30px'}}>
                <Leaderboard/>
            </Col>
            <Col xs={12} sm={10} md={10} lg={6} style={{paddingTop: '15px'}}>
                <Card>
                    <Image src={placeholder} rounded />
                </Card>
            </Col>
        </Row>
    </Container>
    </div>

  {/* <Calculator/> */}
  <Footer />

    </>
  );
}

export default Home;
