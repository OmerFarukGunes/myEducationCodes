package Collections;

import java.util.LinkedList;
import java.util.ListIterator;

public class UsingLinkedList {
    public static void main(String[] args) {
        LinkedList<Integer> numbers = new LinkedList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);
        numbers.add(8);
        numbers.add(7);
        numbers.add(4);
        numbers.add(6);
        numbers.add(5);
        //neredeyse hersey ayni listede burada her deger hhead node ve next olarak tutulur.
        System.out.println(numbers);
        numbers.set(1,19);
        ListIterator<Integer> iter = numbers.listIterator();
        while (iter.hasNext())
            System.out.println(iter.next());

        //orta kisimlara ekleme yaparsan arraylistte yavas ancak linked listte daha hizli
        //arraylistte eleman bulma index bazli oldugundan daha hizlidir.
        //rastgelee elemana erilimekte kullanilamaz.
        //stack ve queue olarak kullanilabilir.
        //linked list array liste gore addresste tuttuguu icin daha fazla alan tutar.
        //cok fazla ekleme cikarma varsa linked list kullanmak dahha mantiklidir.
        //genel olarak ayni metodlara sahihp olsalarda kullanim sekli ve arkaplan islemleri farklidir.
    }
}
