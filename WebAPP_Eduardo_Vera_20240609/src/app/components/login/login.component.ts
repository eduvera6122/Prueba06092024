import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ServiciosService } from 'src/app/Services/servicios.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  loginForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private service: ServiciosService
  ) {
    this.loginForm = this.fb.group({
      nombre: ['', [Validators.required]], // Validación de usuario
      password: ['', [Validators.required]], // Validación de contraseña
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      this.service.login(this.loginForm.value).subscribe((data: any) => {
        console.log(data);

        localStorage.setItem('UsuarioId', data.usuarioId);

        this.router.navigate(['/home']);
      });
    }
  }
}
