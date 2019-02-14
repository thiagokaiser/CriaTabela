using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace CriaTabela.Classes
{
    class PythonClass
    {
        public static void Executa(Parametros parametros, List<Campos> campos)
        {             
            var lower = parametros.tabela.ToLower();
            var upper = char.ToUpper(lower[0]) + lower.Substring(1);

            string modeloPath = Path.GetFullPath(@"../../modelo/python");
                        
            DirectoryInfo Dir = new DirectoryInfo(modeloPath);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo FileName in Files)
            {
                
                string conteudoTxt = File.ReadAllText(FileName.FullName);
                
                string novoConteudo = "";
                
                string caminhoSalvar = FileName.FullName.Replace(modeloPath,"");
                caminhoSalvar = parametros.caminho + "\\" + parametros.appname + caminhoSalvar;
                
                novoConteudo = conteudoTxt.Replace("#utabela", upper);
                novoConteudo = novoConteudo.Replace("#ltabela", lower);
                novoConteudo = novoConteudo.Replace("#appname", parametros.appname.ToLower());
                
                if (FileName.Name == "forms.py")
                {
                    string camposforms = "";
                    foreach (var item in campos)
                    {
                        camposforms = camposforms + "'" + item.nome + "',";                        
                    }
                    novoConteudo = novoConteudo.Replace("#camposforms", camposforms);
                }
                if (FileName.Name == "funcao.py")
                {
                    string excelheader = "";
                    string excellinha = "";
                    
                    novoConteudo = novoConteudo.Replace("#excelheader", excelheader);
                    novoConteudo = novoConteudo.Replace("#excellinha", excellinha);

                }
                if (FileName.Name == "models.py")
                {
                    string camposmodels = "";

                    camposmodels = CamposModels.gerastring(campos);

                    novoConteudo = novoConteudo.Replace("#camposmodels", camposmodels);

                }
                if (FileName.Name == "ltabela_list.html")
                {
                    string htmllistheader = "<th>Descrição</th>";
                    string camposhtmllist = "<td class=\"colunatable\"> {{ #ltabela.descricao }}</td>";

                    novoConteudo = novoConteudo.Replace("#htmllistheader", htmllistheader);
                    novoConteudo = novoConteudo.Replace("#camposhtmllist", camposhtmllist);

                }
                if (FileName.Name == "ltabela_view.html")
                {
                    string camposhtmlview = "<tr><th>Descrição</th><td>{{ #ltabela.descricao }}</td></tr>";

                    novoConteudo = novoConteudo.Replace("#camposhtmlview", camposhtmlview);

                }

                //Salvar todo o texto no caminho do arquivo escolhido
                FileInfo file = new FileInfo(caminhoSalvar);
                file.Directory.Create();
                File.WriteAllText(caminhoSalvar, novoConteudo);
                
                
                
                
            }
            MessageBox.Show("Arquivo salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        
    
    }
    class CamposModels
    {
        public static string gerastring(List<Campos> campos)
        {
            string texto = "";
            string campo = "";

            foreach (var item in campos)
            {
                switch (item.tipo)
                {
                    case "Char":
                        campo = item.nome + " = models.CharField(max_length = 40, blank = True)";
                        break;
                    case "Dec":
                        campo = item.nome + " = models.DecimalField(max_digits = 12, decimal_places = 2)";
                        break;
                    case "Int":
                        campo = item.nome + " = models.IntegerField(blank = True, default = 0)";
                        break;
                    case "Date":
                        campo = item.nome + "  = models.DateField()";
                        break;
                    case "Bool":
                        campo = item.nome + "   = models.BooleanField(default = False)";
                        break;
                    default:
                        break;
                }
                texto = texto + System.Environment.NewLine + @"    " + campo;                
            }
            return texto;
        }

    }
    class CamposHTMLView
    {
        public static string gerastring(List<Campos> campos)
        {
            string texto = "";            

            foreach (var item in campos)
            {
                texto = texto + "<tr><th>" + Descrição + "</th><td>{{" + #ltabela.descricao + " }}</td></tr>";



            }
            return "";
        }
    }
}
