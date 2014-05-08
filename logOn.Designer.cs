/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 15/11/33
 * Time: 01:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Expire
{
	partial class logOn
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
			this.user = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.loginBtn = new System.Windows.Forms.Button();
			this.pass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// user
			// 
			this.user.FormattingEnabled = true;
			this.user.Location = new System.Drawing.Point(99, 22);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(234, 21);
			this.user.TabIndex = 0;
			this.user.TextChanged += new System.EventHandler(this.UserTextChanged);
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(32, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(310, 1);
			this.label6.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Username";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(239, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// loginBtn
			// 
			this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.loginBtn.Enabled = false;
			this.loginBtn.Location = new System.Drawing.Point(122, 75);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(75, 23);
			this.loginBtn.TabIndex = 3;
			this.loginBtn.Text = "login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.Button1Click);
			// 
			// pass
			// 
			this.pass.Location = new System.Drawing.Point(99, 49);
			this.pass.Name = "pass";
			this.pass.Size = new System.Drawing.Size(234, 20);
			this.pass.TabIndex = 2;
			this.pass.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "password";
			// 
			// logOn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 108);
			this.Controls.Add(this.user);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(394, 146);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 146);
			this.Name = "logOn";
			this.Text = "logOn";
		
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox user;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.TextBox pass;
		
	
		
		void UserTextChanged(object sender, System.EventArgs e)
		{
			
			loginBtn.Enabled=true;
		}
	}
}
