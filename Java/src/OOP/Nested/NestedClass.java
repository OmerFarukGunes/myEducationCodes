package OOP.Nested;

public class NestedClass {
    public static void main(String[] args) {
        String[] cities = {"Mardin"};
        Collector.StringPrinter collector= new Collector().new StringPrinter();
        collector.stringPrinter(cities);
        //bu sekilde ic ice siniflar olusturabilirsin.

    }

}
