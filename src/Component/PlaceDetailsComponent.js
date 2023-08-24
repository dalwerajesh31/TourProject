import React, { useState, useEffect } from 'react';
//import './PlaceDetailsComponent.css'; // Import your CSS

const PlaceDetailsComponent = () => {
  const [placeData, setPlaceData] = useState({
    singlePersonCost: '',
    extraPersonCost: '',
    childWithBed: '',
    offerValidFrom: '',
    offerValidTo: '',
    summary: '',
    imageFilename: 'NamoNamah.jpg', // Add a field for the image filename
  });

  const fetchPlaceData = () => {
    // Fetch data from the database and update the state
    fetch('https://your-api-domain.com/api/place-details')
      .then(response => response.json())
      .then(data => setPlaceData(data))
      .catch(error => console.error('Error fetching data:', error));
  };

  useEffect(() => {
    fetchPlaceData(); // Fetch data when the component mounts
  }, []);

  return (
    <div className="place-details-container">
      {/* Left Side */}
      <div className="left-side">
        <div className="image-section">
          {/* Use the dynamically fetched image filename */}
          <img src={`/images/${placeData.imageFilename}`} alt="Place" />
        </div>
        <div className="table-section">
          <h3>Cost Details</h3>
          <div className="cost-box">
            <p>SINGLE PERSON COST</p>
            <input
              type="text"
              value={placeData.singlePersonCost}
              onChange={event =>
                setPlaceData({ ...placeData, singlePersonCost: event.target.value })
              }
            />
          </div>
          <div className="cost-box">
            <p>EXTRA PERSON COST</p>
            <input
              type="text"
              value={placeData.extraPersonCost}
              onChange={event =>
                setPlaceData({ ...placeData, extraPersonCost: event.target.value })
              }
            />
          </div>
          <div className="cost-box">
            <p>CHILD WITH BED</p>
            <input
              type="text"
              value={placeData.childWithBed}
              onChange={event =>
                setPlaceData({ ...placeData, childWithBed: event.target.value })
              }
            />
          </div>
          <div className="cost-box">
            <p>OFFER VALID FROM</p>
            <input
              type="text"
              value={placeData.offerValidFrom}
              onChange={event =>
                setPlaceData({ ...placeData, offerValidFrom: event.target.value })
              }
            />
          </div>
          <div className="cost-box">
            <p>OFFER VALID TO</p>
            <input
              type="text"
              value={placeData.offerValidTo}
              onChange={event =>
                setPlaceData({ ...placeData, offerValidTo: event.target.value })
              }
            />
          </div>
        </div>
      </div>
      {/* Right Side */}
      <div className="right-side">
        <h3>Introduction</h3>
        <p>{placeData.summary}</p>
      </div>
    </div>
  );
};

export default PlaceDetailsComponent;
