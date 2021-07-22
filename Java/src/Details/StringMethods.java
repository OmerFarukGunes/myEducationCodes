package Details;

public class StringMethods {
    public static void main(String[] args) {
        String name="omer";
        System.out.println(name.length());
        System.out.println(name.toUpperCase());
        System.out.println(name.charAt(0));
        System.out.println(name.concat(" fg"));
        //concat anlik olarak ekleme yapar sadece tamamen degeri degistirmez.
        System.out.println(name);
        String obj =name.concat(" fG");
        System.out.println(obj);
        System.out.println(obj.trim());
        //sag sol bosluklari siler
        System.out.println(obj.toLowerCase());
        System.out.println(obj.equalsIgnoreCase(name.concat(" fg")));
        //buyuk kucuk harf onemli olmayacak sekilde karsilastirma yapar.
        System.out.println(obj.compareTo(name.concat(" fg")));
        System.out.println(obj.startsWith("O"));
        System.out.println(obj.endsWith("G"));
        //basliyor mu bitiyor mu icinde var mi case onemli
        System.out.println(obj.contains("m"));
        System.out.println(obj.substring(5));
        //5 ten sonraki degerleri var
        System.out.println(obj.substring(1,5));
        //1 den 5 e kadar degerleri al
        System.out.println(obj.indexOf("e"));
        //e kacinci indexte
        System.out.println(obj.lastIndexOf("g"));
        //en sonda g nerede var yoksa -1

    }
}
