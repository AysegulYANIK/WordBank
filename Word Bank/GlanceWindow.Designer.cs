
namespace Word_Bank
{
    partial class GlanceWindow
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
            this.pronounce = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phonetics = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.TextBox();
            this.meaning = new System.Windows.Forms.TextBox();
            this.sentences = new System.Windows.Forms.TextBox();
            this.collocations = new System.Windows.Forms.TextBox();
            this.synonym = new System.Windows.Forms.Label();
            this.synonyms = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.exception = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pronounce
            // 
            this.pronounce.Location = new System.Drawing.Point(312, 15);
            this.pronounce.Name = "pronounce";
            this.pronounce.Size = new System.Drawing.Size(100, 25);
            this.pronounce.TabIndex = 0;
            this.pronounce.Text = "pronounce";
            this.pronounce.UseVisualStyleBackColor = true;
            this.pronounce.Click += new System.EventHandler(this.pronounce_Click);
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(102, 18);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(204, 20);
            this.word.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "meaning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sentences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "collocations";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConnection.ForeColor = System.Drawing.Color.LightCoral;
            this.lblConnection.Location = new System.Drawing.Point(12, 562);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(44, 16);
            this.lblConnection.TabIndex = 9;
            this.lblConnection.Text = "IIIIIIIII";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "word";
            // 
            // phonetics
            // 
            this.phonetics.Location = new System.Drawing.Point(102, 44);
            this.phonetics.Name = "phonetics";
            this.phonetics.Size = new System.Drawing.Size(204, 20);
            this.phonetics.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "phonetics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "word type";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(102, 73);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(204, 20);
            this.type.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "difficulty";
            // 
            // difficulty
            // 
            this.difficulty.Location = new System.Drawing.Point(102, 102);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(204, 20);
            this.difficulty.TabIndex = 16;
            // 
            // meaning
            // 
            this.meaning.Location = new System.Drawing.Point(102, 128);
            this.meaning.Multiline = true;
            this.meaning.Name = "meaning";
            this.meaning.Size = new System.Drawing.Size(310, 108);
            this.meaning.TabIndex = 17;
            // 
            // sentences
            // 
            this.sentences.Location = new System.Drawing.Point(102, 242);
            this.sentences.Multiline = true;
            this.sentences.Name = "sentences";
            this.sentences.Size = new System.Drawing.Size(310, 108);
            this.sentences.TabIndex = 18;
            // 
            // collocations
            // 
            this.collocations.Location = new System.Drawing.Point(100, 356);
            this.collocations.Multiline = true;
            this.collocations.Name = "collocations";
            this.collocations.Size = new System.Drawing.Size(312, 108);
            this.collocations.TabIndex = 19;
            // 
            // synonym
            // 
            this.synonym.AutoSize = true;
            this.synonym.Location = new System.Drawing.Point(14, 470);
            this.synonym.Name = "synonym";
            this.synonym.Size = new System.Drawing.Size(59, 13);
            this.synonym.TabIndex = 20;
            this.synonym.Text = "synonym(s)";
            // 
            // synonyms
            // 
            this.synonyms.Location = new System.Drawing.Point(100, 470);
            this.synonyms.Multiline = true;
            this.synonyms.Name = "synonyms";
            this.synonyms.Size = new System.Drawing.Size(312, 108);
            this.synonyms.TabIndex = 21;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(100, 584);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 25);
            this.save.TabIndex = 22;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.ForeColor = System.Drawing.Color.Green;
            this.lblSave.Location = new System.Drawing.Point(99, 628);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(75, 13);
            this.lblSave.TabIndex = 23;
            this.lblSave.Text = "Recording List";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(427, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1387, 692);
            this.dataGridView.TabIndex = 24;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(206, 584);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 25);
            this.update.TabIndex = 25;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // exception
            // 
            this.exception.AutoSize = true;
            this.exception.ForeColor = System.Drawing.Color.Coral;
            this.exception.Location = new System.Drawing.Point(99, 660);
            this.exception.Name = "exception";
            this.exception.Size = new System.Drawing.Size(90, 13);
            this.exception.TabIndex = 26;
            this.exception.Text = "Detail Exception :";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(312, 586);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 25);
            this.delete.TabIndex = 27;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // GlanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 861);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exception);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.save);
            this.Controls.Add(this.synonyms);
            this.Controls.Add(this.synonym);
            this.Controls.Add(this.collocations);
            this.Controls.Add(this.sentences);
            this.Controls.Add(this.meaning);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phonetics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word);
            this.Controls.Add(this.pronounce);
            this.Name = "GlanceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORD BANK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GlanceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pronounce;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phonetics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox difficulty;
        private System.Windows.Forms.TextBox meaning;
        private System.Windows.Forms.TextBox sentences;
        private System.Windows.Forms.TextBox collocations;
        private System.Windows.Forms.Label synonym;
        private System.Windows.Forms.TextBox synonyms;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label exception;
        private System.Windows.Forms.Button delete;
    }
}

