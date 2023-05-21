namespace PicturesGUI
{
    partial class ChoisePictureForm
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
            this.Generate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypePictureText = new System.Windows.Forms.ComboBox();
            this.HeightPictureText = new System.Windows.Forms.NumericUpDown();
            this.WidthPictureText = new System.Windows.Forms.NumericUpDown();
            this.LengthFiguresPictureText = new System.Windows.Forms.NumericUpDown();
            this.Lenght_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPictureText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPictureText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthFiguresPictureText)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generate.Location = new System.Drawing.Point(0, 0);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(368, 77);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Готово";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TypePictureText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightPictureText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WidthPictureText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LengthFiguresPictureText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lenght_Label, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.91358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.08642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 311);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип картинки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина";
            // 
            // TypePictureText
            // 
            this.TypePictureText.FormattingEnabled = true;
            this.TypePictureText.Items.AddRange(new object[] {
            "Градиент",
            "Квадраты",
            "Шум"});
            this.TypePictureText.Location = new System.Drawing.Point(187, 3);
            this.TypePictureText.Name = "TypePictureText";
            this.TypePictureText.Size = new System.Drawing.Size(178, 23);
            this.TypePictureText.TabIndex = 8;
            this.TypePictureText.SelectedIndexChanged += new System.EventHandler(this.TypePictureText_SelectedIndexChanged);
            // 
            // HeightPictureText
            // 
            this.HeightPictureText.Location = new System.Drawing.Point(187, 75);
            this.HeightPictureText.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.HeightPictureText.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.HeightPictureText.Name = "HeightPictureText";
            this.HeightPictureText.Size = new System.Drawing.Size(178, 23);
            this.HeightPictureText.TabIndex = 9;
            this.HeightPictureText.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WidthPictureText
            // 
            this.WidthPictureText.Location = new System.Drawing.Point(187, 156);
            this.WidthPictureText.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.WidthPictureText.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WidthPictureText.Name = "WidthPictureText";
            this.WidthPictureText.Size = new System.Drawing.Size(178, 23);
            this.WidthPictureText.TabIndex = 10;
            this.WidthPictureText.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LengthFiguresPictureText
            // 
            this.LengthFiguresPictureText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LengthFiguresPictureText.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.LengthFiguresPictureText.Location = new System.Drawing.Point(187, 239);
            this.LengthFiguresPictureText.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.LengthFiguresPictureText.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.LengthFiguresPictureText.Name = "LengthFiguresPictureText";
            this.LengthFiguresPictureText.Size = new System.Drawing.Size(178, 23);
            this.LengthFiguresPictureText.TabIndex = 11;
            this.LengthFiguresPictureText.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Lenght_Label
            // 
            this.Lenght_Label.AutoSize = true;
            this.Lenght_Label.Location = new System.Drawing.Point(3, 236);
            this.Lenght_Label.Name = "Lenght_Label";
            this.Lenght_Label.Size = new System.Drawing.Size(79, 15);
            this.Lenght_Label.TabIndex = 7;
            this.Lenght_Label.Text = "Длина фигур";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Generate);
            this.panel1.Location = new System.Drawing.Point(-3, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 77);
            this.panel1.TabIndex = 2;
            // 
            // ChoisePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChoisePictureForm";
            this.Text = "Выбор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPictureText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPictureText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthFiguresPictureText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Generate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label Lenght_Label;
        private Panel panel1;
        private ComboBox TypePictureText;
        private NumericUpDown HeightPictureText;
        private NumericUpDown WidthPictureText;
        private NumericUpDown LengthFiguresPictureText;
    }
}