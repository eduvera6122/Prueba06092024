import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ServiciosService } from 'src/app/Services/servicios.service';

@Component({
  selector: 'app-solicitudes-prestamos',
  templateUrl: './solicitudes-prestamos.component.html',
  styleUrls: ['./solicitudes-prestamos.component.css']
})
export class SolicitudesPrestamosComponent {

  solicitudForm: FormGroup;

  constructor(private fb: FormBuilder , private service : ServiciosService , private router : Router) {
    this.solicitudForm = this.fb.group({
      usuarioId : parseInt(localStorage.getItem('UsuarioId') || '0', 10),
      fechaSolicitud: ['', Validators.required],
      montoSolicitado: [0, [Validators.required, Validators.min(1)]],
      estado: "pendiente"
    });
  }

  onSubmit() {
    if (this.solicitudForm.valid) {

      this.service.registrarSolicitud(this.solicitudForm.value).subscribe(data => {
        console.log(data);

        this.router.navigate(['/home']);
        

      });



    } else {
      console.log('Formulario no válido');
    }
  }



}
