package com.mycompany.testproject2;

import MainClasses.Laptop;
import MainClasses.LaptopFactory;

public class TestProject2 {

    public static void main(String[] args) {
        
        Laptop min = LaptopFactory.getSpecs("min", 8, 256, "i5-12450Hz");
        Laptop reco = LaptopFactory.getSpecs("reco", 16, 512, "i7-12700hz");
        
        System.out.println("Minimum Specs:");
        System.out.println(min);
        
        System.out.println("Recommended Specs:");
        System.out.println(reco);
        
    }
    
}
