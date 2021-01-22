namespace trelloyetmezmi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gorevId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikinciSec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gorevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birincisec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gorevId3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucuncusec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.GorevId4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorduncusec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.gorevId5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.besincisec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTeknik = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnyenigorev = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevlerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevlerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trelloEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlerBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(301, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn,
            this.gorevId2,
            this.ikinciSec});
            this.dataGridView3.DataSource = this.gorevlerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.Location = new System.Drawing.Point(342, 156);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(287, 426);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // gorevId2
            // 
            this.gorevId2.DataPropertyName = "gorevId";
            this.gorevId2.HeaderText = "gorevId";
            this.gorevId2.Name = "gorevId2";
            this.gorevId2.Visible = false;
            // 
            // ikinciSec
            // 
            this.ikinciSec.FillWeight = 30.45685F;
            this.ikinciSec.HeaderText = "SEÇ";
            this.ikinciSec.Name = "ikinciSec";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gorevDataGridViewTextBoxColumn1,
            this.gorevId,
            this.birincisec});
            this.dataGridView2.DataSource = this.gorevlerBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(7, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(287, 426);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // gorevId
            // 
            this.gorevId.DataPropertyName = "gorevId";
            this.gorevId.HeaderText = "gorevId";
            this.gorevId.Name = "gorevId";
            this.gorevId.Visible = false;
            // 
            // birincisec
            // 
            this.birincisec.FillWeight = 19.86653F;
            this.birincisec.HeaderText = "SEÇ";
            this.birincisec.Name = "birincisec";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gorevDataGridViewTextBoxColumn2,
            this.gorevId3,
            this.ucuncusec});
            this.dataGridView1.DataSource = this.gorevlerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(677, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 433);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gorevId3
            // 
            this.gorevId3.DataPropertyName = "gorevId";
            this.gorevId3.HeaderText = "gorevId";
            this.gorevId3.Name = "gorevId3";
            this.gorevId3.Visible = false;
            // 
            // ucuncusec
            // 
            this.ucuncusec.DataPropertyName = "gorevId";
            this.ucuncusec.FillWeight = 30.45685F;
            this.ucuncusec.HeaderText = "SEÇ";
            this.ucuncusec.Name = "ucuncusec";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.GorevId4,
            this.dorduncusec});
            this.dataGridView4.DataSource = this.gorevlerBindingSource3;
            this.dataGridView4.Location = new System.Drawing.Point(1011, 156);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(287, 433);
            this.dataGridView4.TabIndex = 16;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // GorevId4
            // 
            this.GorevId4.DataPropertyName = "gorevId";
            this.GorevId4.HeaderText = "gorevId";
            this.GorevId4.Name = "GorevId4";
            this.GorevId4.Visible = false;
            // 
            // dorduncusec
            // 
            this.dorduncusec.DataPropertyName = "gorevId";
            this.dorduncusec.FillWeight = 30.45685F;
            this.dorduncusec.HeaderText = "SEÇ";
            this.dorduncusec.Name = "dorduncusec";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(971, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(971, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1307, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1307, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.gorevId5,
            this.besincisec});
            this.dataGridView5.DataSource = this.gorevlerBindingSource4;
            this.dataGridView5.Location = new System.Drawing.Point(1347, 156);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(287, 433);
            this.dataGridView5.TabIndex = 19;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // gorevId5
            // 
            this.gorevId5.DataPropertyName = "gorevId";
            this.gorevId5.HeaderText = "gorevId";
            this.gorevId5.Name = "gorevId5";
            this.gorevId5.Visible = false;
            // 
            // besincisec
            // 
            this.besincisec.DataPropertyName = "gorevId";
            this.besincisec.FillWeight = 30.45685F;
            this.besincisec.HeaderText = "SEÇ";
            this.besincisec.Name = "besincisec";
            // 
            // btnTeknik
            // 
            this.btnTeknik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeknik.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTeknik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeknik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTeknik.Location = new System.Drawing.Point(1407, 12);
            this.btnTeknik.Name = "btnTeknik";
            this.btnTeknik.Size = new System.Drawing.Size(220, 48);
            this.btnTeknik.TabIndex = 22;
            this.btnTeknik.Text = "Teknik Kart";
            this.btnTeknik.UseVisualStyleBackColor = false;
            this.btnTeknik.Click += new System.EventHandler(this.btnTeknik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 635);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 69);
            this.textBox1.TabIndex = 23;
            // 
            // btnyenigorev
            // 
            this.btnyenigorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenigorev.Location = new System.Drawing.Point(342, 635);
            this.btnyenigorev.Name = "btnyenigorev";
            this.btnyenigorev.Size = new System.Drawing.Size(150, 69);
            this.btnyenigorev.TabIndex = 24;
            this.btnyenigorev.Text = "EKLE";
            this.btnyenigorev.UseVisualStyleBackColor = true;
            this.btnyenigorev.Click += new System.EventHandler(this.btnyenigorev_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Yeni Görev Ata:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(677, 635);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 69);
            this.textBox2.TabIndex = 31;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(77, 118);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 32);
            this.btnsil.TabIndex = 32;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(77, 80);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 32);
            this.btnguncelle.TabIndex = 33;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(899, 595);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 34);
            this.textBox3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(750, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Görev Kodu:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gorev";
            this.dataGridViewTextBoxColumn2.FillWeight = 169.5432F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Başarılı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // gorevlerBindingSource4
            // 
            this.gorevlerBindingSource4.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gorev";
            this.dataGridViewTextBoxColumn1.FillWeight = 169.5432F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Test Sonuçları";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gorevlerBindingSource3
            // 
            this.gorevlerBindingSource3.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // gorevDataGridViewTextBoxColumn2
            // 
            this.gorevDataGridViewTextBoxColumn2.DataPropertyName = "gorev";
            this.gorevDataGridViewTextBoxColumn2.FillWeight = 169.5432F;
            this.gorevDataGridViewTextBoxColumn2.HeaderText = "Test Aşaması";
            this.gorevDataGridViewTextBoxColumn2.Name = "gorevDataGridViewTextBoxColumn2";
            // 
            // gorevlerBindingSource2
            // 
            this.gorevlerBindingSource2.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // DataGridViewTextBoxColumn
            // 
            this.DataGridViewTextBoxColumn.DataPropertyName = "gorev";
            this.DataGridViewTextBoxColumn.FillWeight = 169.5432F;
            this.DataGridViewTextBoxColumn.HeaderText = "Başlananlar";
            this.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn";
            // 
            // gorevlerBindingSource
            // 
            this.gorevlerBindingSource.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // gorevDataGridViewTextBoxColumn1
            // 
            this.gorevDataGridViewTextBoxColumn1.DataPropertyName = "gorev";
            this.gorevDataGridViewTextBoxColumn1.FillWeight = 110.5903F;
            this.gorevDataGridViewTextBoxColumn1.HeaderText = "Araştırılanlar-Yapılacaklar";
            this.gorevDataGridViewTextBoxColumn1.Name = "gorevDataGridViewTextBoxColumn1";
            // 
            // gorevlerBindingSource1
            // 
            this.gorevlerBindingSource1.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // trelloEntitiesBindingSource
            // 
            this.trelloEntitiesBindingSource.DataSource = typeof(trelloyetmezmi.trelloEntities);
            // 
            // gorevlerBindingSource5
            // 
            this.gorevlerBindingSource5.DataSource = typeof(trelloyetmezmi.gorevler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1641, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnyenigorev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTeknik);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trelloEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gorevlerBindingSource;
        private System.Windows.Forms.BindingSource gorevlerBindingSource1;
        private System.Windows.Forms.BindingSource trelloEntitiesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gorevlerBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource gorevlerBindingSource3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource gorevlerBindingSource4;
        private System.Windows.Forms.Button btnTeknik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnyenigorev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn birincisec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevId2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ikinciSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevId3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ucuncusec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevId4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dorduncusec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevId5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn besincisec;
        private System.Windows.Forms.BindingSource gorevlerBindingSource5;
    }
}

