import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material';
import { MatFormFieldModule, MatPaginatorModule } from '@angular/material';
import { MatInputModule } from '@angular/material';

import { ReconRoutingModule } from './recon-routing.module';
import { ReconComponent} from './recon.component';

@NgModule({
  imports: [
    CommonModule,
    ReconRoutingModule,
    MatTableModule,
    MatFormFieldModule,
    MatPaginatorModule,
    MatInputModule
  ],
  declarations: [ReconComponent]
})
export class ReconModule { }
