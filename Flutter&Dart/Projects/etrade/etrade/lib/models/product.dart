class Product {
  int? _id;
  String? _name;
  String? _description;
  int? _price;
  //constructor yardimiyla degerleri alabilirsin
  Product(this._name, this._description, this._price);
  //guncelleme yaparken id de lazim olacak ve genel tguncelleme yazimi withId dir
  Product.withId(this._id, this._name, this._description, this._price);

  int? get id => _id;
  String get name => _name!;
  String get description => _description!;
  int get price => _price!;
  set name(String value) {
    if (value.length >= 2) {
      _name = value;
    }
  }

  set description(String value) {
    if (value.length >= 10) {
      _description = value;
    }
  }

// bu sekilde db ye birsey kaydederken set uzerinde kayit kurallarini direkt verebilirsin.
  set price(int value) {
    if (value > 10) {
      _price = value;
    }
  }

  // bir kisinin elinde bir product nesnesi olacak p degerinde olsun buna var map + p.toMap("name") ile isme ulasabilir
  Map<String, dynamic> toMap() {
    var map = Map<String, dynamic>();
    map["Name"] = _name;
    map["Description"] = _description;
    map["Price"] = _price;
    if (_id != null) {
      map["id"] = _id;
    }
    return map;
  }

  Product.fromObject(dynamic o) {
    this._id = o["Id"];
    this._name = o["Name"];
    this._description = o["Description"];
    this._price = o["Price"];
  }
}
