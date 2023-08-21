import React from 'react';
import "./App.css";
import banner from './img/banner.jpg';

const Banner = () => {
  return (
    <div className="banner">
      <img src={banner} alt="Banner" />
      <div className="banner-content">
        <h1>aGuideHub</h1>
        <p>Welcome To aGuideHub! </p>
      </div>
    </div>
  );
}

export default Banner;