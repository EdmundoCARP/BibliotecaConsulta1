<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaLibros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvLibros = New DataGridView()
        ssEstado = New StatusStrip()
        lblRegistros = New ToolStripStatusLabel()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        txtCategoria = New TextBox()
        txtPrecio = New TextBox()
        txtBuscar = New TextBox()
        lblBuscar = New Label()
        txtaAnio = New TextBox()
        txtEjemplares = New TextBox()
        grpFiltros = New GroupBox()
        grpDetalle = New GroupBox()
        tlpDetalle = New TableLayoutPanel()
        cboCategoria = New ComboBox()
        lblCategoria = New Label()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        ssEstado.SuspendLayout()
        grpFiltros.SuspendLayout()
        grpDetalle.SuspendLayout()
        tlpDetalle.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Dock = DockStyle.Fill
        dgvLibros.Location = New Point(0, 0)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(800, 450)
        dgvLibros.TabIndex = 2
        ' 
        ' ssEstado
        ' 
        ssEstado.Items.AddRange(New ToolStripItem() {lblRegistros})
        ssEstado.Location = New Point(0, 428)
        ssEstado.Name = "ssEstado"
        ssEstado.Size = New Size(800, 22)
        ssEstado.SizingGrip = False
        ssEstado.TabIndex = 3
        ssEstado.Text = "lblRegistros"
        ' 
        ' lblRegistros
        ' 
        lblRegistros.Name = "lblRegistros"
        lblRegistros.Size = New Size(0, 17)
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BorderStyle = BorderStyle.FixedSingle
        txtTitulo.Location = New Point(386, 42)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.ReadOnly = True
        txtTitulo.Size = New Size(100, 23)
        txtTitulo.TabIndex = 4
        txtTitulo.TabStop = False
        ' 
        ' txtAutor
        ' 
        txtAutor.BorderStyle = BorderStyle.FixedSingle
        txtAutor.Location = New Point(3, 81)
        txtAutor.Name = "txtAutor"
        txtAutor.ReadOnly = True
        txtAutor.Size = New Size(100, 23)
        txtAutor.TabIndex = 5
        txtAutor.TabStop = False
        ' 
        ' txtCategoria
        ' 
        txtCategoria.BorderStyle = BorderStyle.FixedSingle
        txtCategoria.Location = New Point(3, 3)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.ReadOnly = True
        txtCategoria.Size = New Size(100, 23)
        txtCategoria.TabIndex = 6
        txtCategoria.TabStop = False
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Location = New Point(386, 81)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 7
        txtPrecio.TabStop = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(497, 22)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Escriba parte del titulo"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 8
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(397, 25)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(94, 15)
        lblBuscar.TabIndex = 9
        lblBuscar.Text = "Buscar por titulo"
        ' 
        ' txtaAnio
        ' 
        txtaAnio.BorderStyle = BorderStyle.FixedSingle
        txtaAnio.Location = New Point(386, 3)
        txtaAnio.Name = "txtaAnio"
        txtaAnio.ReadOnly = True
        txtaAnio.Size = New Size(100, 23)
        txtaAnio.TabIndex = 10
        txtaAnio.TabStop = False
        ' 
        ' txtEjemplares
        ' 
        txtEjemplares.BorderStyle = BorderStyle.FixedSingle
        txtEjemplares.Location = New Point(3, 42)
        txtEjemplares.Name = "txtEjemplares"
        txtEjemplares.ReadOnly = True
        txtEjemplares.Size = New Size(100, 23)
        txtEjemplares.TabIndex = 11
        txtEjemplares.TabStop = False
        ' 
        ' grpFiltros
        ' 
        grpFiltros.Controls.Add(lblCategoria)
        grpFiltros.Controls.Add(cboCategoria)
        grpFiltros.Controls.Add(txtBuscar)
        grpFiltros.Controls.Add(lblBuscar)
        grpFiltros.Dock = DockStyle.Top
        grpFiltros.Location = New Point(0, 0)
        grpFiltros.Name = "grpFiltros"
        grpFiltros.Size = New Size(800, 70)
        grpFiltros.TabIndex = 12
        grpFiltros.TabStop = False
        grpFiltros.Text = "Filros de consulta"
        ' 
        ' grpDetalle
        ' 
        grpDetalle.Controls.Add(tlpDetalle)
        grpDetalle.Dock = DockStyle.Bottom
        grpDetalle.Location = New Point(0, 288)
        grpDetalle.Name = "grpDetalle"
        grpDetalle.Size = New Size(800, 140)
        grpDetalle.TabIndex = 13
        grpDetalle.TabStop = False
        grpDetalle.Text = "Detalle del registro seleccionado"
        ' 
        ' tlpDetalle
        ' 
        tlpDetalle.ColumnCount = 3
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.5F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.5F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        tlpDetalle.Controls.Add(txtCategoria, 0, 0)
        tlpDetalle.Controls.Add(txtaAnio, 1, 0)
        tlpDetalle.Controls.Add(txtEjemplares, 0, 1)
        tlpDetalle.Controls.Add(txtTitulo, 1, 1)
        tlpDetalle.Controls.Add(txtAutor, 0, 2)
        tlpDetalle.Controls.Add(txtPrecio, 1, 2)
        tlpDetalle.Dock = DockStyle.Fill
        tlpDetalle.Location = New Point(3, 19)
        tlpDetalle.Name = "tlpDetalle"
        tlpDetalle.RowCount = 4
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpDetalle.Size = New Size(794, 118)
        tlpDetalle.TabIndex = 15
        ' 
        ' cboCategoria
        ' 
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(270, 22)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(121, 23)
        cboCategoria.TabIndex = 11
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(206, 25)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(58, 15)
        lblCategoria.TabIndex = 12
        lblCategoria.Text = "Categoria"
        ' 
        ' frmConsultaLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpDetalle)
        Controls.Add(grpFiltros)
        Controls.Add(ssEstado)
        Controls.Add(dgvLibros)
        Name = "frmConsultaLibros"
        Text = "Consulta de Libros"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ssEstado.ResumeLayout(False)
        ssEstado.PerformLayout()
        grpFiltros.ResumeLayout(False)
        grpFiltros.PerformLayout()
        grpDetalle.ResumeLayout(False)
        tlpDetalle.ResumeLayout(False)
        tlpDetalle.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents ssEstado As StatusStrip
    Friend WithEvents lblRegistros As ToolStripStatusLabel
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtaAnio As TextBox
    Friend WithEvents txtEjemplares As TextBox
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents grpDetalle As GroupBox
    Friend WithEvents tlpDetalle As TableLayoutPanel
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox

End Class
