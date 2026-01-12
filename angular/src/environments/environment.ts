import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200/';

const oAuthConfig = {
  issuer: 'http://localhost:44305', // SONUNDAKİ / işaretini SİLDİK
  redirectUri: 'http://localhost:4200/', // SONUNA / EKLEDİK (Garanti olsun)
  clientId: 'SmartClinic_App',
  responseType: 'code',
  scope: 'offline_access SmartClinic',
  requireHttps: false,
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