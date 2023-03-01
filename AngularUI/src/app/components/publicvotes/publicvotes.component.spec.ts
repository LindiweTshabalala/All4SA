import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PublicvotesComponent } from './publicvotes.component';

describe('PublicvotesComponent', () => {
  let component: PublicvotesComponent;
  let fixture: ComponentFixture<PublicvotesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PublicvotesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PublicvotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
