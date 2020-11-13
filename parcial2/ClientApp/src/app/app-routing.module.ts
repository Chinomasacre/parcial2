import { RegistropersonaComponent} from './parcial2/registropersona/registropersona.component';


import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule  } from '@angular/router';

const routes: Routes = [
  {
    path: 'personaRegistro',
    component: RegistropersonaComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
