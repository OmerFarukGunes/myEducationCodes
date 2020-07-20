import React, { Component } from 'react'

class Counter extends Component {

    state={
        number:0
    }
    increment =()=>{
        this.setState({
            number:++this.state.number
        })
    }
    decrement =()=>{
        this.setState({
            number:--this.state.number
        })
    }
    // basit bir uygulama ornegidir.
    render() {
        return (
            <div>
                <h1>{this.state.number}</h1>
                <button onClick={this.increment}>Increase</button>
                <button onClick={this.decrement}>Decrease </button>
            </div>
        )
    }
}
export default Counter;
