package Variables;

public class IlkerlVeriTipleri {
    public static void main(String[] args){
        int intDegiskeni =10;
        double doubleDegiskeni = 20.5;

    //HER bir tip icin bu sekilde bilgileri ogrenebilirsin.
        System.out.println("BYTE MIN: " + Byte.MIN_VALUE + " BYTE MAX: " + Byte.MAX_VALUE +" BIT: " + Byte.SIZE);
        System.out.println("BYTE MIN: " + Short.MIN_VALUE + " BYTE MAX: " + Short.MAX_VALUE +" BIT: " + Short.SIZE);

        char alp = 'a';
        int intValue = 'B';
        System.out.println(alp + " "+intValue);
        boolean result = true;
        System.out.println(result);
    }
}
