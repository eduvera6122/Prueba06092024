import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent {

  constructor(private _router: Router,) {

   }


  eliminarIDUsuario(){
    localStorage.removeItem('usuarioId');
   this._router.navigate(['/']);
  }


}
