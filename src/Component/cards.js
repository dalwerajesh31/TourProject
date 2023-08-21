
import Card from 'react-bootstrap/Card';
import { useNavigate } from "react-router-dom"



function Card1({title, text , mylink}) {

  const navigate = useNavigate()
  return (


    <Card style={{ width: '18rem' }}>
      <Card.Img variant="top" src="imgr.jpg" />
      <Card.Body>
        <Card.Title>{title}</Card.Title>
        <Card.Text>
         {text}
        </Card.Text>

        
       
        <button  variant="primary" onClick={ ()=>{navigate('int')} } > Go SomeWhere</button>
    

       
        
      </Card.Body>
    </Card>
  );
}

export default Card1;


/*

export  const  Home=()=>{
    const navigate = useNavigate()


return(
    <>
    <div> Home Page Bro</div>
   <button onClick={ ()=>{navigate('order-summary',{replace: true})} } > Order Placed</button>
    
    </>
)

}*/