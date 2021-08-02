package FileOperation;

import java.io.*;

public class FileReadferWriter {
    public static void main(String[] args) {
        //chahracter bazli dosya islemi
        BufferedWriter bufferedWriter=null;

        try {
             bufferedWriter = new BufferedWriter(new FileWriter("Char.txt",true));
             //ikinci ucuncuu acilista dosya sifirlanmicak append true yapildigi icin oldugu yerden devam edecek islemlere.
             bufferedWriter.write("hello\n");
             bufferedWriter.write("hello");
             bufferedWriter.newLine();
            bufferedWriter.write("hello\n\n\n");
        } catch (IOException e) {
            e.printStackTrace();
        }finally {
            try {
                bufferedWriter.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        try(BufferedReader bufferedReader= new BufferedReader(new FileReader("Char.txt"))){
            String s;
            while ((s=bufferedReader.readLine()) !=null)
                System.out.println(s);
        }catch (Exception e){
            System.out.println(e);
        }

    }
}
