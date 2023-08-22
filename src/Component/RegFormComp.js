import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';

function RegFormComp() {
  return (
    <div className='Form' >
      <Form  >

        <h2  >  Registration Form</h2>
        <Row className="mb-3">
          <Col>
            <Form.Label>First Name</Form.Label>
            <Form.Control placeholder="First name" />
          </Col>
          <Col>
            <Form.Label>Last Name</Form.Label>
            <Form.Control placeholder="Last name" />
          </Col>
        </Row>

        <Row className="mb-3">
          <Form.Group as={Col} controlId="formGridEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control type="email" placeholder="Enter email" />
          </Form.Group>


        </Row>
        <Row>
          <Col>
            <Form.Group className="mb-3" controlId="formGridage"  >
              <Form.Label>Age</Form.Label>
              <Form.Control placeholder="Enter age" type='number' />
            </Form.Group>
          </Col>



          <Col>
            <Form.Group className="mb-3" controlId="formGridgender">
              <Form.Label>Gender</Form.Label>
              <Form.Control as="select" placeholder="Select Gender">
                <option value="male">Male</option>
                <option value="female">Female</option>
                <option value="transgender">Transgender</option>
              </Form.Control>
            </Form.Group>
          </Col>




          <Col>

            <Form.Group className="mb-3" controlId="formGridmobile">
              <Form.Label>Contact Number</Form.Label>
              <Form.Control placeholder="Enter Number" />
            </Form.Group>
          </Col>
        </Row>

        <Row>
          <Col>
            <Form.Group className="mb-3" controlId="formGridAddress1">
              <Form.Label>Address</Form.Label>
              <Form.Control placeholder="Enter Address" />
            </Form.Group>
          </Col>

          <Col>
            <Form.Group className="mb-3" controlId="formGridCode">
              <Form.Label>Country Code</Form.Label>
              <Form.Control placeholder="Enter Code" />
            </Form.Group>
          </Col>
        </Row>




        <Button variant="primary" type="submit">
          Submit
        </Button>
      </Form>
    </div>
  );
}

export default RegFormComp;