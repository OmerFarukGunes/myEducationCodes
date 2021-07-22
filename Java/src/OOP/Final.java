package OOP;

public class Final {
    public static void main(String[] args) {
        int num = 10;
        num=15;
        final int num2 = 50;
        //final degerler atanamaz. sabittir.
    }

}
final class Parent{
    //final olan bir class inherit edilemez.
}
class MyParent{
    final public  void show(){
        System.out.println("dene");
    }
}
class Child extends MyParent{
//    @Override
//    public void show() {
//        super.show();
//    }
    //final metodlar override edilemez. final metodlari oldugu gibi kullanmak zorundasin
    //finalda performans artisi saglar
}
