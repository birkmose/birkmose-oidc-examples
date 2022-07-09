import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import AuthService from '../services/AuthService';

const authService = new AuthService();

function Signin() {
  const navigate = useNavigate();
  useEffect(() => {
    const finishLogin = async () => {
      await authService.userManager.signoutRedirectCallback(window.location.href);
      navigate('/');
    };

    finishLogin();
  }, [navigate]);
  return (
    <div>
      Redirecting...
    </div>
  );
}

export default Signin;
