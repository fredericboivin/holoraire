﻿
﻿namespace HoraireBeta
 {
     partial class SelectDispo
     {
         /// <summary>
         /// Required designer variable.
         /// </summary>
         private System.ComponentModel.IContainer components = null;

         /// <summary>
         /// Clean up any resources being used.
         /// </summary>
         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
             {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }

         #region Windows Form Designer generated code

         /// <summary>
         /// Required method for Designer support - do not modify
         /// the contents of this method with the code editor.
         /// </summary>
         private void InitializeComponent()
         {
             this.panel1 = new System.Windows.Forms.Panel();

             this.button1 = new System.Windows.Forms.Button();
             this.button2 = new System.Windows.Forms.Button();
             this.label1 = new System.Windows.Forms.Label();
             this.SuspendLayout();
             // 
             // panel1
             // 
             this.panel1.BackColor = System.Drawing.Color.Turquoise;
             this.panel1.Location = new System.Drawing.Point(244, 1);
             this.panel1.Name = "panel1";
             this.panel1.Size = new System.Drawing.Size(758, 569);
             this.panel1.TabIndex = 0;
             this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
             this.panel1.DoubleClick += new System.EventHandler(this.panel_CentralDoubleClick);
             this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_CentralMouseDown);
             // 
             // monthCalendar1
             // 

             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(40, 379);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(158, 23);
             this.button1.TabIndex = 2;
             this.button1.Text = "Mode disponibilité";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button2
             // 
             this.button2.Location = new System.Drawing.Point(40, 426);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(158, 23);
             this.button2.TabIndex = 3;
             this.button2.Text = "Mode préférence";
             this.button2.UseVisualStyleBackColor = true;
             this.button2.Click += new System.EventHandler(this.button2_Click_1);
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Location = new System.Drawing.Point(97, 217);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(0, 13);
             this.label1.TabIndex = 4;
             // 
             // SelectDispo
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(1003, 569);
             this.Controls.Add(this.label1);
             this.Controls.Add(this.button2);
             this.Controls.Add(this.button1);

             this.Controls.Add(this.panel1);
             this.Name = "SelectDispo";
             this.Text = "SelectDispo";
             this.Load += new System.EventHandler(this.SelectDispo_Load);
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         #endregion

         private System.Windows.Forms.Panel panel1;

         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.Button button2;
         private System.Windows.Forms.Label label1;
     }


 }