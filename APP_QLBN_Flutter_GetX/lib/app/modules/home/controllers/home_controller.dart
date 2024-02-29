import 'dart:convert';
import 'package:app_qlbn/app/data/models/Benhnhan.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:http/http.dart';

class HomeController extends GetxController {
  PageController pageController = PageController();
  RxInt pageNumber = 1.obs;
  RxList<Benhnhan> listBenhnhan = <Benhnhan>[].obs;
  void getData() async {
    RxList<Benhnhan> listBenhnhan2 = <Benhnhan>[].obs;
    listBenhnhan2.clear();
    const String apiUrl = 'http://api.ctu-it.com:5000/api/Benhnhan';
    try {
      final response = await get(Uri.parse(apiUrl));
      if (response.statusCode == 200) {
        List<dynamic> data = json.decode(response.body);
        for (var element in data) {
          listBenhnhan2.add(Benhnhan.fromJson(element));
        }
      }else{
       // showSnackBar("Có lỗi xảy ra!", context);
      }
    } catch (e) {
      //showSnackBar("Có lỗi xảy ra: $e", context);
    }
    listBenhnhan = listBenhnhan2;
  }

  // void showSnackBar(String message, var context) {
  //   ScaffoldMessenger.of(context).showSnackBar(
  //     SnackBar(
  //       content: Text(message),
  //     ),
  //   );
  // }

  int thamAn(int toltal, int max, int page){
    int temp = 0;
    temp = toltal - (max*page);
    if(temp > max){
      return max;
    }else{
      return temp;
    }
  }

  @override
  void onInit() {
    getData();
    super.onInit();
  }

  @override
  void onReady() {
    super.onReady();
  }

  @override
  void onClose() {
    super.onClose();
  }
}
