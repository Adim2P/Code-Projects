package MainClasses;

public class Online implements Payment {
    
    private String email;
    private String password;
    
    public Online(String email, String password) {
        
        this.email = email;
        this.password = password;
        
    }
    
    public void pay(double amount) {
        
        System.out.println("Paid using online account: " + amount);
        
    }
    
}
