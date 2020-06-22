namespace projektPWSW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnN = new System.Windows.Forms.Button();
            this.cbtests = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWyb = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Label();
            this.sendTestlbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNPP = new System.Windows.Forms.Label();
            this.lbNPT = new System.Windows.Forms.Label();
            this.lbNPBP = new System.Windows.Forms.Label();
            this.lbNBP = new System.Windows.Forms.Label();
            this.lbLPP = new System.Windows.Forms.Label();
            this.lbLPT = new System.Windows.Forms.Label();
            this.lbLPBP = new System.Windows.Forms.Label();
            this.lbLBP = new System.Windows.Forms.Label();
            this.lbCPP = new System.Windows.Forms.Label();
            this.lbCPT = new System.Windows.Forms.Label();
            this.lbCPBP = new System.Windows.Forms.Label();
            this.lbCBP = new System.Windows.Forms.Label();
            this.lbKPP = new System.Windows.Forms.Label();
            this.lbKPT = new System.Windows.Forms.Label();
            this.lbKPBP = new System.Windows.Forms.Label();
            this.lbKBP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTbName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbOK = new System.Windows.Forms.Label();
            this.lbNOK = new System.Windows.Forms.Label();
            this.chN4 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(91, 25);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Gray;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpen.Location = new System.Drawing.Point(218, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Otwórz";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(475, 26);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(92, 58);
            this.btnN.TabIndex = 18;
            this.btnN.Text = "Nastawy";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // cbtests
            // 
            this.cbtests.FormattingEnabled = true;
            this.cbtests.Items.AddRange(new object[] {
            "Test świecenia",
            "Test 1",
            "Test 2",
            "Test 3",
            "Test końcowy"});
            this.cbtests.Location = new System.Drawing.Point(91, 63);
            this.cbtests.Name = "cbtests";
            this.cbtests.Size = new System.Drawing.Size(121, 21);
            this.cbtests.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Test:";
            // 
            // btnWyb
            // 
            this.btnWyb.Location = new System.Drawing.Point(218, 61);
            this.btnWyb.Name = "btnWyb";
            this.btnWyb.Size = new System.Drawing.Size(75, 23);
            this.btnWyb.TabIndex = 23;
            this.btnWyb.Text = "Wybierz";
            this.btnWyb.UseVisualStyleBackColor = true;
            this.btnWyb.Click += new System.EventHandler(this.btnWyb_Click);
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Location = new System.Drawing.Point(258, 9);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(0, 13);
            this.connect.TabIndex = 24;
            // 
            // sendTestlbl
            // 
            this.sendTestlbl.AutoSize = true;
            this.sendTestlbl.Location = new System.Drawing.Point(314, 93);
            this.sendTestlbl.Name = "sendTestlbl";
            this.sendTestlbl.Size = new System.Drawing.Size(0, 13);
            this.sendTestlbl.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(445, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 45);
            this.label11.TabIndex = 9;
            this.label11.Text = "Przekroczenie";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.label10, 3);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(225, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 45);
            this.label10.TabIndex = 8;
            this.label10.Text = "Pomiar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(225, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 45);
            this.label9.TabIndex = 6;
            this.label9.Text = "Brak \r\nprzekroczenia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(115, 49);
            this.label8.Name = "label8";
            this.tableLayoutPanel1.SetRowSpan(this.label8, 2);
            this.label8.Size = new System.Drawing.Size(102, 92);
            this.label8.TabIndex = 5;
            this.label8.Text = "Brak pomiaru";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTol
            // 
            this.lbTol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTol.Location = new System.Drawing.Point(335, 96);
            this.lbTol.Name = "lbTol";
            this.lbTol.Size = new System.Drawing.Size(102, 45);
            this.lbTol.TabIndex = 7;
            this.lbTol.Text = "Tolerancja";
            this.lbTol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Koło";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(5, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 45);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cyfry";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(5, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 45);
            this.label6.TabIndex = 3;
            this.label6.Text = "Linia";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(5, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 46);
            this.label7.TabIndex = 4;
            this.label7.Text = "Napis";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbNPP, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbNPT, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbNPBP, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbNBP, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbLPP, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbLPT, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbLPBP, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbLBP, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbCPP, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCPT, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCPBP, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCBP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbKPP, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbKPT, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbKPBP, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbKBP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTol, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTbName, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 332);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // lbNPP
            // 
            this.lbNPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNPP.Location = new System.Drawing.Point(445, 284);
            this.lbNPP.Name = "lbNPP";
            this.lbNPP.Size = new System.Drawing.Size(105, 46);
            this.lbNPP.TabIndex = 27;
            this.lbNPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNPT
            // 
            this.lbNPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNPT.Location = new System.Drawing.Point(335, 284);
            this.lbNPT.Name = "lbNPT";
            this.lbNPT.Size = new System.Drawing.Size(102, 46);
            this.lbNPT.TabIndex = 26;
            this.lbNPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNPBP
            // 
            this.lbNPBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNPBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNPBP.Location = new System.Drawing.Point(225, 284);
            this.lbNPBP.Name = "lbNPBP";
            this.lbNPBP.Size = new System.Drawing.Size(102, 46);
            this.lbNPBP.TabIndex = 25;
            this.lbNPBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNBP
            // 
            this.lbNBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNBP.Location = new System.Drawing.Point(115, 284);
            this.lbNBP.Name = "lbNBP";
            this.lbNBP.Size = new System.Drawing.Size(102, 46);
            this.lbNBP.TabIndex = 24;
            this.lbNBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLPP
            // 
            this.lbLPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLPP.Location = new System.Drawing.Point(445, 237);
            this.lbLPP.Name = "lbLPP";
            this.lbLPP.Size = new System.Drawing.Size(105, 45);
            this.lbLPP.TabIndex = 23;
            this.lbLPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLPT
            // 
            this.lbLPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLPT.Location = new System.Drawing.Point(335, 237);
            this.lbLPT.Name = "lbLPT";
            this.lbLPT.Size = new System.Drawing.Size(102, 45);
            this.lbLPT.TabIndex = 22;
            this.lbLPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLPBP
            // 
            this.lbLPBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLPBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLPBP.Location = new System.Drawing.Point(225, 237);
            this.lbLPBP.Name = "lbLPBP";
            this.lbLPBP.Size = new System.Drawing.Size(102, 45);
            this.lbLPBP.TabIndex = 21;
            this.lbLPBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLBP
            // 
            this.lbLBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLBP.Location = new System.Drawing.Point(115, 237);
            this.lbLBP.Name = "lbLBP";
            this.lbLBP.Size = new System.Drawing.Size(102, 45);
            this.lbLBP.TabIndex = 20;
            this.lbLBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCPP
            // 
            this.lbCPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCPP.Location = new System.Drawing.Point(445, 190);
            this.lbCPP.Name = "lbCPP";
            this.lbCPP.Size = new System.Drawing.Size(105, 45);
            this.lbCPP.TabIndex = 19;
            this.lbCPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCPT
            // 
            this.lbCPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCPT.Location = new System.Drawing.Point(335, 190);
            this.lbCPT.Name = "lbCPT";
            this.lbCPT.Size = new System.Drawing.Size(102, 45);
            this.lbCPT.TabIndex = 18;
            this.lbCPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCPBP
            // 
            this.lbCPBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCPBP.Location = new System.Drawing.Point(225, 190);
            this.lbCPBP.Name = "lbCPBP";
            this.lbCPBP.Size = new System.Drawing.Size(102, 45);
            this.lbCPBP.TabIndex = 17;
            this.lbCPBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCBP
            // 
            this.lbCBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCBP.Location = new System.Drawing.Point(115, 190);
            this.lbCBP.Name = "lbCBP";
            this.lbCBP.Size = new System.Drawing.Size(102, 45);
            this.lbCBP.TabIndex = 16;
            this.lbCBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKPP
            // 
            this.lbKPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKPP.Location = new System.Drawing.Point(445, 143);
            this.lbKPP.Name = "lbKPP";
            this.lbKPP.Size = new System.Drawing.Size(105, 45);
            this.lbKPP.TabIndex = 15;
            this.lbKPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKPT
            // 
            this.lbKPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKPT.Location = new System.Drawing.Point(335, 143);
            this.lbKPT.Name = "lbKPT";
            this.lbKPT.Size = new System.Drawing.Size(102, 45);
            this.lbKPT.TabIndex = 14;
            this.lbKPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKPBP
            // 
            this.lbKPBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKPBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKPBP.Location = new System.Drawing.Point(225, 143);
            this.lbKPBP.Name = "lbKPBP";
            this.lbKPBP.Size = new System.Drawing.Size(102, 45);
            this.lbKPBP.TabIndex = 13;
            this.lbKPBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKBP
            // 
            this.lbKBP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKBP.Location = new System.Drawing.Point(115, 143);
            this.lbKBP.Name = "lbKBP";
            this.lbKBP.Size = new System.Drawing.Size(102, 45);
            this.lbKBP.TabIndex = 12;
            this.lbKBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(5, 2);
            this.label12.Name = "label12";
            this.tableLayoutPanel1.SetRowSpan(this.label12, 3);
            this.label12.Size = new System.Drawing.Size(102, 139);
            this.label12.TabIndex = 11;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTbName
            // 
            this.lbTbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lbTbName, 4);
            this.lbTbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTbName.Location = new System.Drawing.Point(115, 2);
            this.lbTbName.Name = "lbTbName";
            this.lbTbName.Size = new System.Drawing.Size(435, 45);
            this.lbTbName.TabIndex = 10;
            this.lbTbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(172, 12);
            this.progressBar1.TabIndex = 27;
            // 
            // lbOK
            // 
            this.lbOK.AutoSize = true;
            this.lbOK.Enabled = false;
            this.lbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOK.ForeColor = System.Drawing.Color.Lime;
            this.lbOK.Location = new System.Drawing.Point(353, 59);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(24, 24);
            this.lbOK.TabIndex = 28;
            this.lbOK.Text = "V";
            // 
            // lbNOK
            // 
            this.lbNOK.AutoSize = true;
            this.lbNOK.Enabled = false;
            this.lbNOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNOK.ForeColor = System.Drawing.Color.Red;
            this.lbNOK.Location = new System.Drawing.Point(383, 59);
            this.lbNOK.Name = "lbNOK";
            this.lbNOK.Size = new System.Drawing.Size(25, 24);
            this.lbNOK.TabIndex = 29;
            this.lbNOK.Text = "X";
            // 
            // chN4
            // 
            this.chN4.AutoSize = true;
            this.chN4.Location = new System.Drawing.Point(482, 5);
            this.chN4.Name = "chN4";
            this.chN4.Size = new System.Drawing.Size(66, 17);
            this.chN4.TabIndex = 30;
            this.chN4.Text = "MP-DP4";
            this.chN4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(597, 476);
            this.Controls.Add(this.chN4);
            this.Controls.Add(this.lbNOK);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sendTestlbl);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.btnWyb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtests);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tester radaru";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.ComboBox cbtests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWyb;
        private System.Windows.Forms.Label connect;
        private System.Windows.Forms.Label sendTestlbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbNPP;
        private System.Windows.Forms.Label lbNPT;
        private System.Windows.Forms.Label lbNPBP;
        private System.Windows.Forms.Label lbNBP;
        private System.Windows.Forms.Label lbLPP;
        private System.Windows.Forms.Label lbLPT;
        private System.Windows.Forms.Label lbLPBP;
        private System.Windows.Forms.Label lbLBP;
        private System.Windows.Forms.Label lbCPP;
        private System.Windows.Forms.Label lbCPT;
        private System.Windows.Forms.Label lbCPBP;
        private System.Windows.Forms.Label lbCBP;
        private System.Windows.Forms.Label lbKPP;
        private System.Windows.Forms.Label lbKPT;
        private System.Windows.Forms.Label lbKPBP;
        private System.Windows.Forms.Label lbKBP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTbName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Label lbNOK;
        private System.Windows.Forms.CheckBox chN4;
    }
}

