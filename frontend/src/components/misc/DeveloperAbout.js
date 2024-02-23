import React, {useState} from 'react'
import Card from 'react-bootstrap/Card';
import { FaLinkedin } from 'react-icons/fa';

const DeveloperAbout = ({name,major, funFact, pic, linkedinUrl}) => {
    const [isHovered, setIsHovered] = useState(false);

    const cardStyle = {
        width: '16rem',
        margin: '1rem',
        radius: '0.50px',
        border: '0.1rem solid black',
        // padding: '5rem'
    }


  return (
    <div>
        <a href={linkedinUrl} target="_blank" rel="noopener noreferrer" style={{ textDecoration: 'none' }}>
        <Card 
            style={cardStyle}
            onMouseEnter={() => setIsHovered(true)}
            onMouseLeave={() => setIsHovered(false)}
        >
            <Card.Img style={{radius: '0.50px'}} variant="top" src={pic}/> 
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
            {/* <Card.Text>
                {funFact}
            </Card.Text> */}
            </Card.Body>
        </Card>
        </a>
    </div>
  )
}

export default DeveloperAbout