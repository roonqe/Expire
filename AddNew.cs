/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 09:52 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Expire
{
	/// <summary>
	/// Description of AddNew.
	/// </summary>
	public partial class AddNew : Form
	{
		MainForm forms;
		int intYear;
		string months;
		Fallter f= new Fallter();
		
		public delegate void progDelegate(int i);
		
		public AddNew(MainForm form)
		{
			forms=form;
			
			
			
			
			
		
			InitializeComponent();
			CenterToScreen();
			
			setYear();
			comboYear.Items.AddRange(new object[]{
			                          
			                            intYear,
			                            intYear+1,
			                            intYear+2,
			                            intYear+3,
			                            intYear+4,
			                            intYear+5,
			                            intYear+6,
			                            intYear+7,
			                            intYear+8,
			                         });
			
			comboYear.Text =intYear.ToString();
			comboMonth.Text=months;
			
		
		}
	
		void Save(){
		
			
				
			
			if( /*batchNum.Text.Equals("") ||medAmount.Text =="" ||*/ comboType.Text.Equals("")||comboYear.Text.Equals("")||comboMonth.Text.Equals("")|| medName.Text.Equals("")  )
			{}
			else if(comboType.Text=="others" && textboxOther.Text=="")
			{
				textboxOther.Select();
			}
			else{
			
				Thread prgThead = new Thread(StarProg);
				prgThead.Start();
			Database a= new Database();
			int amount = f.AddInt(medAmount.Text);
			string typeSelect=null;
			if(comboType.Text=="others"){
			typeSelect= textboxOther.Text;
			}else{
			
				typeSelect=comboType.Text;
			}
			string dateType=null;
			
			if(dayNumber.Text=="0" || dayNumber.Enabled==false){
			
				dateType =comboYear.Text+@"/"+comboMonth.Text+@"/"+f.getLastDayOfMonth(comboMonth.Text);
			
			}
			else{
				
		
				string addZero=dayNumber.Text;
				if(dayNumber.Value<10){
					addZero="0"+dayNumber.Text;
				}
				else{}
				 dateType =comboYear.Text+@"/"+comboMonth.Text+@"/"+addZero ;
			}
			a.Ccon();
			a.Add(batchNum.Text,medName.Text,typeSelect,f.CheckDateBeforeAdd(dateType),amount ,note.Text);
		
			forms.getAll(0);
			forms.DisableSelect();
			this.Activate();
			
			
		
		}
		}
		
		void StarProg(){
		 
			toolStripStatusLabel1.Text="  wait";
			for(int i=1;i<=100;i++){
			
				statusStrip1.Invoke(new progDelegate(prog),i);
				Thread.Sleep(1);
			}
			
			Thread.Sleep(10);
		toolStripStatusLabel1.Text=" Done";
	
			statusStrip1.Invoke(new progDelegate(prog),0);
		
		
		}
		void prog(int i){
		
			progressBar1.Value=i;
		
		}
	
		void setYear(){
		
		System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
		string years = System.DateTime.Now.ToString("yyyy",gro);
		 months =DateTime.Now.ToString("MM",gro);
		
		intYear =Convert.ToInt32(years);
		
		}
		
		void Button1Click(object sender, EventArgs e)
		
		{
			
			Save();
		
			}
		
			
			
		
		
		void AddNewSaveKeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Escape){
				this.Close();
			}
			if(e.KeyCode ==Keys.Enter){
			
				Save();
			}
		}
			
	
		
	
		
		void MedAmountKeyPress(object sender, KeyPressEventArgs e)
			
		{
			
			
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) 
			{ 
			e.Handled = false; 
			} 
			else 
			{ 
			e.Handled = true; 
			} 
			
		}
		
	
		
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
		}
		
		
		
		void NewbtnClick(object sender, EventArgs e)
		{
			// blank textbox for new adding
			medAmount.Text="";
			medName.Text="";
			comboType.Text="" ;
			batchNum.Text="";
			note.Text="";
			medName.Select();
		}
		
		void ComboTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			
			if(comboType.Text=="others"){
				
				textboxOther.Visible=true;
				textboxOther.Select();
			}
			else{
				
				textboxOther.Visible=false;
			
			}
		}
		
		void AddNewLoad(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
			
			if(checkBox1.Checked){
			
					dayNumber.Enabled=true;
			}else{
			
					dayNumber.Enabled=false;
			}
		
		}
	}
}
