import React from 'react'

function About() {
  return (
    <div>
      <h1 style={{ textAlign: 'center', fontWeight: 'bold' }}>About</h1>

      <h2 style={{ textAlign: 'center', fontWeight: 'bold' }}>{localStorage.getItem("uid")}</h2>
    </div>
  )
}

export default About