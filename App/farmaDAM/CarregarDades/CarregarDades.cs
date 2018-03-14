using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using MySql.Data.MySqlClient;

namespace CarregarDades
{
    public partial class carregarDades : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();

        public carregarDades()
        {
            InitializeComponent();
        }

        private void btn_FindFile_Click(object sender, EventArgs e)
        {
            String ruta;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Especifico el nom que surtira a la capsa del buscador, junt amb l'extensio del fitxer i quina posicio ocupa.
            openFileDialog1.Filter = "Fichero XML (.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Crido el method per mostrarlo a la dialog box.
            openFileDialog1.ShowDialog();
            txt_RutaFitxer.Text = openFileDialog1.FileName;
            ruta = openFileDialog1.FileName;
        }

        private void btn_InserirDades_Click(object sender, EventArgs e)
        {

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerAsync();
            btn_InserirDades.Visible = false;
            btn_cancelar.Visible = true;
        }

        public void ReadXML(string ruta)
        {
            try
            {
                String valor = null, columna = null, columnes = "", valors = "", taula = "";
                btn_InserirDades.Invoke((MethodInvoker)delegate { btn_InserirDades.Enabled = false; });
                ruta = ruta.Replace(@"\\", @"\");
                XmlNodeList xmlNode;
                FileStream fs = generarFileStream(ruta);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fs);
                xmlNode = sortXMLNode(xmlDoc);
                taula = trobarTaula(xmlDoc);
                String codi_PA = null;
                int llargada;
                int i = 0,percentatge = 0;
                double progres = 0;
                Boolean repetit = false;
                llargada = llargadaXML(xmlNode);

                foreach (XmlNode no in xmlNode)
                {
                    var dict = new Dictionary<string, string> { };
                    foreach (XmlNode ChildNode in no.ChildNodes)
                    {
                        //Reviso si no hi ha una tasca pendent per cancel·lar el background worker
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            lbl_llargada.Invoke((MethodInvoker)delegate { lbl_llargada.Visible = false; });
                            break;
                        }
                        else
                        {
                            valor = null;
                            //Miro si el childnode te mes fills , amb la finalitat de trobar el codi_PA del XML de medicaments 
                            if (taula == "medicaments")
                            {
                                foreach (XmlNode nieto in ChildNode.ChildNodes)
                                {
                                    if (nieto.Name == "composicion_pa")
                                    {
                                        foreach (XmlNode bisnieto in nieto.ChildNodes)
                                        {
                                            if (bisnieto.Name == "cod_principio_activo")
                                            {
                                                if (valor == null)
                                                {
                                                    codi_PA = bisnieto.InnerText.Trim();
                                                    columna = "codi";
                                                    valor = codi_PA;
                                                }
                                            }
                                        }
                                        //trobo si la columna es codi i la tradueixo a id.
                                        if (columna == "codi")
                                        {
                                            String cmd = "SELECT id_PrincipiActiu from principis_actius where codi = " + valor;
                                            valor = conn.resultatComanda(cmd);
                                            columna = "id_PrincipiActiu";
                                        }
                                        if (valor != null) { if (!dict.ContainsValue(valor)) { dict.Add(columna, valor); } }
                                    }
                                }
                            }
                            //Sino es de medicaments, segueixo normal
                            columna = ChildNode.Name.Trim();
                            valor = ChildNode.InnerText.Trim();
                            valor = valor.Replace(@"'", " ");
                            columna = traduirColumna(columna);
                            i++;
                            double test = (double)i / llargada;
                            progres = test * 100;
                            percentatge = Convert.ToInt32(progres);
                            lbl_progres.Invoke((MethodInvoker)delegate { lbl_progres.Visible = true; lbl_progres.Text = percentatge.ToString() + " %"; });

                            //Reviso que les claus uniques no es repeteixin,sino està repetit, l'afageixo al diccionari
                            if (columna == "codi_laboratori" || columna == "codi" || columna == "registre_nacional")
                            {
                                if (columna == "codi_laboratori" && taula == "medicaments")
                                {
                                    String cmd = "SELECT id_laboratori from laboratoris_farmaceutics where codi_laboratori = " + valor;
                                    valor = conn.resultatComanda(cmd);
                                    columna = "id_laboratori";
                                }
                                if (!validarRepetit(columna, taula, valor))
                                {
                                    if (dict.ContainsKey(columna)) { repetit = true; }
                                    else
                                    {
                                        dict.Add(columna, valor);
                                        repetit = false;
                                    }
                                }
                                else { repetit = true; }
                            }
                            else
                            {
                                if (columna != null) { dict.Add(columna, valor); }
                            }
                        }
                        //recorro el diccionari per ficar-ho despres a la query
                        //afegeixo els valors en un string, si es el primer no afegeixo coma

                        if (!repetit)
                        {
                            foreach (KeyValuePair<string, string> entry in dict)
                            {
                                if (entry.Key != null || entry.Key != "")
                                {
                                    if (columnes == "") { columnes = @entry.Key; }
                                    else
                                    {
                                        //traduiexo de codi a id_principiactiu
                                        columnes += "," + entry.Key;
                                    }

                                    if (valors == "")
                                    { valors = "'" + entry.Value + "'"; }
                                    else { valors += "," + "'" + entry.Value + "'"; }
                                }
                            }
                            if (dict.Count > 1) { inserirDades(columnes, taula, valors); }

                        }
                        //reinicio variables desprès d'inserir. 
                        columnes = "";
                        valors = "";
                    }
                }

                //Torno a intercambiar els botons i habilito el de Inserir dades, tambe deixo de mostrar les labels de progres. 
                btn_cancelar.Invoke((MethodInvoker)delegate { btn_cancelar.Visible = false; });
                btn_InserirDades.Invoke((MethodInvoker)delegate { btn_InserirDades.Visible = true; });
                btn_InserirDades.Invoke((MethodInvoker)delegate { btn_InserirDades.Enabled = true; });
                lbl_llargada.Invoke((MethodInvoker)delegate { lbl_llargada.Visible = false; });
                lbl_progres.Invoke((MethodInvoker)delegate { lbl_progres.Visible = false; });

                //Reviso si he arribat al final 
                if (llargada == i) { MessageBox.Show("Dades inserides correctament"); backgroundWorker1.CancelAsync(); }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No s'ha trobat el fitxer XML");
            }
        }

        public Boolean inserirDades(string columna, string taula, string valor)
        {
            Boolean inserit = false;

            if (validarDades(columna, taula, valor))
            {
                try
                {
                    if (taula == "medicaments" && !columna.Contains("id_PrincipiActiu")){}
                    else
                    {
                        var resultSet = conn.executaComanda("INSERT INTO " + taula + "( " + columna + " ) VALUES ( " + valor + " );");
                        if (!resultSet.Equals(0)) { return inserit = true; }
                        else { return inserit = false; }
                    }
                }
                catch (MySqlException eMySql) { }
            }
            return inserit;
        }

        public Boolean validarDades(string columna, string taula, string valor)
        {
            Boolean correcte = false;

            if (columna == null || taula == null || valor == null)
            {
                MessageBox.Show("Dades subministrades incorrectes");
            }
            else if (!conn.executaComanda("SELECT * FROM " + taula))
            {
                MessageBox.Show("La taula no existeix - contacti amb els desenvolupadors");
            }
            else if (!conn.executaComanda("SELECT " + columna + " FROM " + taula))
            {
                MessageBox.Show("La columna no existeix - contacti amb els desenvolupadors");
            }
            else { correcte = true; }
            return correcte;
        }

        public Boolean validarRepetit(string columna, string taula, string valor)
        {
            Boolean repetit = false;
            if (columna != "codi")
            {
                if (columna == null || taula == null || valor == null)
                { return repetit; }
                else if (conn.executaComanda("SELECT * FROM " + taula + " WHERE " + columna + " = '" + valor + "'")) { return repetit = true; }
                else { repetit = false; }
            }
            else { }
            return repetit;
        }

        public string traduirColumna(string str)
        {
            string columna = "";
            switch (str)
            {
                case "laboratorio":
                    columna = "rao_social";
                    break;
                case "localidad":
                    columna = "localidad";
                    break;
                case "codigopostal":
                    columna = "codi_postal";
                    break;
                case "direccion":
                    columna = "direccio";
                    break;
                case "codigolaboratorio":
                    columna = "codi_laboratori";
                    break;
                case "codigoprincipioactivo":
                    columna = "num_registreSanitari";
                    break;
                case "nroprincipioactivo":
                    columna = "codi";
                    break;
                case "principioactivo":
                    columna = "nom";
                    break;
                case "des_nomco":
                    columna = "nom_comercial";
                    break;
                case "sw_receta":
                    columna = "recepta";
                    break;
                case "sw_generico":
                    columna = "generic";
                    break;
                case "sw_sustituible":
                    columna = "substituible";
                    break;
                case "url_fictec":
                    columna = "url_fitxa_tecnica";
                    break;
                case "url_prosp":
                    columna = "url_prospecte";
                    break;
                case "cod_principo_activo":
                    columna = "codi_PA";
                    break;
                case "cif":
                    columna = "cif";
                    break;
                case "":
                    columna = null;
                    break;
                case "nro_definitivo":
                    columna = "registre_nacional";
                    break;
                case "des_dosific":
                    columna = "contingut";
                    break;
                case "laboratorio_titular":
                    columna = "codi_laboratori";
                    break;
                default:
                    columna = null;
                    break;
            }
            return columna;
        }

        private FileStream generarFileStream(string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            return fs;
        }

        private XmlNodeList sortXMLNode(XmlDocument xmlDoc)
        {
            XmlNodeList xmlNode = null;
            if (xmlDoc.GetElementsByTagName("laboratorios").Count > 0)
            {
                xmlNode = xmlDoc.GetElementsByTagName("laboratorios");
                //taula = "laboratoris_farmaceutics";
                return xmlNode;
            }
            else if (xmlDoc.GetElementsByTagName("principiosactivos").Count > 0)
            {
                xmlNode = xmlDoc.GetElementsByTagName("principiosactivos");
                //taula = "principis_actius";
                return xmlNode;
            }
            else if (xmlDoc.GetElementsByTagName("prescription").Count > 0)
            {
                xmlNode = xmlDoc.GetElementsByTagName("prescription");
                //taula = "medicaments";
                return xmlNode;
            }
            else
            {
                MessageBox.Show("Introdueixi un XML vàlid");
                return xmlNode;
            }
        }

        public int llargadaXML(XmlNodeList xmlNode)
        {
            int i = 0;
            foreach (XmlNode no in xmlNode)
            {
                foreach (XmlNode ChildNode in no.ChildNodes) { i++; }
            }
            return i;
        }

        private string trobarTaula(XmlDocument xmlDoc)
        {
            String taula;

            if (xmlDoc.GetElementsByTagName("laboratorios").Count > 0)
            {
                taula = "laboratoris_farmaceutics";
                return taula;
            }
            else if (xmlDoc.GetElementsByTagName("principiosactivos").Count > 0)
            {
                taula = "principis_actius";
                return taula;
            }
            else if (xmlDoc.GetElementsByTagName("prescription").Count > 0)
            {
                taula = "medicaments";
                return taula;
            }
            else
            {
                MessageBox.Show("Introdueixi un XML vàlid");
                return "";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String ruta = txt_RutaFitxer.Text;
            ruta = ruta.Replace(@"\\", @"\");

            if (ruta != "")
            {
                ReadXML(ruta);
            }
            else { MessageBox.Show("Escolleix un arxiu"); }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            MessageBox.Show("Tasca cancel·lada correctament");
        }
    }
}
