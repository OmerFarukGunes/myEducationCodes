import React, { Component } from 'react'
import PropTypes from 'prop-types';
import Omer from './Omer.js'
class Arakatman extends Component {
    static propTypes={
    // ozellik tiplerini bu sekilde ifade edebilirsin
        mySeries:PropTypes.array.isRequired,
    // isrequired dendigi zaman ise bu turde bir propun gelmesi gereklidir dersin. 
    // isRequired yazmayabilir ve zorunluluktan cikartabilirsin.
        name:PropTypes.oneOfType([
            PropTypes.number,
            PropTypes.string
        ] ).isRequired
        // bir degerin birden fazla turden olabilmesine izin verebilir hatta isrequired ekleyerek zorunlu kilabilirsin
    }
    static defaultProps={
        name:"Canan"
    }
    // eger olurda name icin bir deger gelmezse default deger atanir
    render() {
        const  elements= this.props.mySeries.map(mySeries => 
            <Omer key={mySeries.id} newsData={mySeries}/>
            )
            // newsdata olarak tum diziyi attik.
            // keyi tanimlamak dizi icerisinde ki id leri olusturman gerekmektedir.
            // elements= den sonraki ifadeyi direka sagidaki suslu parantez icine de atabilirsin.
        return (
            <div>
                {
                   elements
                        // map  bir nevi foreach gorevi gorur ve dizinin tamammina ulasir
                        // yapilan ara katman sayesinde omere propslar gonderiyoruz
                  
                }
                {
                          this.props.name
                }
            </div>
        )
    }
}
export default Arakatman;