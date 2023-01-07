<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShoesRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.WeightRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.HeightRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.AgeRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SimblingsRadioButton4 = New System.Windows.Forms.RadioButton()
        Me.CarsRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PetsRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(494, 137)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(342, 290)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select a variable to retrive a Univariate Distribution" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ShoesRadioButton1
        '
        Me.ShoesRadioButton1.AutoSize = True
        Me.ShoesRadioButton1.Location = New System.Drawing.Point(96, 258)
        Me.ShoesRadioButton1.Name = "ShoesRadioButton1"
        Me.ShoesRadioButton1.Size = New System.Drawing.Size(107, 24)
        Me.ShoesRadioButton1.TabIndex = 3
        Me.ShoesRadioButton1.TabStop = True
        Me.ShoesRadioButton1.Text = "Shoe Size"
        Me.ShoesRadioButton1.UseVisualStyleBackColor = True
        '
        'WeightRadioButton1
        '
        Me.WeightRadioButton1.AutoSize = True
        Me.WeightRadioButton1.Location = New System.Drawing.Point(96, 176)
        Me.WeightRadioButton1.Name = "WeightRadioButton1"
        Me.WeightRadioButton1.Size = New System.Drawing.Size(84, 24)
        Me.WeightRadioButton1.TabIndex = 4
        Me.WeightRadioButton1.TabStop = True
        Me.WeightRadioButton1.Text = "Weight"
        Me.WeightRadioButton1.UseVisualStyleBackColor = True
        '
        'HeightRadioButton2
        '
        Me.HeightRadioButton2.AutoSize = True
        Me.HeightRadioButton2.Location = New System.Drawing.Point(96, 219)
        Me.HeightRadioButton2.Name = "HeightRadioButton2"
        Me.HeightRadioButton2.Size = New System.Drawing.Size(81, 24)
        Me.HeightRadioButton2.TabIndex = 5
        Me.HeightRadioButton2.TabStop = True
        Me.HeightRadioButton2.Text = "Height"
        Me.HeightRadioButton2.UseVisualStyleBackColor = True
        '
        'AgeRadioButton3
        '
        Me.AgeRadioButton3.AutoSize = True
        Me.AgeRadioButton3.Location = New System.Drawing.Point(96, 137)
        Me.AgeRadioButton3.Name = "AgeRadioButton3"
        Me.AgeRadioButton3.Size = New System.Drawing.Size(63, 24)
        Me.AgeRadioButton3.TabIndex = 6
        Me.AgeRadioButton3.TabStop = True
        Me.AgeRadioButton3.Text = "Age"
        Me.AgeRadioButton3.UseVisualStyleBackColor = True
        '
        'SimblingsRadioButton4
        '
        Me.SimblingsRadioButton4.AutoSize = True
        Me.SimblingsRadioButton4.Location = New System.Drawing.Point(96, 298)
        Me.SimblingsRadioButton4.Name = "SimblingsRadioButton4"
        Me.SimblingsRadioButton4.Size = New System.Drawing.Size(180, 24)
        Me.SimblingsRadioButton4.TabIndex = 7
        Me.SimblingsRadioButton4.TabStop = True
        Me.SimblingsRadioButton4.Text = "Number of Simblings"
        Me.SimblingsRadioButton4.UseVisualStyleBackColor = True
        '
        'CarsRadioButton1
        '
        Me.CarsRadioButton1.AutoSize = True
        Me.CarsRadioButton1.Location = New System.Drawing.Point(96, 339)
        Me.CarsRadioButton1.Name = "CarsRadioButton1"
        Me.CarsRadioButton1.Size = New System.Drawing.Size(145, 24)
        Me.CarsRadioButton1.TabIndex = 8
        Me.CarsRadioButton1.TabStop = True
        Me.CarsRadioButton1.Text = "Number of Cars"
        Me.CarsRadioButton1.UseVisualStyleBackColor = True
        '
        'PetsRadioButton1
        '
        Me.PetsRadioButton1.AutoSize = True
        Me.PetsRadioButton1.Location = New System.Drawing.Point(97, 381)
        Me.PetsRadioButton1.Name = "PetsRadioButton1"
        Me.PetsRadioButton1.Size = New System.Drawing.Size(144, 24)
        Me.PetsRadioButton1.TabIndex = 9
        Me.PetsRadioButton1.TabStop = True
        Me.PetsRadioButton1.Text = "Number of Pets"
        Me.PetsRadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button1.Location = New System.Drawing.Point(595, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Initializate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PetsRadioButton1)
        Me.Controls.Add(Me.CarsRadioButton1)
        Me.Controls.Add(Me.SimblingsRadioButton4)
        Me.Controls.Add(Me.AgeRadioButton3)
        Me.Controls.Add(Me.HeightRadioButton2)
        Me.Controls.Add(Me.WeightRadioButton1)
        Me.Controls.Add(Me.ShoesRadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShoesRadioButton1 As RadioButton
    Friend WithEvents WeightRadioButton1 As RadioButton
    Friend WithEvents HeightRadioButton2 As RadioButton
    Friend WithEvents AgeRadioButton3 As RadioButton
    Friend WithEvents SimblingsRadioButton4 As RadioButton
    Friend WithEvents CarsRadioButton1 As RadioButton
    Friend WithEvents PetsRadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
End Class
