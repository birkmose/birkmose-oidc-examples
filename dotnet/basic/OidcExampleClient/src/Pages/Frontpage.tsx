import React, { useEffect, useState } from 'react';
import { User } from 'oidc-client-ts';
import AuthService from '../services/AuthService';

const authService = new AuthService();

const login = () => {
  authService.login();
};

const logout = async () => {
  await authService.logout();
};

function FrontPage() {
  const [user, setUser] = useState<User | null>();

  const tokenRefresh = async () => {
    const refreshedUser = await authService.renewToken();
    setUser(refreshedUser);
  };

  const tokenExpiry = () => {
    if (user?.expires_in != null) {
      const exp = new Date();
      exp.setSeconds(exp.getSeconds() + user.expires_in);
      return exp.toTimeString();
    }
    return '';
  };

  useEffect(() => {
    const getUser = async () => {
      const loadedUser = await authService.userManager.getUser();
      setUser(loadedUser);
    };

    getUser();
  }, []);

  return (
    <div>
      {
        user && (
          <>
            <div>
              You are currently logged in as user:
              {user.profile.sub}
            </div>
            <div>
              Token will expire:
              {tokenExpiry()}
            </div>
          </>

        )
      }
      <button type="button" onClick={login}>Login</button>
      <button type="button" onClick={tokenRefresh}>Refresh</button>
      <button type="button" onClick={logout}>Logout</button>
    </div>
  );
}

export default FrontPage;
