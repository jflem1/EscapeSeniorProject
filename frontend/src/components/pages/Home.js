import React from 'react'
import { Card, Button, Container, Col, Row } from 'react-bootstrap'
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom'
import CarouselPic from '../misc/Carousel'
import Leaderboard from '../misc/Leaderboard'


const Home = () => {

  const compButtonStyle = {
    backgroundColor: '#FF6800',
    border: 'none',
    marginTop: '30px',
  };

  return (
  <>
    <Container>
    <div style={{ textAlign: 'center', padding: '20px' }}>
      <h1>CAN YOU MAKE IT OUT WITHOUT GETTING CHOMPED?</h1>
    </div>
    </Container>

    <Container className="d-flex align-items-center justify-content-center" style={{ height: '60vh' }}>
      <Row>
        <Col md={6}>
          <Card style={{ width: '25rem', backgroundColor: '#FCC490', border: 'none'}}>
            <CarouselPic/>
            <Button as={Link} to="/game" style={compButtonStyle}>Play!</Button>
          </Card>
        </Col>

        <Col md={6}>
          <Leaderboard/>
        </Col>
      </Row>
    </Container>
  </>

  )
}

export default Home