package Collections;

import java.util.Stack;

public class UsinggStack {
    public static void main(String[] args) {
        Stack<String> objects = new Stack<>();
        //first on last out
        objects.add("omer");
        objects.add("omerf");
        objects.add("omerfg");
        System.out.println(objects.pop());
        //peek en sondaki elemani gosterir ama stackten cikarmaz
        System.out.println(objects.peek());
        objects.push("ekle");
        System.out.println(objects);
        System.out.println(objects.search("ekle"));
        System.out.println(objects.empty());
    }
}
