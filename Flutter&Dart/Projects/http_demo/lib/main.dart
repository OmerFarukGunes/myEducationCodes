import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:http_demo/apis/api.dart';
import 'package:http_demo/models/todo.dart';

void main() => runApp(TodoApp());

class TodoApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    // TODO: implement build
    return MaterialApp(
      home: TodoListApp(),
    );
  }
}

class TodoListApp extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => TodoListAppState();
}

class TodoListAppState extends State {
  List<Todo> list = [];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("TodoList"),
      ),
      body: ListView.builder(
        itemCount: list.length,
        itemBuilder: (context, position) {
          return ListTile(
            title: Text(list[position].title!),
          );
        },
      ),
    );
  }

  getTodos() {
    Api.getTodos().then((response) {
      setState(() {
        //ıterable ile istediğin tarzda aldığın nesneyi sonradan map edebilirsin
        Iterable list = json.decode(response.body);
        this.list = list.map((todo) => Todo.fromJson(todo)).toList();
      });
    });
  }

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    getTodos();
  }
}
