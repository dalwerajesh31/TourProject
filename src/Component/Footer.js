import React from 'react';
export const Footer =()=>{
    const cyear= new Date().getFullYear();
    return (

       <footer  style={{
        position: 'fixed',
        alignItems :"center",
        scrollY:100,
        justifyContent: "center",
        backgroundColor:"lightblue",
        padding:"20px",
        display:'flex',
        width:"left",
        left:"0",
       


       }}>

        <p style={{
            margin:"0",
            marginRight:"100px",
            color:"lightcoral"

        }}>  &#169: {cyear} Created by Group777</p>

        <div style={{marginLeft:"20px"}} >
            <a href='mywebsite' target='_blank' rel='noopener noreferrer'>jjjjjjjjjjj</a>
            <a href='yourwebsite' target='_blank' rel='noopener noreferrer'>mmmmmmmmmmmmmm</a>

        </div>
        </footer>

    )
}