package OOP;

public class MultipleInheritence {
    public static void main(String[] args) {
        Legend michael = new Legend();
        michael.dance();
        michael.Smoke();
        michael.sayMyName();
        Pop.staticMetot();
        System.out.println(Blues.yas);
        Singer singer= new Bluess();
        singer.sing();
    }
}
//interface newlenemezz.
//coklu kalitimi classlarla yapaman interfacelerle yapabilin.
abstract class Singer{
    abstract void sing();
}
//interfacceler birbirine extend edilebilir.
interface Blues{
    //metodlar default olarak publictir.
    void Smoke();
    //static veya final deger atanabilir yani int yas = 50 yaparsan bunun defaultuu static  final olur./
    static final int yas =50;

    default void sayMyName(){
        System.out.println("default atama yapincaaaa interface icerisinde tamamlanmis metod yapabilirsin. ve bu mutlaka implement edilmek zorunda degill");
    }
}
//interface in onunde abstarct vardir aslinda default olarak.
interface  Pop extends Blues{
    void dance();
    static void staticMetot(){
        System.out.println("static metodum ben interface icerisinde tanimlanabilir. Bunun sikintisi su bir sinif bu interi implement edince static metodlar implement edilemez override yapilamaz.");
    }
    @Override
    default void Smoke() {
        System.out.println("pop smoke");
    }
}
//public yaparsak interface i veya classi diger dosyalardan erisilebilir.
class Bluess extends  Singer{
    @Override
    void sing() {
        System.out.println("Blues");
    }
}
class Pops extends Singer{
    @Override
    void sing() {
        System.out.println("pop");
    }
}

class Legend implements Blues,Pop{
    @Override
    public void Smoke() {
        System.out.println("wow");
    }

    @Override
    public void dance() {
        System.out.println("dance");
    }
}