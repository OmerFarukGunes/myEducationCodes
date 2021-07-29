public class Main {

    public static void main(String[] args) {
	 RationalNum num1=new RationalNum(2,4);

	 RationalNum num2=new RationalNum(2,-4);
	 RationalNum num3=new RationalNum(-8,-12);
	 RationalNum num4=new RationalNum(-8,5);
	 RationalNum num5=new RationalNum(8,4);
		System.out.println(num1);
		System.out.println(num2);
		System.out.println(num3);
		System.out.println(num4);
		System.out.println(num5);
		RationalNum num6 = num1.plus(num3);
		System.out.println(num6);
		System.out.println(num1.equals(num2));
    }
}
