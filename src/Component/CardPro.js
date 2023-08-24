import React, { useState, useEffect } from 'react';
import { Button, } from 'react-bootstrap';
import CardComp from './CardComp';
import { NavLink } from 'react-router-dom';

export function CardPro() {
  const [post, setPost] = useState([]);

  useEffect(() => {
    fetch("http://localhost:8080/api/category_master")
      .then(res => res.json())
      .then(result => setPost(result));
  }, []);

  return (
    <div>
      <div className="d2">
        {post.map(card => (
          <div key={card.catId}> {/* Add a unique key for each iteration */}
            <CardComp title={card.catId} />
            <NavLink to={"/bycatId/"+card.catId}>
              <Button>View Details</Button>
            </NavLink>
          </div>
        ))}
      </div>
    </div>
  );
}

export default CardPro;
