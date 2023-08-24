
import Card from 'react-bootstrap/Card';



function CardComp({ title }) {


  return (



    <Card style={{ width: '18rem' }}>
      <Card.Img variant="top" src="imgr.jpg" />
      <Card.Body>
        <Card.Title>{title }</Card.Title>


      <Card.Text> </Card.Text>

     


        
      </Card.Body>
    </Card>
  );
}

export default CardComp;




