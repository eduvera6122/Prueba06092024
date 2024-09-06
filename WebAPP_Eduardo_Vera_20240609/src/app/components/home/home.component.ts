import { Component, OnInit } from '@angular/core';
import { ServiciosService } from 'src/app/Services/servicios.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  solicitudes : any = [];
  
  constructor(private service : ServiciosService){

  }


  ngOnInit(): void {
    this.service.obtenerSolicitudes().subscribe(data => {
      this.solicitudes = data;
    });
  }

  


}
