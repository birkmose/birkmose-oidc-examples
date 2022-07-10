import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import Spinner from '../Components/Spinner';
import AuthService from '../Services/AuthService';

const authService = new AuthService();

const Signin = () => {
  const navigate = useNavigate();
  useEffect(() => {
    const finishLogin = async () => {
      await authService.userManager.signinRedirectCallback(window.location.href);
      navigate('/');
    };

    finishLogin();
  }, [navigate]);
  return (
    <Spinner />
  );
};

export default Signin;
