import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { Aeronave } from './aeronave';

@Injectable({
  providedIn: 'root'
})
export class AeronaveService {

  urlBase='http://localhost:4200/api/Airplane';

  aeronaves: Aeronave[] = [];

  constructor(private http: HttpClient) { }

  Buscar(){
    return this.http.get<Aeronave[]>(this.urlBase);
  }

  Salvar(aeronave: Aeronave){
    return this.http.post<Aeronave>(this.urlBase,aeronave);
  }
 
  Excluir(aeronave: Aeronave){
    return this.http.delete<Aeronave>(this.urlBase + "/" + aeronave.id);
  }

}
