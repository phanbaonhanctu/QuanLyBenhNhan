import 'package:app_qlbn/app/data/models/Benhnhan.dart';
import 'package:flutter/material.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:get/get.dart';
import '../controllers/home_controller.dart';


class HomeView extends GetView<HomeController> {
  const HomeView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: IconButton(onPressed: (){
        ElevatedButton(onPressed: (){
          const SnackBar(content: Text("Hello"));
        }, child: const Text("Hello"));
      }, icon: const Icon(Icons.draw)),
      appBar: AppBar(
        title: const Text('Quản lý bệnh nhân'),
        centerTitle: true,
        backgroundColor: Colors.blue[100],
      ),
      body: Obx(() {
        int itermPage = 100;
        if (controller.listBenhnhan.isEmpty) {
          return const Center(child: CircularProgressIndicator());
        } else {
          return PageView.builder(
            controller: controller.pageController,
            onPageChanged: (value) {
              controller.pageNumber.value = value+1;
            },
            itemCount: controller.listBenhnhan.length ~/ itermPage +1,
            itemBuilder: (context, indexPage) {
              return Center(
              child: ListView.builder(
                itemCount: controller.thamAn(controller.listBenhnhan.length,itermPage,indexPage),
                itemBuilder: (context, index) {
                  Benhnhan benhnhan = controller.listBenhnhan[(indexPage*itermPage)+index];
                  return Column(
                    children: [
                      Container(
                        margin: const EdgeInsets.only(right: 10.0, left: 10.0, bottom: 5.0, top: 5.0),
                        padding: const EdgeInsets.all(5.0),
                        decoration: BoxDecoration(
                          border: Border.all(style: BorderStyle.solid, color: Colors.deepOrange),
                          borderRadius: const BorderRadius.all(Radius.circular(10))
                        ),
                        child: Row(
                          crossAxisAlignment: CrossAxisAlignment.center,
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Expanded(
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,                              
                                children: [
                                  Text("Họ tên: ${benhnhan.name}", style: const TextStyle(fontWeight: FontWeight.bold),),
                                  Text("Địa chỉ: ${benhnhan.address}"),
                                  Text("SĐT: ${benhnhan.phone}"),
                                  Text("Điều trị: ${benhnhan.ppdt}"),
                                ],
                              ),
                            ),
                            IconButton(
                              onPressed: (){
                                // ScaffoldMessenger.of(context).showSnackBar(
                                //   const SnackBar(content: Text("Hello"), duration: Duration(seconds: 2))
                                // );
                                // OverlayEntry overlayEntry;

                                //   overlayEntry = OverlayEntry(
                                //     builder: (context) => Positioned(
                                //       top: 100.0,
                                //       left: 50.0,
                                //       child: Material(
                                //         child: Container(
                                //           padding: EdgeInsets.all(8.0),
                                //           color: Colors.blue,
                                //           child: Text('Thông báo tùy chỉnh'),
                                //         ),
                                //       ),
                                //     ),
                                //   );

                                //   Overlay.of(context).insert(overlayEntry);

                                Fluttertoast.showToast(
                                      msg: "This is Center Short Toast",
                                      toastLength: Toast.LENGTH_SHORT,
                                      gravity: ToastGravity.CENTER,
                                      timeInSecForIosWeb: 1,
                                      backgroundColor: Colors.red,
                                      textColor: Colors.white,
                                      fontSize: 16.0);

                                controller.listBenhnhan.remove(controller.listBenhnhan[(indexPage*itermPage)+index]);
                              }, 
                              icon: const Icon(Icons.delete, color: Color.fromARGB(255, 163, 76, 187)),)
                          ],
                        ),
                      ),
                    ],
                  );
                },
              ),
            );
            },
          );
        }        
      }),
      bottomNavigationBar: Row(
        children: [
          Expanded(child: IconButton(onPressed: (){
            controller.pageController.previousPage(
                      duration: const Duration(milliseconds: 500),
                      curve: Curves.ease,
                    );
          }, icon: const Icon(Icons.arrow_back))),
          Obx(() => Text("${controller.pageNumber.toString()} / ${((controller.listBenhnhan.length ~/ 100) + 1)}")),
          Expanded(child: IconButton(onPressed: (){
            controller.pageController.nextPage(
                      duration: const Duration(milliseconds: 500),
                      curve: Curves.ease,
                    );
          }, icon: const Icon(Icons.arrow_forward))),
        ],
      ),
    );
  }
}
