import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrudRecipesComponent } from './crud-recipes.component';

describe('CrudRecipesComponent', () => {
  let component: CrudRecipesComponent;
  let fixture: ComponentFixture<CrudRecipesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CrudRecipesComponent]
    });
    fixture = TestBed.createComponent(CrudRecipesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
