import { NumericLiteral } from "typescript";
import { Persona } from "./persona";

export class Pago {
    constructor(){
        this.persona = new Persona();
    }
    persona:Persona;
    tipo:string;
    fecha:Date;
    valor:number;
    iva:number;
}
