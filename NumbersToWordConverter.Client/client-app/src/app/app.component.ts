import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [AppService]
})
export class AppComponent {
  constructor(private appService: AppService){}

  result = {
    input: '',
    output: ''
  };

  ngOnInit(){
    this.showConvertedNumber(125);
  }

  showConvertedNumber(no: Number){
    this.appService.getNumberInWords(no).subscribe((response) =>
      this.result = {
        input : response['input'],
        output : response['output']
      },
    (error) => console.log(error));
  }
}
