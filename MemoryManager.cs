using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using Guna.UI2.WinForms;


namespace VisualSorter
{
    public class MemoryManager
    {
        public class PersistentMemory
        {
            public int CurrentImage { get; set; }
            public bool SaveState { get; set; }
        }

        public List<String> CategoryNames = new List<String>();

        public string MemoryFolderPath;

        public void CreateMemoryFiles()
        {
            if (!Directory.Exists(MemoryFolderPath))
                Directory.CreateDirectory(MemoryFolderPath);

            DirectoryInfo di = new DirectoryInfo(MemoryFolderPath);

            if (!di.Attributes.HasFlag(FileAttributes.Hidden))
                di.Attributes |= FileAttributes.Hidden;

            PersistentMemory mem = new PersistentMemory();
            mem.SaveState = true;

            if (!File.Exists(MemoryFolderPath + "Memory.json"))
                File.WriteAllText(MemoryFolderPath + "Memory.json", JsonConvert.SerializeObject(mem));

            if (!File.Exists(MemoryFolderPath + "MemoryList.json"))
                File.WriteAllText(MemoryFolderPath + "MemoryList.json", JsonConvert.SerializeObject(new List<String>()));
        }

        public dynamic ReadMemoryFile()
        {
            string ReadMemoryStr = File.ReadAllText(MemoryFolderPath + "Memory.json");
            var ReadMemory = JsonConvert.DeserializeObject<PersistentMemory>(ReadMemoryStr);
            return ReadMemory;
        }

        public void UpdateMemoryINT(string property, dynamic value)
        {
            string json = File.ReadAllText(MemoryFolderPath + "Memory.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj[property] = value;
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(MemoryFolderPath + "Memory.json", output);
        }

        public void SaveCategoryNameList(List<String> mem)
        {
            string strMemory = JsonConvert.SerializeObject(mem);
            File.WriteAllText(MemoryFolderPath + "MemoryList.json", strMemory);
        }

        public dynamic ReadCategoryList()
        {
            string ReadMemoryStr = File.ReadAllText(MemoryFolderPath + "MemoryList.json");
            var ReadMemory = JsonConvert.DeserializeObject<List<String>>(ReadMemoryStr);
            return ReadMemory;
        }

        public void RestorePreviosState()
        {
            var ReadMemory = ReadMemoryFile();
         
            Form1.f.SaveStateCheckBox.Checked = ReadMemory.SaveState;

            if (ReadMemory.SaveState)
            {

                Form1.ImageIndex = ReadMemory.CurrentImage;
                if (Form1.ImageIndex >= Form1.f.ImagePaths.Length)
                {
                    UpdateMemoryINT("CurrentImage", 0);
                    Form1.ImageIndex = 0;
                }

                foreach (string word in ReadCategoryList())
                {
                    Form1.f.CategoryButtons.CreateButtonGroup(word, Form1.f.CategoryButtonsPanel);
                }
            }
        }

        public void SaveStateOnClose()
        {
            foreach (Panel item in Form1.f.CategoryButtons.CategoryGroups)
            {
                CategoryNames.Add(item.Controls["textBox"].Text);
            }

            SaveCategoryNameList(CategoryNames);
        }

    }
}
