using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace S12_ARCHIVOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPathActual_Click(object sender, EventArgs e)
        {
            //mostramos en el label el PATH del directorio actual
            labelPathActual.Text = Directory.GetCurrentDirectory();
        }

        private void buttonPathEscritorio_Click(object sender, EventArgs e)
        {
            //mostramos en el label el PATH del escritorio de windows
            labelPathEscritorio.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            labelPathRelativo.Text = $"{Path.DirectorySeparatorChar}" + Environment.SpecialFolder.Desktop;
            labelPathCombinado.Text = Path.Combine("stores","201");   // stores\201
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"limpiamos" el textbox
            textBoxContenido.Text = "";
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(Path.Combine(Directory.GetCurrentDirectory(), "stores"));

            foreach (var item in listOfDirectories)
            {
                textBoxContenido.Text += item + Environment.NewLine;
            }
        }

        private void buttonArchivos_Click(object sender, EventArgs e)
        {
            //"limpiamos" el textbox
            textBoxContenidoArchivos.Text = "";
            IEnumerable<string> listOfFiles = Directory.EnumerateFiles(Path.Combine(Directory.GetCurrentDirectory(), "stores"),"*.*", SearchOption.AllDirectories);

            foreach (var item in listOfFiles)
            {
                textBoxContenidoArchivos.Text += item + Environment.NewLine;
            }
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            Console.WriteLine("TAB CHANGE: "+projectFolder);
            ListDirectory(treeView1, projectFolder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linea,linea2 = "";
            labelError.Text = "";
            textBoxContenidoStream.Text = "";
            //ruta a la carpeta S12_ARCHIVOS
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString();
            Console.WriteLine("CLICK STREAM TREE: " + projectFolder);

            //ruta absoluta al archivo selectado del TREE
            string pathFile = Path.Combine($"{projectFolder}{Path.DirectorySeparatorChar}{treeView1.SelectedNode.FullPath}");

            if (File.Exists(pathFile))
            {
                //procesamos el contenido del archivo
                labelError.Text = "";

                FileStream fstream = new FileStream(pathFile, FileMode.Open);

                using (StreamReader sr = new StreamReader(fstream)) {
                    while (!sr.EndOfStream) {
                        
                        linea = sr.ReadLine();
                        
                        Console.WriteLine(linea);

                        linea2 += linea + Environment.NewLine;

                    }
                    textBoxContenidoStream.Text =  linea2;
                    sr.Close();
                }
            }
            else {
                labelError.Text = "DEBE SELECIONAR UN ARCHIVO";
            }
        }
    }
}
