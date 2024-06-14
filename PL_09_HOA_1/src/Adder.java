public class Adder {

    private int total;

    public Adder(int a) {
        total = a;
    }

    public void addNum(int number) {
        total += number;
    }

    public int getTotal() {
        return total;
    }

}
