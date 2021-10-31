Public Class Form1
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Start()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Finish(sender As Object, e As EventArgs) Handles LabelFinish.MouseEnter
        MessageBox.Show("FELICIDADES, LO HAS LOGRADO")
        Close()

    End Sub
    Private Sub Start()
        Dim StartPoint = Panel1.Location
        StartPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartPoint)
    End Sub

    Private Sub Start(sender As Object, e As EventArgs) Handles Label45.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label44.MouseEnter, Label42.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
