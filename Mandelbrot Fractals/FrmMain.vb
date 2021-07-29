Imports System.Math
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FrmMain

    'Date: 28.02.2012
    'Purpose : Will generate Mandelbrot fractals
    'Framework : v3.5
    'Dependences: None


#Region "Locals"

    Dim MandelMaxX As Decimal = 1
    Dim MandelMinX As Decimal = -2.39
    Dim MandelMaxY As Decimal = 1.25
    Dim MandelMinY As Decimal = -1.2

    Dim BtmPixselHeight As Integer
    Dim BtmPixselWidth As Integer

    Dim FracBtm As Bitmap
    Dim Rainbow As Bitmap

    Dim HueFrom As Decimal = 0.672
    Dim HueTo As Decimal = 0.481

    Dim CalcTime As Integer
    Dim CalcPres As CalculationPrecacions

    Dim SelectFrom As Point
    Dim SelectingRec As Rectangle

    Dim ZoomFactor As Double = 1

    Dim CyclesCount As Double

    Dim ProgressBarUpdateIntervalSteps As Integer = 20

    Dim CancelCalculations As Boolean

    Public Enum CalculationPrecacions
        UseDecimal
        UseSingle
        UseDouble
    End Enum

#End Region

#Region "Rainbow"

    Private Sub FrmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Rainbow = New Bitmap(picRainbow.Width, picRainbow.Height)
        Dim Clr As RGBxHSL.HSL = RGBxHSL.RGB_to_HSL(Color.Orange)
        Clr.H = 0
        Dim G As Graphics = Graphics.FromImage(Rainbow)

        For i = 0 To picRainbow.Width
            Clr.H = i / picRainbow.Width
            G.DrawLine(New Pen(RGBxHSL.HSL_to_RGB(Clr)), New Point(i, 0), New Point(i, picRainbow.Height))
        Next

        Dim R As Bitmap = Rainbow.Clone
        G = Graphics.FromImage(R)
        G.DrawLine(New Pen(Brushes.White, 2), New Point(HueFrom * picRainbow.Width, 0), New Point(HueFrom * picRainbow.Width, picRainbow.Height))
        G.DrawLine(New Pen(Brushes.Black, 2), New Point(HueTo * picRainbow.Width, 0), New Point(HueTo * picRainbow.Width, picRainbow.Height))

        Me.lbHue.Text = "Hue : " & HueFrom & " --> " & HueTo

        Me.picRainbow.BackgroundImage = R
    End Sub

    Private Sub picRainbow_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picRainbow.MouseMove
        Dim X As Integer = e.X
        If e.X < 0 Then X = 0
        If e.X > picRainbow.Width Then X = picRainbow.Width

        If e.Button = Windows.Forms.MouseButtons.Left Then
            HueFrom = X / picRainbow.Width
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            HueTo = X / picRainbow.Width
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Or e.Button = Windows.Forms.MouseButtons.Right Then
            Dim R = Rainbow.Clone
            Dim G = Graphics.FromImage(R)

            G.DrawLine(New Pen(Brushes.White, 2), New Point(HueFrom * picRainbow.Width, 0), New Point(HueFrom * picRainbow.Width, picRainbow.Height))
            G.DrawLine(New Pen(Brushes.Black, 2), New Point(HueTo * picRainbow.Width, 0), New Point(HueTo * picRainbow.Width, picRainbow.Height))

            Me.picRainbow.BackgroundImage = R

            Me.lbHue.Text = "Hue : " & Format(HueFrom, "0.000") & " --> " & Format(HueTo, "0.000")
        End If
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnDraw_Click(sender As System.Object, e As System.EventArgs) Handles btnDraw.Click
        Redraw()
    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        Dim PixselToMandelyCoef As Decimal = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

        MandelMinY = MandelMinY - PixselToMandelyCoef * Me.nudMovingStep.Value * BtmPixselHeight / 100
        MandelMaxY = MandelMaxY - PixselToMandelyCoef * Me.nudMovingStep.Value * BtmPixselHeight / 100

        Me.Redraw()
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        Dim PixselToMandelyCoef As Decimal = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

        MandelMinY = MandelMinY + PixselToMandelyCoef * Me.nudMovingStep.Value * BtmPixselHeight / 100
        MandelMaxY = MandelMaxY + PixselToMandelyCoef * Me.nudMovingStep.Value * BtmPixselHeight / 100

        Me.Redraw()
    End Sub

    Private Sub btnLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft.Click
        Dim PixselToMandelXCoef As Decimal = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)

        MandelMinX = MandelMinX - PixselToMandelXCoef * Me.nudMovingStep.Value * BtmPixselWidth / 100
        MandelMaxX = MandelMaxX - PixselToMandelXCoef * Me.nudMovingStep.Value * BtmPixselWidth / 100

        Me.Redraw()
    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        Dim PixselToMandelXCoef As Decimal = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)

        MandelMinX = MandelMinX + PixselToMandelXCoef * Me.nudMovingStep.Value * BtmPixselWidth / 100
        MandelMaxX = MandelMaxX + PixselToMandelXCoef * Me.nudMovingStep.Value * BtmPixselWidth / 100

        Me.Redraw()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        MandelMaxX = 1
        MandelMinX = -2.39
        MandelMaxY = 1.25
        MandelMinY = -1.2

        HueFrom = 0.672
        HueTo = 0.481

        Me.lbHue.Text = "Hue : " & Format(HueFrom, "0.000") & " --> " & Format(HueTo, "0.000")

        Dim R As Bitmap = Rainbow.Clone
        Dim G = Graphics.FromImage(R)
        G.DrawLine(New Pen(Brushes.White, 2), New Point(HueFrom * picRainbow.Width, 0), New Point(HueFrom * picRainbow.Width, picRainbow.Height))
        G.DrawLine(New Pen(Brushes.Black, 2), New Point(HueTo * picRainbow.Width, 0), New Point(HueTo * picRainbow.Width, picRainbow.Height))

        Me.picRainbow.BackgroundImage = R

        ZoomFactor = 1
        Me.slZoom.Text = "Zoom : " & "1x"

        'Me.nudMaxIteractions.Value = 100
        'Me.nudEscapeValue.Value = 3

        Me.radSingle.Checked = True
        Me.chkAutoSwich.Checked = True
        Me.chkSmoothColoring.Checked = True

        Redraw()

    End Sub

    Private Sub btnSvaePicture_Click(sender As System.Object, e As System.EventArgs) Handles btnSvaePicture.Click
        If sfdFractal.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            FracBtm.Save(sfdFractal.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub btnZoom_Click(sender As System.Object, e As System.EventArgs) Handles btnZoom.Click
        Dim Z = IIf(radZoomIn.Checked, nudZoomFactor.Value, 1 / nudZoomFactor.Value)
        ZoomFactor = ZoomFactor * Z


        Dim Midle = (MandelMaxX + MandelMinX) / 2
        Dim Wid = MandelMaxX - MandelMinX

        MandelMinX = Midle - Wid / (2 * Z)
        MandelMaxX = Midle + Wid / (2 * Z)

        Midle = (MandelMaxY + MandelMinY) / 2
        Wid = MandelMaxY - MandelMinY

        MandelMinY = Midle - Wid / (2 * Z)
        MandelMaxY = Midle + Wid / (2 * Z)

        Redraw()

    End Sub

#End Region

#Region "Zooming Rect"

    Private Sub picFrac_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picFrac.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then SelectFrom = e.Location
    End Sub

    Private Sub picFrac_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picFrac.MouseMove
        If FracBtm IsNot Nothing And e.Button = Windows.Forms.MouseButtons.Left Then
            'Selecting = True

            Dim B = FracBtm.Clone
            Dim G = Graphics.FromImage(B)
            Dim Br = New SolidBrush(Color.FromArgb(80, Color.LightGray))



            If SelectFrom.X > e.X And SelectFrom.Y > e.Y Then
                SelectingRec = New Rectangle(e.Location, SelectFrom - e.Location)
            ElseIf SelectFrom.X < e.X And SelectFrom.Y > e.Y Then
                SelectingRec = New Rectangle(SelectFrom.X, e.Y, e.X - SelectFrom.X, SelectFrom.Y - e.Y)
            ElseIf SelectFrom.X > e.X And SelectFrom.Y < e.Y Then
                SelectingRec = New Rectangle(e.X, SelectFrom.Y, SelectFrom.X - e.X, e.Y - SelectFrom.Y)
            Else
                SelectingRec = New Rectangle(SelectFrom, e.Location - SelectFrom)
            End If

            G.FillRectangle(Br, SelectingRec)
            G.DrawRectangle(Pens.LightGray, SelectingRec)
            Me.picFrac.CreateGraphics.DrawImage(B, 0, 0)
            '  picFrac.cre()
        Else
            ' Selecting = False
            SelectingRec = Nothing
        End If

        If FracBtm IsNot Nothing Then
            Dim PixselToMandelXCoef As Decimal = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)
            Dim PixselToMandelYCoef As Decimal = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)
            Dim XCor As Decimal = e.X * PixselToMandelXCoef + MandelMinX
            Dim YCor As Decimal = e.Y * PixselToMandelYCoef + MandelMinY

            Me.slCoordinates.Text = "X= " & Format(XCor, "##0.### ### ### ### ###") & "  ,  Y= " & Format(YCor, "##0.### ### ### ### ###")

        End If

    End Sub

    Private Sub picFrac_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picFrac.MouseUp

        If SelectingRec <> Nothing AndAlso SelectingRec.Width > 4 AndAlso SelectingRec.Height > 4 Then

            Dim PixselToMandelXCoef As Decimal = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)
            Dim PixselToMandelYCoef As Decimal = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

            Dim TmpX = MandelMinX
            Dim TmpY = MandelMinY

            MandelMinX = SelectingRec.Left * PixselToMandelXCoef + MandelMinX
            MandelMinY = SelectingRec.Top * PixselToMandelYCoef + MandelMinY

            Dim XZoom = BtmPixselWidth / SelectingRec.Width
            Dim YZoom = BtmPixselHeight / SelectingRec.Height

            If XZoom < YZoom Then
                MandelMaxX = SelectingRec.Width * PixselToMandelXCoef + MandelMinX
                MandelMaxY = SelectingRec.Height * YZoom / XZoom * PixselToMandelYCoef + MandelMinY
                ZoomFactor = ZoomFactor * XZoom
            Else
                MandelMaxX = SelectingRec.Width * XZoom / YZoom * PixselToMandelXCoef + MandelMinX
                MandelMaxY = SelectingRec.Height * PixselToMandelYCoef + MandelMinY
                ZoomFactor = ZoomFactor * YZoom

            End If

            Redraw()
        End If

        SelectingRec = Nothing

    End Sub

#End Region

#Region "Options"

    Private Sub radSingle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSingle.CheckedChanged, radDecimal.CheckedChanged, radDouble.CheckedChanged
        If radDecimal.Checked Then CalcPres = CalculationPrecacions.UseDecimal
        If radDouble.Checked Then CalcPres = CalculationPrecacions.UseDouble
        If radSingle.Checked Then CalcPres = CalculationPrecacions.UseSingle
    End Sub

    Private Sub chkAutoSwich_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoSwich.CheckedChanged
        radDecimal.Enabled = Not Me.chkAutoSwich.Checked
        radDouble.Enabled = Not Me.chkAutoSwich.Checked
        radSingle.Enabled = Not Me.chkAutoSwich.Checked
        Me.nudEscapeValue.Enabled = Not Me.chkAutoSwich.Checked
        Me.nudMaxIteractions.Enabled = Not Me.chkAutoSwich.Checked
        Me.grpCalculationPrecesion.Enabled = Not Me.chkAutoSwich.Checked
        Me.grpSteps.Enabled = Not Me.chkAutoSwich.Checked
    End Sub

#End Region

#Region "Fractal Drawing"

    Public Sub Redraw()
        Me.slZoom.Text = "Zoom : " & Format(ZoomFactor, "#,##0.00") & "x"

        If btnDraw.Text = "Stop" Then
            CancelCalculations = True
            Application.DoEvents()
            btnDraw.Text = "ReDraw"
            Me.Cursor = Cursors.Default
            Me.slCalcTime.Text = "Calculation Time: Aborted"
            Me.slCycles.Text = "Cycles : 0"
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.slCalcTime.Text = "Calculating ..."
        Me.btnDraw.Text = "Stop"

        BtmPixselHeight = picFrac.Height
        BtmPixselWidth = BtmPixselHeight * (MandelMaxX - MandelMinX) / (MandelMaxY - MandelMinY)

        If Me.chkAutoSwich.Checked Then
            Dim Esc = Math.Ceiling(5 * Math.Log(IIf(ZoomFactor < 1, 1, ZoomFactor)) + 3)
            Me.nudEscapeValue.Value = If(Esc > nudEscapeValue.Maximum, nudEscapeValue.Maximum, Esc)
            Dim Int = Math.Ceiling(200 * Math.Log(IIf(ZoomFactor < 1, 1, ZoomFactor)) + 150)
            Me.nudMaxIteractions.Value = If(Int > nudMaxIteractions.Maximum, nudMaxIteractions.Maximum, Int)

            If ZoomFactor < 40000 Then
                Me.radSingle.Checked = True
            ElseIf ZoomFactor < 50000000000.0 And ZoomFactor > 40000 Then
                Me.radDouble.Checked = True
            Else
                Me.radDecimal.Checked = True
            End If
        End If

        pbProg.Maximum = BtmPixselWidth
        pbProg.Value = 0
        pbProg.Visible = True

        CyclesCount = 0

        FreezUI(False)

        Application.DoEvents()

        Dim StartTime = Now

        Select Case CalcPres
            Case CalculationPrecacions.UseDecimal
                RedrawDecimal()
            Case CalculationPrecacions.UseDouble
                RedrawDouble()
            Case CalculationPrecacions.UseSingle
                RedrawSingle()
        End Select

        Dim EndTime = Now

        Me.picFrac.CreateGraphics.DrawImage(FracBtm, 0, 0)
        pbProg.Visible = False
        Me.Cursor = Cursors.Default

        Me.slCalcTime.Text = "Calculation Time: " & Format((EndTime - StartTime).TotalMilliseconds / 1000, "0.000") & " sec."
        Me.slCycles.Text = "Cycles : " & CyclesCount.ToString("#.## E+0")
        FreezUI(True)
        Me.btnDraw.Text = "ReDraw"

        GC.Collect()
    End Sub

    Public Sub RedrawDouble()
        FracBtm = New Bitmap(BtmPixselWidth, BtmPixselHeight, PixelFormat.Format32bppRgb)

        Dim Mat As BitmapData = FracBtm.LockBits(New Rectangle(0, 0, BtmPixselWidth, BtmPixselHeight), System.Drawing.Imaging.ImageLockMode.ReadOnly, FracBtm.PixelFormat)

        Dim EscapeValue2 As Single = Me.nudEscapeValue.Value ^ 2
        Dim InvLogEscapeValue2 As Single = 1 / Math.Log(EscapeValue2)

        Dim MaxIteration As Integer = Me.nudMaxIteractions.Value

        Dim CurIteration As Integer

        Dim MandelCurX As Double = 0
        Dim MandelCurY As Double = 0

        Dim CurColor As Color

        Dim xTmp As Double
        Dim InvLog2 As Single = 1 / Math.Log(2)

        Dim TransX As Double
        Dim TransY As Double
        Dim TransY2 As Double

        Dim Dens As Single

        Dim PixselToMandelXCoef As Double = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)
        Dim PixselToMandelYCoef As Double = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

        Dim BtmPixselPos As Integer
        Dim q As Double

        Dim MandelCurX2 As Double
        Dim MandelCurY2 As Double

        Dim FirstPixPtr As IntPtr = Mat.Scan0

        For x = 0 To BtmPixselWidth - 1
            For y = 0 To BtmPixselHeight - 1

                CurIteration = 0
                MandelCurX = 0
                MandelCurX2 = 0
                MandelCurY = 0
                MandelCurY2 = 0

                CyclesCount += 1

                TransX = x * PixselToMandelXCoef + MandelMinX
                TransY = y * PixselToMandelYCoef + MandelMinY

                TransY2 = TransY * TransY
                q = (TransX - 1 / 4) ^ 2 + TransY2

                BtmPixselPos = Mat.Stride * y + 4 * x

                If 4 * q * (q + TransX - 1 / 4) < TransY2 Or (TransX + 1) ^ 2 + TransY2 < 1 / 16 Then
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                Else
                    Do While CurIteration < MaxIteration And MandelCurX2 + MandelCurY2 < EscapeValue2
                        xTmp = MandelCurX2 - MandelCurY2 + TransX
                        MandelCurY = 2 * MandelCurX * MandelCurY + TransY

                        MandelCurX = xTmp

                        MandelCurX2 = MandelCurX * MandelCurX
                        MandelCurY2 = MandelCurY * MandelCurY

                        CurIteration += 1

                        CyclesCount += 1
                    Loop

                    If CurIteration < MaxIteration Then

                        If Me.chkSmoothColoring.Checked Then
                            Dens = (CurIteration - 1 - Math.Log(Math.Log(MandelCurX2 + MandelCurY2) * InvLogEscapeValue2) * InvLog2) / MaxIteration
                            Dens = 10.897 * Dens ^ 4 - 28.78 * Dens ^ 3 + 25.884 * Dens ^ 2 - 8.1052 * Dens + 1.0717
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueTo - (HueTo - HueFrom) * Dens)
                        Else
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueFrom + (HueTo - HueFrom) * (CurIteration - 1) / MaxIteration)
                        End If

                        If Me.chkSmartBrightness.Checked Then CurColor = RGBxHSL.SetBrightness(CurColor, 1 - Dens)

                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, CurColor.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, CurColor.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, CurColor.R)
                    Else
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                    End If
                End If
            Next

            If SetProgres(x) = False Then FracBtm.UnlockBits(Mat) : Exit Sub

        Next

        FracBtm.UnlockBits(Mat)

    End Sub
    Public Sub RedrawDecimal()
        FracBtm = New Bitmap(BtmPixselWidth, BtmPixselHeight, PixelFormat.Format32bppRgb)

        Dim Mat As BitmapData = FracBtm.LockBits(New Rectangle(0, 0, BtmPixselWidth, BtmPixselHeight), System.Drawing.Imaging.ImageLockMode.ReadOnly, FracBtm.PixelFormat)

        Dim EscapeValue2 As Single = Me.nudEscapeValue.Value ^ 2
        Dim InvLogEscapeValue2 As Single = 1 / Math.Log(EscapeValue2)

        Dim MaxIteration As Integer = Me.nudMaxIteractions.Value

        Dim CurIteration As Integer

        Dim MandelCurX As Decimal = 0
        Dim MandelCurY As Decimal = 0

        Dim CurColor As Color

        Dim xTmp As Decimal
        Dim InvLog2 As Single = 1 / Math.Log(2)

        Dim TransX As Decimal
        Dim TransY As Decimal
        Dim TransY2 As Decimal

        Dim Dens As Single

        Dim PixselToMandelXCoef As Decimal = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)
        Dim PixselToMandelYCoef As Decimal = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

        Dim BtmPixselPos As Integer
        Dim q As Double

        Dim MandelCurX2 As Decimal
        Dim MandelCurY2 As Decimal

        Dim FirstPixPtr As IntPtr = Mat.Scan0

        For x = 0 To BtmPixselWidth - 1
            For y = 0 To BtmPixselHeight - 1

                CurIteration = 0
                MandelCurX = 0
                MandelCurX2 = 0
                MandelCurY = 0
                MandelCurY2 = 0

                CyclesCount += 1

                TransX = x * PixselToMandelXCoef + MandelMinX
                TransY = y * PixselToMandelYCoef + MandelMinY

                TransY2 = TransY * TransY
                q = (TransX - 1 / 4) ^ 2 + TransY2

                BtmPixselPos = Mat.Stride * y + 4 * x

                If 4 * q * (q + TransX - 1 / 4) < TransY2 Or (TransX + 1) ^ 2 + TransY2 < 1 / 16 Then
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                Else
                    Do While CurIteration < MaxIteration And MandelCurX2 + MandelCurY2 < EscapeValue2
                        xTmp = MandelCurX2 - MandelCurY2 + TransX
                        MandelCurY = 2 * MandelCurX * MandelCurY + TransY

                        MandelCurX = xTmp

                        MandelCurX2 = MandelCurX * MandelCurX
                        MandelCurY2 = MandelCurY * MandelCurY

                        CurIteration += 1

                        CyclesCount += 1
                    Loop

                    If CurIteration < MaxIteration Then

                        If Me.chkSmoothColoring.Checked Then
                            Dens = (CurIteration - 1 - Math.Log(Math.Log(MandelCurX2 + MandelCurY2) * InvLogEscapeValue2) * InvLog2) / MaxIteration
                            Dens = 10.897 * Dens ^ 4 - 28.78 * Dens ^ 3 + 25.884 * Dens ^ 2 - 8.1052 * Dens + 1.0717
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueTo - (HueTo - HueFrom) * Dens)

                        Else
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueFrom + (HueTo - HueFrom) * (CurIteration - 1) / MaxIteration)
                        End If

                        If Me.chkSmartBrightness.Checked Then CurColor = RGBxHSL.SetBrightness(CurColor, 1 - Dens)

                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, CurColor.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, CurColor.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, CurColor.R)
                    Else
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                    End If
                End If
            Next

            If SetProgres(x) = False Then FracBtm.UnlockBits(Mat) : Exit Sub

        Next

        FracBtm.UnlockBits(Mat)

    End Sub

    Public Sub RedrawSingle()
        FracBtm = New Bitmap(BtmPixselWidth, BtmPixselHeight, PixelFormat.Format32bppRgb)

        Dim Mat As BitmapData = FracBtm.LockBits(New Rectangle(0, 0, BtmPixselWidth, BtmPixselHeight), System.Drawing.Imaging.ImageLockMode.ReadOnly, FracBtm.PixelFormat)

        Dim EscapeValue2 As Single = Me.nudEscapeValue.Value ^ 2
        Dim InvLogEscapeValue2 As Single = 1 / Math.Log(EscapeValue2)

        Dim MaxIteration As Integer = Me.nudMaxIteractions.Value

        Dim CurIteration As Integer

        Dim MandelCurX As Single = 0
        Dim MandelCurY As Single = 0

        Dim CurColor As Color

        Dim xTmp As Single
        Dim InvLog2 As Single = 1 / Math.Log(2)

        Dim TransX As Single
        Dim TransY As Single
        Dim TransY2 As Single

        Dim Dens As Single

        Dim PixselToMandelXCoef As Single = (MandelMaxX - MandelMinX) / (BtmPixselWidth - 1)
        Dim PixselToMandelYCoef As Single = (MandelMaxY - MandelMinY) / (BtmPixselHeight - 1)

        Dim BtmPixselPos As Integer
        Dim q As Single

        Dim MandelCurX2 As Single
        Dim MandelCurY2 As Single

        Dim FirstPixPtr As IntPtr = Mat.Scan0

        For x = 0 To BtmPixselWidth - 1
            For y = 0 To BtmPixselHeight - 1

                CurIteration = 0
                MandelCurX = 0
                MandelCurX2 = 0
                MandelCurY = 0
                MandelCurY2 = 0

                CyclesCount += 1

                TransX = x * PixselToMandelXCoef + MandelMinX
                TransY = y * PixselToMandelYCoef + MandelMinY

                TransY2 = TransY * TransY
                q = (TransX - 1 / 4) ^ 2 + TransY2

                BtmPixselPos = Mat.Stride * y + 4 * x

                If 4 * q * (q + TransX - 1 / 4) < TransY2 Or (TransX + 1) ^ 2 + TransY2 < 1 / 16 Then
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                    Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                Else
                    Do While CurIteration < MaxIteration And MandelCurX2 + MandelCurY2 < EscapeValue2
                        xTmp = MandelCurX2 - MandelCurY2 + TransX
                        MandelCurY = 2 * MandelCurX * MandelCurY + TransY

                        MandelCurX = xTmp

                        MandelCurX2 = MandelCurX * MandelCurX
                        MandelCurY2 = MandelCurY * MandelCurY

                        CurIteration += 1

                        CyclesCount += 1
                    Loop

                    If CurIteration < MaxIteration Then

                        If Me.chkSmoothColoring.Checked Then
                            Dens = (CurIteration - 1 - Math.Log(Math.Log(MandelCurX2 + MandelCurY2) * InvLogEscapeValue2) * InvLog2) / MaxIteration
                            Dens = 10.897 * Dens ^ 4 - 28.78 * Dens ^ 3 + 25.884 * Dens ^ 2 - 8.1052 * Dens + 1.0717
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueTo - (HueTo - HueFrom) * Dens)

                        Else
                            CurColor = RGBxHSL.SetHue(Color.Orange, HueFrom + (HueTo - HueFrom) * (CurIteration - 1) / MaxIteration)
                        End If

                        If Me.chkSmartBrightness.Checked Then CurColor = RGBxHSL.SetBrightness(CurColor, 1 - Dens)

                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, CurColor.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, CurColor.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, CurColor.R)
                    Else
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos, Color.Black.B)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 1, Color.Black.G)
                        Marshal.WriteByte(FirstPixPtr, BtmPixselPos + 2, Color.Black.R)
                    End If
                End If

            Next

            If SetProgres(x) = False Then FracBtm.UnlockBits(Mat) : Exit Sub

        Next

        FracBtm.UnlockBits(Mat)

    End Sub

    Private Sub picFrac_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles picFrac.Paint
        If FracBtm IsNot Nothing Then e.Graphics.DrawImage(FracBtm, 0, 0)
    End Sub

#End Region

#Region "Functions"

    Public Function SetProgres(x As Integer) As Boolean
        If x Mod ProgressBarUpdateIntervalSteps = 0 Then

            'this is a hack on pb animation
            Me.pbProg.Value = x + 1
            Me.pbProg.Value = x
            Me.pbProg.Value = x + 1

            Application.DoEvents()

            If CancelCalculations Then
                CancelCalculations = False
                Return False
            End If
        End If

        Return True

    End Function

    Public Sub FreezUI(Enabled As Boolean)
        grpMovement.Enabled = Enabled
        grpZoom.Enabled = Enabled
        grpColors.Enabled = Enabled
        grpQuality.Enabled = Enabled
        btnSvaePicture.Enabled = Enabled
    End Sub

#End Region

End Class
