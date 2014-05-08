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
	partial class Update
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
			this.comboType = new System.Windows.Forms.ComboBox();
			this.comboMonth = new System.Windows.Forms.ComboBox();
			this.comboYear = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.medAmount = new System.Windows.Forms.TextBox();
			this.batchNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.medName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.updateSave = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textboxOther = new System.Windows.Forms.TextBox();
			this.dayNumber = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this._notes = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dayNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// comboType
			// 
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
			this.comboType.Location = new System.Drawing.Point(76, 159);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(156, 26);
			this.comboType.TabIndex = 16;
			this.comboType.SelectedIndexChanged += new System.EventHandler(this.ComboTypeSelectedIndexChanged);
			// 
			// comboMonth
			// 
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
			this.comboMonth.Location = new System.Drawing.Point(357, 159);
			this.comboMonth.Name = "comboMonth";
			this.comboMonth.Size = new System.Drawing.Size(50, 26);
			this.comboMonth.TabIndex = 19;
			// 
			// comboYear
			// 
			this.comboYear.BackColor = System.Drawing.Color.WhiteSmoke;
			this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboYear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboYear.FormattingEnabled = true;
			this.comboYear.Location = new System.Drawing.Point(274, 159);
			this.comboYear.Name = "comboYear";
			this.comboYear.Size = new System.Drawing.Size(77, 26);
			this.comboYear.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(300, 226);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "Amount";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// medAmount
			// 
			this.medAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medAmount.Location = new System.Drawing.Point(284, 252);
			this.medAmount.MaxLength = 10;
			this.medAmount.Name = "medAmount";
			this.medAmount.Size = new System.Drawing.Size(150, 22);
			this.medAmount.TabIndex = 22;
			this.medAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedAmountKeyPress);
			// 
			// batchNum
			// 
			this.batchNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.batchNum.Location = new System.Drawing.Point(76, 252);
			this.batchNum.MaxLength = 10;
			this.batchNum.Name = "batchNum";
			this.batchNum.Size = new System.Drawing.Size(150, 22);
			this.batchNum.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Batch #";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cancel
			// 
			this.cancel.FlatAppearance.BorderSize = 0;
			this.cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel.Location = new System.Drawing.Point(284, 401);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(68, 28);
			this.cancel.TabIndex = 25;
			this.cancel.Text = "Close";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// medName
			// 
			this.medName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medName.Location = new System.Drawing.Point(96, 93);
			this.medName.MaxLength = 20;
			this.medName.Name = "medName";
			this.medName.Size = new System.Drawing.Size(327, 23);
			this.medName.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(49, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Note";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Medicine Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Medicine Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// updateSave
			// 
			this.updateSave.FlatAppearance.BorderSize = 0;
			this.updateSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateSave.Location = new System.Drawing.Point(137, 401);
			this.updateSave.Name = "updateSave";
			this.updateSave.Size = new System.Drawing.Size(68, 28);
			this.updateSave.TabIndex = 24;
			this.updateSave.Text = "Edit";
			this.updateSave.UseVisualStyleBackColor = true;
			this.updateSave.Click += new System.EventHandler(this.UpdateSaveClick);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(2, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(482, 38);
			this.label7.TabIndex = 28;
			this.label7.Text = "Update";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textboxOther
			// 
			this.textboxOther.Location = new System.Drawing.Point(76, 191);
			this.textboxOther.Name = "textboxOther";
			this.textboxOther.Size = new System.Drawing.Size(156, 20);
			this.textboxOther.TabIndex = 29;
			this.textboxOther.Visible = false;
			// 
			// dayNumber
			// 
			this.dayNumber.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.dayNumber.Location = new System.Drawing.Point(413, 159);
			this.dayNumber.Maximum = new decimal(new int[] {
									31,
									0,
									0,
									0});
			this.dayNumber.Name = "dayNumber";
			this.dayNumber.ReadOnly = true;
			this.dayNumber.Size = new System.Drawing.Size(50, 26);
			this.dayNumber.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(274, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "Year         Month      Day\r\n  ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _notes
			// 
			this._notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._notes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._notes.Location = new System.Drawing.Point(66, 309);
			this._notes.Name = "_notes";
			this._notes.Size = new System.Drawing.Size(352, 86);
			this._notes.TabIndex = 32;
			this._notes.Text = "";
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(485, 442);
			this.Controls.Add(this._notes);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dayNumber);
			this.Controls.Add(this.textboxOther);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboType);
			this.Controls.Add(this.comboMonth);
			this.Controls.Add(this.comboYear);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.medAmount);
			this.Controls.Add(this.batchNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.medName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.updateSave);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(501, 480);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(501, 459);
			this.Name = "Update";
			this.Text = "Update";
			((System.ComponentModel.ISupportInitialize)(this.dayNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RichTextBox _notes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown dayNumber;
		private System.Windows.Forms.TextBox textboxOther;
		private System.Windows.Forms.Label label7;
		
		private System.Windows.Forms.Button updateSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox medName;
	//	private System.Windows.Forms.TextBox _notes;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox batchNum;
		private System.Windows.Forms.TextBox medAmount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboYear;
		private System.Windows.Forms.ComboBox comboMonth;
		private System.Windows.Forms.ComboBox comboType;
		
		
	}
}
