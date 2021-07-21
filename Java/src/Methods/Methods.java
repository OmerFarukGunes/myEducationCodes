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
        for (;;){
            secim= select();
            if (secim==0){
                break;
            }
            else
                System.out.println("secim: "+ secim);
        }
    }
    private static  int select(){
        Scanner text = new Scanner(System.in);
        return text.nextInt();

    }
    public  static  void change (int x){
        x+=10;

    }
    public static int sum(int a,int b){
        return a+b;
    }
    public  static  void sayHi(){
        System.out.println("hi");
    }
}
