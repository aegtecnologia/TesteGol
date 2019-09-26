export class Aeronave {
    id :number;
    codigo: string='';
    modelo:string='';
    passageiros: number;
    dataCriacao: Date;
    dataAlteracao: Date;

    constructor(values: Object={}){
        Object.assign(this,values);
    }
}
