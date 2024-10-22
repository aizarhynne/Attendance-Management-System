import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminDB2Component } from './admin-db2.component';

describe('AdminDB2Component', () => {
  let component: AdminDB2Component;
  let fixture: ComponentFixture<AdminDB2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminDB2Component]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminDB2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
