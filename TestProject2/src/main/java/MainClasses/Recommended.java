package MainClasses;

public class Recommended extends Laptop {
    
    private int ram;
    private int ssd;
    private String cpu;
    
    public Recommended(int ram, int ssd, String cpu) {
        
        this.ram = ram;
        this.ssd = ssd;
        this.cpu = cpu;
        
    }
    
    public int getRAM() {
        
        return ram;
        
    }
    
    public int getSSD() {
        
        return ssd;
        
    }
    
    public String getCPU() {
        
        return cpu;
        
    }
    
}
