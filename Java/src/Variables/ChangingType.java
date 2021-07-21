package Variables;

public class ChangingType {
    public static void main(String[] args) {
        int sayi = (int)10.4;
        float num = 130.f;
        byte bit = (byte) num;
        System.out.println(sayi + " " + bit);
        String text = "150";
        sayi = Integer.parseInt(text);
        num = Integer.valueOf(text);
        System.out.println(sayi);
        System.out.println(num);

        text = String.valueOf(num);
        System.out.println(text);
        //burada normalde 3 olmasi gerek ama degerleri int olarak attik ve int olarak aldik. 
        double ortalama = (1+2)/2;
        double ortalama2 = (1+2)/2.0;
        System.out.println(ortalama);
        System.out.println(ortalama2);
    }
}
