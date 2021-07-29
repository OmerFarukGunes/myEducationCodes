package Collections;

import OOP.Student;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Queue;

public class UseQueue {
    public static void main(String[] args) {
        //null deger alamazz ilk giren ilk cikar
        java.util.Queue<Integer>numbers= new LinkedList<>();
        //linked list objesini queue gibi calistirabilirsin.
        numbers.offer(5);
        numbers.add(2);
        numbers.offer(4);
        numbers.offer(3);
        System.out.println(numbers.peek());
        System.out.println(numbers.poll());//kuyrugun basindaki elemani alir ve cikarir.
        System.out.println(numbers.remove());//eger olmayan deegri cikarmaya kalkarsan remove olarak patlar. ama poll ile olamayan
        //degeri cikarmaya calisirsin null doner.

        PriorityQueue<String>names = new PriorityQueue<>();
        names.offer("aOmer");
        names.offer("cOmerf");
        names.offer("bOmerfg");
        names.offer("eOmerfgh");
        names.offer("gOmerfgh");
        names.offer("dOmerfgh");
        Iterator<String>iterator = names.iterator();
        while (iterator.hasNext())
            System.out.println(iterator.next());
        //normalde bunun siralanmasi lazim ama bunu sana java garanti etmiyor !
        while (!names.isEmpty())
            System.out.println(names.poll());
        //ancak cikardigin zaman sirali bir sekilde cikartir.

        PriorityQueue<StudentClass> std = new PriorityQueue<>();
        std.offer(new StudentClass(1,10));
        std.offer(new StudentClass(5,20));
        std.offer(new StudentClass(7,15));
        std.offer(new StudentClass(4,40));
        std.offer(new StudentClass(6,30));
        //buurada neye gore oncelik verecegini belirlemen lazim.comparable ile yapabilirsin

        System.out.println(std);
        //yine anca cikarma islemi yaparken sirali goreblilirsin
        while (!std.isEmpty())
            System.out.println(std.poll());
        //yine olmadi :D
    }
}
class StudentClass implements Comparable<StudentClass>{
    int id;
    int grade;

    public StudentClass(int id, int grade) {
        this.id = id;
        this.grade = grade;
    }

    @Override
    public int compareTo(StudentClass o) {
        if (this.grade>o.grade)
            return 1;
        else if(this.grade < o.grade)
            return -1;
        else
            return 0;
    }

    @Override
    public String toString() {
        return "StudentClass{" +
                "id=" + id +
                ", grade=" + grade +
                '}';
    }
}
