import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';

const LoginForm = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [usernameError, setUsernameError] = useState('');
  const [passwordError, setPasswordError] = useState('');

  const handleUsernameChange = (event) => {
    const value = event.target.value;
    setUsername(value);
    setUsernameError(value ? '' : 'Username is required');
  };

  const handlePasswordChange = (event) => {
    const value = event.target.value;
    setPassword(value);
    setPasswordError(value ? '' : 'Password is required');
  };

  const handleSubmit = async (event) => {
    event.preventDefault();

    if (!username) {
      setUsernameError('Username is required');
    }

    if (!password) {
      setPasswordError('Password is required');
    }

    if (username && password) {
      try {
        const response = await fetch('https://your-postman-mock-api.com/login', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({ username, password }),
        });

        if (response.ok) {
          const data = await response.json();
          if (data.success) {
            console.log('Login authentication successful');
          } else {
            console.error('Login authentication failed:', data.message);
          }
        } else {
          console.error('Error occurred during authentication');
        }
      } catch (error) {
        console.error('Error occurred while authenticating:', error);
      }
    }
  };

  return (
    <div className="login-form">
      <h2>Login</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group controlId="username">
          <Form.Label>Username</Form.Label>
          <Form.Control
            type="text"
            placeholder="Enter username"
            value={username}
            onChange={handleUsernameChange}
            isInvalid={!!usernameError}
          />
          <Form.Control.Feedback type="invalid">
            {usernameError}
          </Form.Control.Feedback>
        </Form.Group>

        <Form.Group controlId="password">
          <Form.Label>Password</Form.Label>
          <Form.Control
            type="password"
            placeholder="Enter password"
            value={password}
            onChange={handlePasswordChange}
            isInvalid={!!passwordError}
          />
          <Form.Control.Feedback type="invalid">
            {passwordError}
          </Form.Control.Feedback>
        </Form.Group>

        <Button variant="primary" type="submit">
          Login
        </Button>
      </Form>

      <p>New customer? <a href="/register">Register here</a></p>
    </div>
  );
};

export default LoginForm;
