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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnSimple = New System.Windows.Forms.Button()
        Me.btnComplex = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter your age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(129, 10)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(118, 20)
        Me.txtAge.TabIndex = 1
        '
        'btnSimple
        '
        Me.btnSimple.Location = New System.Drawing.Point(12, 41)
        Me.btnSimple.Name = "btnSimple"
        Me.btnSimple.Size = New System.Drawing.Size(75, 23)
        Me.btnSimple.TabIndex = 2
        Me.btnSimple.Text = "Simple"
        Me.btnSimple.UseVisualStyleBackColor = True
        '
        'btnComplex
        '
        Me.btnComplex.Location = New System.Drawing.Point(93, 41)
        Me.btnComplex.Name = "btnComplex"
        Me.btnComplex.Size = New System.Drawing.Size(75, 23)
        Me.btnComplex.TabIndex = 2
        Me.btnComplex.Text = "Complex"
        Me.btnComplex.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(174, 41)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 74)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnComplex)
        Me.Controls.Add(Me.btnSimple)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Message Box Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnComplex As Button
    Friend WithEvents btnClose As Button
End Class
