<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipocuenta
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
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.dgvCNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCuentas
        '
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCNum, Me.dgvCNombre, Me.dgvCDescripcion})
        Me.dgvCuentas.Location = New System.Drawing.Point(12, 22)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.Size = New System.Drawing.Size(644, 195)
        Me.dgvCuentas.TabIndex = 0
        '
        'dgvCNum
        '
        Me.dgvCNum.HeaderText = "Numero de cuenta"
        Me.dgvCNum.Name = "dgvCNum"
        '
        'dgvCNombre
        '
        Me.dgvCNombre.HeaderText = "Tipo de cuenta"
        Me.dgvCNombre.Name = "dgvCNombre"
        Me.dgvCNombre.Width = 300
        '
        'dgvCDescripcion
        '
        Me.dgvCDescripcion.HeaderText = "Descripción"
        Me.dgvCDescripcion.Name = "dgvCDescripcion"
        Me.dgvCDescripcion.Width = 200
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(243, 272)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(222, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmTipocuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 363)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Name = "frmTipocuenta"
        Me.Text = "TIPOS DE CUENTAS"
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents dgvCNum As DataGridViewTextBoxColumn
    Friend WithEvents dgvCNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvCDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
End Class
