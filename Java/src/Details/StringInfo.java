package Details;

public class StringInfo {
    public static void main(String[] args) {
        String name = new String("abcd");
        String name2 = new String("abcd");
        String name3 = new String("abc");
        //new dendigi zzaman ramde farkli adres cikar bu yuzzden esitlikte alan adresleri farkli olur
        System.out.println(name == name2);
        //ama equals ise deger esitligi saglanir
        System.out.println(name.equals(name2));

        String abc= "abc";
        String def ="abc";
        String jkl ="abc";
       //bu sekilde tanimlamada ramde ayri yer ayirtilmaz hepsi ayni yeri tutar. o yuzden esitlikte true doner
        System.out.println(abc==def);
        abc="abc fg";
        //e madem bunlarin hepsi ayni yeri tutuyor guncellendigi zaman digeride degismez mi HAYIR!
        System.out.println(def);
        jkl.concat("fg");
                //pekkki boyle eklesem ne olur yine ayni sonuc alinir.
        System.out.println(def);
        System.out.println(name3==def);
    }
}
