using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Image = iTextSharp.text.Image;
using System.Data.Odbc;

namespace Invoice_generator
{
    public partial class Form1 : Form
    {
        

        bool preformat = false;
        Class1 c1 = new Class1();
        string Ttscl = "a";
        string RCW = "b";
        string Nis = "c";
        string Nif = "d";
        string Article = "d";
        string TEL = "e";
        string SALAMA_BANK = "f";
        string ADRESS = "h";
        static Random rnd = new Random();
        int name = rnd.Next(1, 2000);



        //string b = "b";
        DataGridViewComboBoxCell comboBox = new DataGridViewComboBoxCell();
        

        private string imagepath;

        public Form1() {
           

            InitializeComponent();
          
            label29.Visible = false;
            button3.Visible = false;
            label25.Text = Ttscl;
            label21.Text = RCW;
            label22.Text = Nis;
            label23.Text = Nif;
            label24.Text = Article;
            label26.Text = TEL;
            label27.Text = SALAMA_BANK;
            label28.Text = ADRESS;
            label20.Text = name.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label labelSeperator = new Label();
            labelSeperator.AutoSize = false;
            labelSeperator.Height = 2;
            labelSeperator.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(labelSeperator);
        }


        private void btn_Click(object sender, EventArgs e)
        {

        }




        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            preformat = true;
            label29.Visible = true;
            button3.Visible = true;

        }
        public DataGridView getDataview()
        {
            return DataGridView1;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
              /*  comboBox.Items.Add(("Select"));
                comboBox.Items.Add(("p1"));
                comboBox.Items.Add(("p2"));
                comboBox.Items.Add(("p3"));
                int emptyComboBoxRowsIndex = 0;//you change with your index;
                int emptyComboBoxCellIndex = 0;//you change with your index;
                DataGridView1.Rows[emptyComboBoxRowsIndex].Cells[emptyComboBoxCellIndex] = comboBox;*/



                /*ComboBox CB = new ComboBox();
                CB.Items.Add("A");
                CB.Items.Add("B");
                CB.Items.Add("C");
                CB.Items.Add("D");
                CB.Items.Add("E");
                ((DataGridViewComboBoxColumn)DataGridView1.Columns[0]).DataSource = CB.Items;*/
                // DataGridView1.Columns[1].DataSource = CB.Items;
                /*  List<string>[] list= new List<string>[] { };

                  (DataGridView1.Columns[0] as DataGridViewComboBoxColumn).DataSource = new List<string> { "Apples", "Oranges", "Grapes" };

                  for (int i = 0; i < list[0].Count; i++)
                  {
                      int number = DataGridView1.Rows.Add();
                      DataGridView1.Rows[1].Cells[0].Value = list[3][i]; //list[3][1]=="Apples"
                  }*/
                /* var column = new DataGridViewComboBoxColumn();

                 DataTable data = new DataTable();

                 data.Columns.Add(new DataColumn("Value", typeof(string)));
                 data.Columns.Add(new DataColumn("Description", typeof(string)));

                 data.Rows.Add("item1");
                 data.Rows.Add("item2");
                 data.Rows.Add("item3");

                 column.DataSource = data;
                 column.ValueMember = "Value";
                 column.DisplayMember = "Description";

                 DataGridView1.Rows[1].Cells[0] = data;*/


                /* 
                 List<string>[] list;
                 list = Conexiune.Select();

                 (DataGridView1.Columns[0] as DataGridViewComboBoxColumn).DataSource = new List<string> { "Apples", "Oranges", "Grapes" };

                 for (int i = 0; i < list[0].Count; i++)
                 {
                     int number = DataGridView1.Rows.Add();
                     DataGridView1.Rows[number].Cells[0].Value = list[3][i]; //list[3][1]=="Apples"
                 }
                ComboBox.Items.Clear();
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    if (row.Cells["Function"].Value != null && row.Cells["Function"].Value.Equals("CH"))
                        MyComboBox.Items.Add(row.Cells["Name"].Value.ToString());*/



            }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = DateTime.Today.Day;
            int m = DateTime.Today.Month;
            int yy = DateTime.Today.Year;
            int y =  yy-2000;
            Document docc = new Document(PageSize.A5);
            BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial, 15, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_13_bold = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_15_bolld = new iTextSharp.text.Font(arial, 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
            iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
            
            string directoryName = Path.Combine("d:/", "Factures");
            string directoryName0 = Path.Combine("d:/Factures", y.ToString());
            string directoryName1 = Path.Combine("d:/Factures/" + y.ToString(), m.ToString());
            //string directoryName2 = Path.Combine("https://drive.google.com/drive/my-drive");
            Directory.CreateDirectory(directoryName);
            Directory.CreateDirectory(directoryName0);
            Directory.CreateDirectory(directoryName1);
            // Directory.CreateDirectory(directoryName2);
            
                FileStream os = new FileStream("d:/Factures/" + y.ToString() + "/" + m.ToString() + "/" + d + " -" + m.ToString() + "-" + y.ToString() + " " + textBox2.Text + ".pdf", FileMode.Create);
           
            //FileStream os1 = new FileStream("d:/"+ textBox2.Text+d+"-"+m.ToString()+"-"+y.ToString() + ".pdf", FileMode.Create);
            using (os)
            {

                PdfWriter.GetInstance(docc, os);
                docc.Open();

                PdfPTable table1 = new PdfPTable(2);
                float[] width = new float[] { 40f, 60f };

                Paragraph prgr = new Paragraph(new Phrase("Établissement Hospitalique Euel Clinique Future", f_15_bolld));
                prgr.Alignment = Element.ALIGN_CENTER;
                docc.Add(prgr);
                if (preformat == true)
                {
                    Paragraph pp = new Paragraph(new Phrase("         FACTURE PREFORMAT", f_13_bold));
                    pp.Alignment = Element.ALIGN_LEFT;
                    docc.Add(pp);
                }

                String str = "            ";
                //PdfPCell cel1 = new PdfPCell(new Phrase("\n\nÉtablissement Hospitalique Euel Clinique Future", f_15_bold));
                PdfPCell cel2 = new PdfPCell(new Phrase("\n\n Facture N: " + name.ToString()+"-"+y.ToString(), f_12_normal));
                PdfPCell cel22 = new PdfPCell(new Phrase("\n"+str+" Ttscl: " + label25.Text, f_12_normal));
                PdfPCell cel3 = new PdfPCell(new Phrase(" \nDate: " + d+"/"+m+"/"+y, f_12_normal));
                PdfPCell cel33 = new PdfPCell(new Phrase(str+"R.C.W: " + label21.Text, f_12_normal));
                PdfPCell cel4 = new PdfPCell(new Phrase("\nNom et Prenom: " + textBox2.Text, f_12_normal));
                PdfPCell cel44 = new PdfPCell(new Phrase(str+" Nis: " + label22.Text, f_12_normal));
                PdfPCell cel5 = new PdfPCell(new Phrase("\n Age: " + textBox8.Text, f_12_normal));
                PdfPCell cel55 = new PdfPCell(new Phrase(str+" Nif: " + label23.Text, f_12_normal));
                PdfPCell cel555 = new PdfPCell(new Phrase("\n ", f_12_normal));
                PdfPCell cel66 = new PdfPCell(new Phrase(str+" Article:" + label24.Text, f_12_normal));

                //   cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel22.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel33.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel44.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel55.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel555.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel66.Border = iTextSharp.text.Rectangle.NO_BORDER;

                // cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                cel2.HorizontalAlignment = Element.ALIGN_LEFT;
                cel22.HorizontalAlignment = Element.ALIGN_LEFT;
                cel3.HorizontalAlignment = Element.ALIGN_LEFT;
                cel33.HorizontalAlignment = Element.ALIGN_LEFT;
                cel4.HorizontalAlignment = Element.ALIGN_LEFT;
                cel44.HorizontalAlignment = Element.ALIGN_LEFT;
                cel5.HorizontalAlignment = Element.ALIGN_LEFT;
                cel55.HorizontalAlignment = Element.ALIGN_LEFT;
                cel555.HorizontalAlignment = Element.ALIGN_LEFT;
                cel66.HorizontalAlignment = Element.ALIGN_LEFT;

                table1.WidthPercentage = 90;
                //  table1.HorizontalAlignment = Element.ALIGN_LEFT;
                //  table1.AddCell(cel1);
                table1.AddCell(cel2);
                table1.AddCell(cel22);
                table1.AddCell(cel3);
                table1.AddCell(cel33);
                table1.AddCell(cel4);
                table1.AddCell(cel44);
                table1.AddCell(cel5);
                table1.AddCell(cel55);
                table1.AddCell(cel555);
                table1.AddCell(cel66);

                // table1.SpacingAfter = 20;
                // table1.SpacingBefore = 50;
                docc.Add(table1);
                Paragraph line1 = new Paragraph(new Phrase("____________________________________________\n", f_15_bold));
                line1.Alignment = Element.ALIGN_CENTER;
                docc.Add(line1);

                /*
                table1 = new PdfPTable(2);
                 cel1 = new PdfPCell(new Phrase("Facture N:", f_15_bold));
                 cel2 = new PdfPCell(new Phrase("Date:", f_15_bold));
                 cel3 = new PdfPCell(new Phrase("Nom et Prenom:", f_15_bold));
                 cel4 = new PdfPCell(new Phrase("Age:", f_15_bold));

                cel1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                cel2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                cel3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                cel4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel4.Border = iTextSharp.text.Rectangle.NO_BORDER;

                table1.AddCell(cel1);
                table1.AddCell(cel2);
                table1.AddCell(cel3);
                table1.AddCell(cel4);

                table1.SpacingAfter = 20;
                table1.SpacingBefore = 10;

                PdfPTable table2 = new PdfPTable(1);
                table2.AddCell(table1);
                table2.HorizontalAlignment = Element.ALIGN_RIGHT;
                table2.WidthPercentage = 40;
                docc.Add(table2);

                Paragraph prgr = new Paragraph(new Phrase("Facture N: "+ name.ToString()+ "\n", f_12_normal));
                prgr.Add(new Phrase("Date: " + dateTimePicker1.Text+"\n" + f_12_normal));
                prgr.Add(new Phrase("Name and lastname: "+ textBox2.Text + "\n"+ f_15_bold));
                prgr.Add(new Phrase("Age: " + textBox8.Text+"\n" + f_12_normal));
                prgr.Alignment = Element.ALIGN_JUSTIFIED;
                docc.Add(prgr);*/
                PdfPTable table66 = new PdfPTable(2);
                width = new float[] { 40f, 50f };

                //PdfPCell cel1 = new PdfPCell(new Phrase("\n\nÉtablissement Hospitalique Euel Clinique Future", f_15_bold));
                PdfPCell cel8 = new PdfPCell(new Phrase("\n TEL: " + label26.Text, f_12_normal));
                PdfPCell cel9 = new PdfPCell(new Phrase("\n SALAMA BANK: " + label27.Text, f_12_normal));
                PdfPCell cel111 = new PdfPCell(new Phrase("\n ADRESS: " + label28.Text, f_12_normal));


                //   cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel111.Border = iTextSharp.text.Rectangle.NO_BORDER;


                // cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                cel8.HorizontalAlignment = Element.ALIGN_LEFT;
                cel9.HorizontalAlignment = Element.ALIGN_LEFT;
                cel111.HorizontalAlignment = Element.ALIGN_LEFT;


                table66.WidthPercentage = 90;
                //  table1.HorizontalAlignment = Element.ALIGN_LEFT;
                //  table1.AddCell(cel1);
                table66.AddCell(cel8);
                table66.AddCell(cel9);
                table66.AddCell(cel111);

                

                // table1.SpacingAfter = 20;
                // table1.SpacingBefore = 50;
                docc.Add(table66);
                Paragraph p = new Paragraph(new Phrase("       Adress: "+label28.Text, f_12_normal));
                p.Alignment = Element.ALIGN_LEFT;
                docc.Add(p);

                PdfPCell cel1;

                table1 = new PdfPTable(5);
                decimal ht = 0, tva = 0, ttc = 0;
                for (int j = 0; j < 5; j++)
                {
                    cel1 = new PdfPCell(new Phrase(DataGridView1.Columns[j].HeaderText));
                    cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                    cel1.FixedHeight = 20;
                    table1.AddCell(cel1);

                }

                for (int i = 0; i < DataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        cel1 = new PdfPCell(new Phrase(DataGridView1.Rows[i].Cells[j].Value as string));
                        cel1.FixedHeight = 20;
                        table1.AddCell(cel1);
                    }
                    if (DataGridView1.Rows[i].Cells[4].Value != null)
                    {
                        ht += decimal.Parse(DataGridView1.Rows[i].Cells[2].Value as string);
                    }
                    //  ht = 5;
                }
                tva = (ht * 19) / 100;
                ttc = ht + tva;
                
                table1.WidthPercentage = 100;
                width = new float[] { 200f, 250f, 120f, 100, 100 };
                table1.SetWidths(width);
                table1.SpacingBefore = 20;
                docc.Add(table1);

                Paragraph strng = new Paragraph(new Phrase("\n\n", f_15_bold));
                strng.Alignment = Element.ALIGN_CENTER;
                docc.Add(strng);

                table1 = new PdfPTable(2);

                cel3 = new PdfPCell(new Phrase("bruit"));
                cel4 = new PdfPCell(new Phrase(ht.ToString()));
                cel5 = new PdfPCell(new Phrase("TVA"));
                PdfPCell cel6 = new PdfPCell(new Phrase(tva.ToString()));
                PdfPCell cel7 = new PdfPCell(new Phrase("TTC"));
                PdfPCell cel88 = new PdfPCell(new Phrase(ttc.ToString()));


                cel3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel88.Border = iTextSharp.text.Rectangle.NO_BORDER;

                table1.WidthPercentage = 60;
                width = new float[] { 30, 30 };

                cel3.HorizontalAlignment = Element.ALIGN_LEFT;
                cel3.FixedHeight = 20;
                cel5.HorizontalAlignment = Element.ALIGN_LEFT;
                cel5.FixedHeight = 20;
                cel7.HorizontalAlignment = Element.ALIGN_LEFT;
                cel7.FixedHeight = 20;
                cel4.HorizontalAlignment = Element.ALIGN_LEFT;
                cel6.HorizontalAlignment = Element.ALIGN_LEFT;
                cel88.HorizontalAlignment = Element.ALIGN_LEFT;


                table1.SetTotalWidth(width);

                table1.AddCell(cel3);
                table1.AddCell(cel4);
                table1.AddCell(cel5);
                table1.AddCell(cel6);
                table1.AddCell(cel7);
                table1.AddCell(cel88);
                Paragraph space = new Paragraph(new Phrase("\n", f_15_bold));
                docc.Add(space);
                PdfPTable table4 = new PdfPTable(3);

                table1.WidthPercentage = 100;
                width = new float[] { 70,20, 30 };
                PdfPCell cel11 = new PdfPCell(new Phrase("               "));
              
                Image imgLogo = Image.GetInstance("D:/cachee.png");
                imgLogo.ScalePercent(100f);
                PdfPCell pdfcellImage = new PdfPCell(imgLogo, true);
                pdfcellImage.FixedHeight = 100f;
                pdfcellImage.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfcellImage.VerticalAlignment = Element.ALIGN_CENTER;
                pdfcellImage.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfcellImage.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel11.Border = iTextSharp.text.Rectangle.NO_BORDER;


                table4.AddCell(pdfcellImage);
                table4.AddCell(cel11);
                table4.AddCell(table1);
                docc.Add(table4);


                string url = "D:/cachee.png";


                //PdfImage img = new PdfImage(pictureBox1);




          
                docc.Close();
                FileStream fRead = new FileStream(@"d:/Factures/" + y.ToString() + "/" + m.ToString() + "/" + d + " -" + m.ToString() + "-" + y.ToString() + " " + textBox2.Text + ".pdf", FileMode.Open);

                c1.UploadFile(fRead, d + " - " + m.ToString() + " - " + y.ToString() + " " + textBox2.Text + ".pdf", "/PDF", "whyyyy");

                //  System.Diagnostics.Process.Start(@"d:/Factures/"  +y.ToString() +"/"+ m.ToString()+ "/"+ textBox2.Text + d + "-" + m.ToString() + "-" + y.ToString() + ".pdf");
                System.Diagnostics.Process.Start(@"d:/Factures/" + y.ToString() + "/" + m.ToString() + "/" + d + " -" + m.ToString() + "-" + y.ToString() + " " + textBox2.Text + ".pdf");
                //c1.CreateFolder("17H092sF06F99v0xIX941VHzxQEj-dMRa", "hi");



            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           


            // comboBox.Items.Add(popup.txt());

            
            (DataGridView1.Columns[0] as DataGridViewComboBoxColumn).Items.Add(textBox3.Text);
            // DataGridView1.Add comboBox;
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

 

  

        private void label25_Click(object sender, EventArgs e)
        {
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            preformat = false;
            label29.Visible = false;
            button3.Visible = false;
        }
    }
}

