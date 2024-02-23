import React from 'react'
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom'
import { Navbar, Nav, Button } from 'react-bootstrap';

const Footer = () => {

    const footerText = {
        marginLeft: '15px',
        color: '#FFFFFF',
    };

    const footerBackColor = {
        backgroundColor: '#002657',
      };    


return (
    <>
        <div>
            <Navbar expand="lg" fixed="bottom" style={footerBackColor}>
                <Navbar.Brand style={footerText}> 2024 </Navbar.Brand>
                <Navbar.Collapse id="basic-navbar-nav" className="justify-content-end">
                <Nav>
                    <Nav.Link as={Link} to="/home" style={footerText}>Home</Nav.Link>
                    <Nav.Link as={Link} to="/game" style={footerText}>Game</Nav.Link>
                    <Nav.Link as={Link} to="/about" style={footerText}>About</Nav.Link>
                </Nav>
                </Navbar.Collapse>
            </Navbar>
        </div>
    </>
  )
}

export default Footer