// See https://aka.ms/new-console-template for more information

using NumberManipulation;

Operations op = new Operations();
Menu menu = new Menu();

List<int> numbers = new List<int>();

op.generateRandomNumber(numbers);
//op.inputNumber(numbers);
menu.ChoseOption(numbers);



