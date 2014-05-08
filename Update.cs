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
using System.Text.RegularExpressions;



namespace Expire
{
	/// <summary>
	/// Description of Update.
	/// </summary>
	public partial class Update : Form 
	{
		MainForm forms;
		Database database;
		int id; 
		string batch;
		string name;
		string type;
		string amount;
		string _note;
		int intYear;
		Fallter f = new Fallter();
		
		string[] exp = new string[3];
		public Update(MainForm form,Database data,int _id,string _btc,string _name,string _type ,string _exp,string _amonut ,string _note)
		{
			this.forms = form;
			this.id=_id;
		//	MessageBox.Show(_exp);
			this.exp =Regex.Split(_exp,"/");
			this.batch=_btc;
			this.name=_name;
			this.type=_type;
			this.amount=_amonut;
			this._note=_note;
			
			this.database =data;
		
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CenterToScreen();
			
		
			
			intYear =Convert.ToInt32(exp[0]);
			
			comboYear.Items.AddRange(new object[]{
			                          
			                            intYear-3,
			                            intYear-2,
			                            intYear-1,
			                            intYear,
			                            intYear+1,
			                            intYear+2,
			                            intYear+3,
			                            intYear+4,
			                            intYear+5,
			                         });
			comboYear.Text=exp[0];
			comboMonth.Text=exp[1];
			dayNumber.Text =exp[2];
			
			
			medName.Text=_name;
			batchNum.Text=_btc;
			medAmount.Text=_amonut;
			_notes.Text=_note;
			comboType.Text=_type;
			
			
		
			if(comboType.Text ==""){
			textboxOther.Visible=true;
			comboType.Text="others";
			textboxOther.Text=_type;
			}
			
			
			
		}
		

	
		
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
			
			
		}
		
		void UpdateSaveClick(object sender, EventArgs e)
		{
			

			
				
			if( /*batchNum.Text.Equals("") || */ comboType.Text.Equals("")||comboYear.Text.Equals("")||comboMonth.Text.Equals("")|| medName.Text.Equals("") /*|| medAmount.Text.Equals("") */)
			{}
			else if(comboType.Text=="others" && textboxOther.Text=="")
			{
			textboxOther.Select();
			}
			else{
				
				int amo = f.AddInt(medAmount.Text);
				
				string typeSelect=null;
			if(comboType.Text=="others"){
			typeSelect= textboxOther.Text;
			}else{
			
				typeSelect=comboType.Text;
			}
				string dateType=null;
			
			if(dayNumber.Text=="0"){
			
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
				
				database.Ccon();
				database.update(id,batchNum.Text,medName.Text,typeSelect,f.CheckDateBeforeAdd(dateType),amo,_notes.Text);

	forms.checkGet();
		this.Close();
		}
		}
		
		void MedAmountKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
	}
}
