package Collections;

import java.util.Comparator;
import java.util.TreeMap;

public class UsingTreeMap {
    public static void main(String[] args) {
        TreeMap<String, Integer> treeMap = new TreeMap<>();
         treeMap.put("omer",1);
         treeMap.put("ali",2);
         treeMap.put("ayse",3);
         treeMap.put("asli",4);
        System.out.println(treeMap);
        //sira onemlidir

        TreeMap<Square,String>squareStringTreeMap = new TreeMap<>(new Comparator<Square>() {
            @Override
            public int compare(Square o1, Square o2) {
                if(o1.edge<o2.edge)
                    return -1;
                else if(o1.edge>o2.edge)
                    return  1;
                else
                    return 0;
            }
            //burada siralama yapmayi ogretiyoruz,
        });
        Square sq= new Square(4,"blue");
        Square sq1= new Square(2,"grey");
        Square sq2= new Square(33,"red");
        squareStringTreeMap.put(sq,"blue square");
        squareStringTreeMap.put(sq1,"grey square");
        squareStringTreeMap.put(sq2,"red square");
        //siralamanin nasil yapilacagi belli olmayan siniflarda treemap kullanilmaz.
        System.out.println(squareStringTreeMap);
        System.out.println(squareStringTreeMap.lowerEntry(sq));
        System.out.println(squareStringTreeMap.higherKey(sq1));

    }
    //arkaplanda bildigin tree yapisi olusuyor solda kucukler sagda buyukler en tepede rootun oldugu dallanan bir agac.
    //duz agacta o(n) surec vardir
    //dallanmis agacta bu logn dir
}
class Square{
    int edge;
    String color;

    public Square(int edge, String color) {
        this.edge = edge;
        this.color = color;
    }

    @Override
    public String toString() {
        return "Square{" +
                "edge=" + edge +
                ", color='" + color + '\'' +
                '}';
    }
}
