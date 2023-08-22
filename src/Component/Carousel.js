import React, { useState, useEffect } from 'react';
 // Import your CSS for styling

const Carousel = ({ images, interval = 3000 }) => {
  const [currentIndex, setCurrentIndex] = useState(0);

  useEffect(() => {
    const timer = setInterval(() => {
      const nextIndex = (currentIndex + 1) % images.length;
      setCurrentIndex(nextIndex);
    }, interval);

    return () => {
      clearInterval(timer);
    };
  }, [currentIndex, images.length, interval]);

  return (
    <div className="carousel">
      {images.map((image, index) => (
        <img
          key={index}
          src={image}
          alt={`Slide ${index}`}
          className={`carousel-slide ${index === currentIndex ? 'active' : ''}`}
        />
      ))}
    </div>
  );
};

export default Carousel;