import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobrequestApplyComponent } from './jobrequest-apply.component';

describe('JobrequestApplyComponent', () => {
  let component: JobrequestApplyComponent;
  let fixture: ComponentFixture<JobrequestApplyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JobrequestApplyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(JobrequestApplyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
