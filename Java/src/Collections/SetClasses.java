package Collections;

import java.util.HashSet;
import java.util.LinkedHashSet;

public class SetClasses {
    public static void main(String[] args) {
        HashSet<String> letters = new HashSet<>();
        //sadece bazzi elemanlarin tekilligini saglamak istersek kullanirizz.
        letters.add("a");
        letters.add("d");
        letters.add("c");
        letters.add("d");
        letters.add("d");
        letters.add("b");
        //ne kadar ayni deger girsende hepsini tek sefer kaydeeder.
        //arka planda bunlara bos bir value atar bunlar keydir.
        System.out.println(letters);
        LinkedHashSet<String> linkedHashSet = new LinkedHashSet<>();

        linkedHashSet.add("a");
        linkedHashSet.add("d");
        linkedHashSet.add("d");
        linkedHashSet.add("b");
        linkedHashSet.add("c");
        linkedHashSet.add("b");
        linkedHashSet.add("b");
        //sirali bir sekilde her elemandan en fazla bir kez goruntulenmesi saglanir.
        System.out.println(linkedHashSet);
        Object[] tempArr = linkedHashSet.toArray();
        System.out.println(tempArr[0].toString());
        //bu sekilde dizi atamasi yapabilirsin.
        //iterator ile gezebilirsin.
        //null deger atamasi buna yapamazsin cunuku null degeri neye gore siralayacak gulum ?? (treesette)
        //linkedHashSet yavastir. en yavasi treeSettir. hashSet en hizlisidir.
        //her daim set ve equals codelarini override et. kendini saglama al.


    }
}
