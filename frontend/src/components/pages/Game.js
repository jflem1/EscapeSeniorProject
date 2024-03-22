import React, {useState, useCallback,  useEffect} from 'react'
import { Unity, useUnityContext } from "react-unity-webgl";
import axios from "axios";
import Footer from '../Footer';
import { Dropdown, Container, Form, Row, Col, Tab, Tabs } from 'react-bootstrap'
import TextBox from '../misc/textBox';
import Calculator from '../misc/Calculator';
import './Game.css'

const Game = () => {

  const gameStyle = {
    paddingTop: "2rem",
    paddingBottom: '5rem',
  };
  
  const [username, setUsername] = useState();
  const [escapeTime, setEscapeTime] = useState();

  const { addEventListener, removeEventListener, unityProvider } = useUnityContext({
    loaderUrl: "/Build/escapeRoomUnity.loader.js",
    dataUrl: "/Build/escapeRoomUnity.data.unityweb",
    frameworkUrl: "/Build/escapeRoomUnity.framework.js.unityweb",
    codeUrl: "/Build/escapeRoomUnity.wasm.unityweb",
  });

  const handleCreateUser = useCallback((username) => {
    setUsername(username)
    axios.post(process.env.REACT_APP_CREATE_USER_API_URL, {username: username})
    .then((response) => {
      console.log(response)
    })
    .catch((e) => {
      console.log(e)
    })
    console.log(username)
  }, []);

  const updateUserEscapeTime = useCallback((username, userEscapeTime) => {
    setUsername(username)
    setEscapeTime(userEscapeTime)
    console.log(username)
    console.log(userEscapeTime)
  }, []);

  useEffect(() => {
    addEventListener("StartGame", handleCreateUser);
    return () => {
      removeEventListener("StartGame", handleCreateUser);
    };
  }, [addEventListener, removeEventListener, handleCreateUser]);

  useEffect(() => {
    addEventListener("EndGame", updateUserEscapeTime);
    return () => {
      removeEventListener("EndGame", updateUserEscapeTime);
    };
  }, [addEventListener, removeEventListener, updateUserEscapeTime]);
  

  const [Difficulty, setDifficulty] = useState(null);

  const [key, setKey] = useState('Notepad');

  const handleSelect = (eventKey) => {
    setDifficulty(eventKey);
  };
  
  return (
    <>
    <div align="center">

        <h1 style={{ paddingTop: '2.5rem', fontFamily: "'Anton', sans-serif", color:'#000000'}}>Difficulty:</h1>

        <Dropdown onSelect={handleSelect} data-bs-theme="dark">
          <Dropdown.Toggle variant="secondary">
          {Difficulty || 'Select Difficulty'}
          </Dropdown.Toggle>

          <Dropdown.Menu>
            <Dropdown.Item eventKey="Easy">Easy</Dropdown.Item>
            <Dropdown.Item eventKey="Medium">Medium</Dropdown.Item>
            <Dropdown.Item eventKey="Hard">Hard</Dropdown.Item>
          </Dropdown.Menu>
        </Dropdown>
    
      <Container>
        <Row className="justify-content-center">

          <Col xs={12} sm={12} md={10} lg={9}>
            <div style={gameStyle}>
            <Unity unityProvider={unityProvider} style={{ width: '100%', height: '100%' }} />
            </div>
          </Col>

          <Col xs={8} sm={8} md={8} lg={3} style={{paddingTop:'2rem', paddingBottom:'5rem'}}>
            <Tabs
              id="controlled-tab-example"
              activeKey={key}
              onSelect={(k) => setKey(k)}
              className="mb-3 custom-tabs"
            >
              <Tab eventKey="Notepad" title="Notepad">
                <TextBox/>
              </Tab>
              <Tab eventKey="Calculator" title="Calculator">
                <Calculator/>
              </Tab>
            </Tabs>
          </Col>

        </Row>
      </Container>

    </div>

    <Footer/>
    </>
  )
}

export default Game