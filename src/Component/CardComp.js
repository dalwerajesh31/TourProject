
import { Link } from 'react-router-dom';
import Card from 'react-bootstrap/Card';


function CardComp({ title, text, mylink }) {


  return (


    <Card style={{ width: '18rem' }}>
      <Card.Img variant="top" src="imgr.jpg" />
      <Card.Body>
        <Card.Title>{title}</Card.Title>

        <Card.Text> {text} </Card.Text>

        <Link to={mylink}>
          <button>Click on me</button>
        </Link>
      </Card.Body>
    </Card>
  );
}

export default CardComp;

