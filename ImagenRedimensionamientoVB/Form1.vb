Public Class Form1
    Dim img As Image
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            txOrigen.Text = OpenFileDialog1.FileName
            img = Image.FromFile(OpenFileDialog1.FileName)
            lblAncho.Text = "" + img.Width.ToString()
            lblAlto.Text = "" + img.Height.ToString()
        End If
    End Sub
    Public Function convertir(imagen As Image, anchito As Integer, altito As Integer)
        Dim bmp As New Bitmap(anchito, altito)
        Using grafico As Graphics = Graphics.FromImage(bmp)
            grafico.DrawImage(imagen, 0, 0, anchito, altito)
            grafico.Dispose()
            Return bmp
        End Using

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim entradaAncho As Int32 = txEntradaAnchoNuevo.Text
            lblAnchonuevo.Text = entradaAncho.ToString
            Dim alto As Int32 = Int32.Parse(lblAlto.Text)
            Dim ancho As Int32 = Int32.Parse(lblAncho.Text)
            Dim resultado As Integer = (alto * entradaAncho) / ancho
            lblAltoNuevo.Text = resultado.ToString
            img = convertir(img, entradaAncho, resultado)
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                img.Save(SaveFileDialog1.FileName & ".jpg", Imaging.ImageFormat.Jpeg)
                MsgBox("Imagen Guardada")
            End If

        Catch ex As Exception
            MsgBox("Cargue una Imagen y un numero de Ancho ")
        End Try
    End Sub
End Class
