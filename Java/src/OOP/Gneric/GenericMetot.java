package OOP.Gneric;

public class GenericMetot {
    public static void main(String[] args) {
        String[] names= {"omer","ali","osman"};
        Integer [] nums={1,2,3,23,45};
        print(names);
       // printInt(nums);
        printGeneral(names);
        printGeneral(nums);
        printGeneric(names);
        printGeneric(nums);
    }
    //General extends Number gibi spesifik hale getirebilirsin.
    public static <General> void printGeneric(General[]arr){
        for (General temp: arr)
            System.out.println(temp);
        //ee bu asagidakinden farki ne !!
    }

    public static void print(String[] args) {
        for(String i:args){
            System.out.println(i);
        }
    }
    public static void printInt(int[] args) {
        for(int i:args){
            System.out.println(i);
        }
    }
    public static void printGeneral(Object []arr){
        for (Object a : arr)
            System.out.println(a);
        //burada veri tipine ozel islemleri kullanamazsin yani contains vs gibi stringe ozel vs seyleri kullanamazsin.
        //Ya sadece object sinifina ozzel islemleri kullanacan veya tum geglen obje stringg olacak
    }
}
