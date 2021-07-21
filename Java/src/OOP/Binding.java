package OOP;

public class Binding {
    public static void main(String[] args) {
        Top.tell();
        Bottom.tell();
        Top t = new Top();
        t.tell();
        t.show();
        Bottom b = new Bottom();
        b.tell();
        b.show();

        Top tb = new Bottom();
        //peki yukarida her biri kendi tell metodunu cagirdi peki ya bu tb ?
        //burada alt sinifta override edilemeyen bir static metod calistigi icin ana siniftaki metoda bakilir. Ana metodda bu static kod yoksa hata alir.
        tb.tell();
        //static olmayan metodda ise alt sinifta override edilen metod cagirilir.
        tb.show();
    }
}
class Top{
    public static void tell(){
        System.out.println("top");
    }
    public  void show(){
        System.out.println("tops");
    }
}
//static metodlar inherit olsa bile override edilemez.
//asagidaki metod yukaridakinden bagimsizdir.
class Bottom extends Top{
    public static void tell(){
        System.out.println("Bottom");
    }
    @Override
    public  void show(){
        System.out.println("Bottoms");
    }
}