package Methods;

import java.util.Scanner;
public class Methods {

    public static void main(String[] args) {
        sayHi();
        System.out.println(sum(4,3));
        int num=5;
        change(num);
        int secim;
        System.out.println(num);
        for (;;) {
            secim = select(5);
            if (secim == 0) {
                break;
            } else
                System.out.println("secim: " + secim);
        }
    }
    private static  int select(int b){
        Scanner text = new Scanner(System.in);
        return 0;

    }
    public  static  void change (int x){
        x+=10;
        System.out.println(x);
    }
    public static int sum(int a,int b){
        return a+b;
    }
    public  static  void sayHi(){
        System.out.println("hi");
    }
}
