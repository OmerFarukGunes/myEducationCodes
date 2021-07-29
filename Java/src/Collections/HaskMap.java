package Collections;

import java.util.HashMap;
import java.util.Map;

public class HaskMap {
    public static void main(String[] args) {
        HashMap<Integer,String> cities = new HashMap<>();
        cities.put(1,"Adana");
        cities.put(47,"Mardin");
        cities.put(34,"Istanbul");
        cities.put(35,"Izmir");
        cities.put(6,"Ankara");
        System.out.println(cities);
        String value = cities.get(6);
        System.out.println(value);
        System.out.println(cities.size());
        System.out.println(cities.isEmpty());
        //null deger ekleme yapabilirsin.
        cities.put(null,"null value");
        System.out.println(cities.get(null));
        System.out.println(cities.containsKey(35));
        System.out.println(cities.containsValue("Istanbul"));
        System.out.println(cities.remove(6));
        System.out.println(cities);

        HashMap<Integer,String> temp = new HashMap<>();
        temp.putAll(cities);
        System.out.println(temp);
        System.out.println(temp.hashCode());

        for (Map.Entry <Integer,String> entry:cities.entrySet()) {
            System.out.println(entry.getValue());

        }

    }
}
