import React, { Component } from 'react'
import PropTypes from 'prop-types';
class Omer extends Component {
    static propTypes={
        newsData:PropTypes.shape({
            title:PropTypes.string,
            description:PropTypes.string
        })
        // tum olarak alinan dizinin elemanlarinin veri tiplerini belirleyebiliriz.
    }
    render() {

        const{title,description}=this.props;
        return (
            <div>
                <h3>Lorem ipsum dolor sit
                     amet consectetur adipisicing elit. Ea repudiandae beatae sunt 
                     eaque quam odit quae illo. Error voluptatem, enim magnam odio molestias labore 
                     tempore placeat distinctio sed, possimus impedit?</h3>
                     <h1>{title}</h1>
                     <h1>{description}</h1>
            </div>
            
        )
    }
}
export default  Omer;
