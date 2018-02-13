/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-13
 * Time: 11:52
 * 
 */
namespace Password_Generator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkBoxLower;
		private System.Windows.Forms.CheckBox checkBoxUpper;
		private System.Windows.Forms.CheckBox checkBoxNumbers;
		private System.Windows.Forms.CheckBox checkBoxSpecial;
		private System.Windows.Forms.TextBox textBoxAdditional;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericPasswordLength;
		private System.Windows.Forms.Label label3;
		
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
			this.checkBoxLower = new System.Windows.Forms.CheckBox();
			this.checkBoxUpper = new System.Windows.Forms.CheckBox();
			this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
			this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
			this.textBoxAdditional = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericPasswordLength = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxLower
			// 
			this.checkBoxLower.Checked = true;
			this.checkBoxLower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxLower.Location = new System.Drawing.Point(12, 39);
			this.checkBoxLower.Name = "checkBoxLower";
			this.checkBoxLower.Size = new System.Drawing.Size(116, 24);
			this.checkBoxLower.TabIndex = 0;
			this.checkBoxLower.Text = "Lower case [a-z]";
			this.checkBoxLower.UseVisualStyleBackColor = true;
			// 
			// checkBoxUpper
			// 
			this.checkBoxUpper.Checked = true;
			this.checkBoxUpper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxUpper.Location = new System.Drawing.Point(12, 70);
			this.checkBoxUpper.Name = "checkBoxUpper";
			this.checkBoxUpper.Size = new System.Drawing.Size(128, 24);
			this.checkBoxUpper.TabIndex = 1;
			this.checkBoxUpper.Text = "Upper case [A-Z]";
			this.checkBoxUpper.UseVisualStyleBackColor = true;
			// 
			// checkBoxNumbers
			// 
			this.checkBoxNumbers.Checked = true;
			this.checkBoxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxNumbers.Location = new System.Drawing.Point(12, 101);
			this.checkBoxNumbers.Name = "checkBoxNumbers";
			this.checkBoxNumbers.Size = new System.Drawing.Size(104, 24);
			this.checkBoxNumbers.TabIndex = 2;
			this.checkBoxNumbers.Text = "Numbers [0-9]";
			this.checkBoxNumbers.UseVisualStyleBackColor = true;
			// 
			// checkBoxSpecial
			// 
			this.checkBoxSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxSpecial.Location = new System.Drawing.Point(12, 135);
			this.checkBoxSpecial.Name = "checkBoxSpecial";
			this.checkBoxSpecial.Size = new System.Drawing.Size(298, 24);
			this.checkBoxSpecial.TabIndex = 3;
			this.checkBoxSpecial.Tag = "[]{}!\"#$%&\'()*+,-./@^;?";
			this.checkBoxSpecial.Text = "Special characters [ ] { } ! \" # $ % & \' ( ) * + , - . / @ ^ = ; ?";
			this.checkBoxSpecial.UseVisualStyleBackColor = true;
			// 
			// textBoxAdditional
			// 
			this.textBoxAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxAdditional.Location = new System.Drawing.Point(12, 190);
			this.textBoxAdditional.Name = "textBoxAdditional";
			this.textBoxAdditional.Size = new System.Drawing.Size(298, 22);
			this.textBoxAdditional.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Additional characters:";
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonGenerate.Location = new System.Drawing.Point(12, 280);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
			this.buttonGenerate.TabIndex = 6;
			this.buttonGenerate.Text = "Generate";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerateClick);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonCopy.Location = new System.Drawing.Point(106, 280);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(151, 23);
			this.buttonCopy.TabIndex = 7;
			this.buttonCopy.Text = "Copy to clipboard";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.ButtonCopyClick);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxPassword.Location = new System.Drawing.Point(12, 241);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(298, 22);
			this.textBoxPassword.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Generated password:";
			// 
			// numericPasswordLength
			// 
			this.numericPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericPasswordLength.Location = new System.Drawing.Point(146, 7);
			this.numericPasswordLength.Minimum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericPasswordLength.Name = "numericPasswordLength";
			this.numericPasswordLength.Size = new System.Drawing.Size(65, 22);
			this.numericPasswordLength.TabIndex = 10;
			this.numericPasswordLength.Value = new decimal(new int[] {
			8,
			0,
			0,
			0});
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Password length:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 315);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericPasswordLength);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAdditional);
			this.Controls.Add(this.checkBoxSpecial);
			this.Controls.Add(this.checkBoxNumbers);
			this.Controls.Add(this.checkBoxUpper);
			this.Controls.Add(this.checkBoxLower);
			this.Name = "MainForm";
			this.Text = "Password Generator";
			((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
