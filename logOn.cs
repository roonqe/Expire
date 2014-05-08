/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 15/11/33
 * Time: 01:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Expire
{
	/// <summary>
	/// Description of logOn.
	/// </summary>
	public partial class logOn : Form
	{
		
		
		string username="admin";
		string password="123";
		
		public logOn()
		{
			
		
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			CenterToScreen();	
			
			
			
				
			
			
			
		}
		
		
		
		
		
//		void Button1Click(object sender, EventArgs e)
//		{
//			//
//			if(textBox1.Text==username && textBox2.Text==password)
//			{
//			this.Visible=false;
//			MainForm run = new MainForm();
//			run.Show();
//			}
//			else
//			{
//				MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحه");
//			}
//		}
		
		void Button1Click(object sender, EventArgs e)
		{
		if(user.Text==username && pass.Text==password)
			{
			
			this.DialogResult= DialogResult.OK;
			this.Close();
		
			}
			else
			{
				MessageBox.Show("Invalid username / password");
			}
		}
		
	
	}
}
