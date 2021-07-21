package OOP;

public class Static {
    public static void main(String[] args) {
        Officer o1 = new Officer();
        Officer o2 = new Officer();
        o1.setName("sa");
        o2.setName("as");
        o1.show();
    }
}
class Officer{
    private String name;
    private int salary;
     static private int totalOfficer;
    //static deger nesneye bagli degil sinifa bagli deger olur ve bir degisiklik oldugu zaman tum objelerde gecerli olur.
    public Officer(){
        totalOfficer ++;
    }
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getSalary() {
        return salary;
    }

    public void setSalary(int salary) {
        this.salary = salary;
    }
    public void show(){
        System.out.println(totalOfficer);
    }
}
