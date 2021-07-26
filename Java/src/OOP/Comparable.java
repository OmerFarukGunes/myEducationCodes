package OOP;

import java.util.Arrays;

public class Comparable {
    public static void main(String[] args) {

        Children obj2= new Children(9,"Omer");
        Children obj3= new Children(6,"Omer");
        Children obj= new Children(5,"Omer");
        Children obj4= new Children(8,"Omer");
        Children obj5= new Children(7,"Omer");
        Children[] objs = {obj,obj2,obj3,obj4,obj5};
        for (Children i :objs)
            System.out.println(i);
        Arrays.sort(objs);
        for (Children i :objs)
            System.out.println(i);
        }
}
class Children implements java.lang.Comparable<Children> {
    int id;
    String name;

    public Children(int id, String name) {
        this.id = id;
        this.name = name;
    }

    @Override
    public String toString() {
        return "Children{" +
                "id=" + id +
                ", name='" + name + '\'' +
                '}';
    }
    //sinifi siralamk istersen comparable interfaceinden implement etmen lazim.siralama yaparken otomatik cagirilir. asagisi kucukten buyuge siralar. tam tersini yazarak
    //buyukten kucuge siralayabilirsin.
    //string ifadelerde kiyaslama yapmak icin ad.compareTo(o.ad)<0 -1 dondur diyebilirsin
    @Override
    public int compareTo(Children o) {
        if(this.id<o.id)
            return -1;
        else if (this.id>o.id)
            return 1;
        else
            return 0;
    }
}
