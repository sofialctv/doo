package doo_calculadora;

import model.dto.RequestDTO;

import java.util.Scanner;

public class Menu {
    public void show() {
        System.out.println("Olá Meu fi!");
        System.out.println("Escolha uma das opção:");
        System.out.println("1 - Somar");
        System.out.println("2 - Subtrair");
        System.out.println("3 - Multiplicar");
        System.out.println("4 - Dividir");
        System.out.println("5 - Vá embora ...");
    }

    public void RequestDTO retriveValue(){
        Scanner scanner = new Scanner(System.in);
        int opcao = scanner.nextInt();
        System.out.println("Informe o valor 1:");
        int valor1 = scanner.nextInt();
        System.out.println("Informe o valor 2:");
        int valor2 = scanner.nextInt();

        return new RequestDTO((opcao, valor1, valor2));
    }

    public void showResults(RequestDTO requestDTO){
        System.out.println("Resultado:" + requestDTO.getResult());
    }
}
