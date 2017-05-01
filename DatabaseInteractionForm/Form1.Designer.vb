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
      Me.DataGridView1 = New System.Windows.Forms.DataGridView()
      Me.ComboBox1 = New System.Windows.Forms.ComboBox()
      Me.ComboBox2 = New System.Windows.Forms.ComboBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'DataGridView1
      '
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Location = New System.Drawing.Point(59, 29)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.Size = New System.Drawing.Size(653, 315)
      Me.DataGridView1.TabIndex = 0
      '
      'ComboBox1
      '
      Me.ComboBox1.FormattingEnabled = True
      Me.ComboBox1.Location = New System.Drawing.Point(94, 383)
      Me.ComboBox1.Name = "ComboBox1"
      Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
      Me.ComboBox1.TabIndex = 1
      '
      'ComboBox2
      '
      Me.ComboBox2.FormattingEnabled = True
      Me.ComboBox2.Location = New System.Drawing.Point(340, 383)
      Me.ComboBox2.Name = "ComboBox2"
      Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
      Me.ComboBox2.TabIndex = 2
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(792, 99)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 3
      Me.Button1.Text = "Button1"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(792, 166)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 4
      Me.Button2.Text = "Button2"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.Location = New System.Drawing.Point(792, 239)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(75, 23)
      Me.Button3.TabIndex = 5
      Me.Button3.Text = "Button3"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button4
      '
      Me.Button4.Location = New System.Drawing.Point(792, 321)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(75, 23)
      Me.Button4.TabIndex = 6
      Me.Button4.Text = "Button4"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(561, 384)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(100, 20)
      Me.TextBox1.TabIndex = 7
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(919, 449)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.Button4)
      Me.Controls.Add(Me.Button3)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.ComboBox2)
      Me.Controls.Add(Me.ComboBox1)
      Me.Controls.Add(Me.DataGridView1)
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents DataGridView1 As DataGridView
   Friend WithEvents ComboBox1 As ComboBox
   Friend WithEvents ComboBox2 As ComboBox
   Friend WithEvents Button1 As Button
   Friend WithEvents Button2 As Button
   Friend WithEvents Button3 As Button
   Friend WithEvents Button4 As Button
   Friend WithEvents TextBox1 As TextBox
End Class
