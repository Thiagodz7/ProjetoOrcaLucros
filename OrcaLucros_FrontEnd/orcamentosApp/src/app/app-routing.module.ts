import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAppComponent } from './Home/home-app/home-app.component';
import { OrcamentosComponent } from './orcamentos/orcamentos.component';

const routes: Routes = [
  {path: 'home', component : HomeAppComponent},
  {path: 'orcamentos', component : OrcamentosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
