﻿namespace Ferramenta
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            this.btnListarServicos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvServicos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnListarServicos
            // 
            this.btnListarServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarServicos.Location = new System.Drawing.Point(310, 57);
            this.btnListarServicos.Name = "btnListarServicos";
            this.btnListarServicos.Size = new System.Drawing.Size(328, 41);
            this.btnListarServicos.TabIndex = 14;
            this.btnListarServicos.Text = "Listar Serviços do Windows";
            this.btnListarServicos.UseVisualStyleBackColor = true;
            this.btnListarServicos.Click += new System.EventHandler(this.btnListarServicos_Click_1);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(310, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 39);
            this.button5.TabIndex = 13;
            this.button5.Text = "Status";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(161, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(12, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reiniciar serviço";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(161, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Para serviços";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inicia serviço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvServicos
            // 
            this.lvServicos.AllowColumnReorder = true;
            this.lvServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvServicos.FullRowSelect = true;
            this.lvServicos.GridLines = true;
            this.lvServicos.HideSelection = false;
            this.lvServicos.Location = new System.Drawing.Point(12, 133);
            this.lvServicos.Name = "lvServicos";
            this.lvServicos.Size = new System.Drawing.Size(720, 288);
            this.lvServicos.TabIndex = 9;
            this.lvServicos.UseCompatibleStateImageBehavior = false;
            this.lvServicos.View = System.Windows.Forms.View.Details;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarServicos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvServicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicos";
            this.Text = "Serviços windows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarServicos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvServicos;
    }
}