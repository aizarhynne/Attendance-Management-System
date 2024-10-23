import { Component } from '@angular/core';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css'],
  standalone: true,
  imports: [ReactiveFormsModule] // Import necessary modules here
})
export class RegistrationComponent {
  registerForm: FormGroup;
  userType: string = 'user';  // Default user type

  constructor(private fb: FormBuilder) {
    this.registerForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', Validators.required],
      contactNumber: ['', [Validators.required, Validators.pattern('^[0-9]*$')]],
    });
  }

  // Add setUserType method
  setUserType(type: string): void {
    this.userType = type;
    console.log('User Type set to:', this.userType);
  }

  onSubmit(): void {
    if (this.registerForm.valid) {
      const formData = { ...this.registerForm.value, userType: this.userType };
      console.log('Registration Data:', formData);
      // Here you can handle the form submission, like sending data to the backend
    }
  }
}
