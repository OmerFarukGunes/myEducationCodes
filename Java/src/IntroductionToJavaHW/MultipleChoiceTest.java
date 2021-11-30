
import java.util.Random;

public class MultipleChoiceTest {
    public static void main(String[] args) {
        char answers[] = {'a','b','d','e','c','a','e','b','a','d'};
        char studentAnswers[][] = new char[10][10];
        String options ="abcde";
        Random rnd = new Random();
        int scores[]={0,0,0,0,0,0,0,0,0,0};
        System.out.println("Answers: ");
        for (int i =0;i<10;i++)
            System.out.print(i+1+": "+answers[i]+" ");
        System.out.println("\nStudent grades: ");
        for (int i = 0;i<10;i++){
            System.out.print("Student "+i+" ");
            for (int j = 0;j<10;j++){
                studentAnswers[i][j]= options.charAt(rnd.nextInt(options.length()));
                if (studentAnswers[i][j]==answers[j])
                    scores[i] += 10;
                System.out.print(j+1+": "+studentAnswers[i][j]+" ");
            }
            System.out.println("Grade= "+ scores[i]);
        }
    }
}
