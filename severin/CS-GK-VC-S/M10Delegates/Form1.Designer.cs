namespace M10Delegates
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.PlusButton = new System.Windows.Forms.Button();
			this.MinusButton = new System.Windows.Forms.Button();
			this.PlusMinusButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zahl1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(115, 102);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(103, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Zahl2";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 151);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// PlusButton
			// 
			this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlusButton.Location = new System.Drawing.Point(279, 45);
			this.PlusButton.Name = "PlusButton";
			this.PlusButton.Size = new System.Drawing.Size(131, 95);
			this.PlusButton.TabIndex = 4;
			this.PlusButton.Text = "+";
			this.PlusButton.UseVisualStyleBackColor = true;
			this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
			// 
			// MinusButton
			// 
			this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinusButton.Location = new System.Drawing.Point(279, 146);
			this.MinusButton.Name = "MinusButton";
			this.MinusButton.Size = new System.Drawing.Size(131, 93);
			this.MinusButton.TabIndex = 5;
			this.MinusButton.Text = "-";
			this.MinusButton.UseVisualStyleBackColor = true;
			this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
			// 
			// PlusMinusButton
			// 
			this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlusMinusButton.Location = new System.Drawing.Point(279, 245);
			this.PlusMinusButton.Name = "PlusMinusButton";
			this.PlusMinusButton.Size = new System.Drawing.Size(131, 94);
			this.PlusMinusButton.TabIndex = 6;
			this.PlusMinusButton.Text = "+-";
			this.PlusMinusButton.UseVisualStyleBackColor = true;
			this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(144, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ergebnis: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(471, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "ErgebnisFunc";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(38, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 104);
			this.button1.TabIndex = 9;
			this.button1.Text = "demoListNDelegate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PlusMinusButton);
			this.Controls.Add(this.MinusButton);
			this.Controls.Add(this.PlusButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button PlusButton;
		private System.Windows.Forms.Button MinusButton;
		private System.Windows.Forms.Button PlusMinusButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}

