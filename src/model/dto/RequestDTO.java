package model.dto;
public class RequestDTO {

    private int opcao: opcao;
    private int valor1: valor1;
    private int valor2: valor2;

    public RequestDTO(int opcao, int valor1, int valor2){
        this.opcao = opcao;
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public int getOpcao(){
        return opcao;
    }

}
