package IntroductionToJavaHW;


class Sports{
    public void m1(){
        System.out.print("Play ");
    }
    public void m2(){
        System.out.print("Fair ");
    }

    @Override
    public String toString() {
        return  "Oley ";
    }
}
class Basketball extends Sports{
    public  void m2(){
        super.m2();
        System.out.print("Basketball ");
    }
}
class Team extends Basketball{
    public void m2() {
        super.m2();
        System.out.print("Blue ");
    }

    @Override
    public String toString() {
        return "Team "+ super.toString();
    }
}
public class Test {
    public static void main(String[] args) {
    Sports[]f ={new Sports(),new Basketball(),new Team()};
    f[2].m1();
        System.out.println();
    f[2].m2();
        System.out.println();
    System.out.print(f[2].toString());

    }
}
