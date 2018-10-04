'Developed by Badde Liyanage Don Dilanga. bld@dilanga.com. 

Public Class UnitConversion

    '//In here there are 
    '//Inch -> cm
    '//m/s -> km/h
    '//mmHg -> Pa
    ''//Hp -> W
    '//J ->Cal

    'Inch -> cm (IntoCm)
    'cm -> Inch (CmtoIn)

    'ms -> kmh (MstoKmh)
    'kmh -> ms (KmhtoMs)

    'mmHg ->Pa (mmHgtoPa)
    'Pa ->mmHg (PatommHg)

    'Hp -> W (HptoW)
    'W -> Hp (WtoHp)

    'J -> Cal (JtoCal)
    'Cal -> J (CaltoJ)


    Dim _firstValue, _answerValue As Double
    Dim _symbol As String

    Public Function conversion(ByVal _firstValue, ByVal _symbol) As Object

        Try

            Select Case _symbol

                Case "IntoCm"
                    _answerValue = _firstValue * 2.5 '//Inch to Cm
                Case "CmtoIn"
                    _answerValue = _firstValue * (1 / 2.5)  '//Cm to Inch

                Case "MstoKmh"
                    _answerValue = _firstValue * (1 / 0.28) '//Mps to Kmph
                Case "KmhtoMs"
                    _answerValue = _firstValue * 0.28 '//Kmph to Mps

                Case "mmHgtoPa"
                    _answerValue = _firstValue * (133.322368) '//mmHg to Pa
                Case "PatommHg"
                    _answerValue = _firstValue * (1 / 133.322368) '//Pa to mmHg

                Case "HptoW"
                    _answerValue = _firstValue * 745.699872 '//hp to W
                Case "WtoHp"
                    _answerValue = _firstValue * (1 / 745.699872) '//W to Hp

                Case ""
                    _answerValue = "There is no value to convert"

            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return _answerValue

    End Function

End Class
