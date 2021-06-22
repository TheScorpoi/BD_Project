﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WineDBInterfaCe
{
    public partial class Pessoa : Form
    {

        SqlCommand cmd;
        SqlCommand command;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;


        public Pessoa(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            loadInicial();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listPessoas.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }

        private void populate(String nome, String morada, String nif, String data_nasc, String genero, String telemovel)
        {
            listPessoas.Items.Add(new ListViewItem(new[] { nome, morada, nif, data_nasc, genero, telemovel }));
        }

        public void pesquisar()
        {
            String atributo = comboBox1.Text;
            String pesquisaText = textBoxPesquisa.Text;
            String filter = "";

            switch (atributo)
            {
                case "Nome":
                    filter = "Nome";
                    break;
                case "Morada":
                    filter = "Morada";
                    break;
                case "NIF":
                    filter = "NIF";
                    break;
                case "Data de Nascimento":
                    filter = "Data_Nasc";
                    break;
                case "Género":
                    filter = "Genero";
                    break;
                case "Nº Telemóvel":
                    filter = "Telemovel";
                    break;

            }


            listPessoas.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM WineDB.Pessoa WHERE " + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "tablePessoaSearch");

                dt = ds.Tables["tablePessoaSearch"];


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
                dt.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        void listPessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string nome = listPessoas.SelectedItems[0].SubItems[0].Text;
                    string morada = listPessoas.SelectedItems[0].SubItems[1].Text;
                    string nif = listPessoas.SelectedItems[0].SubItems[2].Text;
                    string data_nasc = listPessoas.SelectedItems[0].SubItems[3].Text;
                    string genero = listPessoas.SelectedItems[0].SubItems[4].Text;
                    string telemovel = listPessoas.SelectedItems[0].SubItems[5].Text;

                    textBoxNome.Text = nome;
                    textBoxMorada.Text = morada;
                    textBoxNIF.Text = nif;
                    textBoxDataNasc.Text = data_nasc;
                    textBoxGenero.Text = genero;
                    textBoxTelemovel.Text = telemovel;

                    //MessageBox.Show("PESSOA " + nome + "\n\nID: " + id + "\nEndereço: " + endereco + "\nCapacidade Máxima: " + cap_max + " (litros)\nNº Cubas: " + nCubas + "\nNome Gerente: " + nifGerente + "\n");
                }

            }
            catch (ArgumentOutOfRangeException t)
            {
                MessageBox.Show(t.Message);
            }
        }

        public void loadInicial()
        {
            //https://www.youtube.com/watch?v=JXwZQo4KW40&t=296s

            listPessoas.Items.Clear();
            listPessoas.View = View.Details;

            cmd = new SqlCommand("SELECT * FROM WineDB.Pessoa", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tablePessoa");

            dt = ds.Tables["tablePessoa"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listPessoas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listPessoas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listPessoas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listPessoas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listPessoas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listPessoas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
            }
            contadorPessoas();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void contadorPessoas()
        {
            int count = listPessoas.Items.Count;
            countPessoas.Text = count.ToString();
        }

        private void listPessoas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            this.listPessoas.Sort();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://csharp-station.com/Tutorial/AdoDotNet/Lesson07
            SqlDataReader rdr = null;

            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            int nif = Int32.Parse(textBoxNIF.Text);
            string data_nasc = textBoxDataNasc.Text;
            string genero = textBoxGenero.Text;
            string telemovel = textBoxTelemovel.Text;
            string iban = textBoxIBAN.Text;
            int ss;
            string inicio_ativ = textBoxInicioAtiv.Text;
            int nFunc;
            string adega = textBoxAdega.Text;
            string terreno = textBoxTerreno.Text;

            string cat = comboBox2.Text;
            string categoria = "";
            try
            {
                switch (cat)
                {
                    case "Pessoa":
                        categoria = "Pessoa";
                        command = new SqlCommand("WineDB.Adicionar" + categoria, cnn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Nome", nome));
                        command.Parameters.Add(new SqlParameter("@Morada", morada));
                        command.Parameters.Add(new SqlParameter("@NIF", nif));
                        command.Parameters.Add(new SqlParameter("@Data_Nasc", data_nasc));
                        command.Parameters.Add(new SqlParameter("@Genero", genero));
                        command.Parameters.Add(new SqlParameter("@Telemovel", telemovel));

                        rdr = command.ExecuteReader();

                        break;

                    case "Op. Agricola":
                        categoria = "OperadorAgricola";
                        ss = Int32.Parse(textBoxSS.Text);
                        nFunc = Int32.Parse(textBoxNunFunc.Text);

                        command = new SqlCommand("WineDB.Adicionar" + categoria, cnn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Nome", nome));
                        command.Parameters.Add(new SqlParameter("@Morada", morada));
                        command.Parameters.Add(new SqlParameter("@NIF", nif));
                        command.Parameters.Add(new SqlParameter("@Data_Nasc", data_nasc));
                        command.Parameters.Add(new SqlParameter("@Genero", genero));
                        command.Parameters.Add(new SqlParameter("@Telemovel", telemovel));
                        command.Parameters.Add(new SqlParameter("@IBAN", iban));
                        command.Parameters.Add(new SqlParameter("@Num_SS", ss));
                        command.Parameters.Add(new SqlParameter("@Data_Inicio_Atividade", inicio_ativ));
                        command.Parameters.Add(new SqlParameter("@Num_Func", nFunc));
                        command.Parameters.Add(new SqlParameter("@ID_Terreno", terreno));

                        rdr = command.ExecuteReader();
                        break;
                    case "Op. Adega":
                        categoria = "OperadorAdega";

                        ss = Int32.Parse(textBoxSS.Text);
                        nFunc = Int32.Parse(textBoxNunFunc.Text);
                        
                        command = new SqlCommand("WineDB.Adicionar" + categoria, cnn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Nome", nome));
                        command.Parameters.Add(new SqlParameter("@Morada", morada));
                        command.Parameters.Add(new SqlParameter("@NIF", nif));
                        command.Parameters.Add(new SqlParameter("@Data_Nasc", data_nasc));
                        command.Parameters.Add(new SqlParameter("@Genero", genero));
                        command.Parameters.Add(new SqlParameter("@Telemovel", telemovel));
                        command.Parameters.Add(new SqlParameter("@IBAN", iban));
                        command.Parameters.Add(new SqlParameter("@Num_SS", ss));
                        command.Parameters.Add(new SqlParameter("@Data_Inicio_Atividade", inicio_ativ));
                        command.Parameters.Add(new SqlParameter("@Num_Func", nFunc));
                        command.Parameters.Add(new SqlParameter("@ID_Adega", adega));

                        rdr = command.ExecuteReader();
                        break;
                    case "Gerente":
                        categoria = "Gerente";

                        ss = Int32.Parse(textBoxSS.Text);
                        nFunc = Int32.Parse(textBoxNunFunc.Text);

                        command = new SqlCommand("WineDB.Adicionar" + categoria, cnn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Nome", nome));
                        command.Parameters.Add(new SqlParameter("@Morada", morada));
                        command.Parameters.Add(new SqlParameter("@NIF", nif));
                        command.Parameters.Add(new SqlParameter("@Data_Nasc", data_nasc));
                        command.Parameters.Add(new SqlParameter("@Genero", genero));
                        command.Parameters.Add(new SqlParameter("@Telemovel", telemovel));
                        command.Parameters.Add(new SqlParameter("@IBAN", iban));
                        command.Parameters.Add(new SqlParameter("@Num_SS", ss));
                        command.Parameters.Add(new SqlParameter("@Data_Inicio_Atividade", inicio_ativ));
                        command.Parameters.Add(new SqlParameter("@Num_Func", nFunc));

                        rdr = command.ExecuteReader();
                        break;
                    case "Cliente":
                        categoria = "Cliente";
                        command = new SqlCommand("WineDB.Adicionar" + categoria, cnn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Nome", nome));
                        command.Parameters.Add(new SqlParameter("@Morada", morada));
                        command.Parameters.Add(new SqlParameter("@NIF", nif));
                        command.Parameters.Add(new SqlParameter("@Data_Nasc", data_nasc));
                        command.Parameters.Add(new SqlParameter("@Genero", genero));
                        command.Parameters.Add(new SqlParameter("@Telemovel", telemovel));

                        rdr = command.ExecuteReader();

                        break;
                }
            }
            catch
            {

                textBoxNome.Text = "";
                textBoxMorada.Text = "";
                textBoxTerreno.Text = "";
                textBoxNIF.Text = "";
                textBoxTelemovel.Text = "";
                textBoxAdega.Text = "";
                textBoxDataNasc.Text = "";
                textBoxInicioAtiv.Text = "";
                textBoxNunFunc.Text = "";
                textBoxSS.Text = "";


                MessageBox.Show("Algum dado passado de forma incorreta");
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            loadInicial();
        }

        private void Apagarbutton_Click(object sender, EventArgs e)
        {
            string nif = textBoxNIF.Text;

            if (nif == "")
            {
                MessageBox.Show("Pessoa não foi selecionada corretamente");
            }

            SqlCommand command = new SqlCommand("DELETE FROM WineDB.Pessoa WHERE NIF = '" + nif + "'", cnn);
            command.ExecuteNonQuery();

            //to refrsh
            loadInicial();
        }


    }
}
