import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Home extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Center(
        child: Container(
            alignment: Alignment.topLeft,
            margin: EdgeInsets.only(top: 60.0, bottom: 10.0),
            color: Colors.red,
            child: Column(
              children: <Widget>[
                Row(
                  //satir verebilirsin
                  textDirection: TextDirection.ltr,
                  children: <Widget>[
                    //birden fazla widget vermeni saglar
                    Text(
                      "Asus Laptop",
                      textDirection: TextDirection.ltr,
                      style: TextStyle(
                          color: Colors.white,
                          fontSize: 20.0,
                          decoration: TextDecoration.none),
                    ),
                    Expanded(
                      //bu sayede ekrana sigmayan yeri alt satira gecmesini saglarsin.
                      child: Text("16 Gb Ram, 128 Gb SSD, Intel I7",
                          textDirection: TextDirection.ltr,
                          style: TextStyle(
                              color: Colors.white,
                              fontSize: 20.0,
                              decoration: TextDecoration.none)),
                    )
                  ],
                ),
                Row(
                  //satir verebilirsin
                  textDirection: TextDirection.ltr,
                  children: <Widget>[
                    //birden fazla widget vermeni saglar
                    Text(
                      "Msi Laptop",
                      textDirection: TextDirection.ltr,
                      style: TextStyle(
                          color: Colors.white,
                          fontSize: 20.0,
                          decoration: TextDecoration.none),
                    ),
                    Expanded(
                      //bu sayede ekrana sigmayan yeri alt satira gecmesini saglarsin.
                      child: Text("32 Gb Ram, 512 Gb SSD, Intel I7",
                          textDirection: TextDirection.ltr,
                          style: TextStyle(
                              color: Colors.white,
                              fontSize: 20.0,
                              decoration: TextDecoration.none)),
                    )
                  ],
                ),
                Directionality(
                    textDirection: TextDirection.ltr, child: OrderButton())
              ],
            )));
  }
}

class OrderButton extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    var button = Container(
      margin: EdgeInsets.only(top: 50.0),
      child: RaisedButton(
        child: Text("Go to Checkout"),
        elevation: 5.0,
        onPressed: () {
          order(context);
        },
      ),
    );
    return button;
  }

  order(BuildContext context) {
    var alert = AlertDialog(
      title: Text("Go to checkout"),
      content: Text("I will go to checkout"),
    );
    showDialog(context: context, builder: (BuildContext context) => alert);
  }
}
