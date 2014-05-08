/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 04:05 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lsv = new System.Windows.Forms.ListView();
			this.id = new System.Windows.Forms.ColumnHeader();
			this.num = new System.Windows.Forms.ColumnHeader();
			this.batch_num = new System.Windows.Forms.ColumnHeader();
			this.me_name = new System.Windows.Forms.ColumnHeader();
			this.me_type = new System.Windows.Forms.ColumnHeader();
			this.me_expire = new System.Windows.Forms.ColumnHeader();
			this.amount = new System.Windows.Forms.ColumnHeader();
			this.note = new System.Windows.Forms.ColumnHeader();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripRemove = new System.Windows.Forms.ToolStripButton();
			this.toolStripFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
			this.prnDoc = new System.Drawing.Printing.PrintDocument();
			this.prnPreDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.orderBy = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.byPrint = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bySort = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusRecod = new System.Windows.Forms.ToolStripStatusLabel();
			this.record = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripExpired = new System.Windows.Forms.ToolStripStatusLabel();
			this.stpExpired = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripNear = new System.Windows.Forms.ToolStripStatusLabel();
			this.stpNear = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.otherInfo = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menu.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lsv
			// 
			resources.ApplyResources(this.lsv, "lsv");
			this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.id,
									this.num,
									this.batch_num,
									this.me_name,
									this.me_type,
									this.me_expire,
									this.amount,
									this.note});
			this.lsv.FullRowSelect = true;
			this.lsv.GridLines = true;
			this.lsv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lsv.HideSelection = false;
			this.lsv.Name = "lsv";
			this.lsv.ShowGroups = false;
			this.lsv.ShowItemToolTips = true;
			this.lsv.TabStop = false;
			this.lsv.UseCompatibleStateImageBehavior = false;
			this.lsv.View = System.Windows.Forms.View.Details;
			this.lsv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvItemSelectionChanged);
			this.lsv.DoubleClick += new System.EventHandler(this.LsvDoubleClick);
			this.lsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.lsv.Resize += new System.EventHandler(this.LsvResize);
			// 
			// id
			// 
			resources.ApplyResources(this.id, "id");
			// 
			// num
			// 
			resources.ApplyResources(this.num, "num");
			// 
			// batch_num
			// 
			resources.ApplyResources(this.batch_num, "batch_num");
			// 
			// me_name
			// 
			resources.ApplyResources(this.me_name, "me_name");
			// 
			// me_type
			// 
			resources.ApplyResources(this.me_type, "me_type");
			// 
			// me_expire
			// 
			resources.ApplyResources(this.me_expire, "me_expire");
			// 
			// amount
			// 
			resources.ApplyResources(this.amount, "amount");
			// 
			// note
			// 
			resources.ApplyResources(this.note, "note");
			// 
			// menu
			// 
			this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			resources.ApplyResources(this.menu, "menu");
			this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menu.GripMargin = new System.Windows.Forms.Padding(0);
			this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.menu.Name = "menu";
			this.menu.ShowItemToolTips = true;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripMenuItem2,
									this.openToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.exportToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
			resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.Silver;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenDataFromFile);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToFile);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.findToolStripMenuItem,
									this.optinToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			resources.ApplyResources(this.findToolStripMenuItem, "findToolStripMenuItem");
			this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItemClick);
			// 
			// optinToolStripMenuItem
			// 
			this.optinToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.optinToolStripMenuItem.Name = "optinToolStripMenuItem";
			resources.ApplyResources(this.optinToolStripMenuItem, "optinToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem,
									this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// toolStrip1
			// 
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripNew,
									this.toolStripEdit,
									this.toolStripRemove,
									this.toolStripFind,
									this.toolStripRefresh,
									this.toolStripPrint});
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			// 
			// toolStripNew
			// 
			this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripNew, "toolStripNew");
			this.toolStripNew.Name = "toolStripNew";
			this.toolStripNew.Click += new System.EventHandler(this.ToolStripNewClick);
			// 
			// toolStripEdit
			// 
			this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripEdit, "toolStripEdit");
			this.toolStripEdit.Name = "toolStripEdit";
			this.toolStripEdit.Click += new System.EventHandler(this.LsvDoubleClick);
			// 
			// toolStripRemove
			// 
			this.toolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripRemove, "toolStripRemove");
			this.toolStripRemove.Name = "toolStripRemove";
			this.toolStripRemove.Click += new System.EventHandler(this.ToolStripRemoveClick);
			// 
			// toolStripFind
			// 
			this.toolStripFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripFind, "toolStripFind");
			this.toolStripFind.Name = "toolStripFind";
			this.toolStripFind.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// toolStripRefresh
			// 
			this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripRefresh, "toolStripRefresh");
			this.toolStripRefresh.Name = "toolStripRefresh";
			this.toolStripRefresh.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripPrint
			// 
			this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripPrint, "toolStripPrint");
			this.toolStripPrint.Name = "toolStripPrint";
			this.toolStripPrint.Click += new System.EventHandler(this.BfClick);
			// 
			// prnDoc
			// 
			this.prnDoc.DocumentName = "";
			this.prnDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// prnPreDialog
			// 
			resources.ApplyResources(this.prnPreDialog, "prnPreDialog");
			this.prnPreDialog.Document = this.prnDoc;
			this.prnPreDialog.Name = "printPreviewDialog2";
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.orderBy);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.byPrint);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.bySort);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// orderBy
			// 
			this.orderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.orderBy.FormattingEnabled = true;
			this.orderBy.Items.AddRange(new object[] {
									resources.GetString("orderBy.Items"),
									resources.GetString("orderBy.Items1")});
			resources.ApplyResources(this.orderBy, "orderBy");
			this.orderBy.Name = "orderBy";
			this.orderBy.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.orderBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// byPrint
			// 
			this.byPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.byPrint.FormattingEnabled = true;
			this.byPrint.Items.AddRange(new object[] {
									resources.GetString("byPrint.Items"),
									resources.GetString("byPrint.Items1")});
			resources.ApplyResources(this.byPrint, "byPrint");
			this.byPrint.Name = "byPrint";
			this.byPrint.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			this.byPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// bySort
			// 
			this.bySort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bySort.FormattingEnabled = true;
			this.bySort.Items.AddRange(new object[] {
									resources.GetString("bySort.Items"),
									resources.GetString("bySort.Items1"),
									resources.GetString("bySort.Items2"),
									resources.GetString("bySort.Items3"),
									resources.GetString("bySort.Items4")});
			resources.ApplyResources(this.bySort, "bySort");
			this.bySort.Name = "bySort";
			this.bySort.SelectedIndexChanged += new System.EventHandler(this.BySortSelectedIndexChanged);
			this.bySort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusRecod,
									this.record,
									this.toolStripStatusLabel1,
									this.toolStripExpired,
									this.stpExpired,
									this.toolStripNear,
									this.stpNear});
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.Name = "statusStrip1";
			// 
			// toolStripStatusRecod
			// 
			this.toolStripStatusRecod.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusRecod.Name = "toolStripStatusRecod";
			resources.ApplyResources(this.toolStripStatusRecod, "toolStripStatusRecod");
			// 
			// record
			// 
			resources.ApplyResources(this.record, "record");
			this.record.BackColor = System.Drawing.SystemColors.Control;
			this.record.Name = "record";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
			// 
			// toolStripExpired
			// 
			this.toolStripExpired.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripExpired.Name = "toolStripExpired";
			resources.ApplyResources(this.toolStripExpired, "toolStripExpired");
			// 
			// stpExpired
			// 
			resources.ApplyResources(this.stpExpired, "stpExpired");
			this.stpExpired.BackColor = System.Drawing.SystemColors.Control;
			this.stpExpired.Name = "stpExpired";
			// 
			// toolStripNear
			// 
			this.toolStripNear.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripNear.Name = "toolStripNear";
			resources.ApplyResources(this.toolStripNear, "toolStripNear");
			// 
			// stpNear
			// 
			resources.ApplyResources(this.stpNear, "stpNear");
			this.stpNear.BackColor = System.Drawing.SystemColors.Control;
			this.stpNear.Name = "stpNear";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// otherInfo
			// 
			resources.ApplyResources(this.otherInfo, "otherInfo");
			this.otherInfo.BackColor = System.Drawing.SystemColors.Control;
			this.otherInfo.Name = "otherInfo";
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Item Information";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.Controls.Add(this.otherInfo);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.lsv);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label otherInfo;
		private System.Windows.Forms.ListView lsv;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel stpNear;
		private System.Windows.Forms.ToolStripStatusLabel toolStripNear;
		private System.Windows.Forms.ToolStripStatusLabel stpExpired;
		private System.Windows.Forms.ToolStripStatusLabel toolStripExpired;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel record;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRecod;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox orderBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox byPrint;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox bySort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PrintPreviewDialog prnPreDialog;
		private System.Windows.Forms.ToolStripButton toolStripPrint;
		internal System.Drawing.Printing.PrintDocument prnDoc;
		//private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripRefresh;
		private System.Windows.Forms.ToolStripButton toolStripFind;
		private System.Windows.Forms.ToolStripButton toolStripRemove;
		private System.Windows.Forms.ToolStripButton toolStripEdit;
		private System.Windows.Forms.ToolStripButton toolStripNew;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem optinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		
		private System.Windows.Forms.ListViewItem  t ;
		private System.Windows.Forms.ColumnHeader amount;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ColumnHeader batch_num;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader note;
		private System.Windows.Forms.ColumnHeader me_expire;
		private System.Windows.Forms.ColumnHeader me_type;
		private System.Windows.Forms.ColumnHeader me_name;
		private System.Windows.Forms.ColumnHeader num;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menu;
		
		
		
		
		
		
		
		
	
		
		
		
		

		
		void OtherInfoClick(object sender, System.EventArgs e)
		{
			
			DisableSelect();
		}
		
		
	}
	
}