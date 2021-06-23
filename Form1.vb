Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("data source=SOFIAAZUL\SQL2014; initial catalog=Northwind; integrated security=true")

    Sub Buscar()
        Dim da As New SqlDataAdapter("Select * from factura where nfact=" & CStr(Int(Val(NFact.Text))).Trim, con)
        Dim ds As New DataSet
        da.Fill(ds, "Facturas")
        Grilla.DataSource = ds.Tables("Facturas")
        Grilla.Refresh()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Buscar()
    End Sub
End Class
