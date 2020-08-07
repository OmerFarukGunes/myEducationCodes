import React, { Component } from 'react'

 class Form extends Component {
   
    constructor(props)
    {
          super(props);
        //   this.addButton.bind(this) asil onerilen bind etme yontemi budur. ancak asagida => sayesinde bind islemi de yapilimis olur
    }
    addButton=() => 

    {
        this.props.addNew();
        console.log("hi");
    }
// bu sekilde butonu ayri bir js dosyasinda tanimlayabilir ve her bir eventta yani olayda ornegin tikladigi zaman neler yapabilecegini ayarlayabilirsin
    render() {
        return (
            <div>
                {/* suslu parantezden sonra this addbuttondan once ()=> ekleyerek ve yukarida ki fonksiyonda bulunan bind islemini silerek burada bind islemini 
                de gerceklestirebiliriz. yani kisaca bind etme isleminin birbirinden farkli yollari vardir. */}
                <button onClick={this.addButton}>Add</button>
                {/* bir diger bind etme islemi yolu ise addbuttondan sonra.bind(this) yazmaktir */}
            </div>
        )
    }
}
export default Form;