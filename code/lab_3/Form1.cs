using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string lastButtonClicked;
        public bool IsInputCorrect()
        {
            bool res = true;
            
            int p;
            int.TryParse(pInput.Text, out p);
            int x;
            int.TryParse(xInput.Text, out x);
            int k;
            int.TryParse(kInput.Text, out k);
            if (IsPrime(p))
            {
                El_Gamal.p = p;
            }
            else
            {
                res = false;
            }
            if (IsCorrectX(x, p))
            {
                El_Gamal.x = x;
            }
            else
            {
                res = false;
            }
            if (AreSimple(k, p))
            {
                El_Gamal.k = k;
            }
            else
            {
                res = false;
            }
            return res;
        }
        public bool IsPrime(int num)
        {
            if (num < 2)
            {
                MessageBox.Show($"Ошибка:Значение P некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    MessageBox.Show($"Ошибка:Значение P некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public bool IsCorrectX(int x, int p)
        {
            if ((x < p - 1) && (x > 1))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Ошибка:Значение X некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AreSimple(int a, int b)
        {
            b--;
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            if (a == 1 || b == 1) 
               return true;
            MessageBox.Show($"Ошибка:Значение K некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public static List<int> ConvertToIntList(List<KeyValuePair<int, int>> keyValuePairs)
        {
            List<int> intList = new List<int>();

            foreach (var kvp in keyValuePairs)
            {
                intList.Add(kvp.Key);
                intList.Add(kvp.Value);
            }

            return intList;
        }

        private void fileChoice_Click(object sender, EventArgs e)
        {
          //  El_Gamal.byteInputValues = new List<int>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
             //   fileName.Text = openFileDialog.FileName;
                ReadPlainText(openFileDialog.FileName);
                try
                {
                    fileInput.Text = OutputBytes(El_Gamal.byteInputValues);
                }
                catch //(Exception ex)
                {
                    MessageBox.Show($"Ошибка: Выберите файл для чтения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        public static void ReadPlainText(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length]; // Создаём буфер размером с файл
                fs.Read(buffer, 0, buffer.Length); // Читаем файл целиком в массив байтов

                foreach (byte b in buffer)
                {
                    El_Gamal.byteInputValues.Add(b); // Добавляем байты в List<int>
                }
            }
           // return El_Gamal.byteInputValues;
        }

        public static string OutputBytes(List<int> myList)
        {
            StringBuilder temp = new StringBuilder();
            if (myList.Count > 64)
            {
                temp.Append("Первые 32 байта:\n");
                temp.Append(string.Join(" ", myList.Take(32))); // Берем первые 32 байта
                temp.Append($"{Environment.NewLine}\n"); // Разделитель между блоками
                temp.Append("Последние 32 байта:\n");
                temp.Append(string.Join(" ", myList.Skip(myList.Count - 32).Take(32))); // Берем последние 32 байта
            }
            else
            {
              //  temp.Append("Все байты:\n");
                temp.Append(string.Join(" ", myList)); // Выводим весь список, если он ≤ 64 элементов
            }

            return temp.ToString();
        }

        private void cipher_button_Click(object sender, EventArgs e)
        {
            lastButtonClicked = "cipher_button";
            if (IsInputCorrect() )
            {
                if (El_Gamal.g == 0)
                    MessageBox.Show($"Ошибка: Выберите первообразную", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

                //генерим ключ
                El_Gamal.y = El_Gamal.ModularExponentiation(El_Gamal.g, El_Gamal.x, El_Gamal.p);

                //запускаем шифрование
                List<KeyValuePair<int, int>> abVals = El_Gamal.Encrypt(El_Gamal.p, El_Gamal.k, El_Gamal.y, El_Gamal.g);
                //запись в файл
               
                //результат на экран
                fileResult.Text = (abVals.Count <= 20 ? string.Join(" ", abVals.Select(kvp => $"({kvp.Key}, {kvp.Value})")) // Вывести всё, если пар ≤ 20
                : string.Join(" ", abVals.Take(15).Select(kvp => $"({kvp.Key}, {kvp.Value})")) +
                 " ... " +  string.Join(" ", abVals.Skip(abVals.Count - 15).Select(kvp => $"({kvp.Key}, {kvp.Value})")));

                El_Gamal.byteOutputValues.Clear();
                El_Gamal.byteOutputValues = ConvertToIntList(abVals);
                
            }
        }

        private void getPervoobr_Click(object sender, EventArgs e)
        {
            int p = int.Parse(pInput.Text);
            if (IsPrime(p))
            {
                El_Gamal.p = p;
                El_Gamal.gVals = El_Gamal.GetPervoobr(p);
            }
           

            gChoice.DataSource = El_Gamal.gVals;
        }

        private void gChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            El_Gamal.g = (int)gChoice.SelectedItem;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    ProcessChoice(fileName);
                   
                }
            }
        }

        private void SaveDataEncrypt(string filePath)
        {

            // Записываем как байтовый поток
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                foreach (int number in El_Gamal.byteOutputValues)
                {
                    fs.Write(BitConverter.GetBytes(number), 0, 4); // Записываем число как 4 байта
                }
            }

        }
        private void SaveDataDecrypt(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = El_Gamal.byteOutputValues.Select(b => (byte)b).ToArray(); // Преобразуем `List<int>` в `byte[]`
                fs.Write(buffer, 0, buffer.Length); 
            }
        }

        private void decipher_button_Click(object sender, EventArgs e)
        {
            lastButtonClicked = "decipher_button";
            int p = int.Parse(pInput.Text);
            
            int x = int.Parse(xInput.Text);
            if (IsPrime(x) && IsCorrectX(x, p))
            {
                List<int> output = El_Gamal.Decipher(x, p);

                fileResult.Text = OutputBytes(El_Gamal.byteOutputValues);

              //  SaveDataDecrypt(outFileName.Text);
            }

        }
        private void ProcessChoice(string fileName)
        {
            if (lastButtonClicked == "cipher_button")
            {

                try
                {
                    SaveDataEncrypt(fileName);
                }
                catch //(Exception ex)
                {
                    MessageBox.Show($"Ошибка: Выберите файл для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                try
                {
                    SaveDataDecrypt(fileName);
                }
                catch //(Exception ex)
                {
                    MessageBox.Show($"Ошибка: Выберите файл для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void clean_button_Click(object sender, EventArgs e)
        {
            //fileName.Text = null;
           // outFileName.Text = null;
            fileInput.Text = null;
            fileResult.Text = null;
            El_Gamal.ClearData();
        }
    }
}
