using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Collections.ObjectModel;
using System.IO;

namespace Word_Bank
{
    public partial class GlanceWindow : Form
    {
        private Timer timer;

        public GlanceWindow()
        {
            InitializeComponent();
            lblSave.Visible = false;
            exception.Visible = false;
            InitTimer();
        }

        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 5000; // in miliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSave.Visible = false;
            exception.Visible = false;
        }

        public void selectData()
        {
            Database db = new Database();
            dataGridView.DataSource = db.selectCmd("Select * from WordList");
            dataGridView.ClearSelection();
        }

        private void pronounce_Click(object sender, EventArgs e)
        {
            string word_tobe_pronounced = word.Text;

            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(word_tobe_pronounced);
        }

        private void GlanceWindow_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                lblConnection.ForeColor = Color.LightGreen;
                selectData();
            }
            catch (Exception except)
            {
                lblConnection.ForeColor = Color.Coral;

                exception.Text += except.ToString();
                exception.Visible = true;
            }
            dataGridView.ClearSelection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO [WordList]([word], [phonetics], [W_type], [w_level], [meaning], [collocations], [insentence], [synonym_s]) VALUES('" + word.Text + "', 'ə-ˈbau̇t', 'adverb', 'beginner', 'reasonably close to, almost', 'bring about, come about, go about, talk about, set about, think about, cast about, how about, lie about', 'I asked Tom about his new book. I want to talk to him about it. It is about time we went to bed.Let me tell you about the case.' , 'around, round')";
                Database db = new Database();
                if (db.createNewItem(sql) > 0)
                {
                    lblSave.Text = "Record has been saved.";
                    lblSave.Visible = true;
                    lblSave.ForeColor = Color.Coral;
                    selectData();
                }
            }
            catch (Exception exp)
            {
                lblSave.Text = "An error has been occured.";
                lblSave.ForeColor = Color.Coral;
                lblSave.Visible = true;

                exception.Text += exp.ToString();
                exception.Visible = true;

                selectData();
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecteedRows = dataGridView.Rows[index];

            word.Text = selecteedRows.Cells[0].Value.ToString();
            phonetics.Text = selecteedRows.Cells[1].Value.ToString();
            type.Text = selecteedRows.Cells[2].Value.ToString();
            difficulty.Text = selecteedRows.Cells[3].Value.ToString();
            meaning.Text = selecteedRows.Cells[4].Value.ToString();
            collocations.Text = selecteedRows.Cells[5].Value.ToString();
            sentences.Text = selecteedRows.Cells[6].Value.ToString();
            synonyms.Text = selecteedRows.Cells[7].Value.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE [WordList] SET [phonetics]='"+phonetics.Text+"', [W_type]='"+type.Text+"', [w_level]='"+difficulty.Text+"', [meaning]='"+meaning.Text+"' , [collocations]='"+collocations.Text+"', [insentence]='"+sentences.Text+"', [synonym_s]='"+synonyms.Text+"' WHERE [word]='"+word.Text+"'";
                Database db = new Database();
                if (db.createNewItem(sql) > 0)
                {
                    lblSave.Text = "Record has been updated.";
                    lblSave.Visible = true;
                    selectData();
                }
            }
            catch(Exception exp)
            {
                lblSave.Text = "An error has been occured : " + exp;
                lblSave.ForeColor = Color.Coral;
                lblSave.Visible = true;


                exception.Text += exp.ToString();
                exception.Visible = true;

                selectData();
            }

            if (word.Text == "")
            {
                lblSave.Text = "An error has been occured.";
                lblSave.ForeColor = Color.Coral;
                lblSave.Visible = true;

                exception.Text += " No word selected.  ";
                exception.Visible = true;

                selectData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM [WordList] WHERE [word]='" + word.Text + "'";
                Database db = new Database();
                if (db.createNewItem(sql) > 0)
                {
                    lblSave.Text = "The record has been deleted.";
                    lblSave.Visible = true;
                    selectData();
                }
            }
            catch (Exception exp)
            {
                lblSave.Text = "An error has been occured : " + exp;
                lblSave.ForeColor = Color.Coral;
                lblSave.Visible = true;


                exception.Text += exp.ToString();
                exception.Visible = true;

                selectData();
            }

            if (word.Text == "")
            {
                lblSave.Text = "An error has been occured.";
                lblSave.ForeColor = Color.Coral;
                lblSave.Visible = true;

                exception.Text += " No word selected.  ";
                exception.Visible = true;

                selectData();
            }
        }
    }
}
