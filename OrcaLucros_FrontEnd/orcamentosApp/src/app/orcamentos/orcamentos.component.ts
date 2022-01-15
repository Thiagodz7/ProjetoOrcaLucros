import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { OrcamentosService } from '../shared/orcamentos.service';

@Component({
  selector: 'app-orcamentos',
  templateUrl: './orcamentos.component.html',
  styleUrls: ['./orcamentos.component.css']
})
export class OrcamentosComponent implements OnInit {

  constructor(public toastr : ToastrService, public serviceOrcamentos : OrcamentosService) { }

  ngOnInit(): void {
    this.serviceOrcamentos.refreshList();
  }
}
