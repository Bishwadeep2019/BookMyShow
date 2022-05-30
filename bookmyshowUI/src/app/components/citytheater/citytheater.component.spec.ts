import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CitytheaterComponent } from './citytheater.component';

describe('CitytheaterComponent', () => {
  let component: CitytheaterComponent;
  let fixture: ComponentFixture<CitytheaterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CitytheaterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CitytheaterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
