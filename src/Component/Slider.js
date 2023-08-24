import React from 'react'
import {Carousel} from 'react-bootstrap'


const Slider = () => {
    return (
        <>
            <Carousel>
                <Carousel.Item interval={1000}>
                    <img
                        className="d-block w-100"
                        src="images/alps mountain gif 2.gif"
                        alt="First slide"
                        style={{
                            width: "100%", 
                            height: "300px",
                            objectFit: "cover" 
                        }}
                    />
                   
                </Carousel.Item>
                <Carousel.Item interval={500}>
                    <img
                        className="d-block w-100"
                        src="https://e1.pxfuel.com/desktop-wallpaper/677/144/desktop-wallpaper-mizoram-tourism-travel-guide.jpg"
                        alt="Second slide"
                        style={{
                            width: "100%",
                            height: "300px",
                            objectFit: "cover" 
                        }}
                    />
                    
                </Carousel.Item>
                <Carousel.Item  interval={1000}>
                    <img
                        className="d-block w-100"
                        src="https://e0.pxfuel.com/wallpapers/879/31/desktop-wallpaper-kerala-tourism.jpg"
                        alt="Third slide"
                        style={{
                            width: "100%", 
                            height: "300px",
                            objectFit: "cover" 
                        }}
                    />
                   
                </Carousel.Item>
                <Carousel.Item   > 
                    <img
                        className="d-block w-100"
                        src="https://e0.pxfuel.com/wallpapers/93/376/desktop-wallpaper-tourism-travel-tourism.jpg"
                        alt="Third slide"
                        style={{
                            width: "100%",
                            height: "300px",
                            overflow: "hidden"
                          }}
                    />
                   
                </Carousel.Item>
            </Carousel>
        </>
    )
}

export default Slider