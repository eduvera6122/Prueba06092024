import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServiciosService {

   url = "https://localhost:7192";

  constructor(private http : HttpClient) { }


  login(login : any){
    return this.http.post<any>(this.url+"/api/Usuario", login);
  }

  obtenerSolicitudes(){
    return this.http.get<any>(this.url+"/api/Solicitud");
  }

  registrarSolicitud(Solicitud : any){
    return this.http.post<any>(this.url+"/api/Solicitud", Solicitud);
  }


}
