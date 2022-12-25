using OopPolymorphismOverloading;

//object initialize

BasicMath basic1 = new BasicMath();
//BasicMath basic2 = new()
//{
//    NumberTwo = 5
//};
//BasicMath basic3 = new()
//{
//    NumberTwo = 5
//};
//BasicMath basic4 = new()
//{
//    NumberTwo = 5,
//    NumberOne = 4
//};

basic1.Sum();       //Output :0
basic1.Sum(5, 6);   //Output :11
basic1.Sum(5);  //

//name argument
basic1.Sum(num2: 5);
basic1.Sum(num2: 5, num1: 9);