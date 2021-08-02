package Exceptions;

public class UseException {
    public static void main(String[] args) {

        try {
            Integer i = new Integer("asd"); // boyle bir tanim var aslinda.
            //kullanici int degere string bir girdi verebilir bunuu try catch ile yakalamali ve programin calismasina
            //devam ettirmeliyiz
            System.out.println( i);
        }catch (Exception e){
            System.out.println(e.toString());
        }
        finally{
            System.out.println("elinde sonunda burasi calisir");
        }
        System.out.println("program devam etmeli");

        String [] arr= {"abc","234",null,"bds"};
        for (int i=0; i <arr.length+1;i++){
            try {
                int num = arr[i].length() + Integer.parseInt(arr[i]);
            }
            catch (NumberFormatException error){
                System.out.println(error);
            }
            catch (NullPointerException error){
                System.out.println(error);
            }
            catch (ArrayIndexOutOfBoundsException error){
                System.out.println(error);
            }
            //coklu hatalari bu sekilde kendin ozellestirebilirsin.
            try {
                int num = arr[i].length() + Integer.parseInt(arr[i]);
            }
            //bu sekilde toplu bildigin hatalari  veya diyebilirsin
            catch (NumberFormatException  | ArrayIndexOutOfBoundsException| NullPointerException error){
                System.out.println(error);
            }
            //try catchhleri ic ice yazabilirsin.

        }
    }
}
