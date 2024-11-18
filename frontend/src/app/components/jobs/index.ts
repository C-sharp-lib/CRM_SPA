import {JobListComponent} from './job-list/job-list.component';
import {JobSearchComponent} from './job-search/job-search.component';
import {JobCreateComponent} from './job-create/job-create.component';
import {JobDetailsComponent} from './job-details/job-details.component';
import {JobDeleteComponent} from './job-delete/job-delete.component';

export const components: any[] = [
  JobListComponent,
  JobSearchComponent,
  JobCreateComponent,
  JobDetailsComponent,
  JobDeleteComponent
];

export * from './job-list/job-list.component';
export * from './job-search/job-search.component';
export * from './job-create/job-create.component';
export * from './job-details/job-details.component';
export * from './job-delete/job-delete.component';
