package OOP;

import jdk.jfr.Category;

public class Polymorphism {
    public static void main(String[] args) {
        Animal a = new Animal();
        Dog d = new Dog("Golden");
        Cat c = new Cat("Van");
        tell(d);
        tell(c);
    }
    public static void tell(Animal a){
        if (a instanceof Animal){
            //gonderilen deger tam oalrak hangi turde oldugunu anlamak icin instance kullanilir.
            System.out.println("I'm a animal");
        }
        else{
            a.tell();
        }

    }
}
class Animal{
    private int legNum;

    public void tell(){
        System.out.println("I'm a animal");
    }
    public int getLegNum() {
        return legNum;
    }

    public void setLegNum(int legNum) {
        this.legNum = legNum;
    }
}
class Dog extends Animal{
    private String kind;

    public Dog(String kind) {
        setKind(kind);
        setLegNum(4);
    }

    public String getKind() {
        return kind;
    }

    public void setKind(String kind) {
        this.kind = kind;
    }
    @Override
    public void tell(){
        System.out.println("I'm a dog");
    }
}
class Cat extends Animal{
    private String kind;

    public Cat(String kind) {
        setKind(kind);
        setLegNum(4);
    }

    public String getKind() {
        return kind;
    }

    public void setKind(String kind) {
        this.kind = kind;
    }
    @Override
    public void tell(){
        System.out.println("I'm a Cat");
    }
}
