package FileOperation;

import java.io.*;

public class InputOutputStream {
    public static void main(String[] args) {
        writeFile();
        try {
            readFile();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    private static  void  readFile() throws IOException {
        DataInputStream dataInputStream = null;
        dataInputStream=new DataInputStream(new BufferedInputStream(new FileInputStream("Students.dat")));
        Student student = null;
        boolean end =false;
        while (!end) {
            try {
                int id = dataInputStream.readInt();
                String name = dataInputStream.readUTF();
                student = new Student(id, name);
                System.out.println(student);
            } catch (EOFException e) {
                end = true;
            }
        }
        dataInputStream.close();
        try (ObjectInputStream objectInputStream=new ObjectInputStream(new BufferedInputStream(new FileInputStream("StudentsObject.dat")))){
            Student object = (Student) objectInputStream.readObject();
            //coklu deger almak istediginde arraylist kullaniriz.
            System.out.println(object);
        }catch (Exception e){
            System.out.println(e);
        }
    }
    //iki turlu exception tanimi yapabilirsin. Ustteki alttakinin mantigiyla aynidir.
    private  static void writeFile() {
        Student student= new Student(1,"omer");
        Student student2= new Student(2,"omerfg");
        Student student3= new Student(3,"omerfga");
        try ( DataOutputStream  dataOutputStream = new DataOutputStream(new BufferedOutputStream(new FileOutputStream("Students.dat")) )){

             //bufferedoutput demesek eger degerler byte byte aktarilacak bu da yavaslik saglayacak. Bu sekilde yazilacak tum veriler toplanarak eklenir.
            dataOutputStream.writeInt(student.id);
            dataOutputStream.writeUTF(student.name);
            dataOutputStream.writeInt(student2.id);
            dataOutputStream.writeUTF(student2.name);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } //finally {
           // if (dataOutputStream != null)
          //  {
         //       try {
          //          dataOutputStream.close();
         //       } catch (IOException e) {
          //          e.printStackTrace();
         //       }
        //    }

      //  } acilan dosyayi try icine koydugunu icin otomatik kapanir. eger dosya daha ust kisimda acilirsa finally kisminda kapatmalisin
        try(ObjectOutputStream  objectOutputStream = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream("StudentsObject.dat")) )) {
            objectOutputStream.writeObject(student3);
            //bu sekilde nesneleri dosyalara yazabilirsin
        }catch (Exception e){
            System.out.println(e);
        }
    }
}
class Student implements Serializable{
    //serializable objeyi veri olarak dosyaya atmayi saglar
    int id;
    String name;
    private final long serialVersionUID=1L;
    //dosyaya eklenen objenin versiyon numarasi

    public Student(int id, String name) {
        this.id = id;
        this.name = name;
    }

    @Override
    public String toString() {
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                '}';
    }
}
