import { Component, OnInit } from '@angular/core';
import { ReconService } from '../../data/recon.service';
import { OverviewModel } from '../model/overviewModel';
import { Observable } from 'rxjs';



@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

    sourceTypes: string[] = [];
    logFilter: OverviewModel[] = [];
    constructor(private reconService: ReconService) {
    }

    ngOnInit() {
       this.reconService.getStatsSourceLookup().subscribe(x => { this.sourceTypes = <string[]>x; });
       console.log(this.sourceTypes);

    //    console.log(this.source);
    //    this.reconService.getMiddlewareLogFilter(this.paramSource, this.paramDate,
    //    this.reconstatus).subscribe(x => this.logFilt er = <OverviewModel[]>x);
       // getItemsInSource


    }

    save() {
        alert('serch works');
    }
}

