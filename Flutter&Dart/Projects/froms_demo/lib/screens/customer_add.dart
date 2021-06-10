import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:froms_demo/mixins/validation_mixin.dart';
import 'package:froms_demo/models/customer.dart';

class CustomerAdd extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => CustomerAddState();
}

class CustomerAddState extends State {
  //final sabit deger demektir
  final formkey = GlobalKey<FormState>();
  final customer = Customer();
  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.all(25.0),
      child: Form(
        key: formkey,
        child: Column(
          children: <Widget>[
            firstNameField(),
            lastNameField(),
            emailNameField(),
            passwordNameField(),
            submitButton()
          ],
        ),
      ),
    );
  }

  Widget firstNameField() {
    return TextFormField(
      decoration: InputDecoration(labelText: "First Name", hintText: "Omer"),
      validator: (String? value) {
        if (value!.length < 2) {
          return "isim en az iki karakter olmalıdır";
        }
      },
      onSaved: (String? value) {
        customer.firstName = value;
      },
    );
  }

  Widget lastNameField() {
    return TextFormField(
      decoration: InputDecoration(labelText: "Last Name", hintText: "Gunes"),
      validator: (String? value) {
        if (value!.length < 2) {
          return "soyisim en az iki karakter olmalıdır";
        }
      },
      onSaved: (String? value) {
        customer.lastName = value;
      },
    );
  }

  Widget emailNameField() {
    return TextFormField(
      keyboardType: TextInputType.emailAddress,
      decoration:
          InputDecoration(labelText: "Email Name", hintText: "***@gmail.com"),
      validator: (String? value) {
        if (!value!.contains("@")) {
          return "mail geçerli değil";
        }
      },
      onSaved: (String? value) {
        customer.email = value;
      },
    );
  }

  Widget passwordNameField() {
    return TextFormField(
      //sifre için kullanılan text türü
      obscureText: true,
      decoration:
          InputDecoration(labelText: "Password Name", hintText: "1234Abc"),
      onSaved: (String? value) {
        customer.password = value;
      },
    );
  }

  Widget submitButton() {
    return RaisedButton(
      child: Text("Kaydet"),
      onPressed: () {
        if (formkey.currentState!.validate()) {
          formkey.currentState!.save();
          saveCustomer(customer);
        }
        ;
      },
    );
  }

  void saveCustomer(Customer customer) {
    print(customer.firstName);
  }
}
