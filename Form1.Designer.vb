<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        btnAdd = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        btnMinus = New Button()
        btnDevide = New Button()
        btnMultiply = New Button()
        Label3 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(40, 385)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 0
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(325, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(325, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 25)
        Label2.TabIndex = 4
        Label2.Text = "Enter Number"
        ' 
        ' btnMinus
        ' 
        btnMinus.Location = New Point(254, 385)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(112, 34)
        btnMinus.TabIndex = 5
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = True
        ' 
        ' btnDevide
        ' 
        btnDevide.Location = New Point(474, 385)
        btnDevide.Name = "btnDevide"
        btnDevide.Size = New Size(112, 34)
        btnDevide.TabIndex = 6
        btnDevide.Text = "/"
        btnDevide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(662, 385)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(112, 34)
        btnMultiply.TabIndex = 7
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 25)
        Label3.TabIndex = 8
        Label3.Text = "Answer"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(333, 217)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(btnMultiply)
        Controls.Add(btnDevide)
        Controls.Add(btnMinus)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnDevide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
