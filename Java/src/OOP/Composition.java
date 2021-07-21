package OOP;

public class Composition {
    public static void main(String[] args) {
        Car myCar = new Car();
        myCar.start();
        myCar.stop();

    }
}
class Motor{
    private String name;
    private int power;
    public  Motor(){
        name="honda";
        power=135;
    }
    public void get(){
        System.out.println(name);
    }
    public void start(){
        System.out.println("start");
    }
    public  void stop(){
        System.out.println("stop");
    }
}
class Car{

    private  Motor motorOfCar;
    private String color;
    private int year;
    public  Car(){
        motorOfCar= new Motor();
        motorOfCar.start();
        color="white";
        year=2020;
        motorOfCar.get();
    }
    public void start(){
        System.out.println("starting");
    }
    public  void stop(){
        System.out.println("stopping");
    }
}