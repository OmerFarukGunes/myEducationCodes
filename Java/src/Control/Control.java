package Control;

public class Control {
    public static void main(String[] args) {
        if (20>10){
            System.out.println(true);
        }else if (20==10){
            System.out.println(true);
        }
        else
            System.out.println(true);

        int a = 10<5?10:5;
        System.out.println(a);

        switch (a){
            case 5:
                System.out.println("bitti");
                break;
            default:
                System.out.println("diriri");

        }
    }
}
