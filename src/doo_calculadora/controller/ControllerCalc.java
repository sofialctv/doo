package doo_calculadora.controller;

import model.dto.RequestDTO;
import doo_calculadora.Calculadora;

public class ControllerCalc {

    public int Calcular(RequestDTO requestDTO){
        Calculadora calculadora = new Calculadora();
        int result = calculadora.calcular(requestDTO.getOpcao(), requestDTO
    }

}
