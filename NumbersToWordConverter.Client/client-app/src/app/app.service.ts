import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AppService {
  constructor(private http: HttpClient){ }

  private apiUrl = 'http://localhost:54175/api';

  getNumberInWords(no: Number){
    return this.http.get(`${this.apiUrl}/convert/${no}`);
  }
}
