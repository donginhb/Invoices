﻿Imports System.ComponentModel
Imports System.Text
Imports CemDB

Partial Public Class MainForm
	Inherits DevExpress.XtraEditors.XtraForm

	Private WithEvents dbCompanies As DBDataSet
	Private WithEvents dbInvoices As DBDataSet
	Private WithEvents dbAddresses As DBDataSet
	Private WithEvents dbInvoiceDetails As DBDataSet

	Private WithEvents dsInvoices As DataSet
	Private WithEvents dsCompanies As DataSet
	Private WithEvents dsAddresses As DataSet
	Private WithEvents dsInvoiceDetails As DataSet

	Private tableCompanies As DataTable
	Private tableInvoices As DataTable
	Private tableAddresses As DataTable
	Private tableInvoiceDetails As DataTable

	Dim dbvCompanies As DBView
	Dim dbvInvoices As DBView
	Dim dbvAddresses As DBView
	Dim dbvDetails As DBView
	Dim rpt As DevExpress.XtraReports.IReport


	Shared Sub New()
		DevExpress.UserSkins.BonusSkins.Register()
		DevExpress.Skins.SkinManager.EnableFormSkins()
	End Sub


	Public Sub New()
		InitializeComponent()

		'Setup CemDB to use the .udl from the exe's directory
		DBControl.ConnectionFile(Application.StartupPath + "\\newer_invoice.udl")
		'' Single view example:
		''Initialization
		'dbCompanies = New DBDataSet()
		'tableCompanies = New DataTable()

		''Set Procedures
		'dbCompanies.InsertStoredProcedure = "add_company"
		'dbCompanies.FetchStoredProcedure = "fetch_companies"
		'dbCompanies.UpdateStoredProcedure = "update_company"

		'' connect table to grid control
		'GridControl1.DataSource = tableCompanies

		'dbvCompanies = New DBView(CompanyGridView, dbCompanies)
		'dbCompanies.FetchDataTable(tableCompanies)


		'' Nested Views
		' ''''''''''''''''''
		' Initialization
		dsInvoices = New DataSet()
		dbInvoices = New DBDataSet()

		dsCompanies = New DataSet()
		dbCompanies = New DBDataSet()

		dsAddresses = New DataSet()
		dbAddresses = New DBDataSet()

		dsInvoiceDetails = New DataSet()
		dbInvoiceDetails = New DBDataSet()

		'Set tables
		tableInvoices = New DataTable()
		tableCompanies = New DataTable()
		tableAddresses = New DataTable()
		tableInvoiceDetails = New DataTable()

		''Set Procedures
		dbCompanies.FetchStoredProcedure = "fetch_companies"
		dbCompanies.InsertStoredProcedure = "add_company"
		dbCompanies.UpdateStoredProcedure = "update_company"
		dbCompanies.DeleteStoredProcedure = "delete_company"

		dbAddresses.FetchStoredProcedure = "fetch_addresses"
		dbAddresses.InsertStoredProcedure = "add_address"
		dbAddresses.UpdateStoredProcedure = "update_address"
		dbAddresses.DeleteStoredProcedure = "delete_address"

		dbInvoices.FetchStoredProcedure = "fetch_invoices"
		dbInvoices.InsertStoredProcedure = "add_invoice"
		dbInvoices.UpdateStoredProcedure = "update_invoice"
		dbInvoices.DeleteStoredProcedure = "delete_invoice"

		dbInvoiceDetails.FetchStoredProcedure = "fetch_details"
		dbInvoiceDetails.InsertStoredProcedure = "add_detail"
		dbInvoiceDetails.UpdateStoredProcedure = "update_detail"
		dbInvoiceDetails.DeleteStoredProcedure = "delete_detail"

		' Set  to corresponding datasources
		dbCompanies.DataSet = dsCompanies
		dbInvoices.DataSet = dsInvoices
		dbAddresses.DataSet = dsAddresses
		dbInvoiceDetails.DataSet = dsInvoiceDetails

		' Set views
		dbvCompanies = New DBView(CompanyGridView, dbCompanies)
		dbvInvoices = New DBView(InvoiceGridView, dbInvoices)
		dbvAddresses = New DBView(AddressGridView, dbAddresses)
		dbvDetails = New DBView(DetailGridView, dbInvoiceDetails)

		' Fetch data
		' The parent must fetch the data set**
		' the child must fetch corresponding data table** 
		dbCompanies.FetchDataSet()
	End Sub


	' Delete selected company 
	Private Sub DeleteCompanyButton_Click(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles delete_company.ButtonClick, button_delete.ButtonClick
		Dim result = MessageBox.Show("Are you sure?", "Delete Company", MessageBoxButtons.YesNo)

		If (result = MsgBoxResult.Yes) Then
			Dim cmd As System.Data.SqlClient.SqlCommand = DBControl.GetStoredProcCmd("delete_company")
			cmd.Parameters("@company_id").Value = CompanyGridView.GetFocusedRowCellValue("company_id") ' field value
			DBControl.ExecuteCommand(cmd)
			dbCompanies.FetchDataSet()

		ElseIf (result = MsgBoxResult.No) Then

		End If
	End Sub


	' Delete selected invoice 
	Private Sub DeleteInvoiceButton_Click(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles delete_invoice_button.ButtonClick
		Dim result = MessageBox.Show("Are you sure?", "Delete Invoice", MessageBoxButtons.YesNo)

		If (result = MsgBoxResult.Yes) Then
			Dim cmd As System.Data.SqlClient.SqlCommand = DBControl.GetStoredProcCmd("delete_invoice")
			cmd.Parameters("@invoice_id").Value = InvoiceGridView.GetFocusedRowCellValue("invoice_id")
			DBControl.ExecuteCommand(cmd)
			dbCompanies.FetchDataSet()

		ElseIf (result = MsgBoxResult.No) Then

		End If
	End Sub


	' Delete selected address 
	Private Sub DeleteAddressButton_Click(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles delete_address_button.ButtonClick
		Dim result = MessageBox.Show("Are you sure?", "Delete Address", MessageBoxButtons.YesNo)

		If (result = MsgBoxResult.Yes) Then
			Dim cmd As System.Data.SqlClient.SqlCommand = DBControl.GetStoredProcCmd("delete_address")
			System.Diagnostics.Debug.WriteLine(String.Format("ROW VLAUE: {0}", AddressGridView.GetFocusedRowCellValue("address_id")))
			cmd.Parameters("@address_id").Value = AddressGridView.GetFocusedRowCellValue("address_id") ' field value
			DBControl.ExecuteCommand(cmd)
			dbCompanies.FetchDataSet()
		ElseIf (result = MsgBoxResult.No) Then
		End If
	End Sub


	' Add a new company to database using add company dialog
	Private Sub AddCompanyMenuItem_Click(sender As Object, e As EventArgs) Handles AddCompanyMenuItem.Click
		Dim addCompanyForm = New addCompanyForm
		Dim result As DialogResult = addCompanyForm.ShowDialog()
		If result = Windows.Forms.DialogResult.OK Then
			dbCompanies.FetchDataSet() '** not table.
		End If
	End Sub


	' After fetching, ensure the up-to-date datatables are relations are added and declared (master-detail relationship)
	Private Sub dbCompanies_AfterFetch(sender As Object, cmd As SqlClient.SqlCommand, cancel As Cancel) Handles dbCompanies.AfterFetch
		dbInvoices.FetchDataTable(tableInvoices)
		dbAddresses.FetchDataTable(tableAddresses)
		dbInvoiceDetails.FetchDataTable(tableInvoiceDetails)

		dsCompanies.Tables.Add(tableInvoices)
		dsCompanies.Tables.Add(tableAddresses)
		dsCompanies.Tables.Add(tableInvoiceDetails)

		If dsCompanies.Tables.Count > 2 Then
			dsCompanies.Relations.Add("Company Invoices",
					dsCompanies.Tables(0).Columns("company_id"),
					dsCompanies.Tables(1).Columns("company_id"), False)
			GridControl1.LevelTree.Nodes.Add("Company Invoices", InvoiceGridView)

			dsCompanies.Relations.Add("Company Addresses",
					dsCompanies.Tables(0).Columns("company_id"),
					dsCompanies.Tables(2).Columns("company_id"), False)
			GridControl1.LevelTree.Nodes.Add("Company Addresses", AddressGridView)

			dsCompanies.Relations.Add("Invoice Details",
					dsCompanies.Tables(1).Columns("invoice_id"),
					dsCompanies.Tables(3).Columns("invoice_id"), False)
			GridControl1.LevelTree.Nodes.Add("Invoice Details", DetailGridView)
			GridControl1.DataSource = dsCompanies.Tables(0)
		End If
	End Sub


	Private Sub dbCompanies_AfterInsert(sender As Object, cmd As SqlClient.SqlCommand, row As DataRow, cancel As Cancel) Handles dbCompanies.AfterInsert
		dbCompanies.FetchDataSet()
	End Sub


	' Before fetching datatables, ensure previous relations and tables are cleared
	Private Sub dbCompanies_BeforeFetch(sender As Object, cmd As SqlClient.SqlCommand, cancel As Cancel) Handles dbCompanies.BeforeFetch
		If dsCompanies.Relations.Count > 0 Then
			dsCompanies.Relations.Remove("Company Invoices")
			dsCompanies.Relations.Remove("Company Addresses")
			dsCompanies.Relations.Remove("Invoice Details")
		End If
		dsCompanies.Tables.Clear()
	End Sub


	Private Sub dbInvoices_AfterInsert(sender As Object, cmd As SqlClient.SqlCommand, row As DataRow, cancel As Cancel) Handles dbInvoices.AfterInsert
		dbCompanies.FetchDataSet()
	End Sub


	Private Sub dbInvoices_BeforeUpdate(sender As Object, cmd As SqlClient.SqlCommand, row As DataRow, cancel As Cancel) Handles dbInvoices.BeforeUpdate
		' Not sure why it's not printing the column value but the updating works...
		System.Console.WriteLine("COLUMN VALUE: {0}", InvoiceGridView.GetFocusedRowCellValue("invoice_id"))
	End Sub


	Private Sub dbAddresses_AfterInsert(sender As Object, cmd As SqlClient.SqlCommand, row As DataRow, cancel As Cancel) Handles dbAddresses.AfterInsert
		dbCompanies.FetchDataSet()
	End Sub


	Private Sub dbInvoiceDetails_AfterInsert(sender As Object, cmd As SqlClient.SqlCommand, row As DataRow, cancel As Cancel) Handles dbInvoiceDetails.AfterInsert
		dbCompanies.FetchDataSet()
	End Sub


	Private Sub TotalCompanyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalCompanyReportToolStripMenuItem.Click
		rpt = New MainReport()
		Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
		Tool.ShowPreview()
	End Sub


	Private Sub SelectedCompanyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedCompanyReportToolStripMenuItem.Click
		' Convert row cell value from object to integer
		Dim companyID As Integer = CType(CompanyGridView.GetFocusedRowCellValue("company_id"), Integer)
		rpt = New CompanyReport(companyID)
		Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(rpt)

		' If disposed, exit (because no data available)
		If rpt.IsDisposed Then
			Exit Sub
			Return
		End If
		Try
			Tool.ShowPreview()
		Catch ex As Exception
			System.Console.WriteLine("Tool is messed up.")
		End Try

	End Sub

	' Display summary chart of all invoices from each company.

	Private Sub SummaryChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryChartToolStripMenuItem.Click
		Dim chart As SummaryAnalysisChart = New SummaryAnalysisChart()
		chart.Show()
	End Sub
End Class