import { Component } from '@angular/core';
import { TopbarComponent } from '../topbar/topbar.component';
import { LoginCardComponent } from '../login-card/login-card.component';

@Component({
  selector: 'app-login',
  imports: [
    TopbarComponent,
    LoginCardComponent
  ],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

}
