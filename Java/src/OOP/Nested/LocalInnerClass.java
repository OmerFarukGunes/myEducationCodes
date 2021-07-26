package OOP.Nested;

public class LocalInnerClass {
    public static void main(String[] args) {
        System.out.println(doDivide(5,6));
    }
    static{
        class Divide{
            //static deger taninamaz. static final olmasi gerek.
            public String Dividing(int i, int j){
                return "bolundu";
            }
        }
    }
    public static String doDivide(int num, int num1){
        class Divide{
            public String Dividing(int i, int j){
                return "bolme";
            }
        }
        Divide d = new Divide();
        String sonuc = d.Dividing(num,num1);
        return  sonuc;
    }
}
