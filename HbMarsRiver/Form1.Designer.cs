namespace HbMarsRiverMetinD
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
            this.ddl_Direction = new System.Windows.Forms.ComboBox();
            this.btn_Move = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txt_VehicleYDim = new System.Windows.Forms.TextBox();
            this.txt_AreaYDim = new System.Windows.Forms.TextBox();
            this.txt_VehicleXDim = new System.Windows.Forms.TextBox();
            this.txt_AreaXDim = new System.Windows.Forms.TextBox();
            this.lbl_LastStationMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_LastStation = new System.Windows.Forms.Label();
            this.lbl_VehicleYDim = new System.Windows.Forms.Label();
            this.lbl_AreaYDim = new System.Windows.Forms.Label();
            this.lbl_VehicleXDim = new System.Windows.Forms.Label();
            this.lbl_AreaXDim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddl_Direction
            // 
            this.ddl_Direction.FormattingEnabled = true;
            this.ddl_Direction.Location = new System.Drawing.Point(250, 150);
            this.ddl_Direction.Margin = new System.Windows.Forms.Padding(4);
            this.ddl_Direction.Name = "ddl_Direction";
            this.ddl_Direction.Size = new System.Drawing.Size(160, 24);
            this.ddl_Direction.TabIndex = 17;
            this.ddl_Direction.SelectionChangeCommitted += new System.EventHandler(this.ddl_Direction_SelectionChangeCommitted);
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(398, 292);
            this.btn_Move.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(152, 28);
            this.btn_Move.TabIndex = 21;
            this.btn_Move.Text = "İlerle";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Visible = false;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(211, 292);
            this.btn_Left.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(152, 28);
            this.btn_Left.TabIndex = 20;
            this.btn_Left.Text = "Sola Dön";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Visible = false;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(39, 292);
            this.btn_Right.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(152, 28);
            this.btn_Right.TabIndex = 19;
            this.btn_Right.Text = "Sağa Dön";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Visible = false;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(263, 183);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(100, 28);
            this.btn_Create.TabIndex = 18;
            this.btn_Create.Text = "Alanı Oluştur";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_VehicleYDim
            // 
            this.txt_VehicleYDim.Location = new System.Drawing.Point(250, 118);
            this.txt_VehicleYDim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VehicleYDim.Name = "txt_VehicleYDim";
            this.txt_VehicleYDim.Size = new System.Drawing.Size(163, 22);
            this.txt_VehicleYDim.TabIndex = 16;
            this.txt_VehicleYDim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_VehicleYDim_KeyPress);
            // 
            // txt_AreaYDim
            // 
            this.txt_AreaYDim.Location = new System.Drawing.Point(250, 45);
            this.txt_AreaYDim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AreaYDim.Name = "txt_AreaYDim";
            this.txt_AreaYDim.Size = new System.Drawing.Size(163, 22);
            this.txt_AreaYDim.TabIndex = 14;
            this.txt_AreaYDim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AreaYDim_KeyPress);
            // 
            // txt_VehicleXDim
            // 
            this.txt_VehicleXDim.Location = new System.Drawing.Point(250, 86);
            this.txt_VehicleXDim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VehicleXDim.Name = "txt_VehicleXDim";
            this.txt_VehicleXDim.Size = new System.Drawing.Size(163, 22);
            this.txt_VehicleXDim.TabIndex = 15;
            this.txt_VehicleXDim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_VehicleXDim_KeyPress);
            // 
            // txt_AreaXDim
            // 
            this.txt_AreaXDim.Location = new System.Drawing.Point(250, 13);
            this.txt_AreaXDim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AreaXDim.Name = "txt_AreaXDim";
            this.txt_AreaXDim.Size = new System.Drawing.Size(163, 22);
            this.txt_AreaXDim.TabIndex = 13;
            this.txt_AreaXDim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AreaXDim_KeyPress);
            // 
            // lbl_LastStationMessage
            // 
            this.lbl_LastStationMessage.AutoSize = true;
            this.lbl_LastStationMessage.Location = new System.Drawing.Point(193, 363);
            this.lbl_LastStationMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastStationMessage.Name = "lbl_LastStationMessage";
            this.lbl_LastStationMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_LastStationMessage.TabIndex = 11;
            this.lbl_LastStationMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aracın Yönü:";
            // 
            // lbl_LastStation
            // 
            this.lbl_LastStation.AutoSize = true;
            this.lbl_LastStation.Location = new System.Drawing.Point(35, 363);
            this.lbl_LastStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastStation.Name = "lbl_LastStation";
            this.lbl_LastStation.Size = new System.Drawing.Size(135, 17);
            this.lbl_LastStation.TabIndex = 8;
            this.lbl_LastStation.Text = "Aracın Son Durumu:";
            this.lbl_LastStation.Visible = false;
            // 
            // lbl_VehicleYDim
            // 
            this.lbl_VehicleYDim.AutoSize = true;
            this.lbl_VehicleYDim.Location = new System.Drawing.Point(22, 128);
            this.lbl_VehicleYDim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VehicleYDim.Name = "lbl_VehicleYDim";
            this.lbl_VehicleYDim.Size = new System.Drawing.Size(129, 17);
            this.lbl_VehicleYDim.TabIndex = 7;
            this.lbl_VehicleYDim.Text = "Aracın Y Kordinatı :";
            // 
            // lbl_AreaYDim
            // 
            this.lbl_AreaYDim.AutoSize = true;
            this.lbl_AreaYDim.Location = new System.Drawing.Point(22, 55);
            this.lbl_AreaYDim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AreaYDim.Name = "lbl_AreaYDim";
            this.lbl_AreaYDim.Size = new System.Drawing.Size(192, 17);
            this.lbl_AreaYDim.TabIndex = 6;
            this.lbl_AreaYDim.Text = "Alanın Y Kordinatı Uzunluğu :";
            // 
            // lbl_VehicleXDim
            // 
            this.lbl_VehicleXDim.AutoSize = true;
            this.lbl_VehicleXDim.Location = new System.Drawing.Point(22, 89);
            this.lbl_VehicleXDim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VehicleXDim.Name = "lbl_VehicleXDim";
            this.lbl_VehicleXDim.Size = new System.Drawing.Size(133, 17);
            this.lbl_VehicleXDim.TabIndex = 12;
            this.lbl_VehicleXDim.Text = "Aracın X Kordinatı  :";
            // 
            // lbl_AreaXDim
            // 
            this.lbl_AreaXDim.AutoSize = true;
            this.lbl_AreaXDim.Location = new System.Drawing.Point(22, 17);
            this.lbl_AreaXDim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AreaXDim.Name = "lbl_AreaXDim";
            this.lbl_AreaXDim.Size = new System.Drawing.Size(192, 17);
            this.lbl_AreaXDim.TabIndex = 5;
            this.lbl_AreaXDim.Text = "Alanın X Kordinatı Uzunluğu :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddl_Direction);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_VehicleYDim);
            this.Controls.Add(this.txt_AreaYDim);
            this.Controls.Add(this.txt_VehicleXDim);
            this.Controls.Add(this.txt_AreaXDim);
            this.Controls.Add(this.lbl_LastStationMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_LastStation);
            this.Controls.Add(this.lbl_VehicleYDim);
            this.Controls.Add(this.lbl_AreaYDim);
            this.Controls.Add(this.lbl_VehicleXDim);
            this.Controls.Add(this.lbl_AreaXDim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_Direction;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_VehicleYDim;
        private System.Windows.Forms.TextBox txt_AreaYDim;
        private System.Windows.Forms.TextBox txt_VehicleXDim;
        private System.Windows.Forms.TextBox txt_AreaXDim;
        private System.Windows.Forms.Label lbl_LastStationMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_LastStation;
        private System.Windows.Forms.Label lbl_VehicleYDim;
        private System.Windows.Forms.Label lbl_AreaYDim;
        private System.Windows.Forms.Label lbl_VehicleXDim;
        private System.Windows.Forms.Label lbl_AreaXDim;
    }
}

