import React, {useState} from 'react'
import {Card, Container} from 'react-bootstrap';
import { FaLinkedin } from 'react-icons/fa';

const DeveloperAbout = ({name, major, pic, linkedinUrl}) => {
    const [isHovered, setIsHovered] = useState(false);

    const cardStyle = {
        width: '190px',
        height: '280px',
        marginTop: '20px',
        // border: '0.2rem solid black',
    }


  return (
    <Container>
    <div>
        <a href={linkedinUrl} target="_blank" rel="noopener noreferrer" style={{ textDecoration: 'none' }}></a>
        <Card style={cardStyle} 
        onMouseEnter={() => setIsHovered(true)}
        onMouseLeave={() => setIsHovered(false)}>
            <Card.Img variant="top" src={pic}/>
            {isHovered && (
                <div
                    style={{
                        position: 'absolute',
                        top: '0',
                        right: '0',
                        padding: '5px',
                        color: 'black',
                        backgroundColor: 'rgba(255, 255, 255, 0.8)',
                        borderRadius: '0 0 0 5px',
                    }}
                >
                    <FaLinkedin size={30} />
                </div>
            )}
            <Card.Body>
            <Card.Title>{name}</Card.Title>
            <Card.Text>
                {major}
            </Card.Text>
            </Card.Body>
        </Card>
    </div>
    </Container>
  )
}

export default DeveloperAbout