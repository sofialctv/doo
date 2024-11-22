package doo_calculadora.view;

import doo_calculadora.Menu;
import model.dto.RequestDTO;

public class Application {
    public static void main(String[] args){
        Menu menu = new Menu();
        menu.show();
        RequestDTO requestDTO = menu.new dto.RequestDTO();
    }
}
