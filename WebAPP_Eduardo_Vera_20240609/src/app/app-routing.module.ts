import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { SolicitudesPrestamosComponent } from './components/solicitudes-prestamos/solicitudes-prestamos.component';

const routes: Routes = [

  {
    path: '',
    component : LoginComponent,
    pathMatch: 'full'
  },
  {
    path :'home',
    component : HomeComponent,
  },{
    path : 'registrarSolicitud',
    component : SolicitudesPrestamosComponent
  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
