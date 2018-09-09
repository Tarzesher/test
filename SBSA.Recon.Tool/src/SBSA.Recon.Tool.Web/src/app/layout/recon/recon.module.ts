import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule, MatFormFieldModule,
  MatPaginatorModule, MatInputModule } from '@angular/material';

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
