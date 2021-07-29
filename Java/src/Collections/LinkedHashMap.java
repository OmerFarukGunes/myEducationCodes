package Collections;

import java.util.Map;

public class LinkedHashMap {
    public static void main(String[] args) {
        java.util.LinkedHashMap<String,Integer> linkedHashMap = new java.util.LinkedHashMap<>();
        //elemanlar eklendigi siraya gore okunur.
        linkedHashMap.put("omer",1);
        linkedHashMap.put("smer",6);
        linkedHashMap.put("amer",4);
        linkedHashMap.put("emer",3);
        for (String temp: linkedHashMap.keySet()
             ) {
            System.out.println(temp);

        }
        for (int temp:linkedHashMap.values()
             ) {
            System.out.println(temp);
        }//butun metodlar burada da gecici
        //double linked list vardir burada
        //hash ile degerler bir butun halinde bir code icerisinde tutulur. header alani vardir. son degerin afteri null dir.

    }
}
