﻿namespace WinFormsApp1
{
    partial class MathForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathForm));
            btnCalcular = new Button();
            BoxN1 = new TextBox();
            BoxN2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            boxOperadores = new ComboBox();
            label3 = new Label();
            BoxResult = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(121, 213);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 40);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // BoxN1
            // 
            BoxN1.Location = new Point(181, 52);
            BoxN1.MaxLength = 15;
            BoxN1.Name = "BoxN1";
            BoxN1.PlaceholderText = "0.0";
            BoxN1.Size = new Size(137, 23);
            BoxN1.TabIndex = 2;
            BoxN1.KeyPress += BoxN1_KeyPress;
            // 
            // BoxN2
            // 
            BoxN2.Location = new Point(181, 81);
            BoxN2.MaxLength = 15;
            BoxN2.Name = "BoxN2";
            BoxN2.PlaceholderText = "0.0";
            BoxN2.Size = new Size(137, 23);
            BoxN2.TabIndex = 3;
            BoxN2.KeyPress += BoxN2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione la Operacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero 2:";
            // 
            // boxOperadores
            // 
            boxOperadores.BackColor = Color.White;
            boxOperadores.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOperadores.FormattingEnabled = true;
            boxOperadores.Items.AddRange(new object[] { ">", "<", ">=", "<=", "==", "!=", "+", "-", "*", "/", "PI", "POW", "LOG", "MAX", "MIN" });
            boxOperadores.Location = new Point(181, 19);
            boxOperadores.Name = "boxOperadores";
            boxOperadores.Size = new Size(137, 23);
            boxOperadores.TabIndex = 1;
            boxOperadores.TextChanged += boxOperadores_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 54);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Numero 1:";
            // 
            // BoxResult
            // 
            BoxResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BoxResult.Location = new Point(12, 126);
            BoxResult.MaxLength = 20;
            BoxResult.Multiline = true;
            BoxResult.Name = "BoxResult";
            BoxResult.ReadOnly = true;
            BoxResult.Size = new Size(337, 67);
            BoxResult.TabIndex = 7;
            // 
            // MathForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 265);
            Controls.Add(BoxResult);
            Controls.Add(label3);
            Controls.Add(boxOperadores);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BoxN2);
            Controls.Add(BoxN1);
            Controls.Add(btnCalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MathForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo General";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox BoxN1;
        private TextBox BoxN2;
        private Label label1;
        private Label label2;
        private ComboBox boxOperadores;
        private Label label3;
        private TextBox BoxResult;
    }
}