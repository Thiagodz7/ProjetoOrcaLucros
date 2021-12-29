import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { OrcamentosService } from '../shared/orcamentos.service';
import { Orcamentos } from '../shared/orcamentos.model';

@Component({
  selector: 'app-orcamentos',
  templateUrl: './orcamentos.component.html',
  styleUrls: ['./orcamentos.component.css']
})
export class OrcamentosComponent implements OnInit {

  constructor(public toastr : ToastrService, public serviceOrcamentos : OrcamentosService) { }

  ngOnInit(): void {
  }

  orcamentos : Array<string> = ['Id','SaldoInicial','Entrada','Saida','DtEntrada','DtSaida','ValorFinal']

}
