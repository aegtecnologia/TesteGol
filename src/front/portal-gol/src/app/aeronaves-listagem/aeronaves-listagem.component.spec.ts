import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AeronavesListagemComponent } from './aeronaves-listagem.component';

describe('AeronavesListagemComponent', () => {
  let component: AeronavesListagemComponent;
  let fixture: ComponentFixture<AeronavesListagemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AeronavesListagemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AeronavesListagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
