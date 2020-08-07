import React, { Component } from 'react';
import FG from "./FG"
import './App.css';
import './deneme.css'
import './Omer.js'
import Arakatman from "./Arakatman.js"
import Omer from './Omer.js';
import Counter from "./Counter"
import Footer from "./Footer"
const series=[{
  id:1,
  title:"hiper",
  description:"react"
},
{
 id:2,
 title:"super",
 description:"reactjs"
},
{
 id:3,
 title:"hipersuper",
 description:"java"
}
]
class App extends Component {
  state={
    name:"Omer"
  } 
  // yeni kullanim ustteki gibidir.
  // constructor(props){
  //   super(props);
  //   this.state={
  //     name:"omer"
  //   }
  // }
  addNew(){
    console.log("added")
    series.push({
      id:4,
      title:"Perfect",
      description:"Me"
    });
    // bu fonksiyon cagirildigi zaman diziye eleman eklenir.
    console.log(series)
  }
  changeName(){
    this.setState({
      name:"Omer FG"
    })
    // set state ile reacte geri bildirim yani bir render yaparak hem web uzerinde hem de back-end de degismesini saglayabilirsin.
  }
  render(){
    const num=47;
    const isTure=false;
    const title="react education";
    const description="We can do it";
  
    return (
      <div className="App">
        <Counter/>
        <Footer/>
        <h3>{this.state.name}</h3>
        {/* constructor icerisinde bulunan veya disarisinda sadece state olarak tanmimlanan degeri webe bu sekilde yazavilirsin. */}
      <h2>Hello  World</h2>
     <h1 style={{color:"blue",textAlign:"left"}}>Omer</h1>
     <label htmlFor=""></label>
     <h4>{2+5}</h4>
     {/* suslu parantez icerisinde islemler sonucu cikti olarak verir */}
     {"Omer".toUpperCase()}
     <h5>{num}</h5>
     {
       isTure? <p>YES</p>:<p>FALSE</p>
      //normal is kullanimini burada bu sekilde kullanabilirsin. bunlar yukarida ki hersey jsx formatinda yazilmistir
     }
     <button onClick={this.changeName.bind(this)}>Change</button>
     <FG title={title} solution={description} />
     <FG title={series[1].title} solution={series[1].description} addNew={this.addNew}/>
     {/* fg js sine biz props gonderdik. */}
     <Arakatman mySeries={series} name={4}/>
     <Omer/>
    
      </div>
      // bu sekilde js dosyasi icerisinde html kullanabilirsin. ama sakin unutma sadece tek bir parent kullanabilirsin.
      );
    }
}
export default App;
