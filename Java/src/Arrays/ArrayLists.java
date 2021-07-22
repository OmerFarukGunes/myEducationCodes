package Arrays;
import java.util.ArrayList;
public class ArrayLists {
    public static void main(String[] args) {
        Phone[] phones = new Phone[20];
        Phone obj1 = new Phone("Mi 11", 3000);
        Phone obj2 = new Phone("Mi 10", 2000);
        Phone obj3 = new Phone("Mi 9", 1000);
        phones[0]=obj1;
        phones[1]=obj2;
        phones[2]=obj3;
        System.out.println(phones[1]);
        phones = new Phone[25];
        //boyle yaptigin zaman 0 lanir. bunu yasamamak icin arraylist kullaniriz
        System.out.println(phones[1]);

        ArrayList <Phone> phones2 = new ArrayList<>();
        phones2.add(obj1);
        phones2.add(obj2);
        phones2.add(1,obj3);//obj 2 yerine koyar.
        phones2.remove(0);
        phones2.remove(obj2);
        System.out.println(phones2.size());
        phones2.add(obj2);
        System.out.println(phones2.get(0));
        phones2.set(0,obj1);
        System.out.println(phones2.get(0));
        System.out.println(phones2.contains(obj1));
    }
}
class Phone{
    String model;
    int price;
    public Phone(String model, int price) {
        this.model = model;
        this.price = price;
    }

    @Override
    public String toString() {
        return "phone{" +
                "model='" + model + '\'' +
                ", price=" + price +
                '}';
    }
}
