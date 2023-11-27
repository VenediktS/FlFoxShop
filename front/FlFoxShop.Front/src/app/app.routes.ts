import { Routes } from '@angular/router';
import { CatalogComponent } from './components/catalog/catalog.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
    { path: '', component: AppComponent },
    { path: 'catalog', component: CatalogComponent }

];
