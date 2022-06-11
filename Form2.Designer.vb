<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewCylinderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseByCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCylinderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaySupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodaysSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCylinderToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.SUPPLIERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewCylinderToolStripMenuItem
        '
        Me.NewCylinderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentByToolStripMenuItem, Me.PurchaseByCustomerToolStripMenuItem, Me.UpdateCPToolStripMenuItem, Me.NewCylinderToolStripMenuItem1, Me.PaySupplierToolStripMenuItem, Me.NewCustomerToolStripMenuItem, Me.TodaysSummaryToolStripMenuItem})
        Me.NewCylinderToolStripMenuItem.Name = "NewCylinderToolStripMenuItem"
        Me.NewCylinderToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.NewCylinderToolStripMenuItem.Text = " INPUT"
        '
        'PaymentByToolStripMenuItem
        '
        Me.PaymentByToolStripMenuItem.Name = "PaymentByToolStripMenuItem"
        Me.PaymentByToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.PaymentByToolStripMenuItem.Text = "Payment by  Customer"
        '
        'PurchaseByCustomerToolStripMenuItem
        '
        Me.PurchaseByCustomerToolStripMenuItem.Name = "PurchaseByCustomerToolStripMenuItem"
        Me.PurchaseByCustomerToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.PurchaseByCustomerToolStripMenuItem.Text = "Purchase by Customer"
        '
        'UpdateCPToolStripMenuItem
        '
        Me.UpdateCPToolStripMenuItem.Name = "UpdateCPToolStripMenuItem"
        Me.UpdateCPToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.UpdateCPToolStripMenuItem.Text = "Update Gas' Details"
        '
        'NewCylinderToolStripMenuItem1
        '
        Me.NewCylinderToolStripMenuItem1.Name = "NewCylinderToolStripMenuItem1"
        Me.NewCylinderToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.NewCylinderToolStripMenuItem1.Text = "New cylinder"
        '
        'PaySupplierToolStripMenuItem
        '
        Me.PaySupplierToolStripMenuItem.Name = "PaySupplierToolStripMenuItem"
        Me.PaySupplierToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.PaySupplierToolStripMenuItem.Text = "Pay to Supplier"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'TodaysSummaryToolStripMenuItem
        '
        Me.TodaysSummaryToolStripMenuItem.Name = "TodaysSummaryToolStripMenuItem"
        Me.TodaysSummaryToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.TodaysSummaryToolStripMenuItem.Text = "Today's Summary "
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'SUPPLIERToolStripMenuItem
        '
        Me.SUPPLIERToolStripMenuItem.Name = "SUPPLIERToolStripMenuItem"
        Me.SUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.SUPPLIERToolStripMenuItem.Text = "SUPPLIER"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1051)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "ZEN GASES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewCylinderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateCPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCylinderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaySupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseByCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodaysSummaryToolStripMenuItem As ToolStripMenuItem
End Class
