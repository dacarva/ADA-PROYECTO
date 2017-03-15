Imports System.Data.SqlClient
Imports System.Drawing

Public Class PRESUPUESTO
    Inherits System.Web.UI.Page
    'To keep track of the previous row Group Identifier    
    Dim strPreviousRowID As String = String.Empty
    Dim intSubTotalIndex As Integer = 1

    Dim acum_01 As Double = 0
    Dim acum_02 As Double = 0
    Dim acum_03 As Double = 0
    Dim acum_04 As Double = 0
    Dim acum_05 As Double = 0
    Dim acum_06 As Double = 0
    Dim acum_07 As Double = 0
    Dim acum_08 As Double = 0
    Dim acum_09 As Double = 0
    Dim acum_10 As Double = 0
    Dim acum_11 As Double = 0
    Dim acum_12 As Double = 0
    Dim acum_total As Double = 0

    'variables para llenar gridview 14 columnas


    Private Shared datatable_con As DataTable = New DataTable
    Private Shared compañia As String = "COMPAÑIA X"
    Private Shared row_editar As Integer = -1
    Private Shared row_editar1 As Integer = -1

    Private Shared fila_Seleccionada As Integer = -1

    Private Shared rubro As Integer = 0

    Private Shared control_categorias_drop As Boolean = False
    Private Shared control_categorias_drop_1 As Boolean = False
    Private Shared control_agregar_categorias As Boolean = False

    Private Shared cadena_david As String = "Server=DESKTOP-8K65OT1;UID=DESKTOP-8K65OT1/David Carvajal;Database=PRUEBA;Trusted_Connection=True;MultipleActiveResultSets=True"
    Private Shared cadena_javier As String = "Server=DESKTOP-B45RFNJ\SQLEXPRESS;UID=DESKTOP-B45RFNJ\JAVIER_GARCIA;Database=PRUEBA;Trusted_Connection=True;MultipleActiveResultSets=True"

    Private Shared conn As SqlConnection = New SqlConnection(cadena_david)
    Private Sub cargar_GV()
        control_agregar_categorias = False
        'ordenar dt
        If datatable_con.Rows.Count > 0 Then
            Dim dataView As New DataView(datatable_con)
            dataView.Sort = "CLASE ASC"
            Dim dataTable1 As DataTable = dataView.ToTable()
            datatable_con = dataTable1
            GridView1.DataSource = datatable_con
            GridView1.DataBind()
        Else
            GridView1.DataSource = Nothing
            GridView1.DataBind()
        End If
    End Sub
    Private Sub cargar_GV1()
        control_agregar_categorias = True
        'ordenar dt
        If datatable_con.Rows.Count > 0 Then
            Dim dataView As New DataView(datatable_con)
            dataView.Sort = "CLASE ASC"
            Dim dataTable1 As DataTable = dataView.ToTable()
            datatable_con = dataTable1
            GridView1.DataSource = datatable_con
            GridView1.DataBind()
        Else
            GridView1.DataSource = Nothing
            GridView1.DataBind()
        End If
    End Sub
    Private Sub cargar_DROP_CATEGORIAS()
        If control_categorias_drop = False Then
            'Añadir lista de clase actividad predeterminada
            DropDownList2.Items.Clear()
            DropDownList2.Items.Add("OTRAS CATEGORIAS")
            'si existen datos en datatable generar lista de las clases de actividad
            If Not IsNothing(datatable_con) Then
                If datatable_con.Rows.Count <> 0 Then
                    Dim datatable As DataTable = datatable_con
                    Dim numero_filas_dt As Integer = datatable.Rows.Count
                    Dim numero_columnas_dt As Integer = datatable.Columns.Count
                    Dim vector_dt(numero_filas_dt - 1) As String

                    Dim lista_categorias_dt As New List(Of String)
                    Dim lista_categorias As New List(Of String)

                    For i = 0 To numero_filas_dt - 1
                        Dim Row As DataRow = datatable.Rows(i)
                        If Row(0).ToString() <> "OTRAS CATEGORIAS" Then
                            lista_categorias_dt.Add(Row(0).ToString())
                        End If
                    Next
                    'lista sin duplicados
                    lista_categorias = lista_categorias_dt.Distinct.ToList
                    For i = 0 To lista_categorias.Count - 1
                        DropDownList2.Items.Add(lista_categorias(i).ToString)
                    Next
                End If
            End If
        Else
            control_categorias_drop = False
        End If
    End Sub
    Private Sub cargar_DROP_CATEGORIAS1()
        If control_categorias_drop_1 = False Then
            'Añadir lista de clase actividad predeterminada
            DropDownList3.Items.Clear()
            DropDownList3.Items.Add("OTRAS CATEGORIAS")
            'si existen datos en datatable generar lista de las clases de actividad
            If Not IsNothing(datatable_con) Then
                If datatable_con.Rows.Count <> 0 Then
                    Dim datatable As DataTable = datatable_con
                    Dim numero_filas_dt As Integer = datatable.Rows.Count
                    Dim numero_columnas_dt As Integer = datatable.Columns.Count
                    Dim vector_dt(numero_filas_dt - 1) As String

                    Dim lista_categorias_dt As New List(Of String)
                    Dim lista_categorias As New List(Of String)

                    For i = 0 To numero_filas_dt - 1
                        Dim Row As DataRow = datatable.Rows(i)
                        If Row(0).ToString() <> "OTRAS CATEGORIAS" Then
                            lista_categorias_dt.Add(Row(0).ToString())
                        End If
                    Next
                    'lista sin duplicados
                    lista_categorias = lista_categorias_dt.Distinct.ToList
                    For i = 0 To lista_categorias.Count - 1
                        DropDownList3.Items.Add(lista_categorias(i).ToString)
                    Next
                End If
            End If
        Else
            control_categorias_drop_1 = False
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then




            'añadir lista de sedes obtenido en módulo empresa
            DropDownList1.Items.Add("sede 1")
            DropDownList1.Items.Add("sede 2")
            DropDownList1.Items.Add("sede 3")
            DropDownList1.Items.Add("sede 4")

            'limpiar gridview si no es un postback
            datatable_con.Rows.Clear()

            cargar_GV()





            'esconder paneles de controles y gridview
            Panel2.Visible = False
            'habilitar panel de busqueda
            Panel1.Enabled = True

            'si existen datos en datatable generar lista de las clases de actividad
            'Añadir lista de clase actividad predeterminada
            If control_categorias_drop = False Then


                DropDownList2.Items.Clear()
                DropDownList2.Items.Add("OTRAS CATEGORIAS")
                If Not IsNothing(datatable_con) Then
                    If datatable_con.Rows.Count <> 0 Then


                        Dim datatable As DataTable = datatable_con
                        Dim numero_filas_dt As Integer = datatable.Rows.Count
                        Dim numero_columnas_dt As Integer = datatable.Columns.Count
                        Dim vector_dt(numero_filas_dt - 1) As String

                        Dim lista_categorias_dt As New List(Of String)
                        Dim lista_categorias As New List(Of String)

                        For i = 0 To numero_filas_dt - 1
                            Dim Row As DataRow = datatable.Rows(i)
                            If Row(0).ToString() <> "OTRAS CATEGORIAS" Then
                                lista_categorias_dt.Add(Row(0).ToString())
                            End If
                        Next
                        'lista sin duplicados
                        lista_categorias = lista_categorias_dt.Distinct.ToList
                        For i = 0 To lista_categorias.Count - 1
                            DropDownList2.Items.Add(lista_categorias(i).ToString)
                        Next


                    End If
                End If
            Else
                control_categorias_drop = False
            End If

            If control_categorias_drop_1 = False Then


                DropDownList3.Items.Clear()
                DropDownList3.Items.Add("OTRAS CATEGORIAS")
                If Not IsNothing(datatable_con) Then
                    If datatable_con.Rows.Count <> 0 Then


                        Dim datatable As DataTable = datatable_con
                        Dim numero_filas_dt As Integer = datatable.Rows.Count
                        Dim numero_columnas_dt As Integer = datatable.Columns.Count
                        Dim vector_dt(numero_filas_dt - 1) As String

                        Dim lista_categorias_dt As New List(Of String)
                        Dim lista_categorias As New List(Of String)

                        For i = 0 To numero_filas_dt - 1
                            Dim Row As DataRow = datatable.Rows(i)
                            If Row(0).ToString() <> "OTRAS CATEGORIAS" Then
                                lista_categorias_dt.Add(Row(0).ToString())
                            End If
                        Next
                        'lista sin duplicados
                        lista_categorias = lista_categorias_dt.Distinct.ToList
                        For i = 0 To lista_categorias.Count - 1
                            DropDownList3.Items.Add(lista_categorias(i).ToString)
                        Next


                    End If
                End If
            Else
                control_categorias_drop_1 = False
            End If

        Else

        End If
    End Sub

    Protected Sub GridView1_RowCreated(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowCreated

        If control_agregar_categorias = False Then


            Dim IsSubTotalRowNeedToAdd As Boolean = False
            Dim IsGrandTotalRowNeedtoAdd As Boolean = False


            If (strPreviousRowID <> String.Empty) And (DataBinder.Eval(e.Row.DataItem, "CLASE") <> Nothing) Then
                If strPreviousRowID <> DataBinder.Eval(e.Row.DataItem, "CLASE").ToString() Then
                    IsSubTotalRowNeedToAdd = True
                End If
            End If
            If (strPreviousRowID <> String.Empty) And (DataBinder.Eval(e.Row.DataItem, "CLASE") = Nothing) Then
                IsSubTotalRowNeedToAdd = True
                IsGrandTotalRowNeedtoAdd = True
            End If


            If (strPreviousRowID = String.Empty) And (DataBinder.Eval(e.Row.DataItem, "CLASE") <> Nothing) Then
                Dim grdViewOrders As GridView = CType(sender, GridView)
                Dim row As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)
                Dim cell As TableCell = New TableCell()
                cell.Text = "+" + DataBinder.Eval(e.Row.DataItem, "CLASE").ToString
                cell.ColumnSpan = 100
                cell.CssClass = "GroupHeaderStyle"
                row.Cells.Add(cell)
                GridView1.Controls(0).Controls.AddAt(e.Row.RowIndex + intSubTotalIndex, row)
                intSubTotalIndex = intSubTotalIndex + 1
            End If


            If IsSubTotalRowNeedToAdd = True Then
                If (DataBinder.Eval(e.Row.DataItem, "CLASE") <> Nothing) Then
                    Dim grdViewOrders As GridView = CType(sender, GridView)
                    Dim row As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)
                    Dim cell As TableCell = New TableCell()
                    cell.Text = "+" + DataBinder.Eval(e.Row.DataItem, "CLASE").ToString()
                    cell.ColumnSpan = 100
                    cell.CssClass = "GroupHeaderStyle"
                    row.Cells.Add(cell)
                    GridView1.Controls(0).Controls.AddAt(e.Row.RowIndex + intSubTotalIndex, row)
                    intSubTotalIndex = intSubTotalIndex + 1
                End If
            End If

            If IsGrandTotalRowNeedtoAdd = True Then
                Dim grdViewOrders As GridView = CType(sender, GridView)
                Dim row As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)

                Dim cell As TableCell = New TableCell()
                cell.Text = "Total por mes"
                cell.HorizontalAlign = HorizontalAlign.Left

                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)

                'enero
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_01)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'febrero
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_02)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'marzo
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_03)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'abril
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_04)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'mayo
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_05)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'junio
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_06)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'julio
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_07)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'agosto
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_08)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'septiembre
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_09)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'octubre
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_10)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'noviembre
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_11)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'diciembre
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_12)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)
                'total por meses
                cell = New TableCell()
                cell.Text = String.Format("{0:0.00}", acum_total)
                cell.HorizontalAlign = HorizontalAlign.Center
                cell.CssClass = "Group_total_mes"
                row.Cells.Add(cell)

                'GRAN TOTAL

                Dim color_total As Color
                color_total = Color.FromArgb(200, 203, 195)

                Dim row1 As GridViewRow = New GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert)
                Dim cell1 As TableCell = New TableCell()
                cell1.Text = "PRESUPUESTO TOTAL"
                cell1.HorizontalAlign = HorizontalAlign.Left
                cell1.BackColor = color_total
                cell1.CssClass = "total_pres"
                row1.Cells.Add(cell1)
                'total 
                cell1 = New TableCell()
                cell1.Text = String.Format("{0:0.00}", acum_total)
                cell1.HorizontalAlign = HorizontalAlign.Center
                cell1.BackColor = color_total
                cell1.CssClass = "total_pres"
                row1.Cells.Add(cell1)



                GridView1.Controls(0).Controls.AddAt(e.Row.RowIndex, row)
                GridView1.Controls(0).Controls.AddAt(e.Row.RowIndex, row1)

            End If
        End If



    End Sub

    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound





        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim item As String = e.Row.Cells(1).Text
            For Each button As ImageButton In e.Row.Cells(15).Controls.OfType(Of ImageButton)()

                If button.CommandName = "Delete" Then
                    button.Attributes("onclick") = "if(!confirm('Do you want to delete " + item + "?')){ return false; };"
                    button.ToolTip = "Eliminar Actividad"
                End If
                If button.CommandName = "Edit" Then
                    button.ToolTip = "Editar Actividad"
                End If
                If button.CommandName = "Select" Then
                    button.ToolTip = "Seleccionar Actividad"
                End If




            Next
        End If


        If control_agregar_categorias = False Then
            If e.Row.RowType = DataControlRowType.DataRow Then
                strPreviousRowID = DataBinder.Eval(e.Row.DataItem, "CLASE").ToString()
                Dim valor_01 As Double = 0
                Dim valor_02 As Double = 0
                Dim valor_03 As Double = 0
                Dim valor_04 As Double = 0
                Dim valor_05 As Double = 0
                Dim valor_06 As Double = 0
                Dim valor_07 As Double = 0
                Dim valor_08 As Double = 0
                Dim valor_09 As Double = 0
                Dim valor_10 As Double = 0
                Dim valor_11 As Double = 0
                Dim valor_12 As Double = 0
                Dim valor_TOTAL As Double = 0




                If DataBinder.Eval(e.Row.DataItem, "ENERO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "ENERO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "ENERO").ToString) Then
                            valor_01 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "ENERO").ToString())
                            acum_01 = acum_01 + valor_01
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "FEBRERO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "FEBRERO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "FEBRERO").ToString) Then
                            valor_02 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "FEBRERO").ToString())
                            acum_02 = acum_02 + valor_02
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "MARZO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "MARZO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "MARZO").ToString) Then
                            valor_03 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "MARZO").ToString())
                            acum_03 = acum_03 + valor_03
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "ABRIL") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "ABRIL").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "ABRIL").ToString) Then
                            valor_04 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "ABRIL").ToString())
                            acum_04 = acum_04 + valor_04
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "MAYO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "MAYO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "MAYO").ToString) Then
                            valor_05 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "MAYO").ToString())
                            acum_05 = acum_05 + valor_05
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "JUNIO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "JUNIO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "JUNIO").ToString) Then
                            valor_06 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "JUNIO").ToString())
                            acum_06 = acum_06 + valor_06
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "JULIO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "JULIO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "JULIO").ToString) Then
                            valor_07 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "JULIO").ToString())
                            acum_07 = acum_07 + valor_07
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "AGOSTO") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "AGOSTO").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "AGOSTO").ToString) Then
                            valor_08 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "AGOSTO").ToString())
                            acum_08 = acum_08 + valor_08
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "SEPTIEMBRE") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "SEPTIEMBRE").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "SEPTIEMBRE").ToString) Then
                            valor_09 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "SEPTIEMBRE").ToString())
                            acum_09 = acum_09 + valor_09
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "OCTUBRE") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "OCTUBRE").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "OCTUBRE").ToString) Then
                            valor_10 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "OCTUBRE").ToString())
                            acum_10 = acum_10 + valor_10
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "NOVIEMBRE") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "NOVIEMBRE").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "NOVIEMBRE").ToString) Then
                            valor_11 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "NOVIEMBRE").ToString())
                            acum_11 = acum_11 + valor_11
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "DICIEMBRE") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "DICIEMBRE").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "DICIEMBRE").ToString) Then
                            valor_12 = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "DICIEMBRE").ToString())
                            acum_12 = acum_12 + valor_12
                        End If
                    End If
                End If
                If DataBinder.Eval(e.Row.DataItem, "TOTAL ACTIVIDAD") <> Nothing Then
                    If DataBinder.Eval(e.Row.DataItem, "TOTAL ACTIVIDAD").ToString <> "" Then
                        If IsNumeric(DataBinder.Eval(e.Row.DataItem, "TOTAL ACTIVIDAD").ToString) Then
                            valor_TOTAL = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "TOTAL ACTIVIDAD").ToString())
                            acum_total = acum_total + valor_TOTAL
                        End If
                    End If
                End If


            End If
            e.Row.Cells(0).Visible = False
        Else
            e.Row.Cells(0).Visible = True
        End If

    End Sub
    'Consulta en BD presupuestos
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GridView1.DataSource = Nothing
        GridView1.DataBind()

        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        If IsNumeric(TextBox16.Text) Then
            Dim valor As Double = TextBox16.Text
            rubro = valor
        Else
            Exit Sub
        End If



        If TextBox1.Text <> "" And DropDownList1.SelectedIndex >= 0 Then

            If IsNumeric(TextBox1.Text) Then
                Dim numero_registros As Integer = 0
                Dim index_seleccionado As Integer = DropDownList1.SelectedIndex
                Dim sede As String = DropDownList1.Items(index_seleccionado).Value
                Dim año As String = TextBox1.Text
                Dim lista_actividad As New List(Of String)
                Dim lista_clase As New List(Of String)
                'lista de los meses
                Dim lista_01 As New List(Of String)
                Dim lista_02 As New List(Of String)
                Dim lista_03 As New List(Of String)
                Dim lista_04 As New List(Of String)
                Dim lista_05 As New List(Of String)
                Dim lista_06 As New List(Of String)

                Dim lista_07 As New List(Of String)
                Dim lista_08 As New List(Of String)
                Dim lista_09 As New List(Of String)
                Dim lista_10 As New List(Of String)
                Dim lista_11 As New List(Of String)
                Dim lista_12 As New List(Of String)

                Dim lista_total As New List(Of String)

                conn.Open()
                Dim consulta As String = "SELECT actividad,clase,MES_01,MES_02,MES_03,MES_04,MES_05,MES_06,MES_07,MES_08,MES_09,MES_10,MES_11,MES_12,TOTAL FROM presupuesto_1 WHERE año=" & año & " and sede='" & sede & "' and company_us='" & compañia & "' ORDER BY clase ASC"
                Dim cmd As New SqlCommand(consulta, conn)
                Dim dr As SqlDataReader
                Try
                    dr = cmd.ExecuteReader()
                    While dr.Read
                        numero_registros = numero_registros + 1

                        lista_actividad.Add(dr(0).ToString)
                        lista_clase.Add(dr(1).ToString)

                        Dim Texto As String = dr(0).ToString
                        Dim Texto1 As String = dr(1).ToString

                        For i = 2 To 14
                            If IsDBNull(dr(i)) Then
                                Select Case i
                                    'enero
                                    Case 2
                                        lista_01.Add("")
                                    'febrero
                                    Case 3
                                        lista_02.Add("")
                                    'marzo
                                    Case 4
                                        lista_03.Add("")
                                    'abril
                                    Case 5
                                        lista_04.Add("")
                                    'mayo
                                    Case 6
                                        lista_05.Add("")
                                    'junio
                                    Case 7
                                        lista_06.Add("")
                                    'julio
                                    Case 8
                                        lista_07.Add("")
                                    'agosto
                                    Case 9
                                        lista_08.Add("")
                                    'septiembre
                                    Case 10
                                        lista_09.Add("")
                                    'octubre
                                    Case 11
                                        lista_10.Add("")
                                    'noviembre
                                    Case 12
                                        lista_11.Add("")
                                    'diciembre
                                    Case 13
                                        lista_12.Add("")
                                    'total
                                    Case 14
                                        lista_total.Add("")

                                End Select
                            Else
                                Dim Numero As Double = dr(i)
                                Select Case i
                                    'enero
                                    Case 2
                                        lista_01.Add(Numero.ToString)
                                    'febrero
                                    Case 3
                                        lista_02.Add(Numero.ToString)
                                    'marzo
                                    Case 4
                                        lista_03.Add(Numero.ToString)
                                    'abril
                                    Case 5
                                        lista_04.Add(Numero.ToString)
                                    'mayo
                                    Case 6
                                        lista_05.Add(Numero.ToString)
                                    'junio
                                    Case 7
                                        lista_06.Add(Numero.ToString)
                                    'julio
                                    Case 8
                                        lista_07.Add(Numero.ToString)
                                    'agosto
                                    Case 9
                                        lista_08.Add(Numero.ToString)
                                    'septiembre
                                    Case 10
                                        lista_09.Add(Numero.ToString)
                                    'octubre
                                    Case 11
                                        lista_10.Add(Numero.ToString)
                                    'noviembre
                                    Case 12
                                        lista_11.Add(Numero.ToString)
                                    'diciembre
                                    Case 13
                                        lista_12.Add(Numero.ToString)
                                    'total
                                    Case 14
                                        lista_total.Add(Numero.ToString)

                                End Select
                            End If
                        Next

                    End While
                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                End Try

                Dim tabla As DataTable = New DataTable

                tabla.Columns.AddRange(New DataColumn() {New DataColumn("CLASE", GetType(String)),
                                               New DataColumn("ACTIVIDAD", GetType(String)),
                                               New DataColumn("ENERO", GetType(String)),
                                               New DataColumn("FEBRERO", GetType(String)),
                                               New DataColumn("MARZO", GetType(String)),
                                               New DataColumn("ABRIL", GetType(String)),
                                               New DataColumn("MAYO", GetType(String)),
                                               New DataColumn("JUNIO", GetType(String)),
                                               New DataColumn("JULIO", GetType(String)),
                                               New DataColumn("AGOSTO", GetType(String)),
                                               New DataColumn("SEPTIEMBRE", GetType(String)),
                                               New DataColumn("OCTUBRE", GetType(String)),
                                               New DataColumn("NOVIEMBRE", GetType(String)),
                                               New DataColumn("DICIEMBRE", GetType(String)),
                                               New DataColumn("TOTAL ACTIVIDAD", GetType(String))})




                For i = 0 To numero_registros - 1
                    tabla.Rows.Add(lista_clase(i), lista_actividad(i).ToString _
                    , lista_01(i) _
                    , lista_02(i) _
                    , lista_03(i) _
                    , lista_04(i) _
                    , lista_05(i) _
                    , lista_06(i) _
                    , lista_07(i) _
                    , lista_08(i) _
                    , lista_09(i) _
                    , lista_10(i) _
                    , lista_11(i) _
                    , lista_12(i) _
                    , lista_total(i))

                Next

                datatable_con.Rows.Clear()
                datatable_con = tabla



                cargar_DROP_CATEGORIAS()
                cargar_DROP_CATEGORIAS1()
                cargar_GV()






                Panel2.Visible = True
                Panel1.Enabled = False

            Else
                Exit Sub
            End If
        End If



    End Sub
    'Agregar nueva actividad
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'captar la información de actividad y categoria
        Dim nombre_actividad As String = ""
        Dim nombre_categoria As String = ""

        If TextBox15.Text <> "" Then
            nombre_actividad = TextBox15.Text
            If TextBox2.Text <> "" Then
                nombre_categoria = TextBox2.Text
            Else
                If DropDownList2.SelectedIndex >= 0 Then
                    nombre_categoria = DropDownList2.Items(DropDownList2.SelectedIndex).Value.ToString()
                Else
                    nombre_categoria = "OTRAS CATEGORIAS"
                End If
            End If
        Else
            cargar_GV()
            Exit Sub
        End If

        'verificar que el nombre no se repita en gridview
        Dim datatable As DataTable = datatable_con
        Dim numero_filas_dt As Integer = datatable.Rows.Count
        Dim numero_columnas_dt As Integer = datatable.Columns.Count
        For i = 0 To numero_filas_dt - 1
            Dim Row As DataRow = datatable.Rows(i)
            If Row(0).ToString().ToUpper = nombre_actividad.ToUpper Then
                Response.Write("<script>alert('No se puede agregar una actividad con el mismo nombre de otra actvidiad ya consignada en el presupuesto, digite otro nombre por favor')</script>")
                cargar_GV()
                Exit Sub
            End If
        Next


        ' guardar en el datatable final
        Dim vector_dt(14) As String
        For i = 1 To 14
            vector_dt(i) = ""
        Next
        vector_dt(0) = nombre_categoria
        vector_dt(1) = nombre_actividad
        vector_dt(14) = "0"

        datatable.Rows.Add(vector_dt(0) _
            , vector_dt(1) _
            , vector_dt(2) _
            , vector_dt(3) _
            , vector_dt(4) _
            , vector_dt(5) _
            , vector_dt(6) _
            , vector_dt(7) _
            , vector_dt(8) _
            , vector_dt(9) _
            , vector_dt(10) _
            , vector_dt(11) _
            , vector_dt(12) _
            , vector_dt(13) _
            , vector_dt(14)
            )

        datatable_con = datatable

        'limpiar controles
        TextBox15.Text = ""
        TextBox2.Text = ""
        DropDownList2.SelectedIndex = 0
        Panel3.Visible = False


        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        ' realizar databind y actualizar dropdownlist categorias
        cargar_GV()
        cargar_DROP_CATEGORIAS()
        cargar_DROP_CATEGORIAS1()


    End Sub
    'guardar datatable en BD
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'verificar si existe una tabla que guardar
        If datatable_con.Rows.Count > 0 Then
            ' guardar datatbale en un vector
            Dim datatable As DataTable = datatable_con
            Dim numero_filas_dt As Integer = datatable.Rows.Count
            Dim numero_columnas_dt As Integer = datatable.Columns.Count
            Dim vector_dt(numero_filas_dt - 1, numero_columnas_dt - 1) As String

            For i = 0 To numero_filas_dt - 1
                For i1 = 0 To numero_columnas_dt - 1
                    Dim Row As DataRow = datatable.Rows(i)
                    vector_dt(i, i1) = Row(i1).ToString()
                Next
            Next
            ' guardar en base de datos 
            Dim index_seleccionado As Integer = DropDownList1.SelectedIndex
            Dim sede As String = DropDownList1.Items(index_seleccionado).Value
            Dim año As String = TextBox1.Text

            If compañia <> "" And sede <> "" And año <> "" And IsNumeric(año) Then

                'borrar filas de la tabla
                conn.Open()
                Dim consulta As String = "DELETE FROM  presupuesto_1 WHERE company_us='" & compañia & "' and año=" & año & " and sede='" & sede & "'"
                Dim comm As New SqlCommand(consulta, conn)


                Try
                    comm.ExecuteNonQuery()
                    conn.Close()

                Catch ex As Exception
                    conn.Close()
                    Exit Sub
                End Try
                'guardar todas las filas del dt
                For i = 0 To numero_filas_dt - 1

                    conn.Open()
                    Dim consulta1 As String = "INSERT INTO presupuesto_1 (company_us,año,sede,actividad,clase,MES_01,MES_02,MES_03,MES_04,MES_05,MES_06,MES_07,MES_08,MES_09,MES_10,MES_11,MES_12,TOTAL) VALUES( @company_us,@año,@sede,@actividad,@clase,@MES_01,@MES_02,@MES_03,@MES_04,@MES_05,@MES_06,@MES_07,@MES_08,@MES_09,@MES_10,@MES_11,@MES_12,@TOTAL)"
                    Dim comm1 As New SqlCommand(consulta1, conn)

                    comm1.Parameters.AddWithValue("@company_us", compañia)
                    comm1.Parameters.AddWithValue("@año", año)
                    comm1.Parameters.AddWithValue("@sede", sede)
                    comm1.Parameters.AddWithValue("@actividad", vector_dt(i, 1))
                    comm1.Parameters.AddWithValue("@clase", vector_dt(i, 0))

                    If IsNumeric(vector_dt(i, 2)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 2))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_01", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_01", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 3)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 3))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_02", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_02", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 4)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 4))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_03", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_03", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 5)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 5))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_04", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_04", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 6)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 6))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_05", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_05", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 7)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 7))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_06", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_06", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 8)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 8))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_07", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_07", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 9)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 9))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_08", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_08", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 10)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 10))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_09", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_09", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 11)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 11))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_10", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_10", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 12)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 12))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_11", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_11", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 13)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 13))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@MES_12", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@MES_12", DBNull.Value)
                    End If

                    If IsNumeric(vector_dt(i, 14)) Then
                        Dim valor As Double = Convert.ToDouble(vector_dt(i, 14))
                        valor = Decimal.Round(valor, 0, MidpointRounding.AwayFromZero)
                        comm1.Parameters.AddWithValue("@TOTAL", valor.ToString(System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        comm1.Parameters.AddWithValue("@TOTAL", DBNull.Value)
                    End If





                    Try
                        comm1.ExecuteNonQuery()
                        conn.Close()

                    Catch ex As Exception
                        conn.Close()

                    End Try


                Next


















                ' mensaje verificación
                Response.Write("<script>alert(' Guardado')</script>")
            Else
                ' mensaje no se verifico compañia, sede o usuario
                Response.Write("<script>alert(' Faltan datos o año no es numerico')</script>")
            End If
        Else
            ' mensaje no hay filas
            Response.Write("<script>alert(' no hay filas en la tabla del presupuesto')</script>")
        End If

        GridView1.DataSource = Nothing

        cargar_GV()





    End Sub
    'cancelar Nueva actividad
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        row_editar = -1
        'limpiar controles
        TextBox15.Text = ""
        TextBox2.Text = ""
        DropDownList2.SelectedIndex = 0
        'esconder panel con contoles de nueva categoria
        Panel3.Visible = False
        'databind
        cargar_GV()
    End Sub
    ' Mostrar panel de agrupar
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        'Mostar controles
        If Panel4.Visible = True Then
            Panel4.Visible = False
            Panel3.Visible = False
        Else
            Panel4.Visible = True
            Panel3.Visible = False
        End If



        cargar_GV()






    End Sub


    ' nueva actividad y cancelar nueva actividad
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
            Panel4.Visible = False
        Else
            Panel3.Visible = False
            Panel4.Visible = False
        End If

        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        cargar_GV()



    End Sub
    ' cancelar toda la operación
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Response.Redirect("default.aspx", True)
    End Sub


    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        control_categorias_drop = True
        GridView1.DataSource = Nothing
        GridView1.DataBind()
        cargar_GV()

    End Sub

    Protected Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        GridView1.EditIndex = e.NewEditIndex
        row_editar1 = e.NewEditIndex
        cargar_GV1()
        'GridView1.Columns(0).ItemStyle.Width = Unit.Percentage(20)


    End Sub

    Protected Sub GridView1_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles GridView1.RowCancelingEdit
        GridView1.EditIndex = -1
        cargar_GV()
    End Sub

    Protected Sub GridView1_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles GridView1.RowUpdating

        'Update the values.
        Dim row = GridView1.Rows(e.RowIndex)

        Dim Total As Double = 0
        Dim newrow(14) As String
        For i = 0 To 14
            newrow(i) = ""
        Next

        For i = 1 To 13
            newrow(i) = (CType((row.Cells(i).Controls(0)), TextBox)).Text
        Next

        For i = 2 To 13
            If IsNumeric(newrow(i)) Then
                Dim value As Double = Convert.ToDouble(newrow(i))
                Total = Total + value
            Else
                newrow(i) = ""
            End If
        Next
        newrow(14) = Total.ToString

        'Verificar que el rubro sea mayor o igual al total del presupuesto
        Dim datatable As DataTable = datatable_con
        Dim totales_dt(datatable.Rows.Count - 1) As Double

        For i = 0 To datatable.Rows.Count - 1
            If i <> e.RowIndex Then
                If IsNumeric(datatable_con.Rows(i).Item(14)) Then
                    Dim valor As Double = Convert.ToDouble(datatable_con.Rows(i).Item(14))
                    totales_dt(i) = datatable_con.Rows(i).Item(14)
                Else
                    totales_dt(i) = 0
                End If
            Else
                totales_dt(i) = Total
            End If


        Next

        Dim gran_total As Double = 0
        For i = 0 To datatable.Rows.Count - 1
            gran_total = gran_total + totales_dt(i)
        Next

        If rubro >= gran_total Then
            For i = 1 To 14
                datatable_con.Rows(e.RowIndex).Item(i) = newrow(i)
            Next
        Else
            Response.Write("<script>alert('Si el total del presupuesto supera al rubro total, no se puede completar la edición de esta actividad')</script>")
        End If



        'salir del modo edición

        GridView1.EditIndex = -1

        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        'Bind data to the GridView control.
        cargar_GV()
    End Sub

    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'esconder panel agrupar
        Panel4.Visible = False
        'limpiar controles asociados
        TextBox3.Text = ""
        TextBox4.Text = ""
        DropDownList3.SelectedIndex = 0

        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        cargar_GV()




    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        control_categorias_drop_1 = True
        GridView1.DataSource = Nothing
        GridView1.DataBind()
        cargar_GV()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        fila_Seleccionada = GridView1.SelectedIndex

        TextBox4.Text = ""
        Dim datatable As DataTable = datatable_con
        Dim Row As DataRow = datatable.Rows(fila_Seleccionada)
        TextBox4.Text = Row(1).ToString().ToUpper()
        DropDownList3.Text = Row(0).ToString()

        cargar_GV()
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)

        Dim index As Integer = Convert.ToInt32(e.RowIndex)
        Dim Row As DataRow = datatable_con.Rows(index)
        Row.Delete()

        'quitar selección de fila
        fila_Seleccionada = -1
        TextBox4.Text = ""

        cargar_GV()

    End Sub

    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If fila_Seleccionada >= 0 Then
            Dim nombre_categoria
            If TextBox3.Text <> "" Then
                nombre_categoria = TextBox3.Text
            Else
                If DropDownList3.SelectedIndex >= 0 Then
                    nombre_categoria = DropDownList3.Items(DropDownList3.SelectedIndex).Value.ToString()
                Else
                    nombre_categoria = "OTRAS CATEGORIAS"
                End If
            End If

            Dim datatable As DataTable = datatable_con
            datatable.Rows(fila_Seleccionada).Item(0) = nombre_categoria
            fila_Seleccionada = -1
            TextBox3.Text = ""
            TextBox4.Text = ""
            Panel4.Visible = False
            DropDownList3.SelectedIndex = 0
        Else
            Response.Write("<script>alert('No ha seleccionado una actividad, por favor elija una actividad para agruparla')</script>")
        End If

        cargar_GV()
    End Sub
End Class