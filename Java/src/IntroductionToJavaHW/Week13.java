package IntroductionToJavaHW;

import java.util.Scanner;

class SimpleGeometricObject{
 public String color;
 public boolean filled;
}
class Triangle extends  SimpleGeometricObject{
    private double side1=1.0,side2=1.0,side3 = 1.0;
    Triangle(){
        side1=1.0;
        side2=1.0;
        side3=1.0;
    }
    Triangle(double _side1,double _side2,double _side3){
        side1=_side1;
        side2=_side2;
        side3=_side3;
    }
    public double getSide1(){
        return side1;
    }
    public double getSide2(){
        return side2;
    }
    public double getSide3(){
        return side3;
    }
    public double getArea(){
        return Math.sqrt(getPerimeter()*(getPerimeter()-side1)*(getPerimeter()-side2)*(getPerimeter()-side3));
    }
    public double getPerimeter(){
        return side1+side2+side3;
    }
    public void setSide1(double _side1){
        System.out.println();
    }
    public void setSide2(double _side2){

    }
    public void setSide3(double _side3){

    }
    @Override
    public String toString() {
        return
                "side1=" + side1 +
                ", side2=" + side2 +
                ", side3=" + side3 +
                '}';
    }
}
public class Week13 {
    public static void main(String[] args) {

        Scanner sc= new Scanner(System.in);
        System.out.println("Enter 3 Side of Triangle");
        Triangle triangle = new Triangle( sc.nextDouble(),sc.nextDouble(),sc.nextDouble());
        System.out.println("Enter Color of Triangle");
        triangle.color = sc.next();
        while(true){
            System.out.println("is Filled Triangle ? True or False");
            try{
                triangle.filled = sc.nextBoolean();
                break;
            }catch (Exception e){
                System.out.println("Wrong Input Try Again");
                sc.next();
            }
        }
        System.out.println( triangle.toString());
        System.out.println("Area is: " +triangle.getArea());
        System.out.println("Perimeter is: " +triangle.getPerimeter());
        System.out.println("Color is: " +triangle.color);
        System.out.println("Triangle is " +(triangle.filled ? "filled" :"is not filled"));
    }
}
