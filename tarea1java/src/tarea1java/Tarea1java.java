
package tarea1java;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Tarea1java {

    
    public static void main(String[] args) {
        Scanner entrada=new Scanner(System.in);
        System.out.print("Ingresa tu nombre: ");
        String nom=entrada.nextLine();
        System.out.print("Ingresa la cantidad a convertir: Q.");
        int monto=entrada.nextInt();
        System.out.println("\t\nIngresa el numero de la opcion ha convertir");
        System.out.println("1. Dolar\n2. Euro\n3. Yuan");
        byte opcion=entrada.nextByte();
        
        double mostrarNum;
        DecimalFormat format = new DecimalFormat("#.0000");

        switch (opcion){
            
            case 1 -> {
                mostrarNum=monto*0.12924298;
                System.out.println(nom+", Q."+monto+".00 equivale a "+format.format(mostrarNum)+" dolares");
            }
            
            case 2 -> {
                mostrarNum=monto*0.1094044;
                System.out.println(nom+", Q."+monto+".00 equivale a "+format.format(mostrarNum)+" euros");
            }
            
            case 3 -> {
                mostrarNum=monto*0.83470644;
                System.out.println(nom+", Q."+monto+".00 equivale a "+format.format(mostrarNum)+" yuanes");
            }
                
        }
      
    }
    
}
