import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SigInPage } from './sig-in.page';

describe('SigInPage', () => {
  let component: SigInPage;
  let fixture: ComponentFixture<SigInPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(SigInPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
