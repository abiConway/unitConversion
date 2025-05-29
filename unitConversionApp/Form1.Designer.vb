<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SaveFileDialog1 = New SaveFileDialog()
        convertButton = New Button()
        inputLabel = New Label()
        inputTextBox = New TextBox()
        unitComboBox = New ComboBox()
        resultLabel = New Label()
        historyListBox = New ListBox()
        clearHistoryButton = New Button()
        SuspendLayout()
        ' 
        ' convertButton
        ' 
        convertButton.Location = New Point(532, 40)
        convertButton.Name = "convertButton"
        convertButton.Size = New Size(112, 34)
        convertButton.TabIndex = 2
        convertButton.Text = "Convert"
        convertButton.UseVisualStyleBackColor = True
        ' 
        ' inputLabel
        ' 
        inputLabel.AccessibleRole = AccessibleRole.TitleBar
        inputLabel.AutoSize = True
        inputLabel.Location = New Point(33, 45)
        inputLabel.Name = "inputLabel"
        inputLabel.Size = New Size(63, 25)
        inputLabel.TabIndex = 3
        inputLabel.Text = "Label1"
        ' 
        ' inputTextBox
        ' 
        inputTextBox.Location = New Point(137, 42)
        inputTextBox.Name = "inputTextBox"
        inputTextBox.Size = New Size(150, 31)
        inputTextBox.TabIndex = 4
        ' 
        ' unitComboBox
        ' 
        unitComboBox.FormattingEnabled = True
        unitComboBox.Location = New Point(309, 40)
        unitComboBox.Name = "unitComboBox"
        unitComboBox.Size = New Size(182, 33)
        unitComboBox.TabIndex = 5
        ' 
        ' resultLabel
        ' 
        resultLabel.AutoSize = True
        resultLabel.Location = New Point(33, 93)
        resultLabel.Name = "resultLabel"
        resultLabel.Size = New Size(63, 25)
        resultLabel.TabIndex = 6
        resultLabel.Text = "Label1"
        ' 
        ' historyListBox
        ' 
        historyListBox.FormattingEnabled = True
        historyListBox.ItemHeight = 25
        historyListBox.Location = New Point(33, 225)
        historyListBox.Name = "historyListBox"
        historyListBox.Size = New Size(180, 129)
        historyListBox.TabIndex = 7
        ' 
        ' clearHistoryButton
        ' 
        clearHistoryButton.Location = New Point(219, 320)
        clearHistoryButton.Name = "clearHistoryButton"
        clearHistoryButton.Size = New Size(112, 34)
        clearHistoryButton.TabIndex = 8
        clearHistoryButton.Text = "Button1"
        clearHistoryButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1363, 411)
        Controls.Add(clearHistoryButton)
        Controls.Add(historyListBox)
        Controls.Add(resultLabel)
        Controls.Add(unitComboBox)
        Controls.Add(inputTextBox)
        Controls.Add(inputLabel)
        Controls.Add(convertButton)
        Name = "Form1"
        Text = "ew"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog

    Private Sub txtValues_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents convertButton As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles convertButton.Click

    End Sub

    Friend WithEvents inputLabel As Label
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents unitComboBox As ComboBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents historyListBox As ListBox
    Friend WithEvents clearHistoryButton As Button
End Class
