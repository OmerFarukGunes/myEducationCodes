package Loops;

public class Loops {
    public static void main(String[] args) {
        for (int i = 0 ; i<10; i++)
            System.out.println(i);
        int i =0;
        while(i<10){
            System.out.println(i);
            i++;
        }
        i=0;
        don:
        do {
            System.out.println(i);
            i++;
            break don;
        }while (i<10);
    }
}
