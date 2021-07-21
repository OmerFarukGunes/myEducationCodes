package Arrays;

public class ArrayOperations {
    public static void main(String[] args) {
        int num[]={3,1,6,2,0,7,5,8,9,6,4};
        selectionSort(num);
       for (int i : num)
           System.out.println(i);

        System.out.println(binarySearch(num,5));

    }
    public static void selectionSort(int [] arr){
        for (int i = 0 ; i <arr.length;i++){
            int min = arr[i];
            int minIndex=i;
            for (int j = i+1;j<arr.length ; j++)
            {
                if (min>arr[j]){
                    min=arr[j];
                    minIndex=j;
                }
            }
            if (minIndex !=i){
                arr[minIndex]=arr[i];
                arr[i]=min;
            }
        }
    }
    public static  int binarySearch(int []arr, int value){
        int minIndex =0;
        int maxIndex=arr.length -1;
        while(maxIndex >=minIndex){
            int midIndex = (minIndex+maxIndex)/2;
            if (value<arr[midIndex])
                maxIndex=midIndex-1;
            else if (value== arr[midIndex])
                return midIndex;
            else
                minIndex = midIndex+1;
        }
        return -1;
    }
}
