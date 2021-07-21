package OOP;

public class Introduction {
    public static void main(String[] args) {
        int num = 1;
        Student omer = new Student();
        //deger atamazsan 0 ve null degerler atar.
//        omer.active = false;
//        omer.no = 123;
//        omer.name = "OMER";
//        omer.grade=4;
        omer.getLesson();
        omer.get();

        Student faruk = new Student(1,(byte) 3,true,"faruk");
        faruk.get();

        omer =faruk;
        // bu esitlemede farugun degerleri omere kopyalanmazz farugun tuttugu degerleri omerde tutmaya baslar.
        faruk.get();
        omer.get();
    }
}
