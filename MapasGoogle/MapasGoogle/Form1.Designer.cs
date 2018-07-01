namespace MapasGoogle
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DESTINO_BT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTupdate = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.RouteTXT = new System.Windows.Forms.TextBox();
            this.DisTXT = new System.Windows.Forms.TextBox();
            this.UPRTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddRoubtn = new System.Windows.Forms.Button();
            this.DeleRoubtn = new System.Windows.Forms.Button();
            this.Uproutbtn = new System.Windows.Forms.Button();
            this.Marcadores = new System.Windows.Forms.Button();
            this.ADDconections = new System.Windows.Forms.Button();
            this.DestinyTxt = new System.Windows.Forms.TextBox();
            this.OriginTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dijk = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(1, 10);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(427, 448);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(563, 26);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "ADD";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(563, 87);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "DELETE";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Location = new System.Drawing.Point(462, 31);
            this.txtDescipcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(76, 20);
            this.txtDescipcion.TabIndex = 3;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(462, 92);
            this.txtLatitud.Margin = new System.Windows.Forms.Padding(2);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(76, 20);
            this.txtLatitud.TabIndex = 4;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(462, 154);
            this.txtLongitud.Margin = new System.Windows.Forms.Padding(2);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(76, 20);
            this.txtLongitud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Airport";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitude";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(268, 212);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarRegistro);
            // 
            // DESTINO_BT
            // 
            this.DESTINO_BT.Location = new System.Drawing.Point(563, 212);
            this.DESTINO_BT.Margin = new System.Windows.Forms.Padding(2);
            this.DESTINO_BT.Name = "DESTINO_BT";
            this.DESTINO_BT.Size = new System.Drawing.Size(66, 29);
            this.DESTINO_BT.TabIndex = 13;
            this.DESTINO_BT.Text = "UPDATE";
            this.DESTINO_BT.UseVisualStyleBackColor = true;
            this.DESTINO_BT.Click += new System.EventHandler(this.DESTINO_BT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Update";
            // 
            // TxTupdate
            // 
            this.TxTupdate.Location = new System.Drawing.Point(462, 221);
            this.TxTupdate.Margin = new System.Windows.Forms.Padding(2);
            this.TxTupdate.Name = "TxTupdate";
            this.TxTupdate.Size = new System.Drawing.Size(76, 20);
            this.TxTupdate.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(757, 260);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(249, 211);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(734, 31);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(116, 20);
            this.IDtxt.TabIndex = 17;
            // 
            // RouteTXT
            // 
            this.RouteTXT.Location = new System.Drawing.Point(734, 96);
            this.RouteTXT.Margin = new System.Windows.Forms.Padding(2);
            this.RouteTXT.Name = "RouteTXT";
            this.RouteTXT.Size = new System.Drawing.Size(116, 20);
            this.RouteTXT.TabIndex = 18;
            // 
            // DisTXT
            // 
            this.DisTXT.Location = new System.Drawing.Point(1032, 164);
            this.DisTXT.Margin = new System.Windows.Forms.Padding(2);
            this.DisTXT.Name = "DisTXT";
            this.DisTXT.Size = new System.Drawing.Size(116, 20);
            this.DisTXT.TabIndex = 19;
            // 
            // UPRTXT
            // 
            this.UPRTXT.Location = new System.Drawing.Point(734, 221);
            this.UPRTXT.Margin = new System.Windows.Forms.Padding(2);
            this.UPRTXT.Name = "UPRTXT";
            this.UPRTXT.Size = new System.Drawing.Size(116, 20);
            this.UPRTXT.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Route";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1099, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(731, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Update";
            // 
            // AddRoubtn
            // 
            this.AddRoubtn.Location = new System.Drawing.Point(906, 26);
            this.AddRoubtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddRoubtn.Name = "AddRoubtn";
            this.AddRoubtn.Size = new System.Drawing.Size(66, 29);
            this.AddRoubtn.TabIndex = 25;
            this.AddRoubtn.Text = "ADD";
            this.AddRoubtn.UseVisualStyleBackColor = true;
            this.AddRoubtn.Click += new System.EventHandler(this.AddRoubtn_Click);
            // 
            // DeleRoubtn
            // 
            this.DeleRoubtn.Location = new System.Drawing.Point(906, 87);
            this.DeleRoubtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleRoubtn.Name = "DeleRoubtn";
            this.DeleRoubtn.Size = new System.Drawing.Size(66, 29);
            this.DeleRoubtn.TabIndex = 26;
            this.DeleRoubtn.Text = "DELETE";
            this.DeleRoubtn.UseVisualStyleBackColor = true;
            this.DeleRoubtn.Click += new System.EventHandler(this.DeleRoubtn_Click);
            // 
            // Uproutbtn
            // 
            this.Uproutbtn.Location = new System.Drawing.Point(906, 212);
            this.Uproutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Uproutbtn.Name = "Uproutbtn";
            this.Uproutbtn.Size = new System.Drawing.Size(66, 29);
            this.Uproutbtn.TabIndex = 27;
            this.Uproutbtn.Text = "UPDATE";
            this.Uproutbtn.UseVisualStyleBackColor = true;
            this.Uproutbtn.Click += new System.EventHandler(this.Uproutbtn_Click);
            // 
            // Marcadores
            // 
            this.Marcadores.Location = new System.Drawing.Point(1069, 247);
            this.Marcadores.Margin = new System.Windows.Forms.Padding(2);
            this.Marcadores.Name = "Marcadores";
            this.Marcadores.Size = new System.Drawing.Size(79, 33);
            this.Marcadores.TabIndex = 28;
            this.Marcadores.Text = "MARKERS";
            this.Marcadores.UseVisualStyleBackColor = true;
            this.Marcadores.Click += new System.EventHandler(this.Marcadores_Click);
            // 
            // ADDconections
            // 
            this.ADDconections.Location = new System.Drawing.Point(1069, 210);
            this.ADDconections.Margin = new System.Windows.Forms.Padding(2);
            this.ADDconections.Name = "ADDconections";
            this.ADDconections.Size = new System.Drawing.Size(79, 33);
            this.ADDconections.TabIndex = 29;
            this.ADDconections.Text = "ADD";
            this.ADDconections.UseVisualStyleBackColor = true;
            this.ADDconections.Click += new System.EventHandler(this.ADDconections_Click);
            // 
            // DestinyTxt
            // 
            this.DestinyTxt.Location = new System.Drawing.Point(1032, 96);
            this.DestinyTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DestinyTxt.Name = "DestinyTxt";
            this.DestinyTxt.Size = new System.Drawing.Size(116, 20);
            this.DestinyTxt.TabIndex = 30;
            // 
            // OriginTxt
            // 
            this.OriginTxt.Location = new System.Drawing.Point(1032, 31);
            this.OriginTxt.Margin = new System.Windows.Forms.Padding(2);
            this.OriginTxt.Name = "OriginTxt";
            this.OriginTxt.Size = new System.Drawing.Size(116, 20);
            this.OriginTxt.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1107, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Origin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1099, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Destiny";
            // 
            // Dijk
            // 
            this.Dijk.Location = new System.Drawing.Point(1069, 284);
            this.Dijk.Margin = new System.Windows.Forms.Padding(2);
            this.Dijk.Name = "Dijk";
            this.Dijk.Size = new System.Drawing.Size(79, 33);
            this.Dijk.TabIndex = 34;
            this.Dijk.Text = "DIJKSTRA";
            this.Dijk.UseVisualStyleBackColor = true;
            this.Dijk.Click += new System.EventHandler(this.Dijk_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1032, 321);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(141, 173);
            this.dataGridView3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 505);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Dijk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OriginTxt);
            this.Controls.Add(this.DestinyTxt);
            this.Controls.Add(this.ADDconections);
            this.Controls.Add(this.Marcadores);
            this.Controls.Add(this.Uproutbtn);
            this.Controls.Add(this.DeleRoubtn);
            this.Controls.Add(this.AddRoubtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UPRTXT);
            this.Controls.Add(this.DisTXT);
            this.Controls.Add(this.RouteTXT);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.TxTupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DESTINO_BT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtDescipcion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescipcion;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DESTINO_BT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTupdate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox RouteTXT;
        private System.Windows.Forms.TextBox DisTXT;
        private System.Windows.Forms.TextBox UPRTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddRoubtn;
        private System.Windows.Forms.Button DeleRoubtn;
        private System.Windows.Forms.Button Uproutbtn;
        private System.Windows.Forms.Button Marcadores;
        private System.Windows.Forms.Button ADDconections;
        private System.Windows.Forms.TextBox DestinyTxt;
        private System.Windows.Forms.TextBox OriginTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Dijk;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

