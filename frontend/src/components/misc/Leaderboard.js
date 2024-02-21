import React, {useEffect, useState} from 'react'
import { Card, Button, Container, Col, Row } from 'react-bootstrap'
import axios from "axios";

const Leaderboard = () => {
    const [users, setUsers] = useState([]);
    const [topFive, setTopFive] = useState([]);
    const [error, setErrors] = useState();

    useEffect(() => {
        axios.get(process.env.REACT_APP_GET_ALL_USER_API_URL)
        .then((response) => {
            console.log(response.data.allUsers)
            setUsers(response.data.allUsers)
            setTopFive(getTopFiveFastestTimes(response.data.allUsers))
        })
        .catch((error) => {
            console.log(error)
            console.log("Error with fetching users")
        })
    })

    const getTopFiveFastestTimes = (userData) => {
        const data = userData
        data.forEach(obj => {
            const timeComponents = obj.escapeTime.split(':').map(Number);
            obj.escapeSeconds = timeComponents[0] * 3600 + timeComponents[1] * 60 + timeComponents[2];
        });
    
        // Sort the objects based on escapeSeconds
        data.sort((a, b) => a.escapeSeconds - b.escapeSeconds);
    
        // Select the top five objects
        const topFive = data.slice(0, 5);
    
        return topFive;
    }

  return (
    <>
    <Card className="text-center" style={{ width: '35rem', backgroundColor: '#FCC490', border: 'none'}}>
        <Card.Body>
            <Card.Title className="font-weight-bold" style={{padding: '20px'}}>
                Leaderboard
            </Card.Title>
            {
                topFive.map((item, index) => {

                    return (
                        <Card.Text className="font-weight-bold">
                            {index+1}. {item.username} {item.escapeTime}
                        </Card.Text>
                    )
                })
            }

        </Card.Body>
    </Card>
    </>
  )
}

export default Leaderboard


// <Card.Text className="font-weight-bold">
// 1. Bobby   00:00:00
// </Card.Text>
// <Card.Text className="font-weight-bold">
// 2. Bobby   00:00:00
// </Card.Text>
// <Card.Text className="font-weight-bold">
// 3. Bobby   00:00:00
// </Card.Text>
// <Card.Text className="font-weight-bold">
// 4. Bobby   00:00:00
// </Card.Text>
// <Card.Text className="font-weight-bold">
// 5. Bobby   00:00:00
// </Card.Text>