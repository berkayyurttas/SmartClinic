import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  
  issuer: 'http://localhost:44305/', 
  redirectUri: baseUrl,
  clientId: 'SmartClinic_App',
  responseType: 'code',
  scope: 'offline_access SmartClinic',
  requireHttps: false, // Docker içinde SSL sertifikasıyla uğraşmamak için false yapıyoruz
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SmartClinic',
  },
  oAuthConfig,
  apis: {
    default: {
      
      url: 'http://localhost:44305', 
      rootNamespace: 'SmartClinic',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;