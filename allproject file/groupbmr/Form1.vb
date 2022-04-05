Public Class Form1

    Private Sub male_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles male.Click
        sex.Text = "คุณเลือกเพศชาย"
    End Sub

    Private Sub famale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles famale.Click
        sex.Text = "คุณเลือกเพศหญิง"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        showact.Text = "คุณเลือก: นั่งทำงานอยู่กับที่ และไม่ได้ออกกำลังกายเลย"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาเล็กน้อย ประมาณอาทิตย์ละ 1-3 วัน"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาปานกลาง ประมาณอาทิตย์ละ 3-5 วัน"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนัก ประมาณอาทิตย์ละ 6-7 วัน"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนักทุกวันเช้าเย็น"
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click

        Dim a, h, w, bmi As Integer
        If sex.Text = "คุณเลือกเพศชาย" Then
                If showact.Text = "คุณเลือก: นั่งทำงานอยู่กับที่ และไม่ได้ออกกำลังกายเลย" Then
                    a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    btncal.Text = "BMR ผู้ชายคำนวนได้: " & 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.2 & " กิโลแคลอรี่"
                    w = weight.Text
                    h = high.Text
                    bmi = w / (h / 100) ^ 2
                    If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                    ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                    ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                    ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                    Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                    End If
                ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาเล็กน้อย ประมาณอาทิตย์ละ 1-3 วัน" Then
                    a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    btncal.Text = "BMR ผู้ชายคำนวนได้: " & 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.375 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
                ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาปานกลาง ประมาณอาทิตย์ละ 3-5 วัน" Then
                    a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    btncal.Text = "BMR ผู้ชายคำนวนได้: " & 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.55 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
                ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนัก ประมาณอาทิตย์ละ 6-7 วัน" Then
                    a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    btncal.Text = "BMR ผู้ชายคำนวนได้: " & 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.725 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
                ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนักทุกวันเช้าเย็น" Then
                    a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    btncal.Text = "BMR ผู้ชายคำนวนได้: " & 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                    showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.9 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
                ElseIf showact.Text = "โปรดเลือกความสม่ำเสมอในการออกกำลังกายด้วยครับ" Then
                    showtdee.Text = "โปรดเลือกความสม่ำเสมอในการออกกำลังกายด้วยครับ"
                End If
        ElseIf sex.Text = "คุณเลือกเพศหญิง" Then
            If showact.Text = "คุณเลือก: นั่งทำงานอยู่กับที่ และไม่ได้ออกกำลังกายเลย" Then
                a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                btncal.Text = "BMR ผู้หญิงคำนวนได้: " & 665 + 9.6 * weight.Text + 1.8 * high.Text - 4.7 * age.Text
                showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.2 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
            ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาเล็กน้อย ประมาณอาทิตย์ละ 1-3 วัน" Then
                a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                btncal.Text = "BMR ผู้หญิงคำนวนได้: " & 665 + 9.6 * weight.Text + 1.8 * high.Text - 4.7 * age.Text
                showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.375 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
            ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาปานกลาง ประมาณอาทิตย์ละ 3-5 วัน" Then
                a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                btncal.Text = "BMR ผู้หญิงคำนวนได้: " & 665 + 9.6 * weight.Text + 1.8 * high.Text - 4.7 * age.Text
                showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.55 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
            ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนัก ประมาณอาทิตย์ละ 6-7 วัน" Then
                a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                btncal.Text = "BMR ผู้หญิงคำนวนได้: " & 665 + 9.6 * weight.Text + 1.8 * high.Text - 4.7 * age.Text
                showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.725 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
            ElseIf showact.Text = "คุณเลือก: ออกกำลังกายหรือเล่นกีฬาอย่างหนักทุกวันเช้าเย็น" Then
                a = 66 + 13.7 * weight.Text + 5 * high.Text - 6.8 * age.Text
                btncal.Text = "BMR ผู้หญิงคำนวนได้: " & 665 + 9.6 * weight.Text + 1.8 * high.Text - 4.7 * age.Text
                showtdee.Text = "พลังงานที่คุณใช้ในแต่ละวันคือ " & a * 1.9 & " กิโลแคลอรี่"
                w = weight.Text
                h = high.Text
                bmi = w / (h / 100) ^ 2
                If bmi >= 30 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วนมาก"
                    pic5.Visible = True
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 25 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: อ้วน"
                    pic5.Visible = False
                    pic4.Visible = True
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 23 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักเกิน"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = True
                    pic2.Visible = False
                    pic1.Visible = False
                ElseIf bmi >= 18.5 Then
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: น้ำหนักปกติเหมาะสม"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = True
                    pic1.Visible = False
                Else
                    showbmi.Text = "ค่า BMI ของคุณคือ " & bmi & " เกณฑ์ของคุณคือ: ผอมเกินไป"
                    pic5.Visible = False
                    pic4.Visible = False
                    pic3.Visible = False
                    pic2.Visible = False
                    pic1.Visible = True
                End If
            ElseIf showact.Text = "โปรดเลือกความสม่ำเสมอในการออกกำลังกายด้วยครับ" Then
                showtdee.Text = "โปรดเลือกความสม่ำเสมอในการออกกำลังกายด้วยครับ"
            End If
        ElseIf sex.Text = "โปรดเลือกเพศ" Then
            btncal.Text = "โปรดเลือกเพศด้วยครับ"
        End If
    End Sub
End Class
