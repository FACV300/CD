Public Class Form1

    Public precio As Double = 0
    Dim CanA As Double = 0
    Dim CanB As Double = 0
    Dim CanC As Double = 0
    Dim CanD As Double = 0
    Dim BtnA As Boolean = False
    Dim BtnB As Boolean = False
    Dim BtnC As Boolean = False
    Dim BtnD As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnVerInfo1_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub BtnVerInfo2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnVerInfo3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnVerInfo4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblNombreCancion.Text = ""
        LblNombreArtista.Text = ""
        LblAlbum.Text = ""
        lblAño.Text = ""
        LblPrecioCan.Text = " S/. 0"
        LblNombreCancionSec1.Text = "Far From the End of the World"
        LblNombreArtistaSec1.Text = "Masterplan"
        LblNombreCancionSec2.Text = "21 Guns"
        LblNombreArtistaSec2.Text = "Green Day"
        LblNombreCancionSec3.Text = "Under the Bridge"
        LblNombreArtistaSec3.Text = "Red Hot Chilli Pepppers"
        LblNombreCancionSec4.Text = "Free Bird"
        LblNombreArtistaSec4.Text = "lynyrd skynyrd"



    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackColor = Color.DimGray
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.Black

    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Panel2.BackColor = Color.DimGray
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Color.Black
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter
        Panel3.BackColor = Color.DimGray
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = Color.Black
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter
        Panel4.BackColor = Color.DimGray
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.BackColor = Color.Black
    End Sub

    Private Sub BtnCerrar_MouseEnter(sender As Object, e As EventArgs) Handles BtnCerrar.MouseEnter
        BtnCerrar.BackColor = Color.DimGray
    End Sub

    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.Black
    End Sub

    Private Sub BtnComprar1_Click(sender As Object, e As EventArgs) Handles BtnComprar1.Click
        If BtnA = False Then
            CanA = 3
            BtnA = True
            precio = precio + CanA
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = "Far From the End of the World"
            LblNombreArtista.Text = "Masterplan"
            LblAlbum.Text = "Time To Be King"
            lblAño.Text = "2010"
            LblPrecioCan.Text = " S/. 3.00"
            BtnComprar1.Text = "Seleccionada"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\masterplan.jpg", True)
        Else
            Beep()
        End If
    End Sub





    Private Sub BtnComprar2_Click(sender As Object, e As EventArgs) Handles BtnComprar2.Click
        If BtnB = False Then
            CanB = 2
            BtnB = True
            precio = precio + CanB
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = "21 Guns"
            LblNombreArtista.Text = "Green Day"
            LblAlbum.Text = "21st Century Breakdown"
            lblAño.Text = "2009"
            LblPrecioCan.Text = " S/. 2.00"
            BtnComprar2.Text = "Seleccionada"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\Green.jpg", True)

        Else
            Beep()
        End If
    End Sub

    Private Sub BtnComprar3_Click(sender As Object, e As EventArgs) Handles BtnComprar3.Click
        If BtnC = False Then
            CanC = 4
            BtnC = True
            precio = precio + CanC
            LblMostrarTotal.Text = precio
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = "Under the Bridge"
            LblNombreArtista.Text = "Red Hot Chilli Pepppers"
            LblAlbum.Text = "Blood Sugar Sex Magik"
            lblAño.Text = "1991"
            LblPrecioCan.Text = " S/. 3.00"
            BtnComprar3.Text = "Seleccionada"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\red.jpg", True)
        Else
            Beep()
        End If
    End Sub

    Private Sub BtnComprar4_Click(sender As Object, e As EventArgs) Handles BtnComprar4.Click
        If BtnD = False Then
            CanD = 3
            BtnD = True
            precio = precio + CanD
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = "Free Bird"
            LblNombreArtista.Text = "Lynyrd Skynyrd"
            LblAlbum.Text = "pronounced 'lĕh-'nérd 'skin-'nérd"
            lblAño.Text = "1973"
            LblPrecioCan.Text = " S/. 3.00"
            BtnComprar4.Text = "Seleccionada"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\free.jpg", True)
        Else
            Beep()
        End If
    End Sub

    Private Sub BtnQuitar1_Click(sender As Object, e As EventArgs) Handles BtnQuitar1.Click
        If CanA = 3 Then
            CanA = 0
            BtnA = False
            precio = precio - 3
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = ""
            LblNombreArtista.Text = ""
            LblAlbum.Text = ""
            lblAño.Text = ""
            LblPrecioCan.Text = " S/."
            BtnComprar1.Text = "Añadir"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\just.jpg", True)
        Else
        End If
    End Sub

    Private Sub BtnQuitar2_Click(sender As Object, e As EventArgs) Handles BtnQuitar2.Click
        If CanB = 2 Then
            CanB = 0
            BtnB = False
            precio = precio - 2
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = ""
            LblNombreArtista.Text = ""
            LblAlbum.Text = ""
            lblAño.Text = ""
            LblPrecioCan.Text = " S/."
            BtnComprar2.Text = "Añadir"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\just.jpg", True)
        Else
        End If
    End Sub

    Private Sub BtnQuitar3_Click(sender As Object, e As EventArgs) Handles BtnQuitar3.Click
        If CanC = 4 Then
            CanC = CanC - 4
            BtnC = False
            precio = precio - 4
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = ""
            LblNombreArtista.Text = ""
            LblAlbum.Text = ""
            lblAño.Text = ""
            LblPrecioCan.Text = " S/."
            BtnComprar3.Text = "Añadir"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\just.jpg", True)
        Else
        End If
    End Sub

    Private Sub BtnQuitar4_Click(sender As Object, e As EventArgs) Handles BtnQuitar4.Click
        If CanD = 3 Then
            CanD = CanD - 3
            BtnD = False
            precio = precio - 3
            LblMostrarTotal.Text = precio
            LblNombreCancion.Text = ""
            LblNombreArtista.Text = ""
            LblAlbum.Text = ""
            lblAño.Text = ""
            LblPrecioCan.Text = " S/."
            BtnComprar4.Text = "Añadir"
            PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\just.jpg", True)
        Else
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        LblNombreCancion.Text = "Far From the End of the World"
        LblNombreArtista.Text = "Masterplan"
        LblAlbum.Text = "Time To Be King"
        lblAño.Text = "2010"
        LblPrecioCan.Text = " S/. 3.00"
        PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\masterplan.jpg", True)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        LblNombreCancion.Text = "21 Guns"
        LblNombreArtista.Text = "Green Day"
        LblAlbum.Text = "21st Century Breakdown"
        lblAño.Text = "2009"
        LblPrecioCan.Text = " S/. 2.00"
        PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\green.jpg", True)

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        LblNombreCancion.Text = "Under the Bridge"
        LblNombreArtista.Text = "Red Hot Chilli Pepppers"
        LblAlbum.Text = "Blood Sugar Sex Magik"
        lblAño.Text = "1991"
        LblPrecioCan.Text = " S/. 3.00"
        PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\red.jpg", True)

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        LblNombreCancion.Text = "Free Bird"
        LblNombreArtista.Text = "Lynyrd Skynyrd"
        LblAlbum.Text = "pronounced 'lĕh-'nérd 'skin-'nérd"
        lblAño.Text = "1973"
        LblPrecioCan.Text = " S/. 3.00"
        PictureBox1.Image = Image.FromFile("C:\cd\sesión8\Ima\free.jpg", True)
    End Sub

    Private Sub BtnComprarp_Click(sender As Object, e As EventArgs) Handles BtnComprarp.Click

        If precio = 0 Then
            Beep()
        Else
            MessageBox.Show("Usted pagó con éxito: S/." + precio.ToString)
        End If

    End Sub
End Class