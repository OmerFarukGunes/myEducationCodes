import 'dart:ffi';

void main() {
  selam("hello");
  String sa = don();
  print(sa);
  test(1, 2, 4);
  test2("1, 2, 4", d: "asd");
}

void selam(String isim) {
  print(isim);
}

String don() {
  return "helloo";
}

void test(a, b, c, [d, e]) {
//parametre gönderirken illaki o parametrenin veri tipini belli etmek zorunda değilsin. bu dinamiktir.
//kullanıcı a b c yi girer ancak d ve e yi isterse girer
  print(a);
  print(b);
  print(c);
  print(d);
  print(e);
}

void test2(a, {d, e}) {
  //bu şekilde süslü yazarsan değer atamasında hangisine değer atadığını belirtmen gerek
  print(a);
  print(d);
  print(e);
}
