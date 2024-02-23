import React from 'react'
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom'
import { Navbar, Nav, Button, Container } from 'react-bootstrap'

const Header = () => {

  const navBarBackColor = {
    backgroundColor: '#0052CC',
    height: '70px',
  };

  const compButtonStyle = {
    backgroundColor: '#FF6800',
    marginRight: '10px',
    border: 'none',
  };

  const navBarText = {
    color: '#ffffff',
    marginLeft: '10px',
  };

  return (
  <>
    <div>
      <Navbar expand="lg" style={navBarBackColor}>
        <Navbar.Brand as={Link} to="/" style={navBarText}>Escape the Senior Project</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav" className="justify-content-end">
            <Nav className="ml-auto">
                <Button as={Link} to="/" style={compButtonStyle}>Home</Button>
                <Button as={Link} to="/game" style={compButtonStyle}>Game</Button>
                <Button as={Link} to="/about" style={compButtonStyle}>About</Button>
            </Nav>
          </Navbar.Collapse>
      </Navbar>
    </div>
  </>
  )
}

export default Header