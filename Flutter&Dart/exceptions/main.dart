main() {
  int a = 10;
  int b = 20;
  //a yerine 0 yazarsan program normalde patlar ama try catch ile patlasa bile sana sadece bir hata mesajı döndürür ve çalışmaya devam eder program
  int result;
  try {
    result = b ~/ a;
    //bir bölme işleminin sonucu doubledır genelde ama bunu illa int istiyorsan yaklaşık değerini katman lazım
    print(result);
  } on IntegerDivisionByZeroException catch (e) {
    //on diyip hatayı yanına yazdığında sadece o hataya ait bir işlem yapabilirsin. on yazmadanda catch işlemi yapabilirsin
    //ama ya hata o senin belirlediğin değilse ne olacak ?
    print(e);
  } on FormatException catch (e) {
    //farklı türde olabilri
    print(e);
  } catch (e) {
    //veya öngörülmeyen başka bir hata olabilir bu şekilde try catch kullanabilirsin.
    print(e);
  } finally {
    print("ben her türlü çalışırım. hata olsa da olmasa da");
  }
  try {
    setAge(15);
  } on FormatException catch (e) {
    print(e);
  } on CustomException catch (e) {
    print(e.errorMessage());
  }
}

void setAge(int age) {
  if (age < 13) {
    throw new FormatException("yaşınız 13 ten büyük olmalıdır");
    //direkt exception yapabilirsin acnak biz yazılımcılar özel hata yazıyorsak onun türüne göre döndürme yaparız.
  } else
    throw new CustomException();
}

class CustomException implements Exception {
  String errorMessage() => 'özel hata oluştu';
  //kendi exceptionlarını oluşturabilirsin.
}
