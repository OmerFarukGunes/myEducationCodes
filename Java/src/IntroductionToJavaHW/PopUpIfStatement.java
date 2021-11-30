package IntroductionToJavaHW;
import java.util.Random;
import java.util.Scanner;

public class PopUpIfStatement {
    public static void main(String args[])
    {
        int number1,number2,temp;
        Random rnd = new Random();
        number1 =(int)(Math.random()*9);
        number2 = (int)(Math.random()*9);
        if (number1<number2){
            temp=number1;
            number1=number2;
            number2=temp;
        }
        System.out.print("What is "+ number1+"-"+number2+" ?");
        Scanner Result = new Scanner(System.in);
        temp=Result.nextInt();
        if (temp != number1-number2)
            System.out.println("false");
        else
            System.out.println("true");

    }
}
