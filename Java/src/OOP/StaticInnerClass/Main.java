package OOP.StaticInnerClass;

public class Main {
    public static void main(String[] args) {
        DefaultClass defaultClass= new DefaultClass();
        defaultClass.obj=5;
        defaultClass.metot();
        defaultClass.statikMetot();

        DefaultClass.InnerClass innerClass = new DefaultClass.InnerClass();
        innerClass.innerObj=5;
        innerClass.inentMetot();
        DefaultClass.InnerClass.innerStatikMetot();
        DefaultClass.InnerClass.innerStaticObj=10;

    }
}
