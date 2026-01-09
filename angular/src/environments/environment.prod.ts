import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  // DÜZELTME: https -> http ve port 44326 -> 44305
  issuer: 'http://localhost:44305/',
  redirectUri: baseUrl,
  clientId: 'SmartClinic_App',
  // Docker ve yerel test için Production modunda bile bunu false yapmalıyız
  requireHttps: false, 
  responseType: 'code',
  scope: 'offline_access SmartClinic',
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'SmartClinic',
  },
  oAuthConfig,
  apis: {
    default: {
      // DÜZELTME: https -> http ve port 44326 -> 44305
      url: 'http://localhost:44305',
      rootNamespace: 'SmartClinic',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;