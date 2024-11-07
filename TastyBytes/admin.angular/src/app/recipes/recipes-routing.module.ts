import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipesListComponent } from './recipes-list/recipes-list.component';
import { CrudRecipesComponent } from './crud-recipes/crud-recipes.component';

const routes: Routes = 
[
  {
    path: '',
    component: RecipesListComponent
  },
  {
    path: 'list',
    component: RecipesListComponent
  },
  {
    path: 'crud',
    component: CrudRecipesComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RecipesRoutingModule { }
