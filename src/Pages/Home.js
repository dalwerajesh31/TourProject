import React from 'react'

import CardComp from '../Component/CardComp';

const Home = () => {
    return (<>
        <div className='d1' >
            <CardComp  title="International" text="Internatinal tour happy tour" mylink="/international" />
            <CardComp  title="Domestic tour" text="Explore India" mylink="/domestic" />
            <CardComp  title="Honeymoon" text="Enjoy Honeymoonr" />

        </div>

        <div className='d1'>
            <CardComp  title="Varshasahal tour" text="Explore India" mylink="/international" />
            <CardComp  title="Adventure Tour" text="Ready For Adventure" />
            <CardComp  />

        </div>

        <div className='d1'>
            <CardComp  />
            <CardComp  />
            <CardComp />

        </div>

    </>
    )
}

export default Home;