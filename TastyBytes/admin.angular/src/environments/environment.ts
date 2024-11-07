import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'TastyBytes',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44322/',
    redirectUri: baseUrl,
    clientId: 'TastyBytes_App',
    responseType: 'code',
    scope: 'offline_access TastyBytes',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44322',
      rootNamespace: 'TastyBytes',
    },
  },
} as Environment;
