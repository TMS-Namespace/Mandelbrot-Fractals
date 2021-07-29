<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.picRainbow = New System.Windows.Forms.PictureBox()
        Me.nudMaxIteractions = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxIteractions = New System.Windows.Forms.Label()
        Me.nudEscapeValue = New System.Windows.Forms.NumericUpDown()
        Me.lblEscapeValue = New System.Windows.Forms.Label()
        Me.picFrac = New System.Windows.Forms.PictureBox()
        Me.lbHue = New System.Windows.Forms.Label()
        Me.grpCalculationPrecesion = New System.Windows.Forms.GroupBox()
        Me.radDecimal = New System.Windows.Forms.RadioButton()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.slZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slCalcTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slCycles = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slCoordinates = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbProg = New System.Windows.Forms.ToolStripProgressBar()
        Me.chkSmoothColoring = New System.Windows.Forms.CheckBox()
        Me.chkAutoSwich = New System.Windows.Forms.CheckBox()
        Me.grpQuality = New System.Windows.Forms.GroupBox()
        Me.grpSteps = New System.Windows.Forms.GroupBox()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.chkSmartBrightness = New System.Windows.Forms.CheckBox()
        Me.btnEmptyColor = New System.Windows.Forms.Button()
        Me.nudMovingStep = New System.Windows.Forms.NumericUpDown()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.btnSvaePicture = New System.Windows.Forms.Button()
        Me.lblMoveStep = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblZoomFactor = New System.Windows.Forms.Label()
        Me.grpZoom = New System.Windows.Forms.GroupBox()
        Me.grpZoomDirection = New System.Windows.Forms.GroupBox()
        Me.radZoomOut = New System.Windows.Forms.RadioButton()
        Me.radZoomIn = New System.Windows.Forms.RadioButton()
        Me.btnZoom = New System.Windows.Forms.Button()
        Me.nudZoomFactor = New System.Windows.Forms.NumericUpDown()
        Me.grpMovement = New System.Windows.Forms.GroupBox()
        Me.sfdFractal = New System.Windows.Forms.SaveFileDialog()
        CType(Me.picRainbow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxIteractions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEscapeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalculationPrecesion.SuspendLayout()
        Me.SS.SuspendLayout()
        Me.grpQuality.SuspendLayout()
        Me.grpSteps.SuspendLayout()
        Me.grpColors.SuspendLayout()
        CType(Me.nudMovingStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControls.SuspendLayout()
        Me.grpZoom.SuspendLayout()
        Me.grpZoomDirection.SuspendLayout()
        CType(Me.nudZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMovement.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(120, 60)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(35, 35)
        Me.btnRight.TabIndex = 0
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(39, 60)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(35, 35)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "<-"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(79, 19)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(35, 35)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(79, 100)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(35, 35)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(8, 17)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(116, 53)
        Me.btnDraw.TabIndex = 5
        Me.btnDraw.Text = "ReDraw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'picRainbow
        '
        Me.picRainbow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRainbow.Location = New System.Drawing.Point(6, 19)
        Me.picRainbow.Name = "picRainbow"
        Me.picRainbow.Size = New System.Drawing.Size(302, 44)
        Me.picRainbow.TabIndex = 6
        Me.picRainbow.TabStop = False
        '
        'nudMaxIteractions
        '
        Me.nudMaxIteractions.Location = New System.Drawing.Point(94, 38)
        Me.nudMaxIteractions.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxIteractions.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudMaxIteractions.Name = "nudMaxIteractions"
        Me.nudMaxIteractions.Size = New System.Drawing.Size(67, 27)
        Me.nudMaxIteractions.TabIndex = 7
        Me.nudMaxIteractions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxIteractions.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblMaxIteractions
        '
        Me.lblMaxIteractions.AutoSize = True
        Me.lblMaxIteractions.Location = New System.Drawing.Point(6, 42)
        Me.lblMaxIteractions.Name = "lblMaxIteractions"
        Me.lblMaxIteractions.Size = New System.Drawing.Size(131, 21)
        Me.lblMaxIteractions.TabIndex = 8
        Me.lblMaxIteractions.Text = "Max Iteractions:"
        '
        'nudEscapeValue
        '
        Me.nudEscapeValue.Location = New System.Drawing.Point(94, 14)
        Me.nudEscapeValue.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudEscapeValue.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudEscapeValue.Name = "nudEscapeValue"
        Me.nudEscapeValue.Size = New System.Drawing.Size(67, 27)
        Me.nudEscapeValue.TabIndex = 9
        Me.nudEscapeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudEscapeValue.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblEscapeValue
        '
        Me.lblEscapeValue.AutoSize = True
        Me.lblEscapeValue.Location = New System.Drawing.Point(6, 16)
        Me.lblEscapeValue.Name = "lblEscapeValue"
        Me.lblEscapeValue.Size = New System.Drawing.Size(115, 21)
        Me.lblEscapeValue.TabIndex = 10
        Me.lblEscapeValue.Text = "Escape Value:"
        '
        'picFrac
        '
        Me.picFrac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFrac.Location = New System.Drawing.Point(0, 0)
        Me.picFrac.Name = "picFrac"
        Me.picFrac.Size = New System.Drawing.Size(534, 386)
        Me.picFrac.TabIndex = 11
        Me.picFrac.TabStop = False
        '
        'lbHue
        '
        Me.lbHue.AutoSize = True
        Me.lbHue.Location = New System.Drawing.Point(6, 68)
        Me.lbHue.Name = "lbHue"
        Me.lbHue.Size = New System.Drawing.Size(62, 21)
        Me.lbHue.TabIndex = 12
        Me.lbHue.Text = "0 --> 0"
        '
        'grpCalculationPrecesion
        '
        Me.grpCalculationPrecesion.Controls.Add(Me.radDecimal)
        Me.grpCalculationPrecesion.Controls.Add(Me.radDouble)
        Me.grpCalculationPrecesion.Controls.Add(Me.radSingle)
        Me.grpCalculationPrecesion.Location = New System.Drawing.Point(7, 16)
        Me.grpCalculationPrecesion.Name = "grpCalculationPrecesion"
        Me.grpCalculationPrecesion.Size = New System.Drawing.Size(217, 88)
        Me.grpCalculationPrecesion.TabIndex = 13
        Me.grpCalculationPrecesion.TabStop = False
        Me.grpCalculationPrecesion.Text = "Calculation Precesion:"
        '
        'radDecimal
        '
        Me.radDecimal.AutoSize = True
        Me.radDecimal.Location = New System.Drawing.Point(7, 65)
        Me.radDecimal.Name = "radDecimal"
        Me.radDecimal.Size = New System.Drawing.Size(328, 25)
        Me.radDecimal.TabIndex = 2
        Me.radDecimal.Text = "Decimal (16 Bytes, 28 Decimal Places )"
        Me.radDecimal.UseVisualStyleBackColor = True
        '
        'radDouble
        '
        Me.radDouble.AutoSize = True
        Me.radDouble.Location = New System.Drawing.Point(7, 42)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(303, 25)
        Me.radDouble.TabIndex = 1
        Me.radDouble.Text = "Double (8 Byte, 16 Decimal Places )"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(7, 19)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(286, 25)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single (4 Byte, 7 Decimal Places )"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'SS
        '
        Me.SS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slZoom, Me.ToolStripStatusLabel1, Me.slCalcTime, Me.ToolStripStatusLabel2, Me.slCycles, Me.ToolStripStatusLabel4, Me.slCoordinates, Me.ToolStripStatusLabel3, Me.pbProg})
        Me.SS.Location = New System.Drawing.Point(0, 502)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(739, 28)
        Me.SS.TabIndex = 14
        '
        'slZoom
        '
        Me.slZoom.Name = "slZoom"
        Me.slZoom.Size = New System.Drawing.Size(80, 21)
        Me.slZoom.Text = "Zoom: 1x"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(17, 21)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'slCalcTime
        '
        Me.slCalcTime.Name = "slCalcTime"
        Me.slCalcTime.Size = New System.Drawing.Size(220, 21)
        Me.slCalcTime.Text = "Calculation Time: 0.000 sec."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(17, 21)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'slCycles
        '
        Me.slCycles.Name = "slCycles"
        Me.slCycles.Size = New System.Drawing.Size(77, 21)
        Me.slCycles.Text = "Cycles: 0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(17, 21)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'slCoordinates
        '
        Me.slCoordinates.Name = "slCoordinates"
        Me.slCoordinates.Size = New System.Drawing.Size(138, 21)
        Me.slCoordinates.Text = "X= 0.00 , Y=0.00"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(158, 21)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'pbProg
        '
        Me.pbProg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.pbProg.MarqueeAnimationSpeed = 0
        Me.pbProg.Name = "pbProg"
        Me.pbProg.Size = New System.Drawing.Size(100, 20)
        Me.pbProg.Step = 1
        Me.pbProg.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbProg.Visible = False
        '
        'chkSmoothColoring
        '
        Me.chkSmoothColoring.AutoSize = True
        Me.chkSmoothColoring.Checked = True
        Me.chkSmoothColoring.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSmoothColoring.Location = New System.Drawing.Point(9, 87)
        Me.chkSmoothColoring.Name = "chkSmoothColoring"
        Me.chkSmoothColoring.Size = New System.Drawing.Size(162, 25)
        Me.chkSmoothColoring.TabIndex = 16
        Me.chkSmoothColoring.Text = "Smooth Coloring."
        Me.chkSmoothColoring.UseVisualStyleBackColor = True
        '
        'chkAutoSwich
        '
        Me.chkAutoSwich.AutoSize = True
        Me.chkAutoSwich.Checked = True
        Me.chkAutoSwich.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoSwich.Location = New System.Drawing.Point(230, 87)
        Me.chkAutoSwich.Name = "chkAutoSwich"
        Me.chkAutoSwich.Size = New System.Drawing.Size(127, 25)
        Me.chkAutoSwich.TabIndex = 17
        Me.chkAutoSwich.Text = "Auto Config."
        Me.chkAutoSwich.UseVisualStyleBackColor = True
        '
        'grpQuality
        '
        Me.grpQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpQuality.Controls.Add(Me.grpSteps)
        Me.grpQuality.Controls.Add(Me.chkAutoSwich)
        Me.grpQuality.Controls.Add(Me.grpCalculationPrecesion)
        Me.grpQuality.Location = New System.Drawing.Point(6, 389)
        Me.grpQuality.Name = "grpQuality"
        Me.grpQuality.Size = New System.Drawing.Size(408, 112)
        Me.grpQuality.TabIndex = 17
        Me.grpQuality.TabStop = False
        Me.grpQuality.Text = "Quality:"
        '
        'grpSteps
        '
        Me.grpSteps.Controls.Add(Me.lblEscapeValue)
        Me.grpSteps.Controls.Add(Me.lblMaxIteractions)
        Me.grpSteps.Controls.Add(Me.nudMaxIteractions)
        Me.grpSteps.Controls.Add(Me.nudEscapeValue)
        Me.grpSteps.Location = New System.Drawing.Point(230, 16)
        Me.grpSteps.Name = "grpSteps"
        Me.grpSteps.Size = New System.Drawing.Size(169, 66)
        Me.grpSteps.TabIndex = 18
        Me.grpSteps.TabStop = False
        Me.grpSteps.Text = "Steps:"
        '
        'grpColors
        '
        Me.grpColors.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpColors.Controls.Add(Me.chkSmartBrightness)
        Me.grpColors.Controls.Add(Me.btnEmptyColor)
        Me.grpColors.Controls.Add(Me.picRainbow)
        Me.grpColors.Controls.Add(Me.lbHue)
        Me.grpColors.Controls.Add(Me.chkSmoothColoring)
        Me.grpColors.Location = New System.Drawing.Point(420, 389)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(314, 112)
        Me.grpColors.TabIndex = 18
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "Colors:"
        '
        'chkSmartBrightness
        '
        Me.chkSmartBrightness.AutoSize = True
        Me.chkSmartBrightness.Checked = True
        Me.chkSmartBrightness.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSmartBrightness.Location = New System.Drawing.Point(116, 87)
        Me.chkSmartBrightness.Name = "chkSmartBrightness"
        Me.chkSmartBrightness.Size = New System.Drawing.Size(168, 25)
        Me.chkSmartBrightness.TabIndex = 18
        Me.chkSmartBrightness.Text = "Smart Brightness."
        Me.chkSmartBrightness.UseVisualStyleBackColor = True
        '
        'btnEmptyColor
        '
        Me.btnEmptyColor.BackColor = System.Drawing.Color.Black
        Me.btnEmptyColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmptyColor.ForeColor = System.Drawing.Color.White
        Me.btnEmptyColor.Location = New System.Drawing.Point(232, 83)
        Me.btnEmptyColor.Name = "btnEmptyColor"
        Me.btnEmptyColor.Size = New System.Drawing.Size(76, 23)
        Me.btnEmptyColor.TabIndex = 17
        Me.btnEmptyColor.Text = "Empty Color"
        Me.btnEmptyColor.UseVisualStyleBackColor = False
        '
        'nudMovingStep
        '
        Me.nudMovingStep.Location = New System.Drawing.Point(133, 150)
        Me.nudMovingStep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMovingStep.Name = "nudMovingStep"
        Me.nudMovingStep.Size = New System.Drawing.Size(53, 27)
        Me.nudMovingStep.TabIndex = 19
        Me.nudMovingStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMovingStep.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.btnSvaePicture)
        Me.grpControls.Controls.Add(Me.btnDraw)
        Me.grpControls.Location = New System.Drawing.Point(540, 0)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(193, 76)
        Me.grpControls.TabIndex = 20
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls:"
        '
        'btnSvaePicture
        '
        Me.btnSvaePicture.Enabled = False
        Me.btnSvaePicture.Location = New System.Drawing.Point(130, 17)
        Me.btnSvaePicture.Name = "btnSvaePicture"
        Me.btnSvaePicture.Size = New System.Drawing.Size(58, 53)
        Me.btnSvaePicture.TabIndex = 6
        Me.btnSvaePicture.Text = "Save Picture"
        Me.btnSvaePicture.UseVisualStyleBackColor = True
        '
        'lblMoveStep
        '
        Me.lblMoveStep.AutoSize = True
        Me.lblMoveStep.Location = New System.Drawing.Point(5, 153)
        Me.lblMoveStep.Name = "lblMoveStep"
        Me.lblMoveStep.Size = New System.Drawing.Size(194, 21)
        Me.lblMoveStep.TabIndex = 5
        Me.lblMoveStep.Text = "Move Step (% of width):"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(79, 60)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(35, 35)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "O"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblZoomFactor
        '
        Me.lblZoomFactor.AutoSize = True
        Me.lblZoomFactor.Location = New System.Drawing.Point(10, 20)
        Me.lblZoomFactor.Name = "lblZoomFactor"
        Me.lblZoomFactor.Size = New System.Drawing.Size(115, 21)
        Me.lblZoomFactor.TabIndex = 20
        Me.lblZoomFactor.Text = "Zoom Factor :"
        '
        'grpZoom
        '
        Me.grpZoom.Controls.Add(Me.grpZoomDirection)
        Me.grpZoom.Controls.Add(Me.btnZoom)
        Me.grpZoom.Controls.Add(Me.nudZoomFactor)
        Me.grpZoom.Controls.Add(Me.lblZoomFactor)
        Me.grpZoom.Location = New System.Drawing.Point(540, 260)
        Me.grpZoom.Name = "grpZoom"
        Me.grpZoom.Size = New System.Drawing.Size(193, 126)
        Me.grpZoom.TabIndex = 21
        Me.grpZoom.TabStop = False
        Me.grpZoom.Text = "Zoom:"
        '
        'grpZoomDirection
        '
        Me.grpZoomDirection.Controls.Add(Me.radZoomOut)
        Me.grpZoomDirection.Controls.Add(Me.radZoomIn)
        Me.grpZoomDirection.Location = New System.Drawing.Point(8, 45)
        Me.grpZoomDirection.Name = "grpZoomDirection"
        Me.grpZoomDirection.Size = New System.Drawing.Size(104, 73)
        Me.grpZoomDirection.TabIndex = 23
        Me.grpZoomDirection.TabStop = False
        Me.grpZoomDirection.Text = "Zoom Direction:"
        '
        'radZoomOut
        '
        Me.radZoomOut.AutoSize = True
        Me.radZoomOut.Checked = True
        Me.radZoomOut.Location = New System.Drawing.Point(9, 45)
        Me.radZoomOut.Name = "radZoomOut"
        Me.radZoomOut.Size = New System.Drawing.Size(114, 25)
        Me.radZoomOut.TabIndex = 23
        Me.radZoomOut.TabStop = True
        Me.radZoomOut.Text = "Zoom Out."
        Me.radZoomOut.UseVisualStyleBackColor = True
        '
        'radZoomIn
        '
        Me.radZoomIn.AutoSize = True
        Me.radZoomIn.Location = New System.Drawing.Point(9, 21)
        Me.radZoomIn.Name = "radZoomIn"
        Me.radZoomIn.Size = New System.Drawing.Size(102, 25)
        Me.radZoomIn.TabIndex = 22
        Me.radZoomIn.Text = "Zoom In."
        Me.radZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoom
        '
        Me.btnZoom.Location = New System.Drawing.Point(118, 51)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(70, 66)
        Me.btnZoom.TabIndex = 24
        Me.btnZoom.Text = "Zoom"
        Me.btnZoom.UseVisualStyleBackColor = True
        '
        'nudZoomFactor
        '
        Me.nudZoomFactor.Location = New System.Drawing.Point(90, 17)
        Me.nudZoomFactor.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudZoomFactor.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudZoomFactor.Name = "nudZoomFactor"
        Me.nudZoomFactor.Size = New System.Drawing.Size(95, 27)
        Me.nudZoomFactor.TabIndex = 21
        Me.nudZoomFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudZoomFactor.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'grpMovement
        '
        Me.grpMovement.Controls.Add(Me.lblMoveStep)
        Me.grpMovement.Controls.Add(Me.btnUp)
        Me.grpMovement.Controls.Add(Me.nudMovingStep)
        Me.grpMovement.Controls.Add(Me.btnLeft)
        Me.grpMovement.Controls.Add(Me.btnReset)
        Me.grpMovement.Controls.Add(Me.btnRight)
        Me.grpMovement.Controls.Add(Me.btnDown)
        Me.grpMovement.Location = New System.Drawing.Point(540, 78)
        Me.grpMovement.Name = "grpMovement"
        Me.grpMovement.Size = New System.Drawing.Size(193, 181)
        Me.grpMovement.TabIndex = 22
        Me.grpMovement.TabStop = False
        Me.grpMovement.Text = "Movement:"
        '
        'sfdFractal
        '
        Me.sfdFractal.Filter = "Bmp (*.bmp)|*.bmp"
        Me.sfdFractal.Title = "Save Fractal Image"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 530)
        Me.Controls.Add(Me.grpMovement)
        Me.Controls.Add(Me.grpZoom)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.grpQuality)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.picFrac)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mandelbrot Fractals "
        CType(Me.picRainbow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxIteractions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEscapeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalculationPrecesion.ResumeLayout(False)
        Me.grpCalculationPrecesion.PerformLayout()
        Me.SS.ResumeLayout(False)
        Me.SS.PerformLayout()
        Me.grpQuality.ResumeLayout(False)
        Me.grpQuality.PerformLayout()
        Me.grpSteps.ResumeLayout(False)
        Me.grpSteps.PerformLayout()
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        CType(Me.nudMovingStep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControls.ResumeLayout(False)
        Me.grpZoom.ResumeLayout(False)
        Me.grpZoom.PerformLayout()
        Me.grpZoomDirection.ResumeLayout(False)
        Me.grpZoomDirection.PerformLayout()
        CType(Me.nudZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMovement.ResumeLayout(False)
        Me.grpMovement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents picRainbow As System.Windows.Forms.PictureBox
    Friend WithEvents nudMaxIteractions As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMaxIteractions As System.Windows.Forms.Label
    Friend WithEvents nudEscapeValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblEscapeValue As System.Windows.Forms.Label
    Friend WithEvents picFrac As System.Windows.Forms.PictureBox
    Friend WithEvents lbHue As System.Windows.Forms.Label
    Friend WithEvents grpCalculationPrecesion As System.Windows.Forms.GroupBox
    Friend WithEvents radDecimal As System.Windows.Forms.RadioButton
    Friend WithEvents radDouble As System.Windows.Forms.RadioButton
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents slZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slCalcTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slCoordinates As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkSmoothColoring As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoSwich As System.Windows.Forms.CheckBox
    Friend WithEvents grpQuality As System.Windows.Forms.GroupBox
    Friend WithEvents grpSteps As System.Windows.Forms.GroupBox
    Friend WithEvents grpColors As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmptyColor As System.Windows.Forms.Button
    Friend WithEvents nudMovingStep As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents lblMoveStep As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblZoomFactor As System.Windows.Forms.Label
    Friend WithEvents grpZoom As System.Windows.Forms.GroupBox
    Friend WithEvents nudZoomFactor As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSvaePicture As System.Windows.Forms.Button
    Friend WithEvents btnZoom As System.Windows.Forms.Button
    Friend WithEvents radZoomOut As System.Windows.Forms.RadioButton
    Friend WithEvents radZoomIn As System.Windows.Forms.RadioButton
    Friend WithEvents grpMovement As System.Windows.Forms.GroupBox
    Friend WithEvents grpZoomDirection As System.Windows.Forms.GroupBox
    Friend WithEvents pbProg As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slCycles As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sfdFractal As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkSmartBrightness As System.Windows.Forms.CheckBox

End Class
