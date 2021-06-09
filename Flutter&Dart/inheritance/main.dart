void main() {
  CustomerManager customer = new CustomerManager();
  customer.getBestCustomer();
  customer.save();
  CustomerManager.operasyon();
  //parametre şeklinde static fonku çağıramazsın. classı direkt çağırman lazım.
  Personel personel = new Personel();
  personel.pay();
  personel.save();
  personel.Name = "omer";
  personel.id = 1;
}

class Person {
  int? id;
  String? Name;
  void save() {
    print("kaydedıldı");
  }
}

class CustomerManager extends Person {
  void getBestCustomer() {
    print("best");
  }

  static operasyon() {
    //parametrelerde static olabilir.
    print("statik operasyon çağırıldı.");
  }
}

class Personel extends Person {
  void pay() {
    print("paid");
  }

  //personel için genel bir fonku özelleştirmek istersen override yaparsın.
  @override
  void save() {
    print(" loglandı");
    super.save();
    //super yazdığın zaman override edilmiş bir fonka ek olarak genel fonku çağırmak isteyebilirsin.
  }
}
