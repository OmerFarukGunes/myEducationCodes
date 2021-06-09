import 'package:etrade/db/dbHelper.dart';
import 'package:etrade/models/product.dart';
import 'package:etrade/screens/producList.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    int count = 0;
    List<Product> products = [];
    DbHelper dbHelper = new DbHelper();
    dbHelper
        .initializeDb()
        .then((result) => dbHelper.getProducts().then((value) {
              var productsFuture = dbHelper.getProducts();
              productsFuture.then((data) {
                List<Product> productsData = [];
                count = data.length;
                for (var i = 0; i < count; i++) {
                  productsData.add(Product.fromObject(data[i]));
                }
              });
            }));

    //bu sekilde db de buulunan urunleri cektik
    // Product product = new Product("Mouse", "Msi", 500);
    // dbHelper.insert(product);
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  MyHomePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
      ),
      body: ProductList(),
    );
  }
}
