Imports Microsoft.VisualBasic

' UnitConverter is a utility class responsible for performing unit conversions
' It follows the Single Responsibility Principle by isolating business logic
Public Class UnitConverter

    ' Shared method means it can be called without creating an instance of the class
    ' Accepts a numeric value and a conversion type, returns the converted value
    Public Shared Function Convert(value As Double, conversionType As String) As Double
        Select Case conversionType
            Case "Inches to Centimeters"
                Return value * 2.54

            Case "Centimeters to Inches"
                Return value / 2.54

            Case "Pounds to Kilograms"
                Return value * 0.453592

            Case "Kilograms to Pounds"
                Return value / 0.453592

            Case Else
                ' Enforces robustness: prevents unsupported conversions
                Throw New ArgumentException("Unsupported conversion type.")
        End Select
    End Function

End Class
