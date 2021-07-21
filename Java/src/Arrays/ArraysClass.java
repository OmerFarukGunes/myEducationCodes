package Arrays;

import java.util.Arrays;

public class ArraysClass {
    public static void main(String[] args) {
        int[]nums = {1,2,4,3,0,9,8,11,23,45,24,59,48,21,945,2834,23};
        int []nums2 ={1,2,3,4,123,123};
        Arrays.sort(nums,2,5);
        //parcali siralama
        Arrays.sort(nums);
        //normal siralama
        Arrays.parallelSort(nums);
        //islemcin gucluyse islemcinin coklu cekirdegini kullanrak daha hizli siralama yapar
        System.out.println(Arrays.binarySearch(nums,11));
        //binarySearch icin siralanmis deger lazim. yukaridaki metod direkt arama yapar.
        System.out.println(Arrays.equals(nums,nums2));
        //birebir ayniysa sirasi ve degerleri ayni olmasi gerek eger olursa true

        int nums3[] = new int[20];
        Arrays.fill(nums3,50);
        //fill dersen eger her bir elemana 50 yazar.
        //Arrays. yaz bir ton metod var

    }
}
