import { Component } from '@angular/core';
import { TopbarComponent } from '../topbar/topbar.component';
import { HomeContentComponent } from '../home-content/home-content.component';

@Component({
  selector: 'app-home',
  imports: [
    TopbarComponent,
    HomeContentComponent
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
