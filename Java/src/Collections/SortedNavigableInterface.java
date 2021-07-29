package Collections;

import java.util.Iterator;
import java.util.TreeMap;
import java.util.TreeSet;

public class SortedNavigableInterface {
    public static void main(String[] args) {
        //treeset ve treemap icin gecerlidir.
        TreeMap<String,Integer> treeMap = new TreeMap<>();
        TreeSet<String>treeSet = new TreeSet<>();
        treeSet.add("1");
        treeSet.add("2");
        treeSet.add("3");
        treeSet.add("4");
        treeMap.put("1",1);
        treeMap.put("2",2);
        treeMap.put("3",3);
        treeMap.put("4",4);

        System.out.println(treeMap.comparator());
        System.out.println(treeSet.comparator());
        TreeSet<String> tempSet = (TreeSet<String>) treeSet.subSet("2","4");
        System.out.println(tempSet);
        System.out.println(treeMap.subMap("2","4"));
        System.out.println(treeSet.headSet("5"));//olmayan eleman koyarsan herseyi yazzar treemaptede oyle
        System.out.println(treeMap.headMap("3"));
        System.out.println(treeSet.tailSet("2"));
        System.out.println(treeMap.tailMap("3"));
        System.out.println(treeMap.firstKey());
        System.out.println(treeSet.first());
        System.out.println(treeMap.lastKey());
        System.out.println(treeSet.last());

        System.out.println(treeSet.lower("3"));//3 ten kucuk en buyuk deger
        System.out.println(treeMap.lowerKey("3"));
        System.out.println(treeSet.floor("3"));//verilen key degerine esit veya ondan bir kucuk olan degeri verir.
        System.out.println(treeMap.floorKey("3"));
        //higher hhalide vardir.
        System.out.println(treeSet.ceiling("3"));//verilen key degegrine esit veya ondan bir buyuk olan
        System.out.println(treeMap.ceilingKey("3"));
        System.out.println(treeSet.pollFirst());// ilk elemani verir ve yapidan siler.
        System.out.println(treeSet.pollLast());

        Iterator<String> iterator=treeSet.descendingIterator();
        while (iterator.hasNext())
            System.out.println(iterator.next());

    }

}
