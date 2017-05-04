<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
      Me.TableColumn = New System.Windows.Forms.ComboBox()
      Me.CompareValue = New System.Windows.Forms.ComboBox()
      Me.UpdateButton = New System.Windows.Forms.Button()
      Me.SearcButton = New System.Windows.Forms.Button()
      Me.ShowAllButton = New System.Windows.Forms.Button()
      Me.ExitButton = New System.Windows.Forms.Button()
      Me.Value = New System.Windows.Forms.TextBox()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'DataGridView1
      '
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Location = New System.Drawing.Point(59, 29)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.Size = New System.Drawing.Size(586, 315)
      Me.DataGridView1.TabIndex = 0
      '
      'TableColumn
      '
      Me.TableColumn.FormattingEnabled = True
      Me.TableColumn.Items.AddRange(New Object() {"Hotel_No", "Guest_No", "Date_From", "Date_To", "Room_No"})
      Me.TableColumn.Location = New System.Drawing.Point(94, 383)
      Me.TableColumn.Name = "TableColumn"
      Me.TableColumn.Size = New System.Drawing.Size(121, 21)
      Me.TableColumn.TabIndex = 1
      '
      'CompareValue
      '
      Me.CompareValue.FormattingEnabled = True
      Me.CompareValue.Items.AddRange(New Object() {"=", ">", ">=", "<", "<="})
      Me.CompareValue.Location = New System.Drawing.Point(340, 383)
      Me.CompareValue.Name = "CompareValue"
      Me.CompareValue.Size = New System.Drawing.Size(121, 21)
      Me.CompareValue.TabIndex = 2
      '
      'UpdateButton
      '
      Me.UpdateButton.Location = New System.Drawing.Point(792, 99)
      Me.UpdateButton.Name = "UpdateButton"
      Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
      Me.UpdateButton.TabIndex = 3
      Me.UpdateButton.Text = "UPDATE"
      Me.UpdateButton.UseVisualStyleBackColor = True
      '
      'SearcButton
      '
      Me.SearcButton.Location = New System.Drawing.Point(792, 166)
      Me.SearcButton.Name = "SearcButton"
      Me.SearcButton.Size = New System.Drawing.Size(75, 23)
      Me.SearcButton.TabIndex = 4
      Me.SearcButton.Text = "SEARCH"
      Me.SearcButton.UseVisualStyleBackColor = True
      '
      'ShowAllButton
      '
      Me.ShowAllButton.Location = New System.Drawing.Point(792, 239)
      Me.ShowAllButton.Name = "ShowAllButton"
      Me.ShowAllButton.Size = New System.Drawing.Size(75, 23)
      Me.ShowAllButton.TabIndex = 5
      Me.ShowAllButton.Text = "ALL"
      Me.ShowAllButton.UseVisualStyleBackColor = True
      '
      'ExitButton
      '
      Me.ExitButton.Location = New System.Drawing.Point(792, 321)
      Me.ExitButton.Name = "ExitButton"
      Me.ExitButton.Size = New System.Drawing.Size(75, 23)
      Me.ExitButton.TabIndex = 6
      Me.ExitButton.Text = "EXIT"
      Me.ExitButton.UseVisualStyleBackColor = True
      '
      'Value
      '
      Me.Value.Location = New System.Drawing.Point(561, 384)
      Me.Value.Name = "Value"
      Me.Value.Size = New System.Drawing.Size(100, 20)
      Me.Value.TabIndex = 7
      '
      'frmBooking
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(919, 449)
      Me.Controls.Add(Me.Value)
      Me.Controls.Add(Me.ExitButton)
      Me.Controls.Add(Me.ShowAllButton)
      Me.Controls.Add(Me.SearcButton)
      Me.Controls.Add(Me.UpdateButton)
      Me.Controls.Add(Me.CompareValue)
      Me.Controls.Add(Me.TableColumn)
      Me.Controls.Add(Me.DataGridView1)
      Me.Name = "frmBooking"
      Me.Text = "Form1"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents DataGridView1 As DataGridView
   Friend WithEvents TableColumn As ComboBox
   Friend WithEvents CompareValue As ComboBox
   Friend WithEvents UpdateButton As Button
   Friend WithEvents SearcButton As Button
   Friend WithEvents ShowAllButton As Button
   Friend WithEvents ExitButton As Button
   Friend WithEvents Value As TextBox
   Friend WithEvents hotelBindingSource As BindingSource
   Friend WithEvents bookingBindingSource As BindingSource
End Class
