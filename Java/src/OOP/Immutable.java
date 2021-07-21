package OOP;

public class Immutable {
    //ilk atamasi yapildiktan sonra degistirilemeyen classlardir.
    public static void main(String[] args) {
        String[] companies = {"HP", "ACER", "DELL"};
        //dizinin elemanlarini direkt construuctura yazamazsin
        //direkt dizi atayabilirsin veya new String[]{"degerler"} yazarakta constructuri calistirabilirsin.
        Computer c1 = new Computer(8, 8, companies);
        print(c1);
        String[] firms = c1.getCompany();
        //diziler referans tipi degerler oldugu icin classta bulunan diziyi baska diziye referans almasi icin atarsan. Deger degisirse objede de deger degisir
        firms[0] = "Apple";
        print(c1);
    }
    public  static void print(Computer c1){
        System.out.println(c1.getRam()+" "+c1.getCompany()[0]);
    }
}
class Computer{
   private int core;
    private int ram;
    private String[] company;

    public Computer(int core, int ram, String[] company){
        this.core=core;
        this.ram=ram;
        this.company = company;
    }
    public int getRam() {
        return ram;
    }

    public String[] getCompany() {
        //eger tamamen dii referans olarak gonderilmesin istiyorsan tek tek tum degerleri gonderebilirsin
        return company;
    }
    public  String[] getCopy(){
        //bu sekilde gonderirsen herhangi bir sekilde degerler degistirelemez olur
        String[] copyCompany = new String[company.length];
        for (int i=0;i<copyCompany.length;i++)
            copyCompany[i]=company[i];
        return copyCompany;
    }
    public int getCore() {
        return core;
    }

}
