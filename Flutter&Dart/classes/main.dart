void main() {
  CusomerManager customerManager = new CusomerManager();
  customerManager.Save();
  Customer customer = new Customer.namedCons("deneme");
  customer.id = 5;
  customerManager.Edit(customer);
  customer.customerId = -1;
}

class CusomerManager {
  void Save() {
    print("müşteri kaydedildi");
  }

  void Edit(Customer customer) {
    print("müşteri güncellendi " + customer.name.toString());
  }
}

class Customer {
  int? id;
  String? name;
  Customer.namedCons(String name) {
    this.name = name;
    print("oluşturuldu");
  }
  Customer() {
    print("ok");
  }
  //class içindeki değerlere kural yazmak için
  String get customerName {
    return this.name.toString();
  }

  void set customerId(int id) {
    if (id < 0) {
      print("Hata");
    } else {
      this.id = id;
    }
  }
}
