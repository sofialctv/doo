import java.util.Scanner;
import Ap

public class Main {
    public static void main(String[] args) {

        Menu menu = new menu();

        System.out.println("Olá Meu fi!");
        System.out.println("Escolha uma das opção:");
        System.out.println("1 - Somar");
        System.out.println("2 - Subtrair");
        System.out.println("3 - Multiplicar");
        System.out.println("4 - Dividir");
        System.out.println("5 - Vá embora ...");
        Scanner input = new Scanner(System.in);
        int opcao = input.nextInt();
        System.out.println("Informe o primeiro valor:");
        int valor1 = input.nextInt();
        System.out.println("Informe o segundo valor:");
        int valor2 = input.nextInt();
        int resultado = -1;
        switch (opcao) {
            case 1:
                resultado = valor1 + valor2;
                break;
            case 2:
                resultado = valor1 - valor2;
                break;
            case 3:
                resultado = valor1 * valor2;
                break;
            case 4:
                resultado = valor1 / valor2;
                break;
        }
        if (resultado == -1){
            System.out.println("T+");
        }
        else{
            System.out.println("O Resultado eh "+resultado);
        }



    }
}