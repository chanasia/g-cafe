Public Class Form1

    Private pManuBath As Integer = 0
    Private numRow As Integer = 0
    Private typeCol As String = ""
    Private sizeCol As String = ""
    Private totalPrice As Integer = 0

    Private Sub enDedefault()
        rd_big.Enabled = True
        rd_small.Enabled = True
        rd_big.Checked = True
        checkbath(pManuBath)
        btn_inCount.Enabled = True
        btn_deCount.Enabled = True
    End Sub

    Private Sub checkbath(manuBath As Integer)
        Dim typeBath As Integer = 0
        Dim sizeBath As Integer = 0

        If rd_hot.Checked Then
            typeBath = 0
        ElseIf rd_cool.Checked Then
            typeBath = 5
        ElseIf rd_shake.Checked Then
            typeBath = 10
        End If

        If rd_big.Checked Then
            sizeBath = 20
        ElseIf rd_small.Checked Then
            sizeBath = 10
        End If

        Dim total As Integer = (manuBath + typeBath + sizeBath) * Convert.ToInt32(txt_count.Text)
        lb_bath.Text = total
    End Sub

    Private Sub btn_inCount_Click(sender As Object, e As EventArgs) Handles btn_inCount.Click
        Dim count As String = txt_count.Text
        Dim intCount As Integer = Convert.ToInt32(count)
        count += 1
        If intCount < 99 Then
            txt_count.Text = count
            checkbath(pManuBath)
        End If
    End Sub

    Private Sub btn_deCount_Click(sender As Object, e As EventArgs) Handles btn_deCount.Click
        Dim count As String = txt_count.Text
        Dim intCount As Integer = Convert.ToInt32(count)
        count -= 1
        If intCount > 1 Then
            txt_count.Text = count
            checkbath(pManuBath)
        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Click(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.Click
        rd_hot.Enabled = False
        rd_cool.Enabled = False
        rd_shake.Enabled = False
        rd_hot.Checked = False
        rd_cool.Checked = False
        rd_shake.Checked = False
        rd_big.Enabled = False
        rd_small.Enabled = False
        typeCol = ""
        sizeCol = ""
        lb_manu.Text = "- - -"
        lb_bath.Text = "- - -"
        btn_inCount.Enabled = False
        btn_deCount.Enabled = False
        txt_count.Text = "1"
    End Sub

    Private Sub btn_coco_Click(sender As Object, e As EventArgs) Handles btn_coco.Click
        rd_hot.Enabled = True
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_hot.Checked = True
        lb_manu.Text = "โกโก้"
        pManuBath = 70
        enDedefault()
    End Sub

    Private Sub btn_teaCool_Click(sender As Object, e As EventArgs) Handles btn_teaCool.Click
        rd_hot.Enabled = False
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_cool.Checked = True
        lb_manu.Text = "ชานมเย็น"
        pManuBath = 60
        enDedefault()
    End Sub

    Private Sub btn_teaGreen_Click(sender As Object, e As EventArgs) Handles btn_teaGreen.Click
        rd_hot.Enabled = True
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_hot.Checked = True
        lb_manu.Text = "ชาเขียว"
        pManuBath = 70
        enDedefault()
    End Sub

    Private Sub btn_oLeng_Click(sender As Object, e As EventArgs) Handles btn_oLeng.Click
        rd_hot.Enabled = False
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_cool.Checked = True
        lb_manu.Text = "โอเลี้ยง"
        pManuBath = 60
        enDedefault()
    End Sub

    Private Sub btn_late_Click(sender As Object, e As EventArgs) Handles btn_late.Click
        rd_hot.Enabled = True
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_hot.Checked = True
        lb_manu.Text = "ลาเต้"
        pManuBath = 80
        enDedefault()
    End Sub

    Private Sub btn_cafa_Click(sender As Object, e As EventArgs) Handles btn_cafa.Click
        rd_hot.Enabled = True
        rd_cool.Enabled = True
        rd_shake.Enabled = True
        rd_hot.Checked = True
        lb_manu.Text = "กาแฟโบราณ"
        pManuBath = 70
        enDedefault()
    End Sub

    Private Sub rd_hot_CheckedChanged(sender As Object, e As EventArgs) Handles rd_hot.CheckedChanged
        checkbath(pManuBath)
        typeCol = "ร้อน"
    End Sub
    Private Sub rd_cool_CheckedChanged(sender As Object, e As EventArgs) Handles rd_cool.CheckedChanged
        checkbath(pManuBath)
        typeCol = "เย็น"
    End Sub
    Private Sub rd_shake_CheckedChanged(sender As Object, e As EventArgs) Handles rd_shake.CheckedChanged
        checkbath(pManuBath)
        typeCol = "ปั่น"
    End Sub
    Private Sub rd_big_CheckedChanged(sender As Object, e As EventArgs) Handles rd_big.CheckedChanged
        checkbath(pManuBath)
        sizeCol = "ใหญ่"
    End Sub
    Private Sub rd_small_CheckedChanged(sender As Object, e As EventArgs) Handles rd_small.CheckedChanged
        checkbath(pManuBath)
        sizeCol = "เล็ก"
    End Sub

    Private Sub btn_addManu_Click(sender As Object, e As EventArgs) Handles btn_addManu.Click
        Dim ask As MsgBoxResult = MsgBox("ยืนยันเพิ่มเมนูหรือไม่ !?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            numRow += 1
            If typeCol IsNot "" Or sizeCol IsNot "" Then

                dgv_order.Rows.Add(numRow, lb_manu.Text, typeCol, sizeCol, txt_count.Text, lb_bath.Text)
                totalPrice += Convert.ToInt32(lb_bath.Text)
                lb_totalPrice.Text = totalPrice
            Else
                MessageBox.Show("กรุณาเลือกเมนู")
            End If
        End If
    End Sub

    Private Sub btn_rmOrder_Click(sender As Object, e As EventArgs) Handles btn_rmOrder.Click
        Dim ask As MsgBoxResult = MsgBox("ยืนยันลบเมนูทั้งหมดหรือไม่ !?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            dgv_order.Rows.Clear()
        End If
    End Sub
End Class
