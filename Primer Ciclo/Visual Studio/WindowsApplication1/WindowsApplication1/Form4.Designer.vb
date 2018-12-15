<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Tipo_pagoLabel As System.Windows.Forms.Label
        Dim NITLabel As System.Windows.Forms.Label
        Dim Cantidad_ProLabel As System.Windows.Forms.Label
        Dim Cantidad_ProLabel1 As System.Windows.Forms.Label
        Dim Valor_pagarLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Base_DatosDataSet = New WindowsApplication1.Base_DatosDataSet()
        Me.ClienterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienterTableAdapter = New WindowsApplication1.Base_DatosDataSetTableAdapters.ClienterTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Base_DatosDataSetTableAdapters.TableAdapterManager()
        Me.ClienterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ClienterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_pagoTextBox = New System.Windows.Forms.TextBox()
        Me.NITTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_ProTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_pagarTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Tipo_pagoLabel = New System.Windows.Forms.Label()
        NITLabel = New System.Windows.Forms.Label()
        Cantidad_ProLabel = New System.Windows.Forms.Label()
        Cantidad_ProLabel1 = New System.Windows.Forms.Label()
        Valor_pagarLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienterBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.images1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Base_DatosDataSet
        '
        Me.Base_DatosDataSet.DataSetName = "Base_DatosDataSet"
        Me.Base_DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienterBindingSource
        '
        Me.ClienterBindingSource.DataMember = "Clienter"
        Me.ClienterBindingSource.DataSource = Me.Base_DatosDataSet
        '
        'ClienterTableAdapter
        '
        Me.ClienterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienterTableAdapter = Me.ClienterTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Base_DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienterBindingNavigator
        '
        Me.ClienterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienterBindingNavigator.BindingSource = Me.ClienterBindingSource
        Me.ClienterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienterBindingNavigatorSaveItem})
        Me.ClienterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienterBindingNavigator.Name = "ClienterBindingNavigator"
        Me.ClienterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienterBindingNavigator.Size = New System.Drawing.Size(387, 25)
        Me.ClienterBindingNavigator.TabIndex = 1
        Me.ClienterBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ClienterBindingNavigatorSaveItem
        '
        Me.ClienterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienterBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienterBindingNavigatorSaveItem.Name = "ClienterBindingNavigatorSaveItem"
        Me.ClienterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienterBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(89, 230)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(142, 227)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(89, 256)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(142, 256)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 5
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(101, 288)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 6
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(142, 288)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 7
        '
        'Tipo_pagoLabel
        '
        Tipo_pagoLabel.AutoSize = True
        Tipo_pagoLabel.Location = New System.Drawing.Point(91, 332)
        Tipo_pagoLabel.Name = "Tipo_pagoLabel"
        Tipo_pagoLabel.Size = New System.Drawing.Size(31, 13)
        Tipo_pagoLabel.TabIndex = 8
        Tipo_pagoLabel.Text = "pago"
        AddHandler Tipo_pagoLabel.Click, AddressOf Me.Tipo_pagoLabel_Click
        '
        'Tipo_pagoTextBox
        '
        Me.Tipo_pagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Tipo_pago", True))
        Me.Tipo_pagoTextBox.Location = New System.Drawing.Point(142, 332)
        Me.Tipo_pagoTextBox.Name = "Tipo_pagoTextBox"
        Me.Tipo_pagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_pagoTextBox.TabIndex = 9
        '
        'NITLabel
        '
        NITLabel.AutoSize = True
        NITLabel.Location = New System.Drawing.Point(94, 369)
        NITLabel.Name = "NITLabel"
        NITLabel.Size = New System.Drawing.Size(28, 13)
        NITLabel.TabIndex = 10
        NITLabel.Text = "NIT:"
        '
        'NITTextBox
        '
        Me.NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "NIT", True))
        Me.NITTextBox.Location = New System.Drawing.Point(142, 369)
        Me.NITTextBox.Name = "NITTextBox"
        Me.NITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NITTextBox.TabIndex = 11
        '
        'Cantidad_ProLabel
        '
        Cantidad_ProLabel.AutoSize = True
        Cantidad_ProLabel.Location = New System.Drawing.Point(110, 412)
        Cantidad_ProLabel.Name = "Cantidad_ProLabel"
        Cantidad_ProLabel.Size = New System.Drawing.Size(0, 13)
        Cantidad_ProLabel.TabIndex = 12
        '
        'Cantidad_ProTextBox
        '
        Me.Cantidad_ProTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Cantidad_Pro", True))
        Me.Cantidad_ProTextBox.Location = New System.Drawing.Point(142, 416)
        Me.Cantidad_ProTextBox.Name = "Cantidad_ProTextBox"
        Me.Cantidad_ProTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad_ProTextBox.TabIndex = 13
        '
        'Cantidad_ProLabel1
        '
        Cantidad_ProLabel1.AutoSize = True
        Cantidad_ProLabel1.Location = New System.Drawing.Point(84, 416)
        Cantidad_ProLabel1.Name = "Cantidad_ProLabel1"
        Cantidad_ProLabel1.Size = New System.Drawing.Size(52, 13)
        Cantidad_ProLabel1.TabIndex = 14
        Cantidad_ProLabel1.Text = "Cantidad "
        '
        'Valor_pagarLabel
        '
        Valor_pagarLabel.AutoSize = True
        Valor_pagarLabel.Location = New System.Drawing.Point(73, 458)
        Valor_pagarLabel.Name = "Valor_pagarLabel"
        Valor_pagarLabel.Size = New System.Drawing.Size(37, 13)
        Valor_pagarLabel.TabIndex = 15
        Valor_pagarLabel.Text = "Valor :"
        '
        'Valor_pagarTextBox
        '
        Me.Valor_pagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Valor_pagar", True))
        Me.Valor_pagarTextBox.Location = New System.Drawing.Point(142, 458)
        Me.Valor_pagarTextBox.Name = "Valor_pagarTextBox"
        Me.Valor_pagarTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Valor_pagarTextBox.TabIndex = 16
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(88, 498)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienterBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(128, 495)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(269, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "retornar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Valor_pagarLabel)
        Me.Controls.Add(Me.Valor_pagarTextBox)
        Me.Controls.Add(Cantidad_ProLabel1)
        Me.Controls.Add(Cantidad_ProLabel)
        Me.Controls.Add(Me.Cantidad_ProTextBox)
        Me.Controls.Add(NITLabel)
        Me.Controls.Add(Me.NITTextBox)
        Me.Controls.Add(Tipo_pagoLabel)
        Me.Controls.Add(Me.Tipo_pagoTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ClienterBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienterBindingNavigator.ResumeLayout(False)
        Me.ClienterBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Base_DatosDataSet As Base_DatosDataSet
    Friend WithEvents ClienterBindingSource As BindingSource
    Friend WithEvents ClienterTableAdapter As Base_DatosDataSetTableAdapters.ClienterTableAdapter
    Friend WithEvents TableAdapterManager As Base_DatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienterBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClienterBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Tipo_pagoTextBox As TextBox
    Friend WithEvents NITTextBox As TextBox
    Friend WithEvents Cantidad_ProTextBox As TextBox
    Friend WithEvents Valor_pagarTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
