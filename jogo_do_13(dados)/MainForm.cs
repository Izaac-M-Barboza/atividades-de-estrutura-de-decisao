/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 09/04/2024
 * Hora: 20:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gameSaiz_1_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		// variáveis globais
		Random rnd = new Random();
		int cont = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			int x = rnd.Next(1, 7); 
			button1.Text = x.ToString();
			
			cont++;
			label2.Text = cont.ToString();
			
			if (x == 6)
			{
				MessageBox.Show("Você conseguiu !!!");
				cont = 0;
				label2.Text = cont.ToString();
				button1.Text = "0";
			}
		}
	}
}
