import React, { Component } from 'react'
// rcc yaz ve taba bas bu yapi olusuyor
import Form from "./Form";
 

class FG extends Component {
    constructor()
    {
    super();
    console.log("her bir props taniminda constructor calisir.")
    }
    render() {
        console.log(this.props);
        // app.js ten biz 2 tane props aldik
        const{solution}=this.props;
        return (
            <div>
          <h1>{this.props.title}</h1>
          <h2>{solution}</h2>
          {/* baska bir dosyadan aldigimiz propslari bu sekilde kullanabilir, ulasabiliriz. */}
          <form action="">
              <input type="text"/>
              <button>Save</button>
          </form>
          <Form addNew={this.props.addNew}/>
            </div>
            // unutma sadece bir tane parent ifade kullanabilirsin.
        )
    }
}
export default FG;
