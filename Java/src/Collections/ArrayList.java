package Collections;

import java.util.*;

public class ArrayList {
    public static void main(String[] args) {
        java.util.ArrayList <String> names= new java.util.ArrayList<>(100);
        java.util.ArrayList<Integer>numbers = new java.util.ArrayList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);
        names.add("omer");
        names.add("omerf");
        names.add("omerfg");
        names.add("omerfga");
        names.add("omerfgs");
        names.add("omerfasdfgs");
        //asagidaki olay ben buraya rahat 100 eleman eklicam en o kadar eleman ac de
        names.ensureCapacity(100);
        names.trimToSize();
        //trimtosize ise listede kac eleman varsa boyutunu o kadar yapiyor. Default liste boyutu 10 veya 20 dir
        java.util.ArrayList<String> temp = new java.util.ArrayList<>(names);
        System.out.println(temp);
        System.out.println(temp.size());
        System.out.println(temp.isEmpty());
        temp.clear();
        System.out.println(temp.isEmpty());
        System.out.println(names.contains("omer"));
        System.out.println(names.contains("omerfaruk"));

        String[] arr = names.toArray(new String[0]);//type castin yaparak diziye atama yapabilirsin.
        System.out.println(arr[0]);
        System.out.println(names.get(0));
        names.set(0,"new");
        System.out.println(names.get(0));
        names.remove("omerf");
        List<String> newList= names.subList(1,3);
        //List arraylistin ust sinifidir.
        System.out.println(newList);

        //alt katmani ust katmanda bulunan listeye atabilirsin
        Collections.addAll(newList,arr);
        System.out.println(newList);
        //dizi daha hili eleman degistirir cunku listede araya ekleme yapinca saga kayar degerler dizide oyle olmaz
        //yeni eleman eklemede liste daha hizli islem yapar.
        //arraylisti kullanmak daha iyi olabilir ama genel olarak.
        //.remove ile listeden eleman cikartilabilir.
        java.util.ArrayList<Integer>nums=new java.util.ArrayList<>() ;
        nums.add(1);
        nums.add(2);
        nums.add(23);
        nums.add(24);
        java.util.ArrayList<Integer>nums2=new java.util.ArrayList<>() ;
        nums2.add(1);
        nums2.add(2);
        nums2.add(23);
        nums2.add(24);
        nums2.trimToSize();
        Iterator<Integer> iter= nums.iterator();
        while (iter.hasNext())
            System.out.println(iter.next());
        //bu sekilde listede gezebilirsin

        ListIterator<Integer> listIterator = nums2.listIterator();
        // listelerde genelde bu kullanilir, iteratorlar hareketlidir ilk tanimlandiginda bastan baslar nerede birakirsan orada kalior
        while (listIterator.hasNext())
            System.out.println(listIterator.next());
        //geriye dogru gider. iteratorea baslangic indexi verebilirsin.
        while (listIterator.hasPrevious())
            System.out.println(listIterator.previous());
    }

}
