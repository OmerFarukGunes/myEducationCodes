package OOP;

public class AbstractClasses {
    public static void main(String[] args) {
        Geometric geo = new SquareObject();
        geo.setX(5);
        geo.calculate();
    }
}
abstract class Geometric{
    private int x;
    //her seklin bir kenari en az vardir peki ya bu sekil dikdortgen veya ucgense ?
    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }
   abstract public void calculate();
   abstract public void calculate2();
}
class SquareObject extends Geometric{


    @Override
    public void calculate() {
        System.out.println(getX()*4);
    }
    @Override
    public void calculate2() {
        System.out.println(getX()*getX());
    }
}
