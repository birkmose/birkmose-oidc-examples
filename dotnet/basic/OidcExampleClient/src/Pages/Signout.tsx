import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import Spinner from '../Components/Spinner';
import AuthService from '../services/AuthService';

const authService = new AuthService();

const Signin = () => {
  const navigate = useNavigate();
  useEffect(() => {
    const finishLogin = async () => {
      await authService.userManager.signoutRedirectCallback(window.location.href);
      navigate('/');
    };

    finishLogin();
  }, [navigate]);
  return (
    <Spinner />
  );
};

export default Signin;
