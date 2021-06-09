void main() {
  List<String> sehirler = new List<String>();
  sehirler.add("Ankara");
  sehirler.add("izmir");
  var eleman = sehirler.length;
  sehirler.remove("izmir");
  sehirler.removeAt(0);
  for (var item in sehirler) {
    print(item);
  }
  List<Customer> customer = new List<Customer>();
  customer.add(new Customer());
}

class Customer {
  String? isim;
}
