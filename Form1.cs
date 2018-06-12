using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Trabalho_Módulo_2___IHC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (alunotxtbox.Text == "" && cursotxtbox.Text == "" && matriculatxtbox.Text == "")
            {
                MessageBox.Show("Campo(s) Aluno, Curso, Matrícula são Obrigatórios", "Aluno, Curso, Matrícula",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;

            }
            if (alunotxtbox.Text == "")
            {
                MessageBox.Show("Campo Aluno é Obrigatório", "Aluno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (cursotxtbox.Text == "")
            {
                MessageBox.Show("Campo Curso é Obrigatório", "Curso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (matriculatxtbox.Text == "")
            {
                MessageBox.Show("Campo Matrícula é Obrigatório", "Matrícula",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            //Entrada da Informação, validação e processamento
            int mat1, mat2, mat3, mat4; // textbox de matemática
            int bio1, bio2, bio3, bio4; // textbox de biologia
            int ing1, ing2, ing3, ing4; // textbox de ingles
            int his1, his2, his3, his4; // textbox de historia
            int geo1, geo2, geo3, geo4; // textbox de geografia
            int qui1, qui2, qui3, qui4; // textbox de quimica
            int fis1, fis2, fis3, fis4; // textbox de física
            int por1, por2, por3, por4; // textbox de física
            double mediamat = 0, mediabio = 0, mediaing = 0, mediahis = 0, mediageo = 0, mediaqui = 0, mediafis = 0, mediapor = 0;// media das disciplinas
            double mediatotal = 0;//media total
            int total_mat = 0, total_bio = 0, total_ing = 0, total_his = 0, total_geo = 0, total_qui = 0, total_fis = 0, total_por = 0;// nota total por disciplina
            string[] situacao = new string[8];
            string situacao_final;
            
            mat1 = Convert.ToInt32(matematicatxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM MATEMÁTICA
            mat2 = Convert.ToInt32(matematicatxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM MATEMÁTICA
            mat3 = Convert.ToInt32(matematicatxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM MATEMÁTICA
            mat4 = Convert.ToInt32(matematicatxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM MATEMÁTICA
            if (mat1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Matematica",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (mat2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Matematica",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (mat3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Matematica",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (mat4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Matematica",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            mediamat = (mat1 + mat2 + mat3 + mat4) / 4;
            total_mat = (mat1 + mat2 + mat3 + mat4);
            if(total_mat >= 60)
            {
                situacao[0] = "Aprovado";
            }
            else
            {
                situacao[0] = "Reprovado";
            }
            // Saída da Informação
            mediamattextbox.Text = Convert.ToString(mediamat);
            nfmatttxtbox.Text = Convert.ToString(total_mat);
            situacaomattxtbox.Text = Convert.ToString(situacao[0]);
            bio1 = Convert.ToInt32(biologiatxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM BIOLOGIA
            bio2 = Convert.ToInt32(biologiatxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM BIOLOGIA
            bio3 = Convert.ToInt32(biologiatxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM BIOLOGIA
            bio4 = Convert.ToInt32(biologiatxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM BIOLOGIA
            if (bio1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Biologia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (bio2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Biologia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (bio3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Biologia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (bio4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Biologia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            mediabio = (bio1 + bio2 + bio3 + bio4)/4;
            total_bio = (bio1 + bio2 + bio3 + bio4);
            if (total_bio >= 60)
            {
                situacao[1] = "Aprovado";
            }
            else
            {
                situacao[1] = "Reprovado";
            }
            // Saída da Informação

            mediabiotextbox.Text = Convert.ToString(mediabio);
            nfbiotxtbox.Text = Convert.ToString(total_bio);
            situacaobiotxtbox.Text = Convert.ToString(situacao[1]);
            ing1 = Convert.ToInt32(inglestxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM INGLÊS
            ing2 = Convert.ToInt32(inglestxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM INGLÊS
            ing3 = Convert.ToInt32(inglestxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM INGLÊS
            ing4 = Convert.ToInt32(inglestxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM INGLÊS
            if (ing1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Inglês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (ing2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Inglês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (ing3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Inglês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (ing4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Inglês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
           
            mediaing = (ing1 + ing2 + ing3 + ing4)/4;
            total_ing = (ing1 + ing2 + ing3 + ing4);
            if (total_ing >= 60)
            {
                situacao[2] = "Aprovado";
            }
            else
            {
                situacao[2] = "Reprovado";
            }
            // Saída da Informação
            mediaingtextbox.Text = Convert.ToString(mediaing);
            nfingttxtbox.Text = Convert.ToString(total_ing);
            situacaoingtxtbox.Text = Convert.ToString(situacao[2]);

            his1 = Convert.ToInt32(historiatxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM HISTORIA
            his2 = Convert.ToInt32(historiatxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM HISTORIA
            his3 = Convert.ToInt32(historiatxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM HISTORIA
            his4 = Convert.ToInt32(historiatxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM HISTORIA
            if (his1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "História",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (his2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "História",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (his3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "História",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (his4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "História",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
           
            mediahis = (his1 + his2 + his3 + his4) / 4;
            total_his = (his1 + his2 + his3 + his4);
            if (total_his >= 60)
            {
                situacao[3] = "Aprovado";
            }
            else
            {
                situacao[3] = "Reprovado";
            }
            // Saída da Informação
            mediahistextbox.Text = Convert.ToString(mediahis);
            nfhisttxtbox.Text = Convert.ToString(total_his);
            situacaohisttxtbox.Text = Convert.ToString(situacao[3]);
            geo1 = Convert.ToInt32(geografiatxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM GEOGRAFIA
            geo2 = Convert.ToInt32(geografiatxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM GEOGRAFIA
            geo3 = Convert.ToInt32(geografiatxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM GEOGRAFIA
            geo4 = Convert.ToInt32(geografiatxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM GEOGRAFIA
            if (geo1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Geografia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (geo2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Geografia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (geo3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Geografia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (geo4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Geografia",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            mediageo = (geo1 + geo2 + geo3 + geo4) / 4;
            total_geo = (geo1 + geo2 + geo3 + geo4);
            if (total_geo >= 60)
            {
                situacao[4] = "Aprovado";
            }
            else
            {
                situacao[4] = "Reprovado";
            }
            // Saída da Informação
            mediageotextbox.Text = Convert.ToString(mediageo);
            nfgeottxtbox.Text = Convert.ToString(total_geo);
            situacaogeottxtbox.Text = Convert.ToString(situacao[4]);
            qui1 = Convert.ToInt32(quimicatxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM QUIMICA
            qui2 = Convert.ToInt32(quimicatxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM QUIMICA
            qui3 = Convert.ToInt32(quimicatxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM QUIMICA
            qui4 = Convert.ToInt32(quimicatxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM QUIMICA
            if (qui1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Química",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (qui2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Química",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (qui3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Química",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (qui4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Química",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            mediaqui = (qui1 + qui2 + qui3 + qui4) / 4;
            total_qui = (qui1 + qui2 + qui3 + qui4);
            if (total_qui >= 60)
            {
                situacao[5] = "Aprovado";
            }
            else
            {
                situacao[5] = "Reprovado";
            }
            // Saída da Informação
            mediaquitextbox.Text = Convert.ToString(mediaqui);
            nfquittxtbox.Text = Convert.ToString(total_qui);
            situacaoquitxtbox.Text = Convert.ToString(situacao[5]);
            fis1 = Convert.ToInt32(fisicatxtbo1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            fis2 = Convert.ToInt32(fisicatxtbo2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            fis3 = Convert.ToInt32(fisicatxtbo3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            fis4 = Convert.ToInt32(fisicatxtbo4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            if (fis1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Física",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (fis2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Física",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (fis3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Física",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (fis4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Física",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            
            mediafis = (fis1 + fis2 + fis3 + fis4) / 4;
            total_fis = (fis1 + fis2 + fis3 + fis4);
            if (total_fis >= 60)
            {
                situacao[6] = "Aprovado";
            }
            else
            {
                situacao[6] = "Reprovado";
            }
            // Saída da Informação
            mediafistextbox.Text = Convert.ToString(mediafis);
            nffisttxtbox.Text = Convert.ToString(total_fis);
            situacaofisttxtbox.Text = Convert.ToString(situacao[6]);
            por1 = Convert.ToInt32(portuguestxtbox1.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            por2 = Convert.ToInt32(portuguestxtbox2.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            por3 = Convert.ToInt32(portuguestxtbox3.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            por4 = Convert.ToInt32(portuguestxtbox4.Text);// CONVERSÃO DO VALOR DIGITADO NO PRIMEIRO BIMESTRE EM FISICA
            if (por1 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Portugês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (por2 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Portugês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (por3 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Portugês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (por4 > 25) // Valida um valor até 25
            {
                MessageBox.Show("Digite um valor até 25", "Portugês",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Exclamation);
                return;
            }
            total_por = (por1 + por2 + por3 + por4);
            mediapor = (por1 + por2 + por3 + por4) / 4;
            if (total_por >= 60)
            {
                situacao[7] = "Aprovado";
            }
            else
            {
                situacao[7] = "Reprovado";
            }
            // Saída da Informação
            mediaportextbox.Text = Convert.ToString(mediapor);
            nfporttxtbox.Text = Convert.ToString(total_por);
            situacaoporttxtbox.Text = Convert.ToString(situacao[7]);
            situacao_final = "Aprovado";
            for(int i =0; i < situacao.Length; i++)
            {
                if (situacao[i] == "Reprovado")
                    situacao_final = "Reprovado";
            }
            situacaotextBox.Text = Convert.ToString(situacao_final);
            mediatotal = (total_bio + total_fis + total_geo + total_his + total_ing + total_mat + total_por + total_qui) / 8;
            mediafinaltxtbox.Text = Convert.ToString(mediatotal);
        }
        
        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Limpar_btn_Click(object sender, EventArgs e)
        {
            alunotxtbox.Text = string.Empty;
            cursotxtbox.Text = string.Empty;
            turnotxtbox.Text = string.Empty;
            cidadetxtbox.Text = string.Empty;
            matriculatxtbox.Text = string.Empty;
            idadetxtbox.Text = string.Empty;
            turnotxtbox.Text = string.Empty;
            turmatxtbox.Text = string.Empty;
            portuguestxtbox1.Text = string.Empty;
            portuguestxtbox2.Text = string.Empty;
            portuguestxtbox3.Text = string.Empty;
            portuguestxtbox4.Text = string.Empty;
            fisicatxtbo1.Text = string.Empty;
            fisicatxtbo2.Text = string.Empty;
            fisicatxtbo3.Text = string.Empty;
            fisicatxtbo4.Text = string.Empty;
            quimicatxtbox1.Text = string.Empty;
            quimicatxtbox2.Text = string.Empty;
            quimicatxtbox3.Text = string.Empty;
            quimicatxtbox4.Text = string.Empty;
            geografiatxtbox1.Text = string.Empty;
            geografiatxtbox2.Text = string.Empty;
            geografiatxtbox3.Text = string.Empty;
            geografiatxtbox4.Text = string.Empty;
            historiatxtbox1.Text = string.Empty;
            historiatxtbox2.Text = string.Empty;
            historiatxtbox3.Text = string.Empty;
            historiatxtbox4.Text = string.Empty;
            inglestxtbox1.Text = string.Empty;
            inglestxtbox2.Text = string.Empty;
            inglestxtbox3.Text = string.Empty;
            inglestxtbox4.Text = string.Empty;
            biologiatxtbox1.Text = string.Empty;
            biologiatxtbox2.Text = string.Empty;
            biologiatxtbox3.Text = string.Empty;
            biologiatxtbox4.Text = string.Empty;
            matematicatxtbox1.Text = string.Empty;
            matematicatxtbox2.Text = string.Empty;
            matematicatxtbox3.Text = string.Empty;
            matematicatxtbox4.Text = string.Empty;
            mediabiotextbox.Text = string.Empty;
            mediafinaltxtbox.Text = string.Empty;
            mediafistextbox.Text = string.Empty;
            mediageotextbox.Text = string.Empty;
            mediahistextbox.Text = string.Empty;
            mediaingtextbox.Text = string.Empty;
            mediamattextbox.Text = string.Empty;
            mediaportextbox.Text = string.Empty;
            mediaquitextbox.Text = string.Empty;
            nfbiotxtbox.Text = string.Empty;
            nffisttxtbox.Text = string.Empty;
            nfgeottxtbox.Text = string.Empty;
            nfhisttxtbox.Text = string.Empty;
            nfingttxtbox.Text = string.Empty;
            nfmatttxtbox.Text = string.Empty;
            nfporttxtbox.Text = string.Empty;
            nfquittxtbox.Text = string.Empty;
            situacaobiotxtbox.Text = string.Empty;
            situacaofisttxtbox.Text = string.Empty;
            situacaogeottxtbox.Text = string.Empty;
            situacaohisttxtbox.Text = string.Empty;
            situacaoingtxtbox.Text = string.Empty;
            situacaomattxtbox.Text = string.Empty;
            situacaoporttxtbox.Text = string.Empty;
            situacaoquitxtbox.Text = string.Empty;
            situacaotextBox.Text = string.Empty;
            mediafinaltxtbox.Text = string.Empty;
            anotxtbox.Text = string.Empty;
        }

        //Bitmap BMP;
        Bitmap memoryImage;
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();


            //Graphics G = this.CreateGraphics();
            //BMP = new Bitmap(this.Size.Height, this.Size.Width, G);
            //Graphics mg = Graphics.FromImage(BMP);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_ajuda_Click(object sender, EventArgs e)
        {
            Form2 ajuda = new Form2();
            ajuda.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

