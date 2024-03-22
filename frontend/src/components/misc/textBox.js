import React from 'react';
import { Form, Card } from 'react-bootstrap';

const TextBox = () => {
  return (
    <Card style={{ zIndex: 10000 }}>
      <Form>
        <Form.Group controlId="exampleForm.ControlTextarea1">
          <Form.Control 
            as="textarea" 
            rows={17} 
            placeholder="For your escape plan..." 
            autoFocus
            tabIndex={0} 
          />
        </Form.Group>
      </Form>
    </Card>
  );
};

export default TextBox;
