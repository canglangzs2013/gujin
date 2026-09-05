<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblH = New System.Windows.Forms.Label()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.lblD = New System.Windows.Forms.Label()
        Me.cboD = New System.Windows.Forms.ComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.btnLaJin = New System.Windows.Forms.Button()
        Me.btnGuJin = New System.Windows.Forms.Button()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.grpInput.SuspendLayout()
        Me.grpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblB)
        Me.grpInput.Controls.Add(Me.txtB)
        Me.grpInput.Controls.Add(Me.lblH)
        Me.grpInput.Controls.Add(Me.txtH)
        Me.grpInput.Controls.Add(Me.lblC)
        Me.grpInput.Controls.Add(Me.txtC)
        Me.grpInput.Controls.Add(Me.lblD)
        Me.grpInput.Controls.Add(Me.cboD)
        Me.grpInput.Controls.Add(Me.lblCount)
        Me.grpInput.Controls.Add(Me.txtCount)
        Me.grpInput.Controls.Add(Me.lblHint)
        Me.grpInput.Location = New System.Drawing.Point(18, 18)
        Me.grpInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInput.Size = New System.Drawing.Size(594, 378)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "输入参数"
        '
        'lblB
        '
        Me.lblB.Location = New System.Drawing.Point(30, 57)
        Me.lblB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(240, 30)
        Me.lblB.TabIndex = 0
        Me.lblB.Text = "截面宽度 b（mm）："
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(278, 52)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(238, 28)
        Me.txtB.TabIndex = 1
        '
        'lblH
        '
        Me.lblH.Location = New System.Drawing.Point(30, 111)
        Me.lblH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(240, 30)
        Me.lblH.TabIndex = 2
        Me.lblH.Text = "截面高度 h（mm）："
        Me.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(278, 106)
        Me.txtH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(238, 28)
        Me.txtH.TabIndex = 3
        '
        'lblC
        '
        Me.lblC.Location = New System.Drawing.Point(30, 165)
        Me.lblC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(240, 30)
        Me.lblC.TabIndex = 4
        Me.lblC.Text = "保护层厚度 c（mm）："
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(278, 160)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(238, 28)
        Me.txtC.TabIndex = 5
        '
        'lblD
        '
        Me.lblD.Location = New System.Drawing.Point(30, 219)
        Me.lblD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(240, 30)
        Me.lblD.TabIndex = 6
        Me.lblD.Text = "钢筋直径 d（mm）："
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboD
        '
        Me.cboD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboD.FormattingEnabled = True
        Me.cboD.Items.AddRange(New Object() {"6", "8", "10", "12", "14", "16", "18", "20", "22", "25", "28", "32", "36", "40", "50"})
        Me.cboD.Location = New System.Drawing.Point(278, 214)
        Me.cboD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboD.Name = "cboD"
        Me.cboD.Size = New System.Drawing.Size(238, 26)
        Me.cboD.TabIndex = 7
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(30, 273)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(240, 30)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "根数："
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(278, 268)
        Me.txtCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(238, 28)
        Me.txtCount.TabIndex = 9
        '
        'lblHint
        '
        Me.lblHint.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Gray
        Me.lblHint.Location = New System.Drawing.Point(30, 324)
        Me.lblHint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(540, 30)
        Me.lblHint.TabIndex = 10
        Me.lblHint.Text = "提示：拉筋直径一般梁宽≤350mm时取6mm，＞350mm时取8mm"
        '
        'btnLaJin
        '
        Me.btnLaJin.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLaJin.Location = New System.Drawing.Point(338, 417)
        Me.btnLaJin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLaJin.Name = "btnLaJin"
        Me.btnLaJin.Size = New System.Drawing.Size(248, 75)
        Me.btnLaJin.TabIndex = 2
        Me.btnLaJin.Text = "计算拉筋"
        Me.btnLaJin.UseVisualStyleBackColor = True
        '
        'btnGuJin
        '
        Me.btnGuJin.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnGuJin.Location = New System.Drawing.Point(45, 417)
        Me.btnGuJin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuJin.Name = "btnGuJin"
        Me.btnGuJin.Size = New System.Drawing.Size(248, 75)
        Me.btnGuJin.TabIndex = 1
        Me.btnGuJin.Text = "计算箍筋"
        Me.btnGuJin.UseVisualStyleBackColor = True
        '
        'lblFormula
        '
        Me.lblFormula.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFormula.ForeColor = System.Drawing.Color.Gray
        Me.lblFormula.Location = New System.Drawing.Point(18, 507)
        Me.lblFormula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(594, 30)
        Me.lblFormula.TabIndex = 3
        Me.lblFormula.Text = "箍筋：L = 2(b+h) - 8c + 18.9d        拉筋：L = b - 2c + 2×11.9d"
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.txtResult)
        Me.grpResult.Location = New System.Drawing.Point(18, 543)
        Me.grpResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpResult.Size = New System.Drawing.Size(594, 306)
        Me.grpResult.TabIndex = 4
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "计算结果"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.White
        Me.txtResult.Location = New System.Drawing.Point(15, 38)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(562, 251)
        Me.txtResult.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 862)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.btnGuJin)
        Me.Controls.Add(Me.btnLaJin)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.grpResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "箍筋和拉筋计算"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblB As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblH As Label
    Friend WithEvents txtH As TextBox
    Friend WithEvents lblC As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents lblD As Label
    Friend WithEvents cboD As ComboBox
    Friend WithEvents lblCount As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents lblHint As Label
    Friend WithEvents btnGuJin As Button
    Friend WithEvents btnLaJin As Button
    Friend WithEvents lblFormula As Label
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents txtResult As TextBox
End Class
