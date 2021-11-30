package IntroductionToJavaHW;

import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class WorkShop {
    public static void main(String[] args) {

        String password;
        Scanner scanner = new Scanner(System.in);
        password= scanner.next();
        int nums[] = new int[password.length()];
        Random random = new Random();
        for (int i =1;i<=nums.length;i++)
            nums[i-1]= Math.abs(random.nextInt()%i) ;

        String star;
        System.out.println(stars(0,nums.length));
        for (int i =1;i<=nums.length/2+1;i++){
            star = stars(i,nums.length);
            System.out.println(password.substring(0,i)+star+password.substring(i== nums.length/2+1 ?i:password.length()-i,password.length()));
        }
        System.out.println(Arrays.toString(nums));
    }

    private static String stars(int i,int length){
        int j=0;
        String star ="";
        while (j<length-(i*2)){
            star +='*';
            j++;
        }

        return star;
    }
}
