import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { routes } from './app.routes';
import { CatalogComponent } from './components/catalog/catalog.component';

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
})
export class AppModule { }