import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        // is not restarted.
        primarySwatch: Colors.blue,
      ),
      home: MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage>
    with SingleTickerProviderStateMixin {
  int tabsCount = 0;
  int doubleTabsCount = 0;
  int longPressCount = 0;
  double xPos = 0.0;
  double yPos = 0.0;
  double boxSize = 0.0;
  double fullBoxSize = 150.0;
  AnimationController? controller;
  Animation<double>? animation;
  @override
  void initState() {
    super.initState();
    controller = AnimationController(
        duration: const Duration(milliseconds: 10000), vsync: this);
    animation = CurvedAnimation(parent: controller!, curve: Curves.bounceInOut);
    animation!.addListener(() {
      setState(() {
        boxSize = fullBoxSize * animation!.value;
      });
      centerBox(context);
    });
    controller!.forward();
  }

  @override
  void dispose() {
    controller!.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    if (xPos == 0.0) {
      centerBox(context);
    }

    return Scaffold(
        appBar: AppBar(
          title: Text("Gestures demo"),
        ),
        body: GestureDetector(
          onTap: () {
            setState(() {
              tabsCount++;
            });
          },
          onDoubleTap: () {
            setState(() {
              doubleTabsCount++;
            });
          },
          onLongPress: () {
            setState(() {
              longPressCount++;
            });
          },
          onVerticalDragUpdate: (DragUpdateDetails value) {
            setState(() {
              yPos += value.delta.dy;
            });
          },
          onHorizontalDragUpdate: (DragUpdateDetails value) {
            setState(() {
              xPos += value.delta.dx;
            });
          },
          child: Stack(
            children: <Widget>[
              Positioned(
                left: xPos,
                top: yPos,
                child: Container(
                    width: boxSize,
                    height: boxSize,
                    decoration: BoxDecoration(color: Colors.deepPurple)),
              )
            ],
          ),
        ),
        bottomNavigationBar: Material(
          child: Padding(
            padding: EdgeInsets.all(10.0),
            child: Text(
                "Tab: $tabsCount Double : $doubleTabsCount, Long: $longPressCount"),
          ),
        ));
  }

  void centerBox(BuildContext context) {
    xPos = MediaQuery.of(context).size.width / 2.0 - boxSize / 2.0;
    yPos = MediaQuery.of(context).size.height / 2.0 - boxSize / 2.0 - 15.0;
    setState(() {
      this.xPos = xPos;
      this.yPos = yPos;
    });
  }
}
