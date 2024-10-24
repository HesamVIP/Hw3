
Console.Write("Please Enter your Text Between Units [ 0 & 1 ] : ");
string binaryInput = Console.ReadLine();

if (IsBinaryString(binaryInput))
{
    int result = BinaryToDecimal(binaryInput);
    Console.WriteLine("The Decimal of input is : " + result);
}
else
{
    Console.WriteLine(" Invalid Input ! please Enter Correct Input !!! ");
}

bool IsBinaryString(string binaryString)
{
    foreach (char c in binaryString)
    {
        if (c != '0' && c != '1')
        {
            return false;
        }
    }
    return true;
}

int BinaryToDecimal(string binaryString)
{
    int decimalValue = 0;
    int length = binaryString.Length;

    for (int i = 0; i < length; i++)
    {

        decimalValue += (binaryString[length - 1 - i] - '0') * (1 << i);
    }
    return decimalValue;
}










