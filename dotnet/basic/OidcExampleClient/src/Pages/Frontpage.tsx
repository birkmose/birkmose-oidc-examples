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

const FrontPage = () => {
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
      <h1>Example OIDC Application</h1>
      {
        user && (
          <div className="information">
            <p>
              You are currently logged in as user:
              {' '}
              {user.profile.sub}
              .
              <br />
              Access Token will expire:
              {tokenExpiry()}
              .
            </p>
            <p>
              If you press the &quot;Login (SSO)&quot; button,
              you will observe the single sign-on functionality of the OIDC server.
            </p>
          </div>

        )
      }
      {!user && (
      <div className="information">
        You are currently not logged in.
        <br />
        Press the &quot;Login&quot; button, to initialize an authorization with the OIDC server.
      </div>
      )}
      {!user && <button type="button" onClick={login}>Login</button>}
      {user && <button type="button" onClick={login}>Login (SSO)</button>}
      {user && <button type="button" onClick={tokenRefresh}>Refresh Token</button>}
      {user && <button type="button" onClick={logout}>Logout</button>}
    </div>
  );
};

export default FrontPage;
