import { map } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { Http, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ReconService {

  headers = new Headers();

  // tslint:disable-next-line:no-inferrable-types
  url: string = 'http://localhost:1591/';

  constructor(private readonly http: Http) { }

  saveComment(comment: FormData): Observable<number> {
    const options = new RequestOptions({withCredentials: true });
    return this.http.post(this.url + 'api/Recon/CreateComment', comment, options).pipe(map(r => r.json()));
  }

  saveComments(comment: FormData): Observable<number> {
    const options = new RequestOptions({withCredentials: true });
    return this.http.post(this.url + 'api/Recon/CreateComments', comment, options).pipe(map(r => r.json()));
  }
}
