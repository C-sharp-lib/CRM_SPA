import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import * as fromLayout from './components/layout';
import * as fromAuthentication from './components/authentication';
import * as fromJobs from './components/jobs';
import * as fromServices from './services';

@NgModule({
  declarations: [
    AppComponent,
    ...fromLayout.components,
    ...fromAuthentication.components,
    ...fromJobs.components,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration(),
    ...fromServices.services,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
