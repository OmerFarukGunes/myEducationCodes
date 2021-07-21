package OOP;

public class Student {
   private int no;
    private String name;
    private byte grade;
    private boolean active;

    public void setNo(int no){
        this.no = no;
    }
    public int getNo(){
        return this.no;
    }

    public  Student(boolean status){
        this.active = status;
    }
    public Student(){
        //constructordan const cagiracaksan eger ust kisma yazip cagirman lazim onu

        this(true);
        System.out.println("Created");
    }
    public Student(int no, byte grade, boolean active, String name){
        this(active);
        this.no = no;
        this.grade = grade;
        this.name = name;
    }

    public void getLesson(){
        System.out.println("getLesson");
    }
    public  void get(){
        if (active)
        System.out.println(name + " " + grade + " "+ no);
        else
            System.out.println("passive");
    }
}
