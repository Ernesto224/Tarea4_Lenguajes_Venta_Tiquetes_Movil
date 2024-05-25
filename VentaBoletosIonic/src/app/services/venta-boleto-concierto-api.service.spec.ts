import { TestBed } from '@angular/core/testing';

import { VentaBoletoConciertoAPIService } from './venta-boleto-concierto-api.service';

describe('VentaBoletoConciertoAPIService', () => {
  let service: VentaBoletoConciertoAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VentaBoletoConciertoAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
