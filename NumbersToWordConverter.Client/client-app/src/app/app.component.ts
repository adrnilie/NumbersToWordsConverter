import { Component } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [AppService]
})
export class AppComponent {
  constructor(private appService: AppService){}

  inputNumber = '';
  errorMessage = '';
  result : any = {
    input : '',
    output : ''
  };

  showConvertedNumber(){
    if (this.isInvalidInput(this.inputNumber)) {
      this.errorMessage = 'Input is invalid!';
    }

    this.appService.getNumberInWords(parseInt(this.inputNumber))
    .subscribe((response) => this.result = {
        input : response['input'],
        output : response['output']
      },
    (error) => this.errorMessage = error.message);
  }

  isInvalidInput(input: string) {
    if (isNaN(parseInt(input))) {
      return true;
    } else if (input.toString().length > 12) {
      return true;
    }
    return false;
  }
}
