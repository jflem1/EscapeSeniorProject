import React from 'react'
import Home from './pages/Home'
import Game from './pages/Game'
import About from './pages/About'
import { BrowserRouter as Router, Routes, Route, Link, useNavigate } from 'react-router-dom'

const Routing = () => {
  return (
    <div>
      <Routes>
        <Route path="/" element={<Home/>}></Route>
        <Route path="/game" element={<Game/>}></Route>
        <Route path="/about" element={<About/>}></Route>
      </Routes>
    </div>
  )
}

export default Routing