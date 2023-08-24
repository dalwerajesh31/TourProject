
import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import CardComp from './CardComp';
import { NavLink } from 'react-router-dom';
import { Button } from 'react-bootstrap'; // Make sure to import the Button component

export function SubSector() {
  const [post, setPost] = useState([]);
  const { catId } = useParams();

  useEffect(() => {
    fetch("http://localhost:8080/api/category_master/bycatId/" + catId)
      .then(res => res.json())
      .then(result => {
        setPost(result);
      });
  }, [catId]);

  return (
    <div>
      <div className="d2">
        {post?.map(card => (
          <div key={card.subCatId}>
            <CardComp title={card.subCatId} />
            <NavLink to={"/bysubcatId/" + card.subCatId}>
              <Button>View Details</Button>
            </NavLink>
          </div>
        ))}
      </div>
    </div>
  );
}

export default SubSector;






