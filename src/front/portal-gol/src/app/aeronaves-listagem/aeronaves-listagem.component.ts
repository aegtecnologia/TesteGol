import { Component, OnInit } from '@angular/core';
import { AeronaveService } from '../aeronave.service';
import { Aeronave } from '../aeronave';

@Component({
  selector: 'app-aeronaves-listagem',
  templateUrl: './aeronaves-listagem.component.html',
  styleUrls: ['./aeronaves-listagem.component.css']
})
export class AeronavesListagemComponent implements OnInit {

  aeronaves: Aeronave[];

  constructor(private aeronaveService: AeronaveService) { }

  ngOnInit() {
    this.listar();
  }

  listar(){
    this.aeronaveService.Buscar().subscribe(dados => this.aeronaves = dados);
    console.log(JSON.stringify(this.aeronaves));
  }

}
