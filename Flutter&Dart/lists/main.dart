void main() {
  // var ogrenciler = new List(3);
  // ogrenciler[0] = "engin";
  // ogrenciler[1] = "engin";
  // ogrenciler[2] = "engin";
  // print(ogrenciler);
  var sehirler = ["ankara", "istanbul"];
  sehirler.insert(1, "deneme");
  sehirler.add("kars");
  print(sehirler);
  print(sehirler.length);
  print(sehirler.first);
  print(sehirler.last);
  print(sehirler.firstWhere((s) => s.contains("a")));
  //sehirlerde ilk a geçiren değeri bul. büyük küçük duyarı vardır eğer element bulamazsa hata verir.
}
