import { Injectable } from '@angular/core';
import { Orcamentos } from './orcamentos.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrcamentosService {

  readonly baseURL = 'https://localhost:44331/api/Orcamentos';
  list : Orcamentos[] | undefined
  formData : Orcamentos = new Orcamentos();

   constructor(private http: HttpClient) { }

   postClient(){
     return this.http.post(this.baseURL,this.formData)
    }

    refreshList(){
      this.http.get(this.baseURL)
      .toPromise()
      .then(res => this.list = res as Orcamentos[])
    }
}
