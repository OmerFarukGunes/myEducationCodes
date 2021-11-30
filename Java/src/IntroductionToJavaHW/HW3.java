import java.util.Scanner;

public class HW3{
    public static void main(String[] args) {
        int number;
        Scanner screen = new Scanner(System.in);
        System.out.print("Enter number: ");
        number = screen.nextInt();
        for (int i = 1; i <=number; i++) {
            for (int j = 1; j <= number; j++) {
                if (i%j == 0 || j%i == 0)
		        {
                System.out.print("* ");
		        }
                else
		        {
		        System.out.print("  " );
		        }
            }
            System.out.println(i);
            System.out.println();
        }
    }
}