class Benhnhan {
  String? id;
  String? name;
  String? address;
  String? phone;
  String? gender;
  String? time;
  String? ppdt;

  Benhnhan(
      {this.id,
      this.name,
      this.address,
      this.phone,
      this.gender,
      this.time,
      this.ppdt});

  Benhnhan.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    name = json['name'];
    address = json['address'];
    phone = json['phone'];
    gender = json['gender'];
    time = json['time'];
    ppdt = json['ppdt'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['name'] = name;
    data['address'] = address;
    data['phone'] = phone;
    data['gender'] = gender;
    data['time'] = time;
    data['ppdt'] = ppdt;
    return data;
  }
}
