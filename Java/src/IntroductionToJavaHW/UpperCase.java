

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String str = input.nextLine();

        printCapitalized(str);

    }

    public static void printCapitalized( String str ) {
        for(int i = 0; i < str.length(); i++) {
            if(i != 0 && Character.isLetter(str.charAt(i-1))) {
                System.out.print(str.charAt(i));
                continue;
            }
            System.out.print(Character.toUpperCase(str.charAt(i)));
        }
    }
}
