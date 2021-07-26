package OOP;

import java.util.ArrayList;

public class Interface {
    public static void main(String[] args) {
        Apple a= new Apple();
        newable aa= new Apple();;
        newable bb= new Cow();
        a.specialMethod();
        aa.method();
        ArrayList<newable> objects =new ArrayList<>();

    }
}


interface newable{
    //burada sadece ici bos metodlar yer alir. peki bu ne ise yarar ?
    void method();
}
class Apple implements newable{
    public void specialMethod(){

    }
    @Override
    public void method() {

    }
}
class Cow implements  newable{
    @Override
    public void method() {

    }
}
//yukarida buolunan iki classta interfacete bulunan metodlari kullanmak zorunda ! bu classlar tek catida toplanmis