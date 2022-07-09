import { AuthService } from '../services/AuthService';
import React, { useEffect, useState } from 'react';
import { User } from 'oidc-client-ts'
const authService = new AuthService();

  const login = () => {
    authService.login();
  };

  const logout = async () => {
    await authService.logout();
  };


const FrontPage = () => {
  const [user, setUser] = useState<User | null>();

  const tokenRefresh = async () => {
    const user = await authService.renewToken();
    setUser(user);
  };

  const tokenExpiry = () => {
    if (user?.expires_in != null) {
        let exp = new Date();
        exp.setSeconds(exp.getSeconds() + user.expires_in);
        return exp.toTimeString();
    }
    return '';
  }
  useEffect(() => {
    const getUser = async () => {
        console.log("effect");
        const user = await authService.userManager.getUser();
        setUser(user)
    };

    getUser();
}, []);

    return (<div>
      {
        user && (
          <>         
            <div>You are currently logged in as user: {user.profile.sub}</div>
            <div>Token will expire: {tokenExpiry()}</div>
          </>

        )
      }
        <button onClick={login}>Login</button>
        <button onClick={tokenRefresh}>Refresh</button>
        <button onClick={logout}>Logout</button>
    </div>)
}

export default FrontPage;