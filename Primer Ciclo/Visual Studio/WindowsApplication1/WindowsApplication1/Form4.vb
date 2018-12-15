Public Class Form4
    Private Sub ClienterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosDataSet.Clienter' Puede moverla o quitarla según sea necesario.
        Me.ClienterTableAdapter.Fill(Me.Base_DatosDataSet.Clienter)

    End Sub

    Private Sub Tipo_pagoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tipo_pagoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Tipo_pagoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Button1 As New Form1
        Button1.Show()
        Me.Hide()
    End Sub
End Class