import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})

export class AppComponent {
  title = 'medical center web';

  constructor(private alertService: AlertService) {
    this.alertService.alert$.subscribe(({ message, type }) => {
      this.showAlert(message, type);
    });
  }

  alertMessage: string = '';
  alertType: string = '';

  showAlert(message: string, type: string) {
    this.alertMessage = message;
    this.alertType = type;
    setTimeout(() => {
      this.closeAlert(); 
    }, 5000); 
  }

  closeAlert() {
    this.alertMessage = '';
    this.alertType = '';
  }
}
