import { AuthService } from '../services/AuthService';
import React, { useEffect, useState } from 'react';
import { useNavigate } from "react-router-dom";

const authService = new AuthService();

 

const Signin = () => {
    const navigate = useNavigate();
    useEffect(() => {
        const finishLogin = async () => {
            await authService.userManager.signinRedirectCallback(window.location.href);
            navigate("/");
        };

        finishLogin();
    }, [navigate]);
    return (<div>
       Redirecting...
    </div>)
}

export default Signin;