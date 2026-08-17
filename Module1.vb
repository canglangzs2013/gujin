Module Module1
    Function CalculateStirrupLength(b As Double, h As Double, c As Double, d As Double) As Double
        Return 2 * (b + h) - 8 * c + 18.9 * d
        '' 计算135°弯钩箍筋长度（按外皮尺寸）
        '' 参数说明：
        '' b - 构件截面宽度（如梁宽、柱宽），单位：mm
        '' h - 构件截面高度（如梁高、柱高），单位：mm
        '' c - 纵向钢筋保护层厚度（箍筋外皮至混凝土表面），单位：mm
        '' d - 箍筋直径（如φ6、φ8），单位：mm
        '' 返回值：箍筋长度（单位：mm）
        ''简化公式  L = 2(b + h)−8c+18.9D



        '' 计算截面周长（扣除保护层）
        'Dim perimeter As Double
        'perimeter = ((b - 2 * c) + (h - 2 * c)) * 2

        '' 计算135°弯钩增加长度（1.9d×2）
        'Dim hookLength As Double
        'hookLength = 11.9 * d ' 此处11.9d为用户公式中的弯钩增加长度（含平直段）

        '' 计算调整值（8d）
        'Dim adjustment As Double
        'adjustment = 8 * d

        '' 总长度 = 截面周长 + 弯钩增加长度 + 调整值
        'CalculateStirrupLength = perimeter + hookLength + adjustment
    End Function


    ''' <summary>
    ''' 计算只勾住主筋的拉筋长度（单位：mm）
    ''' </summary>
    ''' <param name="beamWidth">梁宽（构件截面宽度，mm）</param>
    ''' <param name="protectiveLayerThickness">纵向钢筋保护层厚度（箍筋外皮至混凝土表面的距离，mm）</param>
    ''' <param name="stirrupDiameter">箍筋直径（mm，拉筋直径取值依据：梁宽≤350mm时为6mm，梁宽＞350mm时为8mm）</param>
    ''' <returns>单根拉筋的总长度（mm）</returns>
    Function CalculateMainBarOnlyStirrupLength(beamWidth As Double, protectiveLayerThickness As Double, stirrupDiameter As Double) As Double
        ' 验证输入参数有效性（避免负值或零值）
        If beamWidth <= 0 Or protectiveLayerThickness <= 0 Or stirrupDiameter <= 0 Then
            Throw New ArgumentException("输入参数必须为正数！")
        End If

        ' 计算梁宽调整段：梁宽 - 2×保护层厚度（扣除两端保护层）
        Dim widthAdjustment As Double = beamWidth - 2 * protectiveLayerThickness

        ' 计算抗震弯钩增加长度：2×11.9×拉筋直径（135°弯钩的增加长度，符合规范要求）
        Dim hookIncreaseLength As Double = 2 * 11.9 * stirrupDiameter

        ' 总长度 = 梁宽调整段 + 抗震弯钩增加长度
        Dim totalLength As Double = widthAdjustment + hookIncreaseLength

        Return totalLength
    End Function


    Function GetSteelWeightByDiameter(d As Double) As Double
        Dim weight As Double
        Select Case d
            Case 6
                weight = 0.222
            Case 8
                weight = 0.395
            Case 10
                weight = 0.617
            Case 12
                weight = 0.888
            Case 14
                weight = 1.21
            Case 16
                weight = 1.58
            Case 18
                weight = 2.0  ' 括号内2.11是预应力螺纹钢，这里先取普通钢筋值；若要区分需额外逻辑
            Case 20
                weight = 2.47
            Case 22
                weight = 2.98
            Case 25
                weight = 3.85  ' 括号内4.10是预应力螺纹钢
            Case 28
                weight = 4.83
            Case 32
                weight = 6.31  ' 括号内6.65是预应力螺纹钢
            Case 36
                weight = 7.99
            Case 40
                weight = 9.87  ' 括号内10.34是预应力螺纹钢
            Case 50
                weight = 15.42 ' 括号内16.28是预应力螺纹钢
            Case Else
                weight = -1  ' 表示输入的直径不在表中定义的范围内，可根据需求改成抛异常等
        End Select
        Return weight
    End Function
End Module
