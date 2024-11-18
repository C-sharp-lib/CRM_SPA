import {AuthenticationService} from './authentication.service';
import {JobsService} from './jobs.service';

export const services: any[] = [
  AuthenticationService,
  JobsService
];


export * from './authentication.service';
export * from './jobs.service';
