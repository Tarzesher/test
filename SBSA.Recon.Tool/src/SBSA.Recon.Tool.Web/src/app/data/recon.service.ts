import { map } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { OverviewModel } from '../layout/model/overviewModel';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { CommentModel } from '../layout/model/CommentModel';

@Injectable()
export class ReconService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  // tslint:disable-next-line:no-inferrable-types
  url: string = 'http://localhost:63547/api/';

  constructor(private readonly http: HttpClient) { }

  // saveComment(comment: FormData): Observable<number> {
  //   // const options = new RequestOptions({withCredentials: true });
  //   return this.http.post(this.url + 'api/Comment/CreateComment', comment, options).pipe(map(r => r.json()));
  // }

  // saveComments(comment: FormData): Observable<number> {
  //   const options = new RequestOptions({withCredentials: true });
  //   return this.http.post(this.url + 'api/Comment/CreateComments', comment, options).pipe(map(r => r.json()));
  // }

  getStats(): any {

    return this.http.get(this.url + 'stats/', this.httpOptions)
    .pipe(map(r => <OverviewModel[]>r));
  }

  getComments(): any {
    return this.http.get(this.url + 'comment/', this.httpOptions)
    .pipe(map(r => <CommentModel[]>r));
  }



    // getStats(): Observable<OverviewModel[]> {
    // const options = new RequestOptions({withCredentials: true });
    // return this.http.get(this.url + 'stats/', options).pipe(map(r => <OverviewModel[]>r.json()));
  }


