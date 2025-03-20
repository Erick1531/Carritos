// no me da la logicaaa

public class Nodo{
public object Valor1{ get; set; }

public object Valor2 {get; set;}

public Nodo Siguiente {get; set;}

public Nodo(object codigo, object tipo){
    Valor1 = codigo;
    Valor2 = tipo;
    Siguiente = null;
}

}// Nodo