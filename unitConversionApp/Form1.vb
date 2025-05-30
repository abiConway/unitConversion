Public Class Form1

    ' This method runs once when the form is loaded
    ' It initializes control labels and populates the dropdown list with unit types
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default text for UI elements
        inputLabel.Text = "Enter value:"
        convertButton.Text = "Convert"
        resultLabel.Text = "Result:"
        clearHistoryButton.Text = "Clear History"

        ' Populate ComboBox with supported conversions
        unitComboBox.Items.Add("Inches to Centimeters")
        unitComboBox.Items.Add("Centimeters to Inches")
        unitComboBox.Items.Add("Pounds to Kilograms")
        unitComboBox.Items.Add("Kilograms to Pounds")

        ' Set the default selection to the first item
        unitComboBox.SelectedIndex = 0
    End Sub

    ' Triggered when the Convert button is clicked
    ' Validates input, performs conversion, and updates result and history
    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click
        Dim inputText As String = inputTextBox.Text ' Get raw text input
        Dim inputValue As Double

        ' Attempt to parse the input as a number
        If Double.TryParse(inputText, inputValue) Then
            Dim conversionType As String = unitComboBox.SelectedItem.ToString()

            Try
                ' Call the static conversion method from UnitConverter class
                Dim result As Double = UnitConverter.Convert(inputValue, conversionType)

                ' Show the result with two decimal precision
                resultLabel.Text = "Result: " & result.ToString("0.##")

                ' Add the conversion to the ListBox history
                historyListBox.Items.Add($"{inputValue} {conversionType} = {result:0.##}")
            Catch ex As ArgumentException
                ' If conversion type is unsupported, show error
                MessageBox.Show(ex.Message)
            End Try
        Else
            ' Notify user of invalid input
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

    ' Clears all items from the conversion history
    Private Sub clearHistoryButton_Click(sender As Object, e As EventArgs) Handles clearHistoryButton.Click
        historyListBox.Items.Clear()
    End Sub


End Class

