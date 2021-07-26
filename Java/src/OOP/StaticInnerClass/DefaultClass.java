package OOP.StaticInnerClass;

public class DefaultClass {
    int obj;
    public static int staticObjl;
            public void metot(){

            }
           public static void statikMetot(){}
    static class InnerClass{
                int innerObj;
               public   static int innerStaticObj;
                public void inentMetot(){
                    staticObjl++;
                    statikMetot();
                    //static olan tum degiskenlere erisebilirsiun
                }
        public static void  innerStatikMetot(){}
        //bir metot ayni anda statik ve abstraact olamaz
    }
}
