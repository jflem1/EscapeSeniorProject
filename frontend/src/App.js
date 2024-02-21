import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import Header from './components/Header';
import Footer from './components/Footer';
import Routing from './components/Routes';

function App() {
  return (
    <div className='app'>
      <Router>
        <Header/>
        <Footer/>
        <Routing/>
      </Router>
    </div>
  );
}

export default App;
