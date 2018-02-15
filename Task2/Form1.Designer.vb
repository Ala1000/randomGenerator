<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.max = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sorted_txt_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.search_result_label = New System.Windows.Forms.Label()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.binary = New System.Windows.Forms.RadioButton()
        Me.linear = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rand_disp = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'max
        '
        Me.max.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.max.Location = New System.Drawing.Point(296, 69)
        Me.max.Name = "max"
        Me.max.Size = New System.Drawing.Size(48, 24)
        Me.max.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Max"
        '
        'min
        '
        Me.min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.min.Location = New System.Drawing.Point(47, 69)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(48, 24)
        Me.min.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Min"
        '
        'sorted_txt_box
        '
        Me.sorted_txt_box.Location = New System.Drawing.Point(5, 178)
        Me.sorted_txt_box.Name = "sorted_txt_box"
        Me.sorted_txt_box.Size = New System.Drawing.Size(719, 20)
        Me.sorted_txt_box.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sorted random numbers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Random numbers"
        '
        'search_result_label
        '
        Me.search_result_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_result_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.search_result_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.search_result_label.Location = New System.Drawing.Point(591, 16)
        Me.search_result_label.Name = "search_result_label"
        Me.search_result_label.Size = New System.Drawing.Size(98, 25)
        Me.search_result_label.TabIndex = 4
        '
        'search_box
        '
        Me.search_box.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.search_box.Location = New System.Drawing.Point(484, 18)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(54, 20)
        Me.search_box.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter number to search for:"
        '
        'binary
        '
        Me.binary.AutoSize = True
        Me.binary.Location = New System.Drawing.Point(6, 19)
        Me.binary.Name = "binary"
        Me.binary.Size = New System.Drawing.Size(89, 17)
        Me.binary.TabIndex = 1
        Me.binary.TabStop = True
        Me.binary.Text = "Binary search"
        Me.binary.UseVisualStyleBackColor = True
        '
        'linear
        '
        Me.linear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.linear.AutoSize = True
        Me.linear.Location = New System.Drawing.Point(143, 19)
        Me.linear.Name = "linear"
        Me.linear.Size = New System.Drawing.Size(89, 17)
        Me.linear.TabIndex = 0
        Me.linear.TabStop = True
        Me.linear.Text = "Linear search"
        Me.linear.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.16142!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.94017!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(739, 229)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sorted_txt_box)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rand_disp)
        Me.GroupBox2.Controls.Add(Me.max)
        Me.GroupBox2.Controls.Add(Me.binary)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.linear)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.search_box)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.search_result_label)
        Me.GroupBox2.Controls.Add(Me.min)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(733, 207)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search for numbers"
        '
        'rand_disp
        '
        Me.rand_disp.Location = New System.Drawing.Point(5, 125)
        Me.rand_disp.Name = "rand_disp"
        Me.rand_disp.Size = New System.Drawing.Size(719, 20)
        Me.rand_disp.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 245)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents search_result_label As System.Windows.Forms.Label
    Friend WithEvents search_box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents binary As System.Windows.Forms.RadioButton
    Friend WithEvents linear As System.Windows.Forms.RadioButton
    Friend WithEvents max As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sorted_txt_box As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rand_disp As System.Windows.Forms.TextBox

End Class
