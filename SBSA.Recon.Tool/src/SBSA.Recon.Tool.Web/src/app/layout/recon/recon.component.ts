import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { ReconService } from '../../data/recon.service';
import { OverviewModel } from '../model/overviewModel';
import { CommentModel } from '../model/CommentModel';


@Component({
  selector: 'app-recon',
  templateUrl: './recon.component.html',
  styleUrls: ['./recon.component.scss']
})
export class ReconComponent implements OnInit {

    overviewModel: OverviewModel[] = [];
    comments: CommentModel[] = [];
    loading: boolean;

    displayedColumns = [
          'reconID'
        , 'source'
        , 'cdsBusinessDate'
        , 'reference'
        , 'srcReference'
        , 'tradeDate'
        , 'expiryDate'
        , 'settlementDate'
        , 'cif'
        , 'product'
        , 'notional'
        , 'mtm'
        , 'logEvent'
        ];

    dataSource: MatTableDataSource<OverviewModel>;
    commentDataSource: MatTableDataSource<CommentModel>;

    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;

    constructor( private reconService: ReconService) {
        this.reconService = reconService;
    }

    ngOnInit() {

        // this.reconService.getComments()
        // .subscribe(x => this.commentDataSource = new MatTableDataSource(x));
        // this.commentDataSource = new MatTableDataSource(this.comments);
        // this.commentDataSource.paginator = this.paginator;
        // this.commentDataSource.sort = this.sort;

        this.reconService.getStats()
        .subscribe(x => this.dataSource = new MatTableDataSource(x));
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
    }

    applyFilter(filterValue: string) {
        filterValue = filterValue.trim(); // Remove whitespace
        filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
        this.dataSource.filter = filterValue;
        if (this.dataSource.paginator) {
            this.dataSource.paginator.firstPage();
        }
    }
}



