/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-13
 * Time: 11:52
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Generator
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
		void ButtonGenerateClick(object sender, EventArgs e)
		{
			List<char> characters = new List<char>();
			
			if(checkBoxLower.Checked == true)
			{
				for(int i='a'; i<'z'; i++)
				{
					characters.Add((char)i);
				}
			}
			
			if(checkBoxUpper.Checked == true)
			{
				for(int i='A'; i<'Z'; i++)
				{
					characters.Add((char)i);
				}
			}
			
			if(checkBoxNumbers.Checked == true)
			{
				for(int i='0'; i<'9'; i++)
				{
					characters.Add((char)i);
				}
			}
			
			if(checkBoxSpecial.Checked == true)
			{
				foreach(char c in checkBoxSpecial.Tag.ToString().ToCharArray())
				{
					characters.Add(c);
				}
			}
			
			if(textBoxAdditional.Text.Trim().Length != 0)
			{
				foreach(char c in checkBoxSpecial.Text.ToCharArray())
				{
					characters.Add(c);
				}
			}
		
			
			Random rand = new Random();
			string password = "";
			for(int i=0; i<numericPasswordLength.Value; i++)
			{
				int index = rand.Next(0, characters.Count);
				password+=characters[index];
			}
			textBoxPassword.Text = password;
		}
		
		void ButtonCopyClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textBoxPassword.Text);
		}
	}
}
