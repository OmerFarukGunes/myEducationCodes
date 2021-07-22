package OOP;

public class GarbageandFinalize {
    public static void main(String[] args) {
        //finalize ve garbage a guvenme bu kaldirildi
        A obj = new A(10);
        A obj2 = new A(12);

        obj = obj2;
        //obj nin tuttugu nesne artik cop oldu ve burada artik garbage calissin istiyoruz ve yok olsun istiyoruz
        //ancak maalesef biz bunu ayarlayamiyoruz garbage kendi kafasina gore cagiriyor
        for (int i = 0 ; i<1000;i++){
            obj=new A(12);
            //burada bile hher atamada garbage calismayabilir.
            if (i==10)
                System.gc();
            //ancak bu sekilde lutfen calis dersek calisir.
        }
    }
}
class A{
    int i;

    public A(int i) {
        this.i = i;
    }

    @Override
    protected void finalize() throws Throwable {
        System.out.println("finalize");
    }
}
