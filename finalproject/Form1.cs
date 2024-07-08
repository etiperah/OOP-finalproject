using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {
        bool flagManager = false, flagRomance = false, flagBiography = false;
        private Game game;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            panel_left.Controls.Add(button_books);
            panel_left.Controls.Add(button_DVD);
            panel_left.Controls.Add(button_books);
            textBox_managerpassword.UseSystemPasswordChar = true;
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Book>();
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Romance>();
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Biography>();
            dataGridViews_dvd.DataSource = LibraryManager.GetSpecificItem<DVD>();
            this.FormClosed += LibraryManager.SaveLibraryItems;
            ControlBox = false;
            new LibraryManager();
            flagManager = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_genrebook.Items.Add("Romance");
            comboBox_genrebook.Items.Add("Biography");
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_books_Click(object sender, EventArgs e)
        {
            panel_books.Visible = true;
            button_addbook.Visible = true;
            button_removebook.Visible = true;
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Book>();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panel_about_us.Visible = false;
            panel_addbook.Visible = false;
            panel_addDVD.Visible = false;
            panel_biography.Visible = false;
            panel_books.Visible = false;
            panel_DVD.Visible = false;
            panel_login.Visible = false;
            panel_manager.Visible = false;
            panel_romance.Visible = false;
            panel_home.Visible = true;

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string id = textBox_ID.Text;
            if ((name == "Eti" || name == "Adi") && (id == "323838094" || id == "206447708"))
            {
                panel_manager.Visible = true;
                panel_login.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid username or ID");
                textBox_name.Clear();
                textBox_ID.Clear();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_addbook.Visible = false;
            panel_addDVD.Visible = false;
            panel_biography.Visible = false;
            panel_books.Visible = false;
            panel_DVD.Visible = false;
            panel_manager.Visible = false;
            panel_romance.Visible = false;
            panel_about_us.Visible = false;

        }

        private void panel_books_VisibleChanged(object sender, EventArgs e)
        {
            if (flagManager == true)
            {
                button_addbook.Visible = true;
                button_removebook.Visible = true;
            }
        }

        private void button_about_us_Click(object sender, EventArgs e)
        {
            panel_about_us.Visible = true;
            panel_addbook.Visible = false;
            panel_addDVD.Visible = false;
            panel_biography.Visible = false;
            panel_books.Visible = false;
            panel_DVD.Visible = false;
            panel_login.Visible = false;
            panel_manager.Visible = false;
            panel_romance.Visible = false;
        }

        private void button_DVD_Click(object sender, EventArgs e)
        {
            dataGridViews_dvd.DataSource = LibraryManager.GetSpecificItem<DVD>();
            panel_DVD.Visible = true;
            panel_about_us.Visible = false;
            panel_addbook.Visible = false;
            panel_biography.Visible = false;
            panel_addDVD.Visible = false;
            panel_books.Visible = false;
            panel_romance.Visible = false;
            panel_login.Visible = false;
            if (flagManager)
            {
                button_adddvd.Visible = true;
                button_removedvd.Visible = true;
            }
        }

        private void comboBox_genrebook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox_genrebook = (ComboBox)sender;

            string selectedValue = comboBox_genrebook.SelectedItem.ToString();
            if (selectedValue == "Romance")
            {

                panel_romance.Visible = true;
                panel_biography.Visible = false;
                flagRomance = true;
            }
            else
            {
                panel_biography.Visible = true;
                panel_romance.Visible = false;
                flagBiography = true;
            }
        }


        private void button_addbook_Click(object sender, EventArgs e)
        {
            panel_books.Visible = false;
            panel_addbook.Visible = true;
            button_addbook.Visible = false;
            button_removebook.Visible = false;
        }


        private bool IsString(string value)
        {
            return value.All(char.IsLetter);
        }

        private void button_adddvd_Click(object sender, EventArgs e)
        {
            panel_addDVD.Visible = true;
            panel_DVD.Visible = false;
            button_adddvd.Visible = false;
            button_removedvd.Visible = false;
        }

        private void button_addRbook_Click(object sender, EventArgs e)
        {
            if (!isValidate())
            {
                MessageBox.Show("Error");
                return;
            }

            if (flagRomance)
            {
                string title = textBox_titlebook.Text;
                string publisher = textBox_publisherbook.Text;
                int publicationYear = Int32.Parse(textBox_publicationyear.Text);
                int borrowerID = 0;
                bool isBorrowed = false;
                string genre = "Romance";
                string author = textBox_authorbook.Text;
                int numofpages = Int32.Parse(textBox_numberofpages.Text);
                string couple = textBox_couple.Text;
                bool happyEnding = checkBox_happyending.Checked;
                Romance r = new Romance(title, publisher, publicationYear, borrowerID, isBorrowed,
                 author, genre, numofpages, couple, happyEnding);
                MessageBox.Show(r.addedToGrid());
                LibraryManager.AddItem(r);
                dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Book>();
                clearBookForm();
                panel_addbook.Visible = false;
                panel_books.Visible = true;
            }
            else
            {
                string title = textBox_titlebook.Text;
                string publisher = textBox_publisherbook.Text;
                int publicationYear = Int32.Parse(textBox_publicationyear.Text);
                int borrowerID = 0;
                bool isBorrowed = false;
                string genre = "Biography";
                string author = textBox_authorbook.Text;
                int numofpages = Int32.Parse(textBox_numberofpages.Text);
                string subject = textBox_subjectbook.Text;
                Biography b = new Biography(title, publisher, publicationYear, borrowerID, isBorrowed, author, genre, numofpages, subject);
                MessageBox.Show(b.addedToGrid());
                LibraryManager.AddItem(b);
                dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Book>();
                clearBookForm();
                panel_addbook.Visible = false;
                panel_books.Visible = true;
            }
            panel_biography.Visible = false;
            panel_romance.Visible = false;
            flagRomance = false;
            flagBiography = false;
        }

        private void clearBookForm()
        {
            textBox_titlebook.Clear();
            textBox_publisherbook.Clear();
            textBox_publicationyear.Clear();
            comboBox_genrebook.ResetText();
            textBox_authorbook.Clear();
            textBox_numberofpages.Clear();
            textBox_couple.Clear();
            checkBox_happyending.Checked = false;
            textBox_subjectbook.Clear();
            textBox_titleDVD.Clear();
            textBox_publisherDVD.Clear();
            textBox_publicationyearDVD.Clear();
            textBox_director.Clear();
            textBox_durationinminutes.Clear();
        }
        private bool isValidate()
        {
            int publicationYear;
            int numOfPages;

            if (comboBox_genrebook.SelectedItem == null)
            {
                return false;
            }
            if (flagRomance)
            {
                string couple = textBox_couple.Text.Trim();
                if (string.IsNullOrEmpty(couple))
                {
                    return false;
                }
                try
                {
                    Int32.Parse(couple);
                    return false;
                }
                catch
                {

                }
            }
            if (flagBiography)
            {
                string subject = textBox_subjectbook.Text.Trim();
                if (string.IsNullOrEmpty(subject))
                    return false;
                try
                {
                    Int32.Parse(subject);
                    return false;
                }
                catch
                {

                }

            }

            try
            {
                numOfPages = Int32.Parse(textBox_numberofpages.Text);
                publicationYear = Int32.Parse(textBox_publicationyear.Text);


            }
            catch
            {
                return false;
            }

            string title = textBox_titlebook.Text.Trim();
            string author = textBox_authorbook.Text.Trim();
            string publisher = textBox_publisherbook.Text.Trim();
            string genre = comboBox_genrebook.SelectedItem.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author)
                 || string.IsNullOrEmpty(publisher))
            {
                return false;
            }

            try
            {
                Int32.Parse(title);
                Int32.Parse(author);
                Int32.Parse(publisher);
                return false;
            }
            catch
            {

            }
            return true;
        }

        private void button_removebook_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_books.SelectedRows[0].Index;
            Book bookToRemove = (Book)dataGridView_books.Rows[rowIndex].DataBoundItem;

            LibraryManager.RemoveItem(bookToRemove);
            dataGridView_books.Rows.RemoveAt(rowIndex);

        }

        private void radioButton_romance_CheckedChanged(object sender, EventArgs e)
        {

            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Romance>();
            dataGridView_books.Refresh();
        }

        private void radioButton_biography_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Biography>();
            dataGridView_books.Refresh();
        }

        private void button_removedvd_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViews_dvd.SelectedRows[0].Index;
            DVD dvdToRemove = (DVD)dataGridViews_dvd.Rows[rowIndex].DataBoundItem;

            LibraryManager.RemoveItem(dvdToRemove);
            dataGridViews_dvd.Rows.RemoveAt(rowIndex);
        }

        private void checkBox_sortDVD_CheckedChanged(object sender, EventArgs e)
        {
            LibraryManager.SortByPublicationYear();
            dataGridViews_dvd.DataSource = LibraryManager.GetSpecificItem<DVD>();
        }

        private void button_addRDVD_Click(object sender, EventArgs e)
        {
            string title = textBox_titleDVD.Text;
            string publisher = textBox_publisherDVD.Text;
            int publicationYear = Int32.Parse(textBox_publicationyearDVD.Text);
            int borrowerID = 0;
            bool isBorrowed = false;
            string director = textBox_director.Text;
            int durationInMin = Int32.Parse(textBox_durationinminutes.Text);
            DVD dvd = new DVD(title, publisher, publicationYear, borrowerID, isBorrowed, director, durationInMin);
            LibraryManager.AddItem(dvd);
            MessageBox.Show(dvd.addedToGrid());
            clearBookForm();
            dataGridViews_dvd.DataSource = LibraryManager.GetSpecificItem<DVD>();
            panel_addDVD.Visible = false;
            panel_DVD.Visible = true;
            button_adddvd.Visible = true;
            button_removedvd.Visible = true;
        }

        private void checkBox_sortBook_CheckedChanged(object sender, EventArgs e)
        {
            LibraryManager.SortByPublicationYear();
            dataGridView_books.DataSource = LibraryManager.GetSpecificItem<Book>();
        }

        private void pictureBox_red_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want exit?", "Alert!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("GOOD-BYE!");
                Close();
            }
            if (res == DialogResult.No || res == DialogResult.Cancel)
                return;
        }

        private void button_game_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.Show();
        }

        private void dataGridView_books_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // LibraryManager.SaveLibraryItems;
        }

        private void textBox_managerpassword_KeyUp(object sender, KeyEventArgs e)
        {
            string password = textBox_managerpassword.Text;
            if (e.KeyCode == Keys.Enter)
            {

                if (password == "hello")
                {
                    panel_manager.Visible = false;
                    flagManager = true;
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    textBox_managerpassword.Clear();
                }
            }


        }

        private void panel_DVD_VisibleChanged(object sender, EventArgs e)
        {

            if (flagManager == true)
            {
                button_adddvd.Visible = true;
                button_removedvd.Visible = true;
            }
        }
    }
}




