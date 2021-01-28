
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fevereiro_2021
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
		void Button1Click(object sender, EventArgs e)
		{
            Utilizador Uz = new Utilizador();
            this.Hide();
            Uz.ShowDialog();
		}
		void FecharClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
