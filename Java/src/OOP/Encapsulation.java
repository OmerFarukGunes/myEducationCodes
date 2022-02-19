package OOP;

public class Encapsulation{

    public static void main(String[] args) {
        Student std = new Student(5,(byte)3,true,"omer");
        std.get();
        std.setNo(4);
        System.out.println(std.getNo());
    }
}
