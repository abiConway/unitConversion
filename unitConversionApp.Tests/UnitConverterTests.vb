Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports unitConversionApp

<TestClass>
Public Class UnitConverterTests

    <TestMethod>
    Public Sub InchesToCentimeters_ReturnsCorrectValue()
        ' Arrange
        Dim input As Double = 10
        Dim expected As Double = 25.4

        ' Act
        Dim actual As Double = UnitConverter.Convert(input, "Inches to Centimeters")

        ' Assert
        Assert.AreEqual(expected, actual, 0.001)
    End Sub

    <TestMethod>
    Public Sub PoundsToKilograms_ReturnsCorrectValue()
        Dim input As Double = 100
        Dim expected As Double = 45.3592

        Dim actual As Double = UnitConverter.Convert(input, "Pounds to Kilograms")

        Assert.AreEqual(expected, actual, 0.001)
    End Sub

    <TestMethod>
    <ExpectedException(GetType(ArgumentException))>
    Public Sub InvalidConversion_ThrowsException()
        Dim input As Double = 5

        UnitConverter.Convert(input, "Invalid Type")
    End Sub

End Class
