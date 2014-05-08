
/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 09:52 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class AddNew
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.medName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.batchNum = new System.Windows.Forms.TextBox();
			this.addNewSave = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.medAmount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboMonth = new System.Windows.Forms.ComboBox();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.comboYear = new System.Windows.Forms.ComboBox();
			this.newbtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textboxOther = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dayNumber = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.note = new System.Windows.Forms.RichTextBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dayNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Medicine Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Medicine Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(273, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Year         Month      Day\r\n  ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Note";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// medName
			// 
			this.medName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.medName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medName.Location = new System.Drawing.Point(93, 81);
			this.medName.MaxLength = 20;
			this.medName.Name = "medName";
			this.medName.Size = new System.Drawing.Size(327, 23);
			this.medName.TabIndex = 1;
			this.medName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(41, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Batch #";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// batchNum
			// 
			this.batchNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.batchNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.batchNum.Location = new System.Drawing.Point(74, 241);
			this.batchNum.MaxLength = 10;
			this.batchNum.Name = "batchNum";
			this.batchNum.Size = new System.Drawing.Size(150, 22);
			this.batchNum.TabIndex = 5;
			this.batchNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// addNewSave
			// 
			this.addNewSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.addNewSave.FlatAppearance.BorderSize = 0;
			this.addNewSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewSave.Location = new System.Drawing.Point(129, 392);
			this.addNewSave.Name = "addNewSave";
			this.addNewSave.Size = new System.Drawing.Size(68, 28);
			this.addNewSave.TabIndex = 8;
			this.addNewSave.Text = "Add";
			this.addNewSave.UseVisualStyleBackColor = true;
			this.addNewSave.Click += new System.EventHandler(this.Button1Click);
			this.addNewSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// cancel
			// 
			this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancel.FlatAppearance.BorderSize = 0;
			this.cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel.Location = new System.Drawing.Point(333, 392);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(68, 28);
			this.cancel.TabIndex = 10;
			this.cancel.Text = "Close";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			this.cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// medAmount
			// 
			this.medAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.medAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medAmount.Location = new System.Drawing.Point(276, 241);
			this.medAmount.MaxLength = 10;
			this.medAmount.Name = "medAmount";
			this.medAmount.Size = new System.Drawing.Size(150, 22);
			this.medAmount.TabIndex = 6;
			this.medAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			this.medAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedAmountKeyPress);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(263, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Amount";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboMonth
			// 
			this.comboMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboMonth.BackColor = System.Drawing.Color.WhiteSmoke;
			this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboMonth.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboMonth.FormattingEnabled = true;
			this.comboMonth.Items.AddRange(new object[] {
									"01",
									"02",
									"03",
									"04",
									"05",
									"06",
									"07",
									"08",
									"09",
									"10",
									"11",
									"12"});
			this.comboMonth.Location = new System.Drawing.Point(351, 154);
			this.comboMonth.Name = "comboMonth";
			this.comboMonth.Size = new System.Drawing.Size(50, 26);
			this.comboMonth.TabIndex = 4;
			this.comboMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// comboType
			// 
			this.comboType.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboType.FormattingEnabled = true;
			this.comboType.Items.AddRange(new object[] {
									"inj",
									"tab & cap",
									"syrup & susp",
									"inhaler",
									"supp",
									"drops",
									"topical",
									"others"});
			this.comboType.Location = new System.Drawing.Point(73, 154);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(156, 26);
			this.comboType.TabIndex = 2;
			this.comboType.SelectedIndexChanged += new System.EventHandler(this.ComboTypeSelectedIndexChanged);
			this.comboType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// comboYear
			// 
			this.comboYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboYear.BackColor = System.Drawing.Color.WhiteSmoke;
			this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboYear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboYear.FormattingEnabled = true;
			this.comboYear.Location = new System.Drawing.Point(268, 154);
			this.comboYear.Name = "comboYear";
			this.comboYear.Size = new System.Drawing.Size(77, 26);
			this.comboYear.TabIndex = 4;
			this.comboYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// newbtn
			// 
			this.newbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.newbtn.FlatAppearance.BorderSize = 0;
			this.newbtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newbtn.Location = new System.Drawing.Point(55, 392);
			this.newbtn.Name = "newbtn";
			this.newbtn.Size = new System.Drawing.Size(68, 28);
			this.newbtn.TabIndex = 9;
			this.newbtn.Text = "New";
			this.newbtn.UseVisualStyleBackColor = true;
			this.newbtn.Click += new System.EventHandler(this.NewbtnClick);
			this.newbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(483, 38);
			this.label7.TabIndex = 13;
			this.label7.Text = "New";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textboxOther
			// 
			this.textboxOther.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textboxOther.Location = new System.Drawing.Point(73, 186);
			this.textboxOther.Name = "textboxOther";
			this.textboxOther.Size = new System.Drawing.Size(156, 20);
			this.textboxOther.TabIndex = 14;
			this.textboxOther.Visible = false;
			this.textboxOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.progressBar1,
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 444);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(484, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// progressBar1
			// 
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// dayNumber
			// 
			this.dayNumber.Enabled = false;
			this.dayNumber.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.dayNumber.Location = new System.Drawing.Point(407, 154);
			this.dayNumber.Maximum = new decimal(new int[] {
									31,
									0,
									0,
									0});
			this.dayNumber.Name = "dayNumber";
			this.dayNumber.ReadOnly = true;
			this.dayNumber.Size = new System.Drawing.Size(50, 26);
			this.dayNumber.TabIndex = 16;
			this.dayNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(458, 156);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(21, 24);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// note
			// 
			this.note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.note.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.note.Location = new System.Drawing.Point(65, 303);
			this.note.Name = "note";
			this.note.Size = new System.Drawing.Size(352, 82);
			this.note.TabIndex = 33;
			this.note.Text = "";
			// 
			// AddNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(484, 466);
			this.Controls.Add(this.note);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.dayNumber);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textboxOther);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboType);
			this.Controls.Add(this.comboYear);
			this.Controls.Add(this.comboMonth);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.medAmount);
			this.Controls.Add(this.batchNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.medName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.newbtn);
			this.Controls.Add(this.addNewSave);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 477);
			this.Name = "AddNew";
			this.Text = "Add New Medicine";
			this.Load += new System.EventHandler(this.AddNewLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewSaveKeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dayNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown dayNumber;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar progressBar1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox medAmount;
		private System.Windows.Forms.TextBox textboxOther;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button newbtn;
		private System.Windows.Forms.ComboBox comboYear;
		
		public string returnYear(){
				System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			string years = System.DateTime.Now.ToString("yyyy",gro);
			
			return years;
		}
		
			private System.Windows.Forms.ComboBox comboType;
			private System.Windows.Forms.ComboBox comboMonth;
			private System.Windows.Forms.Label label6;
			private System.Windows.Forms.TextBox batchNum;
			private System.Windows.Forms.Label label5;
			private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.RichTextBox note;
			private System.Windows.Forms.Label label4;
			private System.Windows.Forms.Label label3;
			private System.Windows.Forms.Label label2;
			private System.Windows.Forms.Label label1;
			private System.Windows.Forms.TextBox medName;
			private System.Windows.Forms.Button addNewSave;
	}
}
