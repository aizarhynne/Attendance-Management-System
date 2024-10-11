import { Routes } from '@angular/router';

import { AdminDB2Component } from './admin-db2/admin-db2.component';
import { ReportPageComponent } from './report-page/report-page.component';
import { UserManagementComponent } from './user-management/user-management.component';

export const routes: Routes = [
  {
    path: 'admin-db2',
    component: AdminDB2Component,
  },
  {
    path: 'report-page',
    component: ReportPageComponent,
  },
  {
    path: 'user-management',
    component: UserManagementComponent,
  },
];