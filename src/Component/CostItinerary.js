import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
function PackageMaster() {
  const [tourDetails, setTourDetails] = useState([]);
  const { pkgId } = useParams();
  let navigate = useNavigate();
  useEffect(() => {
    fetch("http://localhost:8080/api/itinerary_master/ById/" + pkgId)
      .then(res => res.json())
      .then(result => setTourDetails(result));
  }, [pkgId]);
  
  return (
    <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center',  minHeight: '100vh' }}>
      {tourDetails.map((category, index) => (
        <div key={index} style={{ width: '18rem', margin: '1rem' }}>
          <img
            src={"/"+category.imagePath}
            style={{ maxWidth: '100%' }}
          />
          <div>
            <h5>Day {category.dayNumber}</h5>
            <p>{category.itineraryDetail}</p>
            
          </div>
        </div>
      ))}
      <button onClick={() => navigate(`/bypkgId/${catMasterId}`)}>View Details</button>
    </div>
  );
}

export default PackageMaster;

