import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule} from '@angular/material/form-field';

@Component({
  selector: 'app-login-card',
  imports: [
    MatCardModule,
    MatFormFieldModule
  ],
  templateUrl: './login-card.component.html',
  styleUrl: './login-card.component.css'
})
export class LoginCardComponent {

}
