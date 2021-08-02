package Exceptions;

public class ThrowExc {
    public static void main(String[] args) {
        System.out.println(returnValueMetod());
    }
    private static String returnValueMetod(){
        String hi = "hi";
        try {
            hi = hi +" try";
            return hi; //buradaki return finally calismak zorunda oldugu icin calismayacaktir
            //ArithmeticException e = new ArithmeticException();
           // throw e; bu sekilde yapabilirdin. throw firlatir catche gider.
        }
        catch (Exception e){
            hi = hi + " catch";
            return  hi;
        }
        finally {
            hi +=" finally";
            //finally kisminda return olmak zorunda degil.
        }
       // try {
        //    if (1<0){
        //        throw  new SpecialThrow("Error");
       //         //bu sekilde kendi exceptionlarini olusturabilirsin
       //     }
      //  }catch (Exception e){
       //     System.out.println(e);
       // }
    }

    //classlarda metotlarda da try catc kullanilabilir.
}
class SpecialThrow extends Exception{
    String errorMessage;

    public SpecialThrow(String errorMessage) {
        this.errorMessage = errorMessage;
    }

    @Override
    public String toString() {
        return errorMessage;
    }
}