package OOP.AnonymousClass;

public class AnonymousClass {
    public static void main(String[] args) {

        Calculator c = new Calculator();
        c.add(5,6);
        newCalculator newCalculator= new newCalculator();
        newCalculator.add(5,6);
        Calculator calculator = new  Calculator(){
            @Override
            public void add(int a, int d) {
                System.out.println("anonymous class budur. sadece tanimli oldugu objede gecerli olur classin tamamina etki etme");
                super.add(a, d);
            }
        };
        calculator.add(5,6);
        //abstract class icinde ayni seyi yapabilirsin. Interface te de ayni sekilde.
    }
}
class newCalculator extends Calculator{
    @Override
    public void add(int a, int d) {
        System.out.println("Iki Sayinin Toplami: ");
        super.add(a, d);

    }
}
