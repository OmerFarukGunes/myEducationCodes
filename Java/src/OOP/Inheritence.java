package OOP;

public class Inheritence {
    public static void main(String[] args) {
        Rectangle rec = new Rectangle(5,10);
        rec.show();
        Square square = new Square(5);
        square.show();
        System.out.println(square);
        Geo geo =new Rectangle(5,10);//implict atama denir
        Rectangle rec2 = (Rectangle) geo;// dikdortgen ikiside evet ama gelipte bunu belli etmesen maalesef derleyici salak anlamiyor.
        //bu atamaya explicit dirket olarak atamadir, downcasting alt sinifa dusurme

    }

}
class Geo{
    private int width;
    private int height;


    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public Geo(){
        System.out.println("deneme");
    }
    //normalde direkt classi yazdirirsan sacma bir adress cikar. bunun tanimi sistemde kayitli sen override yaparak guncelleyebilirsin.
    //inherit edecegin classta veya ana classta override yapabilirsin. alt siniflar ust sinifi kullanir eger alt sinifta da override varsa orasi calisir.
    @Override
    public String toString(){
        return "yeni toString";
    }
}
class Rectangle extends Geo {

    public Rectangle(int  width, int height){
        setHeight(height);
        setWidth(width);
    }
    public Rectangle(int  width){
        setHeight(width);
        setWidth(width);
    }
    public void show(){
        System.out.println(getHeight() +" " + getWidth());
    }
}
class Square extends Rectangle{
    //mutlaka bir constructor olmasi gerek.
    //super bir ust sinifi temsil eder ve oranin constructerini belirler.
    public Square(int  width){
        super(width);
    }
    public void show(){
        System.out.println("said" + getHeight() +" " + getWidth());
    }
}