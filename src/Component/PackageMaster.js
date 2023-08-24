import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';

import CardComp from './CardComp';

function PackageMaster() {
  const [post, setPost] = useState([]);
  const { catMasterId } = useParams();

  useEffect(() => {
    fetch("http://localhost:8080/api/package_master/catmaster/" + catMasterId)
      .then(res => res.json())
      .then(result => setPost(result));
  }, [catMasterId]);

  return (
    <div>
      <div className="d2">
        {post.map(card => (
          <div key={card.pkgId}>
            <CardComp title={card.pkgName} />
            {/* <NavLink to={"/bypkgId/"+card.catMasterId}>
              <Button>View Details</Button>
            </NavLink> */}
          </div>
        ))}
      </div>
    </div>
  );
}

export default PackageMaster;