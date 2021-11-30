package IntroductionToJavaHW;
import java.util.Scanner;
public class SumOfDigits {
    public static void main(String args[])
    {
        int number, digit, sum = 0;
        Scanner screen = new Scanner(System.in);
        System.out.print("Enter the number between 0 and 1000: ");
        number = screen.nextInt();
        while (number> 1000 || number < 0)
        {
            System.out.print("Enter the number between 0 and 1000:");
            number = screen.nextInt();
        }
        while(number > 0)
        {
            digit = number % 10;
            sum = sum + digit;
            number = number / 10;
        }
        System.out.println("The sum of the Digits: "+sum);
    }
}
