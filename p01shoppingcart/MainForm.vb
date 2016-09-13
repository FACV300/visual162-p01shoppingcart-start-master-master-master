Public Class MainForm

    Dim acumH1 As Double = 0
    Dim acumH2 As Double = 0
    Dim acumH3 As Double = 0
    Dim acumH4 As Double = 0
    Dim acumM1 As Double = 0
    Dim acumM2 As Double = 0
    Dim acumM3 As Double = 0
    Dim acumM4 As Double = 0
    Dim acumC1 As Double = 0
    Dim acumC2 As Double = 0
    Dim acumC3 As Double = 0
    Dim acumC4 As Double = 0
    Dim acumA1 As Double = 0
    Dim acumA2 As Double = 0
    Dim acumA3 As Double = 0
    Dim acumA4 As Double = 0
    Dim alH1 As Integer = 0
    Dim alH2 As Integer = 0
    Dim alH3 As Integer = 0
    Dim alH4 As Integer = 0
    Dim alM1 As Integer = 0
    Dim alM2 As Integer = 0
    Dim alM3 As Integer = 0
    Dim alM4 As Integer = 0
    Dim alC1 As Integer = 0
    Dim alC2 As Integer = 0
    Dim alC3 As Integer = 0
    Dim alC4 As Integer = 0
    Dim alA1 As Integer = 0
    Dim alA2 As Integer = 0
    Dim alA3 As Integer = 0
    Dim alA4 As Integer = 0
    Dim totalH As Integer = 0
    Dim totalM As Integer = 0
    Dim totalC As Integer = 0
    Dim totalA As Integer = 0
    Dim totalGeneral As Integer = 0

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnCom1_Click(sender As Object, e As EventArgs) Handles BtnCom1.Click
        If Lblpro1.Text = "Camisa de Algodon" Then
            PictureBox1.Image = ImageList1.Images.Item(0)
            lblTituloProducto.Text = "Camisa de Algodon"
            LblPrecios.Text = "$ 120"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
        Else
            If Lblpro1.Text = "Polo Rayas Cuello Redondo" Then
                lblTituloProducto.Text = "Polo Rayas Cuello Redondo"
                LblPrecios.Text = "$ 80"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(4)
            Else
                If Lblpro1.Text = "Zapatos Oxfords" Then
                    PictureBox1.Image = ImageList1.Images.Item(8)
                    lblTituloProducto.Text = "Zapatos Oxfords"
                    LblPrecios.Text = "$ 120"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""
                Else
                    If Lblpro1.Text = "Reloj de Acero" Then
                        PictureBox1.Image = ImageList1.Images.Item(12)
                        lblTituloProducto.Text = "Reloj de Acero"
                        LblPrecios.Text = "$ 380"
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BtnHombres.ForeColor = Color.SteelBlue
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.Black

        lblTituloProducto.Text = "Camisa de Algodon"
        LblPrecios.Text = "$ 120"
        LblTallas.Text = "Tallas"
        Lblsml.Text = "XS  S  M  L  XL"
        PictureBox1.Image = ImageList1.Images.Item(0)

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub BtnHombres_Click(sender As Object, e As EventArgs) Handles BtnHombres.Click
        Lblcan1.Text = 0
        Lblcan2.Text = 0
        Lblcan3.Text = 0
        Lblcan4.Text = 0
        BtnHombres.ForeColor = Color.SteelBlue
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.Black
        LblTallas.ForeColor = Color.Black
        Lblsml.ForeColor = Color.Black
        lblTituloProducto.Text = "Camisa de Algodon"
        LblPrecios.Text = "$ 120"
        LblTallas.Text = "Tallas"
        Lblsml.Text = "XS  S  M  L  XL"
        PictureBox1.Image = ImageList1.Images.Item(0)
        Lblpro1.Text = "Camisa de Algodon"
        Lblpre1.Text = "120"
        Lblpro2.Text = "Blazer mezcla de Lana"
        Lblpre2.Text = "240"
        Lblpro3.Text = "Jersey Cuello Pico"
        Lblpre3.Text = "160"
        Lblpro4.Text = "Polo cuello redondeado"
        Lblpre4.Text = "70"

        Lblcan1.Text = alH1
        Lblcan2.Text = alH2
        Lblcan3.Text = alH3
        Lblcan4.Text = alH4



    End Sub

    Private Sub Btnmenos1_Click(sender As Object, e As EventArgs) Handles Btnmenos1.Click
        If Lblcan1.Text > 0 Then
            Lblcan1.Text = Lblcan1.Text - 1
            If lblTituloProducto.Text = "Camisa de Algodon" Then
                acumH1 = Lblpre1.Text * Lblcan1.Text
                totalH = acumH1 + acumH2 + acumH3 + acumH4
                alH1 = Lblcan1.Text
            ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then
                acumM1 = Lblpre1.Text * Lblcan1.Text
                totalM = acumM1 + acumM2 + acumM3 + acumM4
                alM1 = Lblcan1.Text
            ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then
                acumC1 = Lblpre1.Text * Lblcan1.Text
                totalC = acumC1 + acumC2 + acumC3 + acumC4
                alC1 = Lblcan1.Text
            ElseIf lblTituloProducto.Text = "Reloj de Acero" Then
                acumA1 = Lblpre1.Text * Lblcan1.Text
                totalA = acumA1 + acumA2 + acumA3 + acumA4
                alA1 = Lblcan1.Text
            End If
            totalGeneral = totalH + totalM + totalC + totalA
            lblTotal.Text = totalGeneral
        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas1_Click(sender As Object, e As EventArgs) Handles Btnmas1.Click
        Lblcan1.Text = Lblcan1.Text + 1
        If lblTituloProducto.Text = "Camisa de Algodon" Then
            acumH1 = Lblpre1.Text * Lblcan1.Text
            totalH = acumH1 + acumH2 + acumH3 + acumH4
            alH1 = Lblcan1.Text
        ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then
            acumM1 = Lblpre1.Text * Lblcan1.Text
            totalM = acumM1 + acumM2 + acumM3 + acumM4
            alM1 = Lblcan1.Text
        ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then
            acumC1 = Lblpre1.Text * Lblcan1.Text
            totalC = acumC1 + acumC2 + acumC3 + acumC4
            alC1 = Lblcan1.Text
        ElseIf lblTituloProducto.Text = "Reloj de Acero" Then
            acumA1 = Lblpre1.Text * Lblcan1.Text
            totalA = acumA1 + acumA2 + acumA3 + acumA4
            alA1 = Lblcan1.Text
        End If
        totalGeneral = totalH + totalM + totalC + totalA
        lblTotal.Text = totalGeneral

    End Sub

    Private Sub Btnmenos2_Click(sender As Object, e As EventArgs) Handles Btnmenos2.Click
        If Lblcan2.Text > 0 Then
            Lblcan2.Text = Lblcan2.Text - 1

            If lblTituloProducto.Text = "Camisa de Algodon" Then
                acumH2 = Lblpre2.Text * Lblcan2.Text
                totalH = acumH1 + acumH2 + acumH3 + acumH4
                alH2 = Lblcan2.Text
            ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then

                acumM2 = Lblpre2.Text * Lblcan2.Text
                totalM = acumM1 + acumM2 + acumM3 + acumM4
                alM2 = Lblcan2.Text
            ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

                acumC2 = Lblpre2.Text * Lblcan2.Text
                totalC = acumC1 + acumC2 + acumC3 + acumC4
                alC2 = Lblcan2.Text
            ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

                acumA1 = Lblpre2.Text * Lblcan2.Text
                totalA = acumA1 + acumA2 + acumA3 + acumA4
                alA2 = Lblcan2.Text

            End If
            totalGeneral = totalH + totalM + totalC + totalA
            lblTotal.Text = totalGeneral

        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas2_Click(sender As Object, e As EventArgs) Handles Btnmas2.Click
        Lblcan2.Text = Lblcan2.Text + 1
        If lblTituloProducto.Text = "Camisa de Algodon" Then

            acumH2 = Lblpre2.Text * Lblcan2.Text
            totalH = acumH1 + acumH2 + acumH3 + acumH4
            alH2 = Lblcan2.Text
        ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then

            acumM2 = Lblpre2.Text * Lblcan2.Text
            totalM = acumM1 + acumM2 + acumM3 + acumM4
            alM2 = Lblcan2.Text
        ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

            acumC2 = Lblpre2.Text * Lblcan2.Text
            totalC = acumC1 + acumC2 + acumC3 + acumC4
            alC2 = Lblcan2.Text
        ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

            acumA2 = Lblpre2.Text * Lblcan2.Text
            totalA = acumA1 + acumA2 + acumA3 + acumA4
            alA2 = Lblcan2.Text
        End If
        totalGeneral = totalH + totalM + totalC + totalA
        lblTotal.Text = totalGeneral
    End Sub

    Private Sub Btnmenos3_Click(sender As Object, e As EventArgs) Handles Btnmenos3.Click
        If Lblcan3.Text > 0 Then
            Lblcan3.Text = Lblcan3.Text - 1

            If lblTituloProducto.Text = "Camisa de Algodon" Then

                acumH3 = Lblpre3.Text * Lblcan3.Text
                totalH = acumH1 + acumH2 + acumH3 + acumH4
                alH3 = Lblcan3.Text
            ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then
                acumM3 = Lblpre3.Text * Lblcan3.Text
                totalM = acumM1 + acumM2 + acumM3 + acumM4
                alM3 = Lblcan3.Text
            ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

                acumC3 = Lblpre3.Text * Lblcan3.Text
                totalC = acumC1 + acumC2 + acumC3 + acumC4
                alC3 = Lblcan3.Text
            ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

                acumA3 = Lblpre3.Text * Lblcan3.Text
                totalA = acumA1 + acumA2 + acumA3 + acumA4
                alA3 = Lblcan3.Text
            End If
            totalGeneral = totalH + totalM + totalC + totalA
            lblTotal.Text = totalGeneral

        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas3_Click(sender As Object, e As EventArgs) Handles Btnmas3.Click
        Lblcan3.Text = Lblcan3.Text + 1
        If lblTituloProducto.Text = "Camisa de Algodon" Then

            acumH3 = Lblpre3.Text * Lblcan3.Text
            totalH = acumH1 + acumH2 + acumH3 + acumH4
            alH3 = Lblcan3.Text
        ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then

            acumM3 = Lblpre3.Text * Lblcan3.Text
            totalM = acumM1 + acumM2 + acumM3 + acumM4
            alM3 = Lblcan3.Text
        ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

            acumC3 = Lblpre3.Text * Lblcan3.Text
            totalC = acumC1 + acumC2 + acumC3 + acumC4
            alC3 = Lblcan3.Text
        ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

            acumA3 = Lblpre3.Text * Lblcan3.Text
            totalA = acumA1 + acumA2 + acumA3 + acumA4
            alA3 = Lblcan3.Text
        End If
        totalGeneral = totalH + totalM + totalC + totalA
        lblTotal.Text = totalGeneral

    End Sub

    Private Sub Btnmenos4_Click(sender As Object, e As EventArgs) Handles Btnmenos4.Click
        If Lblcan4.Text > 0 Then
            Lblcan4.Text = Lblcan4.Text - 1

            If lblTituloProducto.Text = "Camisa de Algodon" Then

                acumH4 = Lblpre4.Text * Lblcan4.Text
                totalH = acumH1 + acumH2 + acumH3 + acumH4
                alH4 = Lblcan4.Text
            ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then

                acumM4 = Lblpre4.Text * Lblcan4.Text
                totalM = acumM1 + acumM2 + acumM3 + acumM4
                alM4 = Lblcan4.Text
            ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

                acumC4 = Lblpre4.Text * Lblcan4.Text
                totalC = acumC1 + acumC2 + acumC3 + acumC4
                alC4 = Lblcan4.Text
            ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

                acumA4 = Lblpre4.Text * Lblcan4.Text
                totalA = acumA1 + acumA2 + acumA3 + acumA4
                alA4 = Lblcan4.Text
            End If
            totalGeneral = acumH4 + acumM4 + acumA4 + acumC4
            lblTotal.Text = totalGeneral

        Else
            Beep()
        End If
    End Sub

    Private Sub Btnmas4_Click(sender As Object, e As EventArgs) Handles Btnmas4.Click
        Lblcan4.Text = Lblcan4.Text + 1
        If lblTituloProducto.Text = "Camisa de Algodon" Then

            acumH4 = Lblpre4.Text * Lblcan4.Text
            totalH = acumH1 + acumH2 + acumH3 + acumH4
            alH4 = Lblcan4.Text
        ElseIf lblTituloProducto.Text = "Polo Rayas Cuello Redondo" Then

            acumM4 = Lblpre4.Text * Lblcan4.Text
            totalM = acumM1 + acumM2 + acumM3 + acumM4
            alM4 = Lblcan4.Text
        ElseIf lblTituloProducto.Text = "Zapatos Oxfords" Then

            acumC4 = Lblpre4.Text * Lblcan4.Text
            totalC = acumC1 + acumC2 + acumC3 + acumC4
            alC4 = Lblcan4.Text
        ElseIf lblTituloProducto.Text = "Reloj de Acero" Then

            acumA4 = Lblpre4.Text * Lblcan4.Text
            totalA = acumA1 + acumA2 + acumA3 + acumA4
            alA4 = Lblcan4.Text
        End If
        totalGeneral = totalH + totalM + totalC + totalA
        lblTotal.Text = totalGeneral

    End Sub

    Private Sub BtnMujeres_Click(sender As Object, e As EventArgs) Handles BtnMujeres.Click
        Lblcan1.Text = 0
        Lblcan2.Text = 0
        Lblcan3.Text = 0
        Lblcan4.Text = 0
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.SteelBlue
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.Black
        LblTallas.ForeColor = Color.Black
        Lblsml.ForeColor = Color.Black
        PictureBox1.Image = ImageList1.Images.Item(4)
        lblTituloProducto.Text = "Polo Rayas Cuello Redondo"
        LblPrecios.Text = "$ 80"
        LblTallas.Text = "Tallas"
        Lblsml.Text = "XS  S  M  L"
        Lblpro1.Text = "Polo Rayas Cuello Redondo"
        Lblpre1.Text = "80"
        Lblpro2.Text = "Chompa Lana Cuello Redondo"
        Lblpre2.Text = "150"
        Lblpro3.Text = "Casaca de Jean"
        Lblpre3.Text = "220"
        Lblpro4.Text = "Abrigo Mezcla Lana"
        Lblpre4.Text = "270"
        Lblcan1.Text = alM1
        Lblcan2.Text = alM2
        Lblcan3.Text = alM3
        Lblcan4.Text = alM4


    End Sub

    Private Sub BtnCalzado_Click(sender As Object, e As EventArgs) Handles BtnCalzado.Click

        Lblcan1.Text = 0
        Lblcan2.Text = 0
        Lblcan3.Text = 0
        Lblcan4.Text = 0
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.SteelBlue
        BtnAcce.ForeColor = Color.Black
        LblTallas.ForeColor = Color.Black
        Lblsml.ForeColor = Color.Black
        PictureBox1.Image = ImageList1.Images.Item(8)
        lblTituloProducto.Text = "Zapatos Oxfords"
        LblPrecios.Text = "$ 120"
        LblTallas.Text = "Tallas"
        Lblsml.Text = "37 38 39 40 41 42"
        Lblpro1.Text = "Zapatos Oxfords"
        Lblpre1.Text = "120"
        Lblpro2.Text = "Zapatos Derby"
        Lblpre2.Text = "140"
        Lblpro3.Text = "Botines"
        Lblpre3.Text = "160"
        Lblpro4.Text = "Loafers"
        Lblpre4.Text = "80"
        Lblcan1.Text = alC1
        Lblcan2.Text = alC2
        Lblcan3.Text = alC3
        Lblcan4.Text = alC4
    End Sub

    Private Sub BtnAcce_Click(sender As Object, e As EventArgs) Handles BtnAcce.Click
        Lblcan1.Text = 0
        Lblcan2.Text = 0
        Lblcan3.Text = 0
        Lblcan4.Text = 0
        BtnHombres.ForeColor = Color.Black
        BtnMujeres.ForeColor = Color.Black
        BtnCalzado.ForeColor = Color.Black
        BtnAcce.ForeColor = Color.SteelBlue
        PictureBox1.Image = ImageList1.Images.Item(12)
        lblTituloProducto.Text = "Reloj de Acero"
        LblPrecios.Text = "$ 380"
        LblTallas.ForeColor = Color.DarkGray
        Lblsml.ForeColor = Color.DarkGray
        Lblpro1.Text = "Reloj de Acero"
        Lblpre1.Text = "380"
        Lblpro2.Text = "Cinturón de Cuero"
        Lblpre2.Text = "70"
        Lblpro3.Text = "Billetera de Cuero"
        Lblpre3.Text = "190"
        Lblpro4.Text = "Gorra Clasica"
        Lblpre4.Text = "50"
        Lblcan1.Text = alA1
        Lblcan2.Text = alA2
        Lblcan3.Text = alA3
        Lblcan4.Text = alA4

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Lblpro2.Text = "Blazer mezcla de Lana" Then
            PictureBox1.Image = ImageList1.Images.Item(1)
            lblTituloProducto.Text = "Blazer mezcla de Lana"
            LblPrecios.Text = "$ 240"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
        Else
            If Lblpro2.Text = "Chompa Lana Cuello Redondo" Then
                lblTituloProducto.Text = "Chompa Lana Cuello Redondo"
                LblPrecios.Text = "$ 150"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(5)
            Else

                If Lblpro2.Text = "Zapatos Derby" Then
                    PictureBox1.Image = ImageList1.Images.Item(9)
                    lblTituloProducto.Text = "Zapatos Derby"
                    LblPrecios.Text = "$ 140"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""
                Else
                    If Lblpro2.Text = "Cinturón de Cuero" Then
                        PictureBox1.Image = ImageList1.Images.Item(13)
                        lblTituloProducto.Text = "Reloj de Acero"
                        LblPrecios.Text = "$ 70"
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Lblpro3.Text = "Jersey Cuello Pico" Then
            PictureBox1.Image = ImageList1.Images.Item(2)
            lblTituloProducto.Text = "Blazer mezcla de Lana"
            LblPrecios.Text = "$ 160"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""

        Else
            If Lblpro3.Text = "Casaca de Jean" Then
                lblTituloProducto.Text = "Casaca de Jean"
                LblPrecios.Text = "$ 220"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(6)
            Else
                If Lblpro3.Text = "Botines" Then
                    PictureBox1.Image = ImageList1.Images.Item(10)
                    lblTituloProducto.Text = "Botines"
                    LblPrecios.Text = "$ 160"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"
                    lblTotal.Text = ""

                Else
                    If Lblpro3.Text = "Billetera de Cuero" Then
                        PictureBox1.Image = ImageList1.Images.Item(14)
                        lblTituloProducto.Text = "Billetera de Cuero"
                        LblPrecios.Text = "$ 190"

                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Lblpro4.Text = "Polo cuello redondeado" Then
            PictureBox1.Image = ImageList1.Images.Item(3)
            lblTituloProducto.Text = "Polo cuello redondeado"
            LblPrecios.Text = "$ 70"
            LblTallas.Text = "Tallas"
            Lblsml.Text = "XS  S  M  L  XL"
            lblTotal.Text = ""
        Else
            If Lblpro4.Text = "Abrigo Mezcla Lana" Then
                lblTituloProducto.Text = "Abrigo Mezcla Lana"
                LblPrecios.Text = "$ 270"
                LblTallas.Text = "Tallas"
                Lblsml.Text = "XS  S  M  L"
                lblTotal.Text = ""
                PictureBox1.Image = ImageList1.Images.Item(7)
            Else
                If Lblpro4.Text = "Loafers" Then
                    PictureBox1.Image = ImageList1.Images.Item(11)
                    lblTituloProducto.Text = "Loafers"
                    LblPrecios.Text = "$ 80"
                    LblTallas.Text = "Tallas"
                    Lblsml.Text = "37 38 39 40 41 42"

                Else
                    If Lblpro4.Text = "Gorra Clasica" Then
                        PictureBox1.Image = ImageList1.Images.Item(15)
                        lblTituloProducto.Text = "Billetera de Cuero"
                        LblPrecios.Text = "$ 50"
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Lblcan1_Click(sender As Object, e As EventArgs) Handles Lblcan1.Click

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        If lblTotal.Text = 0 Then
            Beep()
        Else
            MessageBox.Show("Usted pagó con éxito: $ " + lblTotal.Text)
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class