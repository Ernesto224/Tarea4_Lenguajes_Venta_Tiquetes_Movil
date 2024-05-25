import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PayPagePage } from './pay-page.page';

describe('PayPagePage', () => {
  let component: PayPagePage;
  let fixture: ComponentFixture<PayPagePage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(PayPagePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
