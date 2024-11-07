import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RecipesRoutingModule } from './recipes-routing.module';
import { RecipesListComponent } from './recipes-list/recipes-list.component';
import { CrudRecipesComponent } from './crud-recipes/crud-recipes.component';


@NgModule({
  declarations: [
    RecipesListComponent,
    CrudRecipesComponent
  ],
  imports: [
    CommonModule,
    RecipesRoutingModule
  ]
})
export class RecipesModule { }
