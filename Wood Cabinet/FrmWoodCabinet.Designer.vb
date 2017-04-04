<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWoodCabinet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWoodCabinet))
        Me.LblWoodCabinetCost = New System.Windows.Forms.Label()
        Me.LblLinearFeet = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPine = New System.Windows.Forms.RadioButton()
        Me.RBOak = New System.Windows.Forms.RadioButton()
        Me.RBCherry = New System.Windows.Forms.RadioButton()
        Me.TxtFeet = New System.Windows.Forms.TextBox()
        Me.LblCostEst = New System.Windows.Forms.Label()
        Me.LblCost = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWoodCabinetCost
        '
        Me.LblWoodCabinetCost.AutoSize = True
        Me.LblWoodCabinetCost.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWoodCabinetCost.Location = New System.Drawing.Point(32, 24)
        Me.LblWoodCabinetCost.Name = "LblWoodCabinetCost"
        Me.LblWoodCabinetCost.Size = New System.Drawing.Size(231, 31)
        Me.LblWoodCabinetCost.TabIndex = 0
        Me.LblWoodCabinetCost.Text = "Wood Cabinet Cost"
        '
        'LblLinearFeet
        '
        Me.LblLinearFeet.AutoSize = True
        Me.LblLinearFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLinearFeet.Location = New System.Drawing.Point(53, 71)
        Me.LblLinearFeet.Name = "LblLinearFeet"
        Me.LblLinearFeet.Size = New System.Drawing.Size(90, 20)
        Me.LblLinearFeet.TabIndex = 1
        Me.LblLinearFeet.Text = "Linear Feet"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RBCherry)
        Me.GroupBox1.Controls.Add(Me.RBOak)
        Me.GroupBox1.Controls.Add(Me.RbPine)
        Me.GroupBox1.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(75, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wood Type"
        '
        'RbPine
        '
        Me.RbPine.AutoSize = True
        Me.RbPine.Checked = True
        Me.RbPine.Location = New System.Drawing.Point(34, 26)
        Me.RbPine.Name = "RbPine"
        Me.RbPine.Size = New System.Drawing.Size(56, 25)
        Me.RbPine.TabIndex = 0
        Me.RbPine.TabStop = True
        Me.RbPine.Text = "Pine"
        Me.RbPine.UseVisualStyleBackColor = True
        '
        'RBOak
        '
        Me.RBOak.AutoSize = True
        Me.RBOak.Location = New System.Drawing.Point(34, 51)
        Me.RBOak.Name = "RBOak"
        Me.RBOak.Size = New System.Drawing.Size(56, 25)
        Me.RBOak.TabIndex = 1
        Me.RBOak.Text = "Oak"
        Me.RBOak.UseVisualStyleBackColor = True
        '
        'RBCherry
        '
        Me.RBCherry.AutoSize = True
        Me.RBCherry.Location = New System.Drawing.Point(34, 76)
        Me.RBCherry.Name = "RBCherry"
        Me.RBCherry.Size = New System.Drawing.Size(73, 25)
        Me.RBCherry.TabIndex = 2
        Me.RBCherry.Text = "Cherry"
        Me.RBCherry.UseVisualStyleBackColor = True
        '
        'TxtFeet
        '
        Me.TxtFeet.Location = New System.Drawing.Point(161, 71)
        Me.TxtFeet.Name = "TxtFeet"
        Me.TxtFeet.Size = New System.Drawing.Size(56, 20)
        Me.TxtFeet.TabIndex = 3
        '
        'LblCostEst
        '
        Me.LblCostEst.AutoSize = True
        Me.LblCostEst.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostEst.Location = New System.Drawing.Point(34, 221)
        Me.LblCostEst.Name = "LblCostEst"
        Me.LblCostEst.Size = New System.Drawing.Size(121, 23)
        Me.LblCostEst.TabIndex = 4
        Me.LblCostEst.Text = "Cost Estimate:"
        '
        'LblCost
        '
        Me.LblCost.AutoSize = True
        Me.LblCost.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCost.Location = New System.Drawing.Point(161, 221)
        Me.LblCost.Name = "LblCost"
        Me.LblCost.Size = New System.Drawing.Size(84, 23)
        Me.LblCost.TabIndex = 5
        Me.LblCost.Text = "$0000.00"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.White
        Me.BtnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(38, 257)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(100, 30)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(163, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmWoodCabinet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(302, 479)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.LblCost)
        Me.Controls.Add(Me.LblCostEst)
        Me.Controls.Add(Me.TxtFeet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblLinearFeet)
        Me.Controls.Add(Me.LblWoodCabinetCost)
        Me.Name = "FrmWoodCabinet"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblWoodCabinetCost As System.Windows.Forms.Label
    Friend WithEvents LblLinearFeet As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBCherry As System.Windows.Forms.RadioButton
    Friend WithEvents RBOak As System.Windows.Forms.RadioButton
    Friend WithEvents RbPine As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFeet As System.Windows.Forms.TextBox
    Friend WithEvents LblCostEst As System.Windows.Forms.Label
    Friend WithEvents LblCost As System.Windows.Forms.Label
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
