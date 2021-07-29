package OOP.Gneric;

public class GenericPrint <Obj>{
    public void print(Obj []arr){
        for (Obj a : arr)
            System.out.println(a);
    }
}
