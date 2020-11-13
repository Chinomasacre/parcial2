import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl} from '@angular/forms';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-registropersona',
  templateUrl: './registropersona.component.html',
  styleUrls: ['./registropersona.component.css']
})

export class RegistropersonaComponent implements OnInit{
  formGroup: FormGroup;
  persona: Persona;
  constructor(private personaService: PersonaService,private formBuilder: FormBuilder) { }

  ngOnInit(){
    this.persona = new Persona();
    this.buildForm();
  }
  private buildForm(){
    this.persona.identificacion = '';
    this.persona.nombre = '';
    this.persona.direccion = '';
    this.persona.telefono = '';
    this.persona.pais = '';

    this.formGroup = this.formBuilder.group({
      identificacion: [this.persona.identificacion, Validators.required],
      nombre: [this.persona.nombre, Validators.required],
      direccion: [this.persona.direccion, [Validators.required, Validators.min(1)]],
      telefono: [this.persona.telefono, [Validators.required, Validators.min(1)]],
      pais: [this.persona.pais, [Validators.required, Validators.min(1)]],
      departamento: [this.persona.departamento, [Validators.required, Validators.min(1)]],
      ciudad: [this.persona.ciudad, [Validators.required, Validators.min(1)]]
    });
  }
  get control() { 
    return this.formGroup.controls;
     }
  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }
      
  add(){
    this.persona = this.formGroup.value;

    this.personaService.post(this.persona).subscribe(p => {
      if (p != null) {
        alert('persona creada');
        this.persona = p;
      }
    });
  }
}
