package com.mycompany.teststrategy;

import MainClasses.Cart;
import MainClasses.Mobile;
import MainClasses.Online;

public class TestStrategy {
    
    public static void main(String[] args) {
        
        Cart cart = new Cart(1512.75);
        cart.pay(new Online("miguellicauco@gmail.com", "hamburger123"));
        
        cart = new Cart(375.25);
        cart.pay(new Mobile("+639153672125", 0413));
        
    }
    
}