using SpaceStatistics.SocialNetworkPackage.AccountPackage;
using SpaceStatistics.SocialNetworkPackage.AccountPackage.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.IO;

namespace SpaceStatistics.ExplorerPackage.Bots.BotForms
{
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }
        IBot bot = new VkQuizBot();
        Authorization authorization;
        private void button1_Click(object sender, EventArgs e)
        {
           authorization = new Authorization(textBox1.Text, textBox2.Text,SocialNetworkPackage.Elements.SocialNetworkEnum.Vk, 6663693);
            VkToken token = (VkToken)authorization.Token;
            string filename = bot.Start(new string[] { token.login, token.pass, textBox3.Text });
            makeExel();
        }

        private void makeExel()
        {
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Visible = true;
            ex.SheetsInNewWorkbook = 1;
            Workbook wb = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)ex.Worksheets[1];
            sheet.Name = "Викторина 1";
            string[] ansvers;
            Thread.Sleep(5000);
            using (StreamReader sr = new StreamReader("usersvoite.txt", Encoding.Default))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("файл загружен");
                ansvers = sr.ReadLine().Split('*');
                Console.WriteLine("вопросы загружены");
            }
            int number = 1;
            Thread.Sleep(5000);
            foreach (string st in ansvers)
            {
                string[] piple = st.Split('#');
                int j = 0;
                while (piple[j] != "" && j < piple.Length)
                {
                    string[] stIdNameLast = piple[j].Split();
                    int i = 1;
                    long ansvId = Convert.ToInt64(stIdNameLast[0]);
                    long id = -1;
                    if (sheet.Cells[i, 1].Value != 0)
                    {
                        id = Convert.ToInt64(sheet.Cells[i, 1].Value);
                    }
                    bool ok = true;
                    while (id != ansvId && ok && id != 0)
                    {
                        if (sheet.Cells[i, 3 + number].Value != 1)
                            sheet.Cells[i, 3 + number].Value = 0;
                        i++;
                        ok = sheet.Cells[i, 1].Value != 0;
                        if (ok)
                        {
                            id = Convert.ToInt64(sheet.Cells[i, 1].Value);
                        }
                    }
                    if (ok && id != 0)
                    {
                        sheet.Cells[i, 3 + number] = 1;
                    }
                    else
                    {
                        sheet.Cells[i, 1].Value = ansvId;
                        sheet.Cells[i, 2].Value = stIdNameLast[1];
                        sheet.Cells[i, 3].Value = stIdNameLast[2];
                        sheet.Cells[i, 3 + number] = 1;
                    }
                    Console.WriteLine(ansvId);
                    j++;
                }
                number++;
            }
            Console.WriteLine("сохранение");
            ex.Application.ActiveWorkbook.SaveAs("Viktorina.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
