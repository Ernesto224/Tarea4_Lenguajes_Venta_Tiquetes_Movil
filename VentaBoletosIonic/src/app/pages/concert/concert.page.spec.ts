import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ConcertPage } from './concert.page';

describe('ConcertPage', () => {
  let component: ConcertPage;
  let fixture: ComponentFixture<ConcertPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(ConcertPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
