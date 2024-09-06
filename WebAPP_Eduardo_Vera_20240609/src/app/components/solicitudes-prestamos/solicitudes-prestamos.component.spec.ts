import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudesPrestamosComponent } from './solicitudes-prestamos.component';

describe('SolicitudesPrestamosComponent', () => {
  let component: SolicitudesPrestamosComponent;
  let fixture: ComponentFixture<SolicitudesPrestamosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SolicitudesPrestamosComponent]
    });
    fixture = TestBed.createComponent(SolicitudesPrestamosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
