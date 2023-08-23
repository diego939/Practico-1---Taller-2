namespace Practico1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BGuardar = new Button();
            BEliminar = new Button();
            LApellido = new Label();
            textBox1 = new TextBox();
            LNombre = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // BGuardar
            // 
            resources.ApplyResources(BGuardar, "BGuardar");
            BGuardar.Name = "BGuardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += button1_Click;
            // 
            // BEliminar
            // 
            resources.ApplyResources(BEliminar, "BEliminar");
            BEliminar.Name = "BEliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // LApellido
            // 
            resources.ApplyResources(LApellido, "LApellido");
            LApellido.Name = "LApellido";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // LNombre
            // 
            resources.ApplyResources(LNombre, "LNombre");
            LNombre.Name = "LNombre";
            LNombre.Click += label1_Click;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(LNombre);
            Controls.Add(textBox1);
            Controls.Add(LApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LApellido;
        private TextBox textBox1;
        private Label LNombre;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}