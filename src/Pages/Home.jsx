import React from 'react'
import Banner from '../Component/Banner'
import App1 from '../Component/Crawling'
import Card1 from '../Component/cards'
import { Footer } from '../Component/Footer'
import Navbar from '../Component/Navbar'
import Crawling from '../Component/Crawling'


const Home = () => {
    return (<>
        <Navbar />
        <Banner/>

        <div> <Crawling/></div>

            <div className='d1' >
                <Card1 title="International" text="Internatinal tour happy tour" mylink="/international"/>
                <Card1  title="IDomestic tour" text="Explore India"  mylink="b" />
                <Card1  title="Honeymoon" text="Enjoy Honeymoonr"/>
               
            </div>

            <div className='d1'>
                <Card1 />
                <Card1 />
                <Card1 />
             
            </div>

            <div className='d1'>
                <Card1 />
                <Card1 />
                <Card1 />
              
            </div>

            <Footer/>
        </>
    )
}

export default Home