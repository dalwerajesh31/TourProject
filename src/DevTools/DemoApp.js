// App.js
import React, { useState, useEffect } from 'react';
import Card from './Card';

const DemoApp = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    // Fetch data from an API
    fetch('https://api.example.com/data')
      .then(response => response.json())
      .then(data => setData(data));
  }, []);

  return (
    <div className="app">
      {data.map(item => (
        <Card
          key={item.id}
          title={item.title}
          description={item.description}
          imageUrl={item.imageUrl}
        />
      ))}
    </div>
  );
};

export default DemoApp;
