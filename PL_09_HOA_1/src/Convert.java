public class Convert {
    public static void main(String[] args) {
        
        Adder adder = new Adder(0);
        adder.addNum(10);
        adder.addNum(20);
        adder.addNum(30);
        
        int total = adder.getTotal();

        System.out.println("Total: " + total);
    }
}
