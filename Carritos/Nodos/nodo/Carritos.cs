public class Carritos{
 public object Codigo { get; set; }
 public object Tipo { get; set; }

 public int Entradas { get; set; }

public int Salidas { get; set; }

public Carritos(object codigo, object tipo){
    Codigo = codigo;
    Tipo = tipo;
    Entradas = 0;
    Salidas = 0;
    }
}