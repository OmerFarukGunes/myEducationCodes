package Collections;

import java.util.Collections;
import java.util.Enumeration;
import java.util.Vector;

public class UsingVector {
    public static void main(String[] args) {
        //arraylist gibi dinamik olarak artan bir dizi gibidir. vectorda tek bir threat islem yapar yani diger islemler
        //sirada bekler synchronizedtir.
        Vector<String>cities=new Vector<>();
        cities.add("Bursa");
        cities.add("Bursa");
        cities.add("Bursa");

        //listelerle ayni kullanima sahhiptir.
        System.out.println(cities.capacity());

        //iteratorin vectorlar icin olani aslinda bunda da iteratorda kullanabilirsin.
        Enumeration<String>enumeration = cities.elements();
        while (enumeration.hasMoreElements())
            System.out.println(enumeration.nextElement());
    }
}
