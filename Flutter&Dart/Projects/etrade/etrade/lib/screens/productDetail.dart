import 'package:etrade/db/dbHelper.dart';
import 'package:etrade/models/product.dart';
import 'package:flutter/material.dart';

class ProductDetail extends StatefulWidget {
  Product product;
  ProductDetail(this.product);
  @override
  State<StatefulWidget> createState() => ProductDetailState(product);
}

DbHelper dbHelper = new DbHelper();
enum Choice { Delete, Update }

class ProductDetailState extends State {
  Product product;
  ProductDetailState(this.product);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Product Detail for ${product.name}"),
        actions: <Widget>[
          PopupMenuButton<Choice>(
            onSelected: select,
            itemBuilder: (BuildContext context) => <PopupMenuEntry<Choice>>[
              PopupMenuItem<Choice>(
                value: Choice.Delete,
                child: Text("Delete product"),
              ),
              PopupMenuItem<Choice>(
                value: Choice.Update,
                child: Text("Update product"),
              )
            ],
          )
        ],
      ),
      body: Center(
        child: Card(
          child: Column(
            children: <Widget>[
              ListTile(
                leading: Icon(Icons.shop),
                title: Text(product.name),
                subtitle: Text(product.description),
              ),
              Text(product.price.toString() + " TL"),
              ButtonTheme(
                child: ButtonBar(
                  children: <Widget>[
                    FlatButton(
                      child: Text("Add To Card"),
                      onPressed: () {
                        AlertDialog alertDialog = new AlertDialog(
                          title: Text("Succes"),
                          content: Text("${product.name} added"),
                        );
                        showDialog(
                            context: context, builder: ((_) => alertDialog));
                      },
                    )
                  ],
                ),
              )
            ],
          ),
        ),
      ),
    );
  }

  void select(Choice choice) async {
    int result;
    switch (choice) {
      case Choice.Delete:
        Navigator.pop(context, true);
        var id = product.id;
        result = await dbHelper.delete(id);
        if (result != 0) {
          AlertDialog alertDialog = new AlertDialog(
            title: Text("Deleted"),
            content: Text("${product.name}"),
          );
          showDialog(context: context, builder: ((_) => alertDialog));
        }
        break;
      default:
    }
  }
}
