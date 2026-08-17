Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim beamWidth As Double = 600 ' 梁宽（mm）
        Dim protectiveLayerThickness As Double = 25 ' 保护层厚度（mm）
        Dim stirrupDiameter As Double = 10 ' 拉筋直径（mm）

        Dim stirrupLength As Double = CalculateMainBarOnlyStirrupLength(beamWidth, protectiveLayerThickness, stirrupDiameter)
        MessageBox.Show($"只勾住主筋的拉筋长度为：{stirrupLength}mm")
        MessageBox.Show(GetSteelWeightByDiameter(stirrupDiameter) * stirrupLength & "kg")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim length As Double
        length = CalculateStirrupLength(300, 600, 25, 10) / 1000

        MessageBox.Show("箍筋长度为：" & length & "m")
        MessageBox.Show(GetSteelWeightByDiameter(10) * length & "kg")
    End Sub


End Class
