import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';


@Component({
  selector: 'app-recon',
  templateUrl: './recon.component.html',
  styleUrls: ['./recon.component.scss']
})
export class ReconComponent implements OnInit {

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
        , 'comment'];

    dataSource: MatTableDataSource<OverviewStats>;

    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;

    constructor() {
        // Create 100 overview
        const stats: OverviewStats[] = [];
        for (let i = 1; i <= 100; i++) {
            stats.push(createOverview(i));
        }

        // Assign the data to the data source for the table to render
        this.dataSource = new MatTableDataSource(stats);
    }

    ngOnInit() {
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

export interface OverviewStats {
    reconID: number;
    source: string;
    cdsBusinessDate: Date;
    reference: string;
    srcReference: string;
    tradeDate: Date;
    expiryDate: Date;
    settlementDate: Date;
    cif: number;
    product: string;
    notional: number;
    mtm: string;
    logEvent: string;
    comment: string;
}

function createOverview(id: number): OverviewStats {

    const stats: OverviewStats = {
        reconID: id,
        source: 'BNKT',
        cdsBusinessDate: new Date('2018-05-14'),
        reference: 'BNKT_M619252000',
        srcReference: 'M619252000',
        tradeDate:  new Date('Feb 15 2018 12:00AM'),
        expiryDate:  new Date('Feb 15 2018 12:00AM'),
        SettlementDate: new Date('Feb 15 2018 12:00AM'),
        cif: 0,
        product: 'N/A',
        notional: 56000000,
        mtm: null,
        logEvent: 'LogFilter',
        comment: 'LogFilter: BNKT_M560348000 filtered. Invalid Trade Indicator from Source'
    };
    return stats;
}


