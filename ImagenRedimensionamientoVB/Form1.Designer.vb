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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAlto = New System.Windows.Forms.Label()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAltoNuevo = New System.Windows.Forms.Label()
        Me.lblAnchonuevo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txEntradaAnchoNuevo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txOrigen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(741, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Alto"
        '
        'lblAlto
        '
        Me.lblAlto.AutoSize = True
        Me.lblAlto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlto.Location = New System.Drawing.Point(811, 174)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(20, 24)
        Me.lblAlto.TabIndex = 22
        Me.lblAlto.Text = "0"
        '
        'lblAncho
        '
        Me.lblAncho.AutoSize = True
        Me.lblAncho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAncho.Location = New System.Drawing.Point(811, 131)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(20, 24)
        Me.lblAncho.TabIndex = 21
        Me.lblAncho.Text = "0"
        Me.lblAncho.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(722, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ancho"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(741, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Alto"
        '
        'lblAltoNuevo
        '
        Me.lblAltoNuevo.AutoSize = True
        Me.lblAltoNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltoNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAltoNuevo.Location = New System.Drawing.Point(811, 393)
        Me.lblAltoNuevo.Name = "lblAltoNuevo"
        Me.lblAltoNuevo.Size = New System.Drawing.Size(20, 24)
        Me.lblAltoNuevo.TabIndex = 26
        Me.lblAltoNuevo.Text = "0"
        '
        'lblAnchonuevo
        '
        Me.lblAnchonuevo.AutoSize = True
        Me.lblAnchonuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnchonuevo.Location = New System.Drawing.Point(811, 350)
        Me.lblAnchonuevo.Name = "lblAnchonuevo"
        Me.lblAnchonuevo.Size = New System.Drawing.Size(20, 24)
        Me.lblAnchonuevo.TabIndex = 25
        Me.lblAnchonuevo.Text = "0"
        Me.lblAnchonuevo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(722, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ancho"
        '
        'txEntradaAnchoNuevo
        '
        Me.txEntradaAnchoNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEntradaAnchoNuevo.Location = New System.Drawing.Point(726, 319)
        Me.txEntradaAnchoNuevo.Name = "txEntradaAnchoNuevo"
        Me.txEntradaAnchoNuevo.Size = New System.Drawing.Size(173, 28)
        Me.txEntradaAnchoNuevo.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(13, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(686, 442)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(744, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(155, 51)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Examinar ..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(744, 439)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(155, 65)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txOrigen
        '
        Me.txOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txOrigen.Location = New System.Drawing.Point(141, 21)
        Me.txOrigen.Name = "txOrigen"
        Me.txOrigen.Size = New System.Drawing.Size(597, 28)
        Me.txOrigen.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ruta Origen :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(707, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Ingrese nuevo Ancho"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 517)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txOrigen)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txEntradaAnchoNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAltoNuevo)
        Me.Controls.Add(Me.lblAnchonuevo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAlto)
        Me.Controls.Add(Me.lblAncho)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlto As Label
    Friend WithEvents lblAncho As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAltoNuevo As Label
    Friend WithEvents lblAnchonuevo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txEntradaAnchoNuevo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txOrigen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label2 As Label
End Class
