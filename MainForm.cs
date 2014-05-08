/*
 * Created by SharpDevelop.
 * User: abdulaziz
 * Date: 06/08/33
 * Time: 04:04 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Expire
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public enum print{ NONE ,ALIST ,ALABEL , SLIST,SLABEL}
		
		public enum Date { EXP ,NEAR,ATTENTION,SAFF,LONG}
		
		
		Database data = new Database();
		
		
		
		
		public int Count{get;set;}
			
			int 			_Id;
			int 			_oneClick=0;
			int 			 _Scorll;
			//string			title ="deafult";
			string 			_Batch ;
			print 			switchPrint;
			string			_Atten ;
			int				totalPage=0;
			string			_Type ;
			string			_Expdate ;
			string			_Amount;
			string			_Note;
			ListViewItem 	item;
			bool 			SelectItem=false;
			int				expiryCount=0;
			int				nearCount=0;
			
			bool			selectItemPrint=false;
			Date 			setColor; // 0 expired  |||| 1 Near to expiry |||| 2 one year to expiry 
		//	bool			withLogon=false; // true  is with login form |||| false without login
			int page =1;
			List<int> multiSelecteItem =new List<int>();
			PrnControl prnCo;
			PrnLable prnlab=new PrnLable();
			PrnText  prntext = new PrnText();
			Fallter f = new Fallter();
			//Find find ;
			Finder find;
			AddNew addnew ;
		
		public MainForm()
		{
			
			GetStart();
		
	
		}
		
		
		
		public void GetStart(){
		
			
		//find= new Find(this,data);
		find= new Finder(this);
		addnew = new AddNew(this);
		prnCo =	new PrnControl(this);
			
			InitializeComponent();
				CenterToScreen();	
		
				data.Ccon();
	//		data.createdb();
	
		getAll(0);
			
		
		}
		
		#region get set 
		
			public int TotalPage{
		
			get{return totalPage;}
			set{ totalPage =value;}
		
		
		}
		#endregion
		
		public void Start(){
		
			data = new Database();
		data.Ccon();
		getAll(0);
		}
		
		
			public void Start(string loca){
		
			//data = new Database();
			data.Location =loca;
			data = new Database();
		data.Ccon();
		getAll(0);
		}
		
		public void Stop(){
		
	data.Dispose();
	orderBy.SelectedIndex=0;
	byPrint.SelectedIndex=0;
	bySort.SelectedIndex=0;
		}
		
		#region get information from data
		
		public void getinfo(int id)
		{
			if(data.getinfo(id)==""){
			otherInfo.Enabled=false;
			}
			else{
				otherInfo.Enabled=true;
				toolTip1.SetToolTip(otherInfo,data.getinfo(id));
			}
		}
		
		
		public void checkGet(){
		
			if(bySort.Text.Equals("All")){
			
				getAll(0);
			}
			if(bySort.Text.Equals("Exp")){
			
				getAll(4);
			}
			if(bySort.Text.Equals("Near Exp")){
			
				getAll(5);
			}
				if(bySort.Text.Equals("Next 3Months")){
			
				getAll(6);
			}
			if(bySort.Text.Equals("All after")){
			
				getAll(7);
			}
			
		}
		
		
		/// <summary>
		/// create listviewitem by get data from database
		/// </summary>
		public void getAll(int textType){
			expiryCount=0;
			nearCount=0;
			lsv.Items.Clear();
//			otherInfo.Text="";
			int texttype =textType;
			
			if(orderBy.Text.Equals("Name"))
			{
				data.getAll(texttype,1);
			}
			else{
			data.getAll(texttype);
			}
			
			int x =0;
			
			
				
			if(data.retlist().Count<=0){}
			else{
			while(x <data.retlist().Count){
				
				// seprat listarray to array then to string
				string[] result =data.retlist()[x].ToString().Split(';');
				
				
				t = new ListViewItem(result[0].ToString());
				
				//argument medicine
				t.SubItems.Add((x+1).ToString());
				
				
				
				
				t.SubItems.Add(result[1].ToString().ToUpper());
			
				t.SubItems.Add(result[2].ToString().ToUpper());
				t.SubItems.Add(result[3].ToString().ToUpper());
				
				
				//expired date
			//	t.SubItems.Add(result[4].ToString().ToUpper());
			
			t.SubItems.Add(getMonthName(result[4].ToString()));
				//amount of medicine
				t.SubItems.Add(result[5].ToString().ToUpper());
				
				// notes for medicine
			string itemNote="";
				if(result[6].ToString().Equals("")){
					
					itemNote =getTimeline(result[4].ToString());
				}
				else{
					
					itemNote =getTimeline(result[4].ToString())+" *";
				}
			t.SubItems.Add(itemNote);
				
				
				
				lsv.Items.Add(t);
			lsv.Items[x].UseItemStyleForSubItems=false;
			if(setColor==Date.EXP){
			lsv.Items[x].SubItems[7].BackColor=Color.Red;
			}
		
			if(setColor==Date.NEAR){
			lsv.Items[x].SubItems[7].BackColor=Color.Orange;
			}
			if(setColor==Date.ATTENTION){
			lsv.Items[x].SubItems[7].BackColor=Color.LightGreen;
			}
				if(setColor== Date.SAFF){
			lsv.Items[x].SubItems[7].BackColor=Color.LightSalmon;
			}
			if(setColor==Date.LONG){
			lsv.Items[x].SubItems[7].BackColor=Color.White;
			}
				x++;
			}
			
		
			
			

			DisableSelect();
			record.Text= data.retlist().Count.ToString();
			stpExpired.Text =expiryCount.ToString();
			stpNear.Text=nearCount.ToString();
			
			
			}
//			
//			if(lsv.Items.Count<=0 ){
//			
//			_Scorll=0;
//			}
//			else if(_Scorll ==lsv.Items.Count){
//			_Scorll=lsv.Items.Count-1;
//			
//				lsv.Items[_Scorll].Selected=true;
//			
//			}
//			else{
//				
//			lsv.EnsureVisible(_Scorll);
//			lsv.Items[_Scorll].Selected=true;
//			
//			}
			
			}
		
		#endregion
		
		
		#region Print item list Or label
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			prnlab.e=e ;prntext.e=e;
			prnlab.lsv=lsv ; prntext.lsv=lsv;
			
			switch(switchPrint){
				
					case print.ALIST: PrintAllText();
						break;
						
					case print.SLIST: PrintSelectedText();
						break;
						
					case print.SLABEL: PrintSelectedLabel();
						break;
						
						case print.ALABEL: PrintAllLabel();
						break;
						
					default:
                  		 	
                    break;
						
			
			}
			

			
				}
				
			
		public void PrintAllText(){
		if(page ==prntext.newPage){
			prntext.PrnAllText(prntext.Loop);
				page +=1;
				if(page==prntext.newPage){
						
			prntext.e.HasMorePages=true;
			
	
		
				}else{
					prntext.e.HasMorePages=false;
					
					
				}
				
				TotalPage +=1;
	
			
			}
		}
		
		public void PrintSelectedText(){
			
				if(page==prntext.newPage){
		
			prntext.PrnSelectedText(multiSelecteItem,prntext.skipCount);
		
				
				
					page +=1;
				if(page==prntext.newPage){
						
			prntext.e.HasMorePages=true;
			
	
		
				}else{
						prntext.e.HasMorePages=false;
						
						
				}
				
					TotalPage +=1;
	
				}
		
		}
		
		public void PrintAllLabel(){
		
		
			if(page==prnlab.newPage){
		
				prnlab.PrintAllLable(prnlab.Loop);
				
					page +=1;
				if(page==prnlab.newPage){
						
			prnlab.e.HasMorePages=true;
			
	
		
				}else{
					prnlab.e.HasMorePages=false;
				}
				
	
	TotalPage +=1;
				}
		}
		
		public void PrintSelectedLabel(){
		
		
			
			if(page==prnlab.newPage){
		
				prnlab.PrintSelectedLable(multiSelecteItem,prnlab.skipCount);
				
					page +=1;
				if(page==prnlab.newPage){
						
			prnlab.e.HasMorePages=true;
			
	
		
				}else{
						
						prnlab.e.HasMorePages=false;
						
						
						
				}
				
					TotalPage +=1;
	
				}
		
		}
		
			
		public void PrintDoc(){
		
				SetupPrint();
			prnDoc.Print();
		
		}
		
		
		public void PrintLabel(){
			
			SetupPrint();
	switchPrint=print.NONE;
		
		}
		public void SetupPrint(){
		
			
		prnlab.SetZero();
		prntext.SetZero();
		TotalPage=0;
		
		 page =1;
		 //print label from listview  
		 if(selectItemPrint){
		 	if(byPrint.Text.Equals("Label")){
		 // print selected label		
		 switchPrint=print.SLABEL;
		 	}
		 	else{
		 // print select text
		 
		 switchPrint=print.SLIST;
		 	}
		 
		 
	ListView.SelectedListViewItemCollection getSelect = lsv.SelectedItems;
	
		multiSelecteItem.Clear();
		foreach ( ListViewItem item in getSelect )
		{
			multiSelecteItem.Add(item.Index);
		}
		
		if(multiSelecteItem.Count==0){
			
		// switchPrint=print.ALIST;
		}
		 
		 }
		 else{
		 	if(byPrint.Text.Equals("Label")){
		 //print all lable
		 switchPrint=print.ALABEL;
		 	}else{
		 //print all text
		 switchPrint=print.ALIST;
		 	}
		 }
		}
		
		
			void BfClick(object sender, EventArgs e)
		{
			

	
		
		
		 
	
			if(prnCo.Visible){
			
				prnCo.Activate();
				
			}else{
				try{
				
					if(lsv.Items.Count==0){
					
					
					}
					else{
					
								
					prnCo.printPreviewControl1.Document= prnDoc;
					prnCo.printDialog1.Document = prnCo.printPreviewControl1.Document;
					SetupPrint();
					prnCo.Show();
					}
					
				}catch(Exception){
					
					prnCo = new  PrnControl(this);
					if(lsv.Items.Count==0){
					
					
					}
					else{
					
								
					prnCo.printPreviewControl1.Document= prnDoc;
					prnCo.printDialog1.Document = prnCo.printPreviewControl1.Document;
					SetupPrint();
					prnCo.Show();
					}
				
				}
			}
		
		
			
		
		}

	#endregion			
		
		
		
		#region Event
		
		
		
		void ToolStripNewClick(object sender, EventArgs e)
		{
			
				AddNew();
		}
		
		
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
		
			getAll(0);
		}
		
		
		
		void LsvResize(object sender, EventArgs e)
		{
			
			SizeLastColumn((ListView) sender);
	
		}
		
	
		
		void FindToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			
			openFind();
	
		}
		
	
		
		
		
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			
				openFind();
	
		}
		
		public void openFind(){
		
				if(find.Visible){
			
				find.Activate();
			}else{
				try{
			find.Show();
				}catch(Exception){
					find = new Finder(this);
					find.Show();
				
				}
			}
		}
		
		
		
		void ToolStripRemoveClick(object sender, EventArgs e)
		{
			// remove item 
			if(SelectItem){
			Delete();
			}

		}
		
		
		
		void AboutToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			About about =new About();
			about.ShowDialog();
			
		}
		
		
		
		
		
		
		void NewToolStripMenuItemClick(object sender, System.EventArgs e)
		{
		
			if(data.IsDefault()){
				data.Drop();
				
			}else{
			
				data.SetLocation();
			}
			
			
			
			Stop();
			Start();
			
			
			
			
		}
		
		
		
		
		
		
		public void menuItem1_Click(object sender , System.EventArgs e){
			
			AddNew();
			
		}
		
		
		
		
		

		
		
		
		
		public void menuItem4_Click(object sender , System.EventArgs e){
			
			
			getAll(0);
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			// exit app
			System.Environment.Exit(0);
		}
		
		
		
		
		
		
	
		
		
		
		
		
		
		public void menulist(System.Windows.Forms.MouseEventArgs e){
			
			
			ContextMenu myContextMenu = new ContextMenu();

			MenuItem menuItem4 = new MenuItem("refresh");
			MenuItem menuItem1 = new MenuItem("New");
			MenuItem menuItem2 = new MenuItem("Delete");
			MenuItem menuItem3 = new MenuItem("Update");


			// Clear all previously added MenuItems.
			myContextMenu.MenuItems.Clear();
			myContextMenu.MenuItems.Add(menuItem4);
			myContextMenu.MenuItems.Add(menuItem1);
			myContextMenu.MenuItems.Add(menuItem2);
			myContextMenu.MenuItems.Add(menuItem3);

			if (lsv.SelectedItems.Count > 0)
			{
				
				
				
				foreach (ListViewItem item in lsv.SelectedItems)
				{
					myContextMenu.MenuItems[2].Visible = true;
					myContextMenu.MenuItems[3].Visible = true;
					myContextMenu.MenuItems[0].Visible = false;
					myContextMenu.MenuItems[1].Visible = true;
					
					
					
					
					
				}

			}
			else
			{
				myContextMenu.MenuItems[2].Enabled = false;
				myContextMenu.MenuItems[3].Enabled = false;
				myContextMenu.MenuItems[0].Visible = false;
				myContextMenu.MenuItems[1].Visible = true;
				
				
				
				
			}

			
			myContextMenu.Show(lsv, e.Location, LeftRightAlignment.Right);

			//event
			menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
		//	menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			
			
			
		}
		
		
		
				
		void LsvDoubleClick(object sender, EventArgs e)
		{
			// up date form 
			
			OpenUpdate();
			
		}
		
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			AddNew();
		}
		
		
		
		
		
		
		void MainFormResize(object sender, EventArgs e)
		{
			
			
			
			if (this.WindowState == FormWindowState.Maximized)
			{
				// code to execute after Maximize button has been clicked
//				int screenWidth =Screen.PrimaryScreen.Bounds.Width;
//				
//			
//				int screenAfter= screenWidth-40-99-70-90;
//				MessageBox.Show("sss");
//				screenAfter= screenAfter/3;
//				me_name.Width=screenAfter;
//				me_type.Width=screenAfter;
//				note.Width=screenAfter;
				
				
			}
			
			if (this.WindowState == FormWindowState.Minimized)
			{
				// code to execute after Minimize button has been clicked
				
				//MessageBox.Show(this.Width.ToString());
				
			}
		}
		
		
		
			void MainFormLoad(object sender, EventArgs e)
		{
		
			
	orderBy.SelectedIndex=0;
	byPrint.SelectedIndex=0;
	bySort.SelectedIndex=0;
			
//			if(withLogon){
//			showlogin();
//			}
//			
		}
			
			
			
			void LsvItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			
				selectItemPrint=false;
			
			item =(ListViewItem) e.Item;
			
				if(_oneClick==item.Index){
				
				
			}
			
			else{
			
			
		
			
			
//			if(item.SubItems[3].BackColor==Color.DodgerBlue)
//			{
//				for(int loop =1;loop<=6;loop++){
//				item.SubItems[loop].BackColor=Color.White;
//				item.SubItems[loop].ForeColor=Color.Black;
//				}
//				
//			}else{
//				for(int loop =1;loop<=6;loop++){
//				item.SubItems[loop].BackColor=Color.DodgerBlue;
//				item.SubItems[loop].ForeColor=Color.White;
//				}
//			}
			
			 _Scorll =item.Index;
			// MessageBox.Show(_Scorll.ToString());
			 _oneClick =item.Index;
			_Batch =item.SubItems[2].Text;
			_Atten =item.SubItems[3].Text;
			_Type =item.SubItems[4].Text;
			_Expdate =getMonthNo(item.SubItems[5].Text);
			
			_Amount=item.SubItems[6].Text;
			
			_Id =Convert.ToInt32(item.Text);
			_Note =data.getinfo(_Id);
			
			getinfo(_Id);
			
			
			if (lsv.SelectedItems.Count > 0) {
				
				
				if(selectItemPrint){
					DisableSelect();
				}else{
					SelectItem =true;

				}
				
				
			}
			else{
				
				DisableSelect();
			
		//otherInfo.Text="";
				
			}
			
			
		}
			}
	
				
           
		
	
		
		
		
	
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
//			if(e.KeyCode == Keys.Up){
//			
//			
//				
//				
//				if(lsv.Items.Count<=0 ){
//			
//			_Scorll=0;
//			}
//			else if(_Scorll ==lsv.Items.Count){
//			_Scorll=lsv.Items.Count-1;
//			
//				lsv.Items[_Scorll].Selected=true;
//			
//			}
//			else{
//				
//			
//		lsv.Items[_Scorll].Selected=false;
//		try{
//				lsv.Items[_Scorll-1].Selected=true;
//			
//		}catch{
//		
//		lsv.Items[0].Selected=true;
//		}
//			}
//			
//			}
//			
//			
//			if(e.KeyCode == Keys.Down){
//			
//					
//				if(lsv.Items.Count<=0 ){
//			
//			_Scorll=0;
//			}
//			else if(_Scorll ==lsv.Items.Count){
//			_Scorll=lsv.Items.Count-1;
//			
//				lsv.Items[_Scorll].Selected=true;
//			
//			}
//			else{
//				
//			
//					lsv.EnsureVisible(_Scorll);
//			lsv.Items[_Scorll].Selected=false;
//			lsv.Items[_Scorll+1].Selected=true;
//				
//			
//			}
//			
//			}
			
			
			if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
			{
				//do stuff
				AddNew();
			}
			if( e.Modifiers==Keys.Control ){
		//		multiSelecteItem.Clear();
				DisableSelect();
				selectItemPrint=true;
			
			}
			
		
		
			if(e.KeyCode==Keys.F && e.Modifiers==Keys.Control)
			{
				openFind();
			}
			if (e.KeyCode == Keys.Delete)
			{
				//do stuff
				if(SelectItem){
				
					Delete();
				}
			}
			
			if(e.KeyCode == Keys.F5 ){
				getAll(0);
			}
		}
		
		
		
	
		
		
		
		private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
		
		
		
		
		
		
		
	
		
		
	
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
			checkGet();
		}
		
		void BySortSelectedIndexChanged(object sender, EventArgs e)
		{
			
			if(bySort.Text.Equals("All")){
			
				getAll(0);
			}
			if(bySort.Text.Equals("Exp")){
			
				getAll(4);
			}
			if(bySort.Text.Equals("Near Exp")){
			
				getAll(5);
			}
				if(bySort.Text.Equals("Next 3Months")){
			
				getAll(6);
			}
					if(bySort.Text.Equals("All after")){
			
				getAll(7);
			}
			_Scorll=0;
			
		}
		
	
		
		
		#endregion 
		
		
		
		#region Time getmonth getyear get name of month
		
		
		public string getMonthName(string date){
		
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			dtfi.ShortDatePattern = "yyy/MM/dd";
			dtfi.DateSeparator = "/";
			//convert string to date
			string newDate="";
			try{
			DateTime oldDate = Convert.ToDateTime(date, dtfi);
		
			// newDate= oldDate.ToString("MMM dd,yyy ",dtfi);
			newDate = f.DeleteLastDayOfMonth(oldDate,dtfi);
			 
			}catch{
			 newDate="null";
			}
			
		
			return  newDate;
		}
		
		public string getMonthNo(string date){
		
		//	MessageBox.Show(date);
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			
string newDate;			
		
			if(date.Contains(" ,")){
				
				dtfi.ShortDatePattern = "yyy/MM";
			dtfi.DateSeparator = "/";
				DateTime oldDate = Convert.ToDateTime(date, dtfi);
				string lastDayOfMonth = f.getLastDayOfMonth(oldDate.Month.ToString());
			//	MessageBox.Show(oldDate.Month.ToString());
				newDate = oldDate.ToString("yyyy/MM/"+lastDayOfMonth,dtfi);
			   }
			   else{
			
				dtfi.ShortDatePattern = "yyy/MM/dd";
			dtfi.DateSeparator = "/";
				DateTime oldDate = Convert.ToDateTime(date, dtfi);
				newDate = oldDate.ToString("yyyy/MM/dd",dtfi);
			   }
			
			//convert string to date
			
		
			
			
		
			return  newDate;
		}
		
		public string getTimeline(string date){
		
			string expiryDateReutrn;
						
			string expDate = date;
			DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
			System.Globalization.CultureInfo gro = System.Globalization.CultureInfo.GetCultureInfo("en-US");
			dtfi.ShortDatePattern = "yyyy/MM/dd";
			dtfi.DateSeparator = "/";
			//convert string to date
			
			DateTime oldDate = Convert.ToDateTime(expDate, dtfi);
			// date new
			
			
		
			
		
			
			int newYear = Convert.ToInt32(DateTime.Now.ToString("yyyy",gro))*12;
			
			int oldYear = Convert.ToInt32(oldDate.Year.ToString())*12;
			
			int newMonth = Convert.ToInt32( DateTime.Now.ToString("MM",gro));
			
			int oldMonth = Convert.ToInt32(oldDate.Month.ToString());
			
			int expiry=(oldYear-newYear)-(newMonth-oldMonth);
			
			int on=0;
			int onn=0;
			while(true){
		
			if(expiry>=12){
			
			expiry=expiry-12;
			on++;
			}
			
			else{
			onn=expiry;
			break;
			
			}
			
		}
		if(onn<0){
			setColor=Date.EXP;
			expiryDateReutrn= "Expired";
			expiryCount++;
		}
		else if(on==0 && onn==0){
			setColor=Date.NEAR;
			expiryDateReutrn="Near to Expiry";
			nearCount++;
		}
		else if(on==0 && onn<=11 &&onn>=6){
			setColor=Date.ATTENTION;
		expiryDateReutrn=onn+" Months";
		}
		else if(on==0 && onn<=5){
			setColor=Date.SAFF;
		expiryDateReutrn=onn+" Months";
		}
		else if(on>0 && onn==0){
			setColor=Date.LONG;
		expiryDateReutrn=on+" Years";
		}
		else{
			setColor=Date.LONG;
		expiryDateReutrn=on+" Years "+onn+" Months";
		
		}
		
		return expiryDateReutrn;
				
				}
		
		
		#endregion
	
		
		
		
		
		#region Add Update Delete <== item
		
		
		public void AddNew(){
		
				if(addnew.Visible){
			
				addnew.Activate();
			}else{
				try{
			addnew.Show();
				}catch(Exception){
					addnew = new AddNew(this);
					addnew.Show();
				
				}
			}
			
		}
		
		public void OpenUpdate(){
		
		if(SelectItem){
				
			Update up = new Update(this,this.data,_Id,_Batch,_Atten,_Type,_Expdate,_Amount,_Note);
			
			up.ShowDialog();
			}
			
		}
		
		public void Delete(){
		
			DialogResult result =MessageBox.Show("Are you sure , want to delete :  "+ _Atten+" ?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if(result== DialogResult.Yes){
				data.delete(_Id);
				DisableSelect();
				getAll(0);
			}
			else{}
			
		
		}
		
		
		#endregion
		
		
		
		public void DisableSelect(){	SelectItem=false;	}
		

		
		void showlogin(){
			logOn log = new logOn();
			
			if(DialogResult.OK ==log.ShowDialog(this))
			{
				this.Show();
			
			}
			else{
				this.Close();
			}
		
		
		
		}
		
		
		
		
		/// <summary>
		/// auto resize listView item  LexRema @ http://stackoverflow.com
		/// </summary>
		/// <param name="lv"></param>
		/// 
		
		private void SizeLastColumn(ListView lv)
{
		
		
		 int x = lsv.Width/20 == 0 ? 1 : lsv.Width/20;
			
			
			
			
//				lsv.Columns[7].Width = x*6; 
//			lsv.Columns[6].Width = x*2; 
//			lsv.Columns[5].Width = x*2; 
//		lsv.Columns[4].Width = x*2; 
			lsv.Columns[3].Width = x*6; 
//			lsv.Columns[2].Width = x*2; 
//			lsv.Columns[1].Width = x; 
			 lsv.Columns[lsv.Columns.Count - 1].Width = -2;
}
		

		

		
	
		
	
		
		public void BntS(string search)
		{
			
		Count =	lsv.Items.Count;
		getAll(0);
			for(int x=-1;x<Count;x++){
			try{
			string getSearch = lsv.Items[x].SubItems[3].Text.ToLower();
						if(getSearch.Contains(search)){
			//MessageBox.Show(getSearch);
			lsv.EnsureVisible(x);
			lsv.Items[x].Selected=true;
			
			}
			else{
			
			//	lsv.Items[x].Remove();
				//x=-0;
			}
			}catch{
			Count =	lsv.Items.Count;
			x=-1;
			}

		}
		
		}
		
		
		// TODO 
		
		void OpenDataFromFilef(object sender, EventArgs e)
		{
			
			
			openFileDialog1.Title="open";
			openFileDialog1.FileName="";
			openFileDialog1.Filter="EXPD Files|*.EXPD";
			if(openFileDialog1.ShowDialog()==DialogResult.OK){
				Stop();
				Start(openFileDialog1.FileName);
	
		
			}
			
		}
		
		
		void SaveDataToFile(object sender, EventArgs e)
		{
			
			saveFileDialog1.Filter="EXPD Files|*.EXPD";
			saveFileDialog1.FileName="";
//			saveFileDialog1.CheckFileExists=true;
//			saveFileDialog1.CheckPathExists=true;
		//	saveFileDialog1.ShowDialog();
		
		if(saveFileDialog1.ShowDialog()==DialogResult.OK){
			
		//	MessageBox.Show(Path.GetFileName(saveFileDialog1.FileName));
	
		System.IO.File.Copy(data.Location,saveFileDialog1.FileName.ToString());
	//	saveFileDialog1	
//			MessageBox.Show(data.Location.ToString());
			//MessageBox.Show(saveFileDialog1);
			
			if(data.IsDefault()){
				data.Drop();
					Stop();
					Start();
				data.SetLocation();
			}else{
				Stop();
				Start();
				data.SetLocation();
			}
		
			Start();
			}
		}
		
		void TestlocClick(object sender, EventArgs e)
		{
			// TODO: Implement TestlocClick
			
			MessageBox.Show(data.Location);
		}
		
		void StartCconClick(object sender, EventArgs e)
		{
			// TODO: Implement StartCconClick
			
			data = new Database();
			
			data.Ccon();
			getAll(0);
		}
		
		void StopCconClick(object sender, EventArgs e)
		{
			// TODO: Implement StopCconClick
			data.Dispose();
		}
		
//		void ShowMouseHover(object sender, EventArgs e)
//		{
//			// TODO: Implement ShowMouseHover
//			
//		//	MessageBox.Show();
//		
//		otherInfo.Location=new Point(showInfo.Location.X-otherInfo.Width,showInfo.Location.Y-otherInfo.Height);
//		otherInfo.Visible=true;
//		otherInfo.Focus();
//		
//		
//			
//		}
		
	
		
		void ShowMouseLeave(object sender, EventArgs e)
		{
			// TODO: Implement ShowMouseLeave
			//otherInfo.Visible=false;
		}
		
		void OtherInfoMouseEnter(object sender, EventArgs e)
		{
			// TODO: Implement OtherInfoMouseEnter
		
			
		}
		}
		
		
	
	}
