import 'package:etrade/db/dbHelper.dart';
import 'package:etrade/models/product.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class ProductAdd extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => ProductAddState();
}

class ProductAddState extends State {
  DbHelper dbhelper = new DbHelper();
  TextEditingController txtName = new TextEditingController();
  TextEditingController txtDescription = new TextEditingController();
  TextEditingController txtPrice = new TextEditingController();
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Add a new product"),
      ),
      body: Padding(
        padding: EdgeInsets.only(top: 30.0, left: 10.0, right: 10.0),
        child: Column(children: <Widget>[
          TextField(
              controller: txtName,
              decoration: InputDecoration(labelText: "name")),
          TextField(
            controller: txtDescription,
            decoration: InputDecoration(labelText: "Description"),
          ),
          TextField(
              controller: txtPrice,
              decoration: InputDecoration(labelText: "Price")),
          FlatButton(onPressed: () {}, child: Text("Save"))
        ]),
      ),
    );
  }

  void save() async {
    int result = await dbhelper.insert(Product(
        txtName.text, txtDescription.text, int.tryParse(txtPrice.text)));
    if (result != 0) {
      Navigator.pop(context, true);
    }
  }
}
