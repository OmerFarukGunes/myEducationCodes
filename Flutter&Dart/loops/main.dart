void main() {
  for (var i = 0; i <= 5; i++) {
    print(i);
  }
  var ogrenciler = ["engin", "Derin"];
  for (var item in ogrenciler) {
    print(item);
  }
  int sayi = 5;
  while (sayi <= 10) {
    print(sayi);
    sayi++;
  }
  do {
    print(sayi);
    sayi++;
  } while (sayi <= 15);
}
