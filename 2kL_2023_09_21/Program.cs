using _2kL_2023_09_21;

var mc1 = new MyClass(3);
var mc2 = new MyClass(7);
Console.WriteLine(mc1);
Console.WriteLine(mc2);
var mc3 = mc1 + mc2;
Console.WriteLine(mc3);
Console.WriteLine(-mc3);
Console.WriteLine(+(-mc3));
Console.WriteLine(4 + mc1 + 5);
MyClass mc4 = 7;
int x = (int)mc4;
string s = (string)(mc4+10);
Console.WriteLine(s);
MyClass mc5 = 358;
Console.WriteLine(mc5[2]);
