package Details;

public class StringInfo {
    public static void main(String[] args) {
        String abc= "abc";
        String def = abc;
        abc+="fg";
        System.out.println(abc);
        System.out.println(def);
        def+="123";
        System.out.println(def);
        System.out.println(abc);

    }
}
