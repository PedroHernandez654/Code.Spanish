public class Main {
    public static void main(String[] args) {
        //Primera Parte
        int resultado = 0;
        resultado = suma(1,2,3);
        System.out.println(resultado);
        //Segunda Parte
        Coche coche =  new Coche();
        coche.AumentarPuertas();
        System.out.println(coche.puertas);
    }
//Primera Parte
    public static int suma(int a, int b, int c){
        return a + b + c;
    }
}
//Segunda Parte
class Coche{
    public int puertas = 0;
    public  void AumentarPuertas(){
        this.puertas++;
    }
}