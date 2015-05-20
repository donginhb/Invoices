﻿Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
			If dbCompanies IsNot Nothing Then
				dbCompanies.Dispose()
				dbCompanies = Nothing
			End If
			If dbInvoices IsNot Nothing Then
				dbInvoices.Dispose()
				dbInvoices = Nothing
			End If
			If dbAddresses IsNot Nothing Then
				dbAddresses.Dispose()
				dbAddresses = Nothing
			End If
			If dbInvoiceDetails IsNot Nothing Then
				dbInvoiceDetails.Dispose()
				dbInvoiceDetails = Nothing
			End If
			If dsInvoices IsNot Nothing Then
				dsInvoices.Dispose()
				dsInvoices = Nothing
			End If
			If dsCompanies IsNot Nothing Then
				dsCompanies.Dispose()
				dsCompanies = Nothing
			End If
			If dsAddresses IsNot Nothing Then
				dsAddresses.Dispose()
				dsAddresses = Nothing
			End If
			If dsInvoiceDetails IsNot Nothing Then
				dsInvoiceDetails.Dispose()
				dsInvoiceDetails = Nothing
			End If
			If tableCompanies IsNot Nothing Then
				tableCompanies.Dispose()
				tableCompanies = Nothing
			End If
			If tableInvoices IsNot Nothing Then
				tableInvoices.Dispose()
				tableInvoices = Nothing
			End If
			If tableAddresses IsNot Nothing Then
				tableAddresses.Dispose()
				tableAddresses = Nothing
			End If
			If tableInvoiceDetails IsNot Nothing Then
				tableInvoiceDetails.Dispose()
				tableInvoiceDetails = Nothing
			End If
		End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
		Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.InvoiceGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.InvoiceIDColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.InvoiceDateColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.TermsColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
		Me.AddressGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.companyIDAddressGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.addressIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.addressesGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.phoneGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.dateModifyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.deleteAddressOptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.delete_address_button = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.CompanyGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.companyNameCol = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.companyIDCol = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.deleteCompanyBtnColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.button_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.delete_invoice_button = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
		Me.DetailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.invoiceDetailGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.detailIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.descriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.quantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.costGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.AddCompanyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SummaryChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TotalCompanyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SelectedCompanyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
		Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
		CType(Me.InvoiceGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AddressGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.delete_address_button, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CompanyGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.button_delete, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.delete_invoice_button, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DetailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'InvoiceGridView
		'
		Me.InvoiceGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.InvoiceIDColumn, Me.GridColumn3, Me.InvoiceDateColumn, Me.TermsColumn})
		Me.InvoiceGridView.GridControl = Me.GridControl1
		Me.InvoiceGridView.Name = "InvoiceGridView"
		Me.InvoiceGridView.OptionsDetail.AllowExpandEmptyDetails = True
		Me.InvoiceGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		'
		'InvoiceIDColumn
		'
		Me.InvoiceIDColumn.Caption = "Invoice ID"
		Me.InvoiceIDColumn.FieldName = "invoice_id"
		Me.InvoiceIDColumn.Name = "InvoiceIDColumn"
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Company ID"
		Me.GridColumn3.FieldName = "company_id"
		Me.GridColumn3.Name = "GridColumn3"
		'
		'InvoiceDateColumn
		'
		Me.InvoiceDateColumn.Caption = "Invoice Date"
		Me.InvoiceDateColumn.DisplayFormat.FormatString = "d"
		Me.InvoiceDateColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.InvoiceDateColumn.FieldName = "date"
		Me.InvoiceDateColumn.Name = "InvoiceDateColumn"
		Me.InvoiceDateColumn.Visible = True
		Me.InvoiceDateColumn.VisibleIndex = 0
		'
		'TermsColumn
		'
		Me.TermsColumn.Caption = "Terms"
		Me.TermsColumn.FieldName = "terms"
		Me.TermsColumn.Name = "TermsColumn"
		Me.TermsColumn.Visible = True
		Me.TermsColumn.VisibleIndex = 1
		'
		'GridControl1
		'
		Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
		Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
		GridLevelNode1.LevelTemplate = Me.InvoiceGridView
		GridLevelNode2.LevelTemplate = Me.DetailGridView
		GridLevelNode2.RelationName = "Invoice Details"
		GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
		GridLevelNode1.RelationName = "Company Invoices"
		GridLevelNode3.LevelTemplate = Me.AddressGridView
		GridLevelNode3.RelationName = "Company Addresses"
		Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode3})
		Me.GridControl1.Location = New System.Drawing.Point(0, 24)
		Me.GridControl1.MainView = Me.CompanyGridView
		Me.GridControl1.Name = "GridControl1"
		Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.button_delete, Me.delete_invoice_button, Me.delete_address_button})
		Me.GridControl1.Size = New System.Drawing.Size(632, 254)
		Me.GridControl1.TabIndex = 0
		Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AddressGridView, Me.CompanyGridView, Me.LayoutView1, Me.DetailGridView, Me.InvoiceGridView})
		'
		'AddressGridView
		'
		Me.AddressGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.companyIDAddressGridColumn, Me.addressIDGridColumn, Me.addressesGridColumn, Me.phoneGridColumn, Me.dateModifyGridColumn, Me.deleteAddressOptionGridColumn})
		Me.AddressGridView.GridControl = Me.GridControl1
		Me.AddressGridView.Name = "AddressGridView"
		Me.AddressGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		'
		'companyIDAddressGridColumn
		'
		Me.companyIDAddressGridColumn.Caption = "Company ID"
		Me.companyIDAddressGridColumn.FieldName = "company_id"
		Me.companyIDAddressGridColumn.Name = "companyIDAddressGridColumn"
		Me.companyIDAddressGridColumn.OptionsColumn.AllowShowHide = False
		Me.companyIDAddressGridColumn.OptionsColumn.ShowCaption = False
		Me.companyIDAddressGridColumn.OptionsColumn.ShowInCustomizationForm = False
		Me.companyIDAddressGridColumn.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
		'
		'addressIDGridColumn
		'
		Me.addressIDGridColumn.Caption = "Address ID"
		Me.addressIDGridColumn.FieldName = "address_id"
		Me.addressIDGridColumn.Name = "addressIDGridColumn"
		Me.addressIDGridColumn.OptionsColumn.ShowCaption = False
		Me.addressIDGridColumn.OptionsColumn.ShowInCustomizationForm = False
		Me.addressIDGridColumn.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
		'
		'addressesGridColumn
		'
		Me.addressesGridColumn.Caption = "Addresses"
		Me.addressesGridColumn.FieldName = "addresses"
		Me.addressesGridColumn.Name = "addressesGridColumn"
		Me.addressesGridColumn.Visible = True
		Me.addressesGridColumn.VisibleIndex = 0
		'
		'phoneGridColumn
		'
		Me.phoneGridColumn.Caption = "Phone"
		Me.phoneGridColumn.FieldName = "phone"
		Me.phoneGridColumn.Name = "phoneGridColumn"
		Me.phoneGridColumn.Visible = True
		Me.phoneGridColumn.VisibleIndex = 1
		'
		'dateModifyGridColumn
		'
		Me.dateModifyGridColumn.Caption = "Date Modify"
		Me.dateModifyGridColumn.DisplayFormat.FormatString = "d"
		Me.dateModifyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.dateModifyGridColumn.FieldName = "date_modify"
		Me.dateModifyGridColumn.Name = "dateModifyGridColumn"
		Me.dateModifyGridColumn.Visible = True
		Me.dateModifyGridColumn.VisibleIndex = 2
		'
		'deleteAddressOptionGridColumn
		'
		Me.deleteAddressOptionGridColumn.Caption = "GridColumn1"
		Me.deleteAddressOptionGridColumn.ColumnEdit = Me.delete_address_button
		Me.deleteAddressOptionGridColumn.Name = "deleteAddressOptionGridColumn"
		Me.deleteAddressOptionGridColumn.Visible = True
		Me.deleteAddressOptionGridColumn.VisibleIndex = 3
		'
		'delete_address_button
		'
		Me.delete_address_button.AutoHeight = False
		Me.delete_address_button.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("delete_address_button.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
		Me.delete_address_button.Name = "delete_address_button"
		Me.delete_address_button.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'CompanyGridView
		'
		Me.CompanyGridView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CompanyGridView.Appearance.GroupRow.Options.UseFont = True
		Me.CompanyGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.companyNameCol, Me.companyIDCol, Me.deleteCompanyBtnColumn})
		Me.CompanyGridView.GridControl = Me.GridControl1
		Me.CompanyGridView.Name = "CompanyGridView"
		Me.CompanyGridView.OptionsDetail.AllowExpandEmptyDetails = True
		'
		'companyNameCol
		'
		Me.companyNameCol.Caption = "Company Name"
		Me.companyNameCol.FieldName = "name"
		Me.companyNameCol.Name = "companyNameCol"
		Me.companyNameCol.Visible = True
		Me.companyNameCol.VisibleIndex = 0
		Me.companyNameCol.Width = 594
		'
		'companyIDCol
		'
		Me.companyIDCol.FieldName = "company_id"
		Me.companyIDCol.Name = "companyIDCol"
		'
		'deleteCompanyBtnColumn
		'
		Me.deleteCompanyBtnColumn.ColumnEdit = Me.button_delete
		Me.deleteCompanyBtnColumn.Name = "deleteCompanyBtnColumn"
		Me.deleteCompanyBtnColumn.Visible = True
		Me.deleteCompanyBtnColumn.VisibleIndex = 1
		Me.deleteCompanyBtnColumn.Width = 130
		'
		'button_delete
		'
		Me.button_delete.AutoHeight = False
		Me.button_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("button_delete.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
		Me.button_delete.Name = "button_delete"
		Me.button_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'delete_invoice_button
		'
		Me.delete_invoice_button.AutoHeight = False
		Me.delete_invoice_button.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("delete_invoice_button.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
		Me.delete_invoice_button.Name = "delete_invoice_button"
		Me.delete_invoice_button.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'LayoutView1
		'
		Me.LayoutView1.GridControl = Me.GridControl1
		Me.LayoutView1.Name = "LayoutView1"
		Me.LayoutView1.TemplateCard = Nothing
		'
		'DetailGridView
		'
		Me.DetailGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.invoiceDetailGridColumn, Me.detailIDGridColumn, Me.descriptionGridColumn, Me.quantityGridColumn, Me.costGridColumn})
		Me.DetailGridView.GridControl = Me.GridControl1
		Me.DetailGridView.Name = "DetailGridView"
		Me.DetailGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		'
		'invoiceDetailGridColumn
		'
		Me.invoiceDetailGridColumn.Caption = "invoice_id"
		Me.invoiceDetailGridColumn.FieldName = "invoice_id"
		Me.invoiceDetailGridColumn.Name = "invoiceDetailGridColumn"
		'
		'detailIDGridColumn
		'
		Me.detailIDGridColumn.Caption = "detail_id"
		Me.detailIDGridColumn.FieldName = "detail_id"
		Me.detailIDGridColumn.Name = "detailIDGridColumn"
		'
		'descriptionGridColumn
		'
		Me.descriptionGridColumn.Caption = "Description"
		Me.descriptionGridColumn.FieldName = "description"
		Me.descriptionGridColumn.Name = "descriptionGridColumn"
		Me.descriptionGridColumn.Visible = True
		Me.descriptionGridColumn.VisibleIndex = 0
		'
		'quantityGridColumn
		'
		Me.quantityGridColumn.Caption = "Quantity"
		Me.quantityGridColumn.FieldName = "quantity"
		Me.quantityGridColumn.Name = "quantityGridColumn"
		Me.quantityGridColumn.Visible = True
		Me.quantityGridColumn.VisibleIndex = 1
		'
		'costGridColumn
		'
		Me.costGridColumn.Caption = "Cost"
		Me.costGridColumn.FieldName = "cost"
		Me.costGridColumn.Name = "costGridColumn"
		Me.costGridColumn.Visible = True
		Me.costGridColumn.VisibleIndex = 2
		'
		'AddCompanyMenuItem
		'
		Me.AddCompanyMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.AddCompanyMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator, Me.toolStripSeparator1, Me.toolStripSeparator2})
		Me.AddCompanyMenuItem.Image = CType(resources.GetObject("AddCompanyMenuItem.Image"), System.Drawing.Image)
		Me.AddCompanyMenuItem.Name = "AddCompanyMenuItem"
		Me.AddCompanyMenuItem.Size = New System.Drawing.Size(28, 20)
		Me.AddCompanyMenuItem.Text = "&File"
		'
		'toolStripSeparator
		'
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(57, 6)
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(57, 6)
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(57, 6)
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(113, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
		Me.AboutToolStripMenuItem.Text = "&About..."
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCompanyMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryChartToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.ViewToolStripMenuItem.Text = "View"
		'
		'SummaryChartToolStripMenuItem
		'
		Me.SummaryChartToolStripMenuItem.Name = "SummaryChartToolStripMenuItem"
		Me.SummaryChartToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.SummaryChartToolStripMenuItem.Text = "Summary Chart"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem.Text = "Tools"
		'
		'PrintToolStripMenuItem
		'
		Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalCompanyReportToolStripMenuItem, Me.SelectedCompanyReportToolStripMenuItem})
		Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
		Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
		Me.PrintToolStripMenuItem.Text = "Print"
		'
		'TotalCompanyReportToolStripMenuItem
		'
		Me.TotalCompanyReportToolStripMenuItem.Name = "TotalCompanyReportToolStripMenuItem"
		Me.TotalCompanyReportToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
		Me.TotalCompanyReportToolStripMenuItem.Text = "Main Report"
		'
		'SelectedCompanyReportToolStripMenuItem
		'
		Me.SelectedCompanyReportToolStripMenuItem.Name = "SelectedCompanyReportToolStripMenuItem"
		Me.SelectedCompanyReportToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
		Me.SelectedCompanyReportToolStripMenuItem.Text = "Selected Company Report"
		'
		'LayoutViewCard1
		'
		Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
		Me.LayoutViewCard1.Name = "LayoutViewCard1"
		'
		'LayoutViewColumn1
		'
		Me.LayoutViewColumn1.LayoutViewField = Nothing
		Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
		'
		'Form1
		'
		Me.ClientSize = New System.Drawing.Size(632, 278)
		Me.Controls.Add(Me.GridControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.InvoiceGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AddressGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.delete_address_button, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CompanyGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.button_delete, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.delete_invoice_button, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DetailGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents InvoiceGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents InvoiceIDColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents InvoiceDateColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents TermsColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
	Friend WithEvents CompanyGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents companyNameCol As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents companyIDCol As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents AddCompanyMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents deleteCompanyBtnColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents delete_company As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents button_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents AddressGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents companyIDAddressGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents addressIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents addressesGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents phoneGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents dateModifyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents delete_invoice_button As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents deleteAddressOptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents delete_address_button As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
	Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
	Friend WithEvents DetailGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents invoiceDetailGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents detailIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents descriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents quantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents costGridColumn As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents TotalCompanyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SelectedCompanyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SummaryChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

#End Region

End Class
