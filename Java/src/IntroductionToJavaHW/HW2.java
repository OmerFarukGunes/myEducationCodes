package IntroductionToJavaHW;
import java.util.ArrayList;
import java.util.Random;
public class HW2 {
    public static void main(String[] args) {
        ArrayList<String>days= new ArrayList<String>(){{
                add("Monday");
                add ("Tuesday");
                add ("Wednesday");
                add ("Thursday");
                add ("Friday");
                add ("Saturday");
                add ("Sunday");
        }};
        Random rd = new Random();
        int value = (int)(1+(Math.random()*7));
        System.out.println(value +". " + days.get(value-1));
    }
}
