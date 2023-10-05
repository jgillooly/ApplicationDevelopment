// See https://aka.ms/new-console-template for more information
string firstNumber = "10";
string secondNumber = "2";


MathStuff mathStuff = new MathStuff(15, 32);

Console.WriteLine(mathStuff.addStuff(firstNumber, secondNumber));

public class MathStuff
{
    public MathStuff(short number, short numberAgain) {
        shortOne = number;
        shortTwo = numberAgain;
    }

    private short shortOne {  get; set; }
    private short shortTwo { get; set; }

    public int addStuff()
    {
        return shortOne + shortTwo;
    }

    public int addStuff(int number, int alsoNumber)
    {
        return number + alsoNumber;
    }
    public int addStuff(string firstNumber, string secondNumber)
    {
        return int.Parse(firstNumber) + int.Parse(secondNumber);
    }
}