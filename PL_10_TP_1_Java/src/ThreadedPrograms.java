import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class ThreadedPrograms {

    public static void main(String[] args) {

        ExecutorService executor = Executors.newFixedThreadPool(6);

        for (int i = 0; i < 6; i++) {
            Runnable task = new Task();
            executor.submit(task);
        }

        executor.shutdown();

    }

    static class Task implements Runnable {
        @Override
        public void run() {

            System.out.println("Executing the task on thread: " + Thread.currentThread().getName());

            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}


        
