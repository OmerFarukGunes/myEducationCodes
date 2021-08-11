package LambdaExpression;

public class LambaExpression {
    public static void main(String[] args) {
    new Thread(new ThreadClass()).start();
    new Thread(new Runnable() {
        @Override
        public void run() {
            System.out.println("anonim");
        }
    }).start();
    //yukaridakiyle asagidaki islem birebir aynidir
    new Thread(()->System.out.println("anonim lambda")).start();
    }
}
class ThreadClass implements Runnable{
    @Override
    public void run() {
        System.out.println("run");
    }
}