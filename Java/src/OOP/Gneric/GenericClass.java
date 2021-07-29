package OOP.Gneric;

import java.util.ArrayList;

public class GenericClass {
    public static void main(String[] args) {
        String[] names= {"omer","ali","osman"};
        Integer [] nums={1,2,3,23,45};
        Print.main(names);
       // PrintInt.printInt(nums);
        //her seferinda farkli sekilde sinif olusturup yazdirdik. Daha easy si var
        GenericPrint<String> stringGenericPrint = new GenericPrint<>();
        stringGenericPrint.print(names);

        GenericPrint<Integer> genericPrint = new GenericPrint<>();
        genericPrint.print(nums);
        //bu sekilde iki farkli class yazmaak yerine veri turunden bagimsiz islemlerini yapabilirsin.

        ArrayList List = new ArrayList();
        List.add("ankara");
        List.add(1);
        List.add(true);
        List.add(5.4);
        //for dongusunu obje olarak yaparsan listedeki tum elemanlari gezebilirsin.
        for (Object ob : List)
            System.out.println(ob);
    }
}
