int n = InputInt("Введите число: ");
int count = 1;
while (count <= n)
{
    int cube = count * count * count;
    Console.Write(cube + ", ");
    count++;
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}