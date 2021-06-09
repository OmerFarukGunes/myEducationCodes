import 'package:flutter/foundation.dart';
import 'package:sqflite/sqflite.dart';
import 'dart:async';
import 'dart:io';
import 'package:path_provider/path_provider.dart';
import 'package:etrade/models/product.dart';

class DbHelper {
  String tblProduct = "Products";
  String colId = "Id";
  String colDescription = "Description";
  String colPrice = "Price";
  String colName = "Name";
  static final DbHelper _dbHelper = DbHelper._internal();
  DbHelper._internal();
  factory DbHelper() {
    return _dbHelper;
  }
  static Database? _db;
  //future ileride demektir. Operasyon bittiginde ne yapilacagi yazilir
  Future<Database> get db async {
    if (_db == null) {
      _db = await initializeDb();
    }
    return _db!;
  }

//proje icin db olusturulmasi
  Future<Database> initializeDb() async {
    Directory directory = await getApplicationDocumentsDirectory();
    String path = directory.path + "etrade.db";
    var dbEtrade = await openDatabase(path, version: 1, onCreate: _createDb);
    return dbEtrade;
  }

//$ isareti toplama islemi gibi birsey "Create table " + tblProduct yazmak gibi birsey asagida tamamen bir sql kodu bulunmakta
  void _createDb(Database db, int version) async {
    await db.execute(
        "Create table $tblProduct($colId integer primarykey,$colName text," +
            "$colDescription text, $colPrice int)");
  }
  //yukarida tabloyu sql kodu ile her bir kolonun ismini ve tipini vererek tablo olusturuldu.

  Future<int> insert(Product product) async {
    Database db = await this.db;
    var result = await db.insert(tblProduct, product.toMap());
    return result;
  }

  Future<int> update(Product product) async {
    Database db = await this.db;
    var result = await db.update(tblProduct, product.toMap(),
        where: "$colId =?", whereArgs: [product.id]);
    return result;
  }

  Future<int> delete(int? id) async {
    Database db = await this.db;
    var result =
        await db.rawDelete("Delete from $tblProduct where $colId = $id");
    return result;
  }

  Future<List> getProducts() async {
    Database db = await this.db;
    var result = await db.rawQuery("Select * from $tblProduct");
    return result;
  }
}
