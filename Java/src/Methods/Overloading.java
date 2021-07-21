package Methods;

public class Overloading {
    public static void main(String[] args) {
        System.out.println(overloading(5,9));
        System.out.println(overloading(5.5,9.5));
    }

    public static int overloading(int a, int b) {
        return a+b;
    }
    public static double overloading(double a, double b) {
        return a+b;
    }
}
