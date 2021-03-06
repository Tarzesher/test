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

    createComment(formData: any) {
      return this.http.get(this.url + 'comment/create' + formData, this.httpOptions)
      .pipe(map(r => <OverviewModel[]>r));
    }

    getStats(): any {
      return this.http.get(this.url + 'stats/', this.httpOptions)
      .pipe(map(r => <OverviewModel[]>r));
    }

    getComments(): any {
      return this.http.get(this.url + 'comment/', this.httpOptions)
      .pipe(map(r => <CommentModel[]>r));
    }

    getCommentById(reconId: number): any {
      return this.http.get(this.url + 'comment/GetById' + reconId, this.httpOptions)
      .pipe(map(r => <CommentModel[]>r));
    }

    getStatsBySource(source: string, date: Date): any {
      return this.http.get(this.url + 'stats/GetBySource?source=' + source + '&date=' + date, this.httpOptions)
      .pipe(map(r => <CommentModel[]>r));
    }

    getStatsSourceLookup(): any {
      return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
      .pipe(map(r => r));
    }

    getItemsInSource(source: string, date: Date, reconStatus: string):  any {
      return this.http.get(this.url + 'stats/GetItemsInSource?source=' + source + '&date='
         + date + '&reconstatus=' + reconStatus, this.httpOptions)
      .pipe(map(r => r));
    }

    getMiddlewareLogFilter(source: string, date: Date, reconStatus: string): any {
      return this.http.get(this.url + 'stats/GetMiddlewareLogFilter?source=' + source
      + '&date=' + date + '&reconstatus=' + reconStatus, this.httpOptions)
      .pipe(map(r => r));
    }



    // getStatsSourceLookup(): Observable<string[]> {
    //   return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
    //   .pipe(map(r => <string[]>r));
    // }
    // getStatsSourceLookup(): Observable<string[]> {
    //   return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
    //   .pipe(map(r => <string[]>r));
    // }
    // getStatsSourceLookup(): Observable<string[]> {
    //   return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
    //   .pipe(map(r => <string[]>r));
    // }
    // getStatsSourceLookup(): Observable<string[]> {
    //   return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
    //   .pipe(map(r => <string[]>r));
    // }
    // getStatsSourceLookup(): Observable<string[]> {
    //   return this.http.get(this.url + 'stats/GetSourceLookup', this.httpOptions)
    //   .pipe(map(r => <string[]>r));
    // }
  }


