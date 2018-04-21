<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Alta = New System.Windows.Forms.Button
        Me.Baja = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.Enumerar = New System.Windows.Forms.Button
        Me.Alfabetizar = New System.Windows.Forms.Button
        Me.Mayus = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Quitar = New System.Windows.Forms.Button
        Me.LeerXml = New System.Windows.Forms.Button
        Me.GrabarXml = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(152, 199)
        Me.ListBox1.TabIndex = 0
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(192, 12)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(75, 30)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Location = New System.Drawing.Point(192, 48)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(75, 30)
        Me.Baja.TabIndex = 2
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(192, 84)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 28)
        Me.Modificar.TabIndex = 3
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Enumerar
        '
        Me.Enumerar.Location = New System.Drawing.Point(192, 118)
        Me.Enumerar.Name = "Enumerar"
        Me.Enumerar.Size = New System.Drawing.Size(75, 27)
        Me.Enumerar.TabIndex = 4
        Me.Enumerar.Text = "Enumerar"
        Me.Enumerar.UseVisualStyleBackColor = True
        '
        'Alfabetizar
        '
        Me.Alfabetizar.Location = New System.Drawing.Point(192, 151)
        Me.Alfabetizar.Name = "Alfabetizar"
        Me.Alfabetizar.Size = New System.Drawing.Size(75, 31)
        Me.Alfabetizar.TabIndex = 5
        Me.Alfabetizar.Text = "Alfabetizar"
        Me.Alfabetizar.UseVisualStyleBackColor = True
        '
        'Mayus
        '
        Me.Mayus.Location = New System.Drawing.Point(192, 188)
        Me.Mayus.Name = "Mayus"
        Me.Mayus.Size = New System.Drawing.Size(75, 30)
        Me.Mayus.TabIndex = 6
        Me.Mayus.Text = "Mayus"
        Me.Mayus.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 229)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Quitar
        '
        Me.Quitar.Location = New System.Drawing.Point(192, 224)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(75, 23)
        Me.Quitar.TabIndex = 8
        Me.Quitar.Text = "Quitar"
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'LeerXml
        '
        Me.LeerXml.Location = New System.Drawing.Point(192, 283)
        Me.LeerXml.Name = "LeerXml"
        Me.LeerXml.Size = New System.Drawing.Size(75, 23)
        Me.LeerXml.TabIndex = 9
        Me.LeerXml.Text = "LeerXml"
        Me.LeerXml.UseVisualStyleBackColor = True
        '
        'GrabarXml
        '
        Me.GrabarXml.Location = New System.Drawing.Point(192, 253)
        Me.GrabarXml.Name = "GrabarXml"
        Me.GrabarXml.Size = New System.Drawing.Size(75, 24)
        Me.GrabarXml.TabIndex = 10
        Me.GrabarXml.Text = "GrabarXml"
        Me.GrabarXml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 355)
        Me.Controls.Add(Me.GrabarXml)
        Me.Controls.Add(Me.LeerXml)
        Me.Controls.Add(Me.Quitar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mayus)
        Me.Controls.Add(Me.Alfabetizar)
        Me.Controls.Add(Me.Enumerar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Enumerar As System.Windows.Forms.Button
    Friend WithEvents Alfabetizar As System.Windows.Forms.Button
    Friend WithEvents Mayus As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents LeerXml As System.Windows.Forms.Button
    Friend WithEvents GrabarXml As System.Windows.Forms.Button

End Class
