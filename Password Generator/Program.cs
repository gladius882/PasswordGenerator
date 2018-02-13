/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-13
 * Time: 11:52
 * 
 */
using System;
using System.Windows.Forms;

namespace Password_Generator
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
