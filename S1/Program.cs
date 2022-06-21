// На вход принимает два числа и выдает, какое число большее, а какое меньшее
// а=5; b=7 -> max=7, min=5
// a=2; b=10 -> max=10, min=2
// a=-9, b=-3 -> max=-3, min=-9

int A = -9;
int B = -3;
if (A > B)
{
    Console.WriteLine("min: " + B);
    Console.WriteLine("max: " + A);
}
else
{
   Console.WriteLine("min: " + A);
   Console.WriteLine("max: " + B);
}
