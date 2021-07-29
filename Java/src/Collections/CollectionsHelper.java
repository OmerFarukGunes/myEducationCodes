package Collections;

import java.util.Collections;
import java.util.Comparator;

public class CollectionsHelper {
    public static void main(String[] args) {
        Student student = new Student(1,"omer");
        Student student2 = new Student(1,"omerf");
        Student student3 = new Student(1,"omerfg");
        java.util.ArrayList<Student> students = new  java.util.ArrayList<>();
        students.add(student);
        students.add(student2);
        students.add(student3);
        Student maxOgr = Collections.max(students, new Comparator<Student>(){
            @Override
            public int compare(Student o1,Student o2) {
                if(o1.name.compareTo(o2.name)<0)
                    return -1;
                else
                    return  1;
            }
        });
        System.out.println(maxOgr);
        int result = Collections.binarySearch(students,student);
        System.out.println(result);
        Collections.reverse(students);
        System.out.println(students);
    }
}
class  Student implements  Comparable<Student>{
    int id;
    String name;

    @Override
    public String toString() {
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                '}';
    }

    public Student(int id, String name) {
        this.id = id;
        this.name = name;
    }

    @Override
    public int compareTo(Student o) {
        if(o.name.compareTo(o.name)<0)
            return -1;
        else
            return  1;
    }
}
