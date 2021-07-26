package OOP.Acces;

public class DefaultOrPackage {
    int num = 5;
    void metot(){

    }
    class InnerClass{

    }
}
class x extends DefaultOrPackage{
    @Override
    void metot() {
        super.metot();
        System.out.println(num);
    }
}
