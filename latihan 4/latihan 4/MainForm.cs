/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 4:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace latihan_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Hello " + this.txt_1.Text + ", Nim kamu "+ this.txt_2.Text + ", Kelas "+ this.txt_3.Text +", Mata Kuliah "+this.txt_4.Text);
		}
	}
}
