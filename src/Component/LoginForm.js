import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

function LoginForm() {

  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const navigate = useNavigate();

  const handleUsernameChange = (event) => {
    setUsername(event.target.value);
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  const handleSubmit = async () => {
    try {
      const response = await axios.get('http://localhost:8080/api/customer_master/login', {
        params: { username, password }
      });

      localStorage.setItem("uid",response.data);

      if (response.status === 200) {
        alert("!!! User Logged In successfully !!!")}
      else
      {
        alert("!!! Login Failed !!!")
      }
    } catch (error) {
      alert('Login failed:', error.response ? error.response.data : error.message);
    }

    navigate("/")
  };

 // alert(localStorage.getItem("uid"));

  return (
    <div>
      <input
        type="text"
        placeholder="Username"
        value={username}
        onChange={handleUsernameChange}
      />
      <input
        type="password"
        placeholder="Password"
        value={password}
        onChange={handlePasswordChange}
      />
      <button onClick={handleSubmit}>Login</button>
    </div>
  );
}

export default LoginForm;