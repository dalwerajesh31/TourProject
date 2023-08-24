import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import CardComp from './CardComp';
import { NavLink } from 'react-router-dom';
import { Button } from 'react-bootstrap';

export function SubCatName() {
  const [tour, setTour] = useState([]);
  const { subCatId } = useParams();

  useEffect(() => {
    fetch("http://localhost:8080/api/category_master/bysubcatId/"+subCatId)
      .then(res => res.json())
      .then(result => {
        setTour(result);
      });
  }, [subCatId]);

  return (
    <div>
      <div className="d2">
        {tour.length > 0 ? (
          tour.map(card => (
            <div key={card.subCatId}>
              <CardComp title={card.catName} />
              <NavLink to={"/bysubcatId/" + card.catName}>
                <Button>View Details</Button>
              </NavLink>
            </div>
          ))
        ) : (
          <p>Loading...</p>
        )}
      </div>
    </div>
  );
}

export default SubCatName;
