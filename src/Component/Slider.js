import React from 'react'
import {Carousel} from 'react-bootstrap'



const Slider = () => {
    return (
        
            <Carousel>
                <Carousel.Item interval={2000}>
                    <img
                        className="d-block w-100"
                        src={"images/First_slider.jpg"}
                        alt="First slide"
                        style={{
                            width: "100%", 
                            height: "400px",
                            objectFit: "scale-down" 
                        }}
                    />
                   
                </Carousel.Item>
                 <Carousel.Item interval={500}>
                    <img
                        className="d-block w-100"
                        src={"Images/International_slider.png"}
                        alt="Second slide"
                        style={{
                            width: "100%",
                            height: "400px",
                            objectFit: "scale-down" 
                        }}
                    />
                    
                </Carousel.Item>
                <Carousel.Item  interval={1000}>
                    <img
                        className="d-block w-100"
                        src={"Images/Domestic_slider.jpg"}
                        alt="Third slide"
                        style={{
                            width: "100%", 
                            height: "400px",
                            objectFit: "none" 
                        }}
                    />
                   
                </Carousel.Item>
              
            </Carousel>
       
    )
}

export default Slider