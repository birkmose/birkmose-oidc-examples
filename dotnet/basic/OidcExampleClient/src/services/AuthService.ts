import { Log, User, UserManager } from 'oidc-client-ts';

import { Constants } from '../helpers/Constants';

export class AuthService {
  public userManager: UserManager;

  constructor() {
    const settings = {
      authority: Constants.stsAuthority,
      client_id: Constants.clientId,
      redirect_uri: `${Constants.clientRoot}signin`,
      //silent_redirect_uri: `${Constants.clientRoot}silent-renew.html`,
      // tslint:disable-next-line:object-literal-sort-keys
      post_logout_redirect_uri: `${Constants.clientRoot}signout`,
      response_type: 'code',
      response_mode: 'query' as 'query',
      scope: Constants.clientScope
    };
    this.userManager = new UserManager(settings);

  }

  public getUser(): Promise<User | null> {
    return this.userManager.getUser();
  }

  public login(): Promise<void> {
    return this.userManager.signinRedirect();
  }

  public renewToken(): Promise<User | null> {
    return this.userManager.signinSilent();
  }

  public logout(): Promise<void> {
    return this.userManager.signoutRedirect();
  }
}
