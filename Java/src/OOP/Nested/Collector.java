package OOP.Nested;

public class Collector {
    private  int privateNum = 1;
    int defaultNum = 2;
    protected int protectedNum = 3;
    public  int publicInt =4;
    private void privateMetot(){}
    protected void protectedMetot(){}
    public void publicMetot(){}
    void defaultMetot(){}

     class StringPrinter{
        //inner classlarda static degiskenler olamaz static final degiskenler olabilir.
        static final int sayi = 51;
         void stringPrinter(String [] arr){
            System.out.println(privateNum);
            System.out.println(protectedNum);
            System.out.println(publicInt);


            for (String temp : arr)
                System.out.println(temp);

        }
         //bu tarz sinif tanimlamalarida yapilabilr.
         abstract class AbstractClass{}

         final class FinalAbstract{}
    }

}
