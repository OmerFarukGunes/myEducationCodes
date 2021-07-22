package OOP;

import java.util.Objects;

public class Equals {
    public static void main(String[] args) {
        Object p = new Person(5,"Omer");
        Person p2 = new Person(5,"Omer");
        System.out.println(p);
        System.out.println(p2);

        //burada esitlik olmazz cunku ikisinin bulundugu adresler farklidir normalde ama equals metodunda bu referans atamasi yapilmaktadir.
        System.out.println(p.equals(p2));
        p=p2;
        //ama bi esitlik saglarsaniz iki objede ayni adresi referans eder ve esit olur
        System.out.println(p.equals(p2));
        System.out.println(p.hashCode() +" " + p2.hashCode());
        //gorundugu gibi hashcodelar aynidir.
        Epmloyee e = new Epmloyee(5,"Omer");
        //gonderdigin obje onemli degil.
        System.out.println(p.equals(e));

        String name = "emre";
        String  name2 ="emre";
        //stringler istisnadir yani iki obje ayni adresi refere etmesede degerler karsilistirilir.
        System.out.println(name.equals(name2));
        //ayni sekilde wrapper siniflarda istisnadir.
        Integer num = new Integer(1);
        Integer num2 = new Integer(1);
        System.out.println(num.equals(num2));
    }
}
class  Person{
    int id;
    String name;

    public Person(int id, String name) {
        this.id = id;
        this.name = name;
    }
    @Override
    public String toString(){
        return id+" " + name;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Person person = (Person) o;
        return id == person.id && name.equals(person.name);
    }

    @Override
    public int hashCode() {
        return Objects.hash(id, name);
    }
}
class Epmloyee{
    int id;
    String name;

    public Epmloyee(int id, String name) {
        this.id = id;
        this.name = name;
    }
}