package Arrays;

public class Array {
    public static void main(String[] args) {
        int nums[] = new int [10];
        int nums2[] = new int [10];
        int nums3[] = new int [10];
        int []nums4= {1,2,3,4,5};
        nums[0]=10;
        for (int i = 0; i<nums2.length;i++)
            nums2[i]=i;

        String []months = {"Ocak","Subat","Mart"};
        for (int num: nums4) //foreach
            System.out.println(num);
        System.out.println(nums[0]);
        add(nums[0]);
        System.out.println(nums[0]);

        System.out.println(nums[0]);
        addArray(nums);
        System.out.println(nums[0]);
        //dizi yolladiginda dizi degeri artar.
        show(1,2,3,4,5);
        //diziyi kopyalamak icin tek tek degerleri ataman alzim veya
         System.arraycopy(nums4,0,nums3,0,nums4.length);
         //kopyalama yukaridaki gibi yapilabilir. degerler atanir.
        nums3 = nums4;
        //ustteki kullanim ise deger atamasi yapmaz nuums4 un tuuttuguu degerleri nums3 te tutmaya baslar.


        int [][]multiArray = new int [2][3];
        multiArray[0][1]= 1;
        multiArray[0][2]= 2;

        int [][]multiArray2 = {{1,2,3},{4,5,6},{7,8,9}};

    }
        private  static void add(int i){
        i++;
        }
        private  static  void  addArray(int[]nums){
            nums[0]++;
        }
        private static  void show(int ... arr){
            //... koydugun zaman ne kadar eleman gonderirsen gonder hepsini alir dii olarak.
            for (int num : arr)
                System.out.println(num);
        }

}
