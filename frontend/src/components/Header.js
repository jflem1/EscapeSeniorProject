import React from 'react'
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom'
import { Navbar, Nav, Button, Container } from 'react-bootstrap'
import logo from './images/lockLogo.png'

const Header = () => {

  const navBarBackColor = {
    background:'#90AACB',
  };

  const compButtonStyle = {
    color: '#ffffff',
    marginRight: '40px',
    border: 'none',
    fontSize: '21px',
    fontFamily: "'Anton', sans-serif",
  };

  const navBarText = {
    color: '#ffffff',
    marginLeft: '20px',
    fontFamily: "'Anton', sans-serif",
    fontSize: '21px',
  };  

  return (
  <>
    <div>
      <Navbar expand="lg" style={navBarBackColor} >
        <Navbar.Brand as={Link} to="/" style={navBarText}>
          <img
                alt=""
                src={logo}
                width="50"
                height="50"
            />{' '}
          Escape the Senior Project</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav" className="justify-content-end">
            <Nav className="ml-auto">
                <Nav.Link as={Link} to="/" style={compButtonStyle}>Home</Nav.Link>
                <Nav.Link as={Link} to="/game" style={compButtonStyle}>Game</Nav.Link>
                <Nav.Link as={Link} to="/about" style={compButtonStyle}>About</Nav.Link>
            </Nav>
          </Navbar.Collapse>
      </Navbar>
    </div>
  </>
  )
}

export default Header