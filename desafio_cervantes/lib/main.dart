import 'package:flutter/material.dart';
import 'package:sqflite_common_ffi/sqflite_ffi.dart';
import 'user.dart';
import 'databaseUser.dart';

void main() {
  sqfliteFfiInit();
  databaseFactory = databaseFactoryFfi;
  runApp(MaterialApp(home: UserScreen()));
}

class UserScreen extends StatefulWidget {
  @override
  _UserScreenState createState() => _UserScreenState();
}

class _UserScreenState extends State<UserScreen> {
  List<User> Users = [];

  final nameController = TextEditingController();
  final emailController = TextEditingController();
  final phoneController = TextEditingController();

  User? selectedUser;

  @override
  void initState() {
    super.initState();
    loadUsers();
  }

  void loadUsers() async {
    final list = await DatabaseUser.instance.readAllUsers();
    setState(() => Users = list);
  }

  void clean() {
    nameController.clear();
    emailController.clear();
    phoneController.clear();
    selectedUser = null;
  }

  void saveUser() async {
    final name = nameController.text;
    final email = emailController.text;
    final phone = int.tryParse(phoneController.text) ?? 0;

    if (selectedUser == null) {
      await DatabaseUser.instance.create(
          User(name: name, email: email, phone: phone));
    } else {
      await DatabaseUser.instance.update(
        User(
          id: selectedUser!.id,
          name: name,
          email: email,
          phone: phone,
        ),
      );
    }

    clean();
    loadUsers();
  }

  void updateUser(User User) {
    nameController.text = User.name;
    emailController.text = User.email;
    phoneController.text = User.phone.toString();
    setState(() => selectedUser = User);
  }

  void deleteUser(int id) async {
    await DatabaseUser.instance.delete(id);
    loadUsers();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Cadastro de Usuários')),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(children: [
          TextField(controller: nameController, decoration: InputDecoration(labelText: 'Name')),
          TextField(controller: emailController, decoration: InputDecoration(labelText: 'Email')),
          TextField(
            controller: phoneController,
            decoration: InputDecoration(labelText: 'Phone'),
            keyboardType: TextInputType.number,
          ),
          SizedBox(height: 10),
          ElevatedButton(
            onPressed: saveUser,
            child: Text(selectedUser == null ? 'Add' : 'Update'),
          ),
          Divider(),
          Expanded(
            child: ListView.builder(
              itemCount: Users.length,
              itemBuilder: (context, index) {
                final User = Users[index];
                return ListTile(
                  title: Text(User.name),
                  subtitle: Text('${User.email} - ${User.phone}'),
                  trailing: Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                          icon: Icon(Icons.edit),
                          onPressed: () => updateUser(User)),
                      IconButton(
                          icon: Icon(Icons.delete),
                          onPressed: () => deleteUser(User.id!)),
                    ],
                  ),
                );
              },
            ),
          )
        ]),
      ),
    );
  }
}