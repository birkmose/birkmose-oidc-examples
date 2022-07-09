export default class Constants {
  public static stsAuthority = (window as any).oidc_env.stsAuthority;

  public static clientId = (window as any).oidc_env.clientId;

  public static clientRoot = (window as any).oidc_env.clientRoot;

  public static clientScope = (window as any).oidc_env.clientScope;
}
