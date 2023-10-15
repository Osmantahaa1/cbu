string inputText = textBoxInput.Text;
string selectedUnit = comboBoxUnits.SelectedItem as string;
string result = "";

if (selectedUnit == "Decimal to Hexadecimal")
{
    try
    {
        int decimalValue = Convert.ToInt32(inputText);
        result = decimalValue.ToString("X");
    }
    catch (FormatException)
    {
        result = "Geçersiz giriş!";
    }
}
else if (selectedUnit == "Hexadecimal to Decimal")
{
    try
    {
        int decimalValue = Convert.ToInt32(inputText, 16);
        result = decimalValue.ToString();
    }
    catch (FormatException)
    {
        result = "Geçersiz giriş!";
    }
}
else if (selectedUnit == "Decimal to Binary")
{
    try
    {
        int decimalValue = Convert.ToInt32(inputText);
        result = Convert.ToString(decimalValue, 2);
    }
    catch (FormatException)
    {
        result = "Geçersiz giriş!";
    }
}
else if (selectedUnit == "Binary to Decimal")
{
    if (IsBinaryValid(inputText))
    {
        int decimalValue = Convert.ToInt32(inputText, 2);
        result = decimalValue.ToString();
    }
    else
    {
        result = "Geçersiz giriş!";
    }
}

labelResult.Text = "Sonuç: " + result;
