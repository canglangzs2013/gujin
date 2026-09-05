Public Class Form1

    ''' <summary>窗体加载时填入默认值（与原代码中的硬编码参数一致）</summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtB.Text = "300"
        txtH.Text = "600"
        txtC.Text = "25"
        cboD.SelectedItem = "10"
        txtCount.Text = "1"

    End Sub

    ''' <summary>读取并校验一个必须大于 0 的数字输入；非法时弹窗提示并返回 Nothing</summary>
    Private Function ReadPositiveDouble(txt As TextBox, paramName As String) As Double?
        Dim value As Double
        If Not Double.TryParse(txt.Text.Trim(), value) OrElse value <= 0 Then
            MessageBox.Show("【" & paramName & "】必须输入大于 0 的数字！", "输入错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            txt.SelectAll()
            Return Nothing
        End If
        Return value
    End Function

    ''' <summary>读取并校验根数（不小于 1 的整数）；非法时弹窗提示并返回 Nothing</summary>
    Private Function ReadCount() As Integer?
        Dim n As Integer
        If Not Integer.TryParse(txtCount.Text.Trim(), n) OrElse n < 1 Then
            MessageBox.Show("【根数】必须输入不小于 1 的整数！", "输入错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCount.Focus()
            txtCount.SelectAll()
            Return Nothing
        End If
        Return n
    End Function

    ''' <summary>读取钢筋直径并校验是否在重量表（Module1.GetSteelWeightByDiameter）中</summary>
    Private Function ReadDiameter() As Double?
        Dim d As Double
        If Not Double.TryParse(cboD.Text.Trim(), d) OrElse d <= 0 Then
            MessageBox.Show("【钢筋直径 d】必须选择或输入大于 0 的数字！", "输入错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboD.Focus()
            Return Nothing
        End If
        If GetSteelWeightByDiameter(d) < 0 Then
            MessageBox.Show("直径 " & d & "mm 不在钢筋重量表中！" & vbCrLf &
                            "可选直径：6 / 8 / 10 / 12 / 14 / 16 / 18 / 20 / 22 / 25 / 28 / 32 / 36 / 40 / 50",
                            "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboD.Focus()
            Return Nothing
        End If
        Return d
    End Function

    ''' <summary>计算箍筋：L = 2(b+h) - 8c + 18.9d</summary>
    Private Sub btnGuJin_Click(sender As Object, e As EventArgs) Handles btnGuJin.Click
        Dim b = ReadPositiveDouble(txtB, "截面宽度 b")
        If b Is Nothing Then Return
        Dim h = ReadPositiveDouble(txtH, "截面高度 h")
        If h Is Nothing Then Return
        Dim c = ReadPositiveDouble(txtC, "保护层厚度 c")
        If c Is Nothing Then Return
        Dim d = ReadDiameter()
        If d Is Nothing Then Return
        Dim n = ReadCount()
        If n Is Nothing Then Return

        Try
            Dim lengthMm As Double = CalculateStirrupLength(b, h, c, d)
            Dim unitWeight As Double = GetSteelWeightByDiameter(d)          ' kg/m
            Dim perBarKg As Double = unitWeight * lengthMm / 1000           ' 单根重量 kg
            Dim totalKg As Double = perBarKg * n                            ' 合计重量 kg

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("—— 箍筋计算 ——")
            sb.AppendLine("输入：b=" & b & "mm，h=" & h & "mm，c=" & c & "mm，d=" & d & "mm，共 " & n & " 根")
            sb.AppendLine("公式：L = 2(b+h) - 8c + 18.9d")
            sb.AppendLine("单根长度：" & Math.Round(lengthMm, 1).ToString("0.#") & " mm（" & Math.Round(lengthMm / 1000, 3).ToString("0.###") & " m）")
            sb.AppendLine("理论线密度：" & unitWeight.ToString("0.###") & " kg/m")
            sb.AppendLine("单根重量：" & perBarKg.ToString("0.###") & " kg")
            sb.AppendLine("合计重量（" & n & " 根）：" & totalKg.ToString("0.###") & " kg")
            txtResult.Text = sb.ToString()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>计算拉筋（只勾住主筋）：L = b - 2c + 2×11.9d</summary>
    Private Sub btnLaJin_Click(sender As Object, e As EventArgs) Handles btnLaJin.Click
        Dim b = ReadPositiveDouble(txtB, "梁宽（截面宽度 b）")
        If b Is Nothing Then Return
        Dim c = ReadPositiveDouble(txtC, "保护层厚度 c")
        If c Is Nothing Then Return
        Dim d = ReadDiameter()
        If d Is Nothing Then Return
        Dim n = ReadCount()
        If n Is Nothing Then Return

        Try
            Dim lengthMm As Double = CalculateMainBarOnlyStirrupLength(b, c, d)
            Dim unitWeight As Double = GetSteelWeightByDiameter(d)          ' kg/m
            Dim perBarKg As Double = unitWeight * lengthMm / 1000           ' 单根重量 kg
            Dim totalKg As Double = perBarKg * n                            ' 合计重量 kg

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("—— 拉筋（只勾住主筋）计算 ——")
            sb.AppendLine("输入：梁宽 b=" & b & "mm，c=" & c & "mm，d=" & d & "mm，共 " & n & " 根")
            sb.AppendLine("公式：L = b - 2c + 2×11.9d")
            sb.AppendLine("单根长度：" & Math.Round(lengthMm, 1).ToString("0.#") & " mm（" & Math.Round(lengthMm / 1000, 3).ToString("0.###") & " m）")
            sb.AppendLine("理论线密度：" & unitWeight.ToString("0.###") & " kg/m")
            sb.AppendLine("单根重量：" & perBarKg.ToString("0.###") & " kg")
            sb.AppendLine("合计重量（" & n & " 根）：" & totalKg.ToString("0.###") & " kg")
            txtResult.Text = sb.ToString()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
