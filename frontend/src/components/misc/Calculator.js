import React from 'react'
import "./Calculator.css";
import { useState, useEffect} from 'react'
import { Container, Button } from 'react-bootstrap'

const Calculator = () => {
    const [preState, setPreState] = useState("")
    const [currState, setCurrState] = useState("")
    const [input, setInput] = useState("0")
    const [operator, setOperator] = useState(null)
    const [total, setTotal] = useState(null)

    const inputNum = (e) => {
        if (currState.includes(".") && e.target.innerText === ".") return;

        if(total) {
            setPreState("");
        }

        currState
            ? setCurrState((pre) => pre + e.target.innerText)
            : setCurrState(e.target.innerText);
            setTotal(false);

    };

    useEffect(() => {
        setInput(currState);
    }, [currState]);

    useEffect(() => {
        setInput("0");
    }, []);

    const operatorType = (e) => {
        setTotal(false)
        setOperator(e.target.innerText)
        if(currState === "") return
        if(preState!== ""){
            equals()
        }setPreState(currState)
        setCurrState("")
    };

    const equals = (e) => {
        if(e?.target.innerText === "="){
            setTotal(true)
    };

    let cal
    switch (operator) {
        case "/":
            cal = String(parseFloat(preState) / parseFloat(currState));
            if(isNaN(cal)){
                cal = preState
            }
            break;
        case "+":
            cal = String(parseFloat(preState) + parseFloat(currState));
            if(isNaN(cal)){
                cal = preState
            }
            break;
        case "X":
            cal = String(parseFloat(preState) * parseFloat(currState));
            if(isNaN(cal)){
                cal = preState
            }
            break;
        case "-":
            cal = String(parseFloat(preState) - parseFloat(currState));
            if(isNaN(cal)){
                cal = preState
            }
            break;
        default:
            return
        }
        setInput("")
        setPreState(cal)
        setCurrState("")
    }

    const minusPlus= () => {
        if(currState.charAt(0) === "-"){
            setCurrState(currState.substring(1));
        }
        else{
            setCurrState("-" + currState);
        }
    };

    const percent = () => {
        preState
            ? setCurrState(String((parseFloat(currState)/100) * preState))
            : setCurrState(String(parseFloat(currState) / 100));
    };

    const reset = () => {
        setPreState("");
        setCurrState("");
        setInput("0");
    };

    const formattedInput = input !== "" || input === "0" ? Number(input).toLocaleString() : '';
    const formattedPreState = input === "" || input === "0" ? Number(preState).toLocaleString() : '';

  return (
    <>
    <Container style={{backgroundColor: '#90AACB', borderRadius: '1rem', padding: '1rem', height:'58vh'}}>
        <div className='wrapper'>
            <div className='screen'>{formattedInput || formattedPreState}</div>

            <Button onClick={reset} style={{backgroundColor:'#5f8cc6', border:'none'}}>AC</Button>
            <Button onClick={percent} style={{backgroundColor:'#5f8cc6', border:'none'}}>%</Button>    
            <Button onClick={minusPlus} style={{backgroundColor:'#5f8cc6', border:'none'}}>+/-</Button> 

            <Button onClick={operatorType} style={{backgroundColor:"rgb(48, 86, 132)", border:'none'}}>/</Button>  
    
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>7</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>8</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>9</Button>

            <Button onClick={operatorType} style={{backgroundColor:"rgb(48, 86, 132)", border:'none'}}>X</Button> 

            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>4</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>5</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>6</Button>

            <Button onClick={operatorType} style={{backgroundColor:"rgb(48, 86, 132)", border:'none', fontSize:'1.5rem'}}>+</Button> 

            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>1</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>2</Button>
            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>3</Button>

            <Button onClick={operatorType} style={{backgroundColor:"rgb(48, 86, 132)", border:'none', fontSize:'1.5rem'}}>-</Button> 

            <Button onClick={inputNum} style={{alignItems: "left", gridColumn: "1 / span 2", border:'none', backgroundColor:'#a9a8a8'}}>0</Button>

            <Button onClick={inputNum} style={{backgroundColor:'#a9a8a8', border:'none'}}>.</Button>
            
            <Button onClick={equals} style={{backgroundColor:"rgb(48, 86, 132)", border:'none', fontSize:'1.5rem'}}>=</Button> 
        </div>
    </Container>
    </>
  )
}

export default Calculator