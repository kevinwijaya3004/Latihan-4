/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 4:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace latihan_4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.TextBox txt_1;
		private System.Windows.Forms.TextBox txt_2;
		private System.Windows.Forms.TextBox txt_3;
		private System.Windows.Forms.TextBox txt_4;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_1 = new System.Windows.Forms.Button();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.txt_2 = new System.Windows.Forms.TextBox();
			this.txt_3 = new System.Windows.Forms.TextBox();
			this.txt_4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NIM :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelas :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mata Kuliah :";
			// 
			// btn_1
			// 
			this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_1.Location = new System.Drawing.Point(160, 224);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(143, 40);
			this.btn_1.TabIndex = 4;
			this.btn_1.Text = "Klik Saya";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// txt_1
			// 
			this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_1.Location = new System.Drawing.Point(98, 36);
			this.txt_1.Name = "txt_1";
			this.txt_1.Size = new System.Drawing.Size(134, 30);
			this.txt_1.TabIndex = 5;
			// 
			// txt_2
			// 
			this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_2.Location = new System.Drawing.Point(81, 81);
			this.txt_2.Name = "txt_2";
			this.txt_2.Size = new System.Drawing.Size(135, 30);
			this.txt_2.TabIndex = 6;
			// 
			// txt_3
			// 
			this.txt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_3.Location = new System.Drawing.Point(98, 127);
			this.txt_3.Name = "txt_3";
			this.txt_3.Size = new System.Drawing.Size(134, 30);
			this.txt_3.TabIndex = 7;
			// 
			// txt_4
			// 
			this.txt_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_4.Location = new System.Drawing.Point(149, 173);
			this.txt_4.Name = "txt_4";
			this.txt_4.Size = new System.Drawing.Size(154, 30);
			this.txt_4.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 325);
			this.Controls.Add(this.txt_4);
			this.Controls.Add(this.txt_3);
			this.Controls.Add(this.txt_2);
			this.Controls.Add(this.txt_1);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "latihan 4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
