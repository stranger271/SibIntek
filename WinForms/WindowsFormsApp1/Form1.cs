using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (InputText.Text == "") { return; }
             
            foreach ( RadioButton rb in groupBox1.Controls.OfType<RadioButton>() ) {
                
                if (rb.Checked) {
                    
                    switch (rb.Tag)
                    {
                        case "1":
                            DeleteSpaces();
                            break;
                        case "2":
                            FirstLetterUpper();
                            break;
                        case "3":
                            FirstAndLastLetterRevers();
                            break;
                        case "4":
                            ListOfWordsSorted();
                            break;
                        case "5":
                            SaveTxtOnDesctop();
                            break;
                        case "6":
                            DateJob();
                            break;
                    }

                    break;//выходи из цикла
                }
            }   
        }

        //**********************************************************************
        private void FirstLetterUpper()
        {            
            char[] chars;
            string result = "";
            string[] words = GetWords(InputText.Text);

            try
            {
                foreach (string word in words)
                {
                    chars = word.ToCharArray();                    
                    chars[0] = Char.ToUpper(chars[0]);
                    result += new string(chars) + " ";
                }

                Result.Text = result;
            }
            catch (Exception ex) {
                Result.Text = "Ошибка: " + ex.Message;
            }

        }

        private void DeleteSpaces()
        { 
            Result.Text = InputText.Text.Replace(" ", "").Replace(Environment.NewLine, "");          
        }
        
        private void DateJob()
        {
            DateTime date;
            string result = "";

            if (DateTime.TryParse(InputText.Text, out date))
            {
                result = date.ToString("dd-MM-yyyy");
                result += Environment.NewLine +  date.ToString("dddd");               
                result += Environment.NewLine + Math.Abs((DateTime.Now - date).Days).ToString();
                Result.Text = result;
            }
            else {
                MessageBox.Show("Введите дату в формате дд.мм.гггг");
                InputText.Text = "";
            }
        }

        private void SaveTxtOnDesctop()
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string FolderName = "Test";
            string Path = DesktopPath + @"\" +FolderName;

            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            try
            {               
                File.WriteAllText(Path + @"\Тестовый файл.txt" , InputText.Text);
                Result.Text = Path + @"\Тестовый файл.txt";
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message.ToString();
            }         
             
        }

        private void ListOfWordsSorted()
        {
            string result="";
            
            string[] words = GetWords(InputText.Text);
            words = words.OrderBy(c => c).ToArray();// можно Array.sort я что то решил linq использовать

            foreach (string s in words) { result += s + Environment.NewLine; }
            
            Result.Text = result;

        }

        private void FirstAndLastLetterRevers()
        {
            char[] chars;
            char temp;
            int len;
            string result = "";

            string[] words = GetWords(InputText.Text);

            try
            {
                foreach (string word in words)
                {
                    chars = word.ToCharArray();
                    len = chars.Length;

                    if(len > 1)
                    {
                        temp = chars[0];
                        chars[0] = chars[len - 1];
                        chars[len - 1] = temp; 
                    }

                    result += new string(chars) + " ";
                }

                Result.Text = result;
            }
            catch (Exception ex)
            {
                Result.Text = "Ошибка: " + ex.Message;
            }

        }

        //******************************** UTILS

        private void LoremIpsum_Click(object sender, EventArgs e)
        {
            InputText.Text = $"Тестовый текст для проверки задания. {Environment.NewLine}В том числе перенос текста.";
        }

        //получить все знаки пунктуации в предложении
        private char[] GetSeparators(string str) 
        {
            List<char> separators = new List<char>{' '};
            separators.AddRange(Environment.NewLine.ToCharArray());

            foreach (char c in str) {

                if (Char.IsPunctuation(c)) {
                    separators.Add(c);                
                }            
            }
           
            return separators.Distinct().ToArray();
        }

        //получить все слова из текста
        private string[] GetWords(string str)
        {
            return str.Split(GetSeparators(str), StringSplitOptions.RemoveEmptyEntries);
        }

        private string CreateFolderDialog() {

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
               return FBD.SelectedPath;
            }

            return null;

        }

        //******************************** ButtonsFolder

        private void SelectFolder_Click(object sender, EventArgs e)
        {           
            string dir = CreateFolderDialog();
            if (dir == null) return;

            string[] files = Directory.GetFiles(dir);

            //получаем список расширений файлов
            foreach (string f in files) 
            {
                FileInfo fi = new FileInfo(f);
                string path = dir + @"\" + fi.Extension.Substring(1);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                fi.MoveTo(path +@"\" + fi.Name);
            }

            MessageBox.Show("Выполнено!");
        }


        private void ClearFolder_Click(object sender, EventArgs e)
        {
            string result="";
            string dir = CreateFolderDialog();
            if (dir == null) return;

            string[] directories = Directory.GetDirectories(dir);
            string[] files = Directory.GetFiles(dir);

            //удаляем подкаталоги
            foreach (string f in directories)
            {
                try
                {
                    Directory.Delete(f, true);
                }
                catch {
                    result += "Каталог " + f + " не удалось удалить!" + Environment.NewLine;
                    continue;
                }
            }

            //удаляем файлы
            foreach (string f in files)
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                    result += "Файл " + f + " не удалось удалить!" + Environment.NewLine;
                    continue;
                }
            }

            Result.Text = result;

            MessageBox.Show("Выполнено!");

        }
    }
}
