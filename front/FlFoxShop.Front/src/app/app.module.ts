import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgModule, importProvidersFrom } from '@angular/core';
import { routes } from './app.routes';
import { CatalogComponent } from './components/catalog/catalog.component';
import { HttpClientModule } from '@angular/common/http';
import { TestService } from './services/test-service';

@NgModule({
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes)
  ],
  declarations: [
    AppComponent,
    CatalogComponent
  ],
  bootstrap: [
    AppComponent
  ],
  providers: [
    importProvidersFrom(HttpClientModule),
    TestService
  ]
})
export class AppModule { }