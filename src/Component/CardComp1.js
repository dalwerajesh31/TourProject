

import Card from 'react-bootstrap/Card';


function CardComp1({  title}) {


  return (


    <Card style={{  width: '10000px', height: '400px' } }>
      <Card.Img variant="top" src="imgr.jpg" />
      <Card.Body>
        <Card.Title>{title}</Card.Title>
        {/* <h1> <Card.Text> {catmaster_id} </Card.Text></h1> */}

        

        {/* <Link to={mylink}>
          <button>Click on me</button>
        </Link> */}
      </Card.Body>
    </Card>
  );
}

export default CardComp1;

