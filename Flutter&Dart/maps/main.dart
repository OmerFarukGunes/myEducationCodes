void main() {
  var sozluk = {"Book": "Kitap", "Table": "Masa"};
  print(sozluk);
  sozluk["teacher"] = "Ogretmen"; //yeni ekler
  sozluk["Book"] = "Kitap1"; //olanı düzenler
  print(sozluk["Book"]);
  for (var itm in sozluk.keys) {
    print(itm);
  }
  for (var itm in sozluk.values) {
    print(itm);
  }
  print(sozluk.length);
  sozluk.remove("Book");
  print(sozluk.containsKey("Book"));
  sozluk.forEach((k, v) => print(k));
}
