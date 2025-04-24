
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(31, 38);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(43, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Usuario";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(101, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(80, 20);
            this.txt1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(247, 33);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 25);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Salir";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(31, 72);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(34, 13);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "Clave";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(101, 72);
            this.txt2.Name = "txt2";
            this.txt2.PasswordChar = '*';
            this.txt2.Size = new System.Drawing.Size(80, 20);
            this.txt2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txt2;
    }
}

