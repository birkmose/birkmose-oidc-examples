import React from 'react';
import logo from './logo.svg';
import './App.css';
import { AuthService } from './services/AuthService';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import FrontPage from './Pages/Frontpage'
import Signin from './Pages/Signin'
import Signout from './Pages/Signout'

async function getUser(authService: AuthService) {
  const user = await authService.getUser()
  console.log(user);
}

function App() {

  let authService = new AuthService();

  const login = () => {
    authService.login();
  };

  getUser(authService);

  return (
    <BrowserRouter>
    <Routes>
    <Route path="/" element={<FrontPage />}/>
    <Route path="/signin" element={<Signin />}/>
    <Route path="/signout" element={<Signout />}/>
        {/* <Route index element={<Home />} />
        <Route path="blogs" element={<Blogs />} />
        <Route path="contact" element={<Contact />} /> */}
        {/* <Route path="*" element={<NoPage />} /> */}
      {/* </Route> */}
    </Routes>
  </BrowserRouter>
  );
}

export default App;
