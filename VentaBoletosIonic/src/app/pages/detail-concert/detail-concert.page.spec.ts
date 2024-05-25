import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DetailConcertPage } from './detail-concert.page';

describe('DetailConcertPage', () => {
  let component: DetailConcertPage;
  let fixture: ComponentFixture<DetailConcertPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailConcertPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
