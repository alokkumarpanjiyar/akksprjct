Imports Oracle.ManagedDataAccess.Client


Partial Class Find_Capital
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OracleConnection("Data Source=SANDYORACLE11G;Persist Security Info=True;User ID=ORA_TUTOR;Password=ora_tutor00;")
        Dim sql As String = "select capital as cap from state where state_name='" & TXT_STATENM.Text & "'"
        Dim cmd As New OracleCommand(sql, con)


        If con.State <> Data.ConnectionState.Open Then
            con.Open()
        End If

        Try
            Dim dr As OracleDataReader = cmd.ExecuteReader()

            If dr.Read Then
                LBL_CAPITALNM.Text = dr("cap").ToString
            End If
        Catch

        Finally
            con.Close()
        End Try

    End Sub
End Class
