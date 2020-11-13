import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistropersonaComponent } from './registropersona.component';

describe('RegistropersonaComponent', () => {
  let component: RegistropersonaComponent;
  let fixture: ComponentFixture<RegistropersonaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistropersonaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistropersonaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
