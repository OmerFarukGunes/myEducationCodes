package OOP.Acces;

public class ProtectedClass {
//sinif protected olamaz. Protected yapinca pakkete ozgu kullanilabilir ve kalitim olarak alinmasina izin verilir.
    protected int num;
    protected void  protectedMetot(){

    }
    protected class InnerProtectedClass{

    }
}
//
class Y extends ProtectedClass{
    @Override
    protected void protectedMetot() {
        super.protectedMetot();
    }
}
