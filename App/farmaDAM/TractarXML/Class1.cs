using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TractarXML
{
    public class Class1
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        public void ReadXML(string taula)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNodeList xmlNode = null;
            String valor = null;
            String columna = null;
            String strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String columnes = "";
            String valors = "";
            FileStream fs = null; 
            try
            {
                //switch per trobar el arxiu segons la taula a modificar
                switch (taula)
                {
                    case "laboratoris_farmaceutics":
                        strPath = strPath + @"\XML\DICCIONARIO_LABORATORIOS.xml";
                        fs = generarFileStream(strPath);
                        xmlNode = generarXmlNode("laboratorios",fs);
                        break;
                    case "principis_actius":
                        strPath = strPath + @"\XML\DICCIONARIO_PRINCIPIOS_ACTIVOS.xml";
                        fs = generarFileStream(strPath);
                        xmlNode = generarXmlNode("principiosactivos", fs);
                        break;
                    case "medicaments":
                        strPath = strPath + @"\XML\Prescripcion.xml";
                        fs = generarFileStream(strPath);
                        xmlNode = generarXmlNode("prescription", fs);
                        break;
       
                } 
                
                Boolean repetit = false;
                foreach (XmlNode no in xmlNode)
                {
                    var dict = new Dictionary<string, string> { };
                    foreach (XmlNode ChildNode in no.ChildNodes)
                    {
                        columna = ChildNode.Name.Trim();
                        valor = ChildNode.InnerText.Trim();
                        valor = valor.Replace(@"'", " ");
                        columna = traduirColumna(columna);
                        if (columna == "codi_laboratori" || columna == "codi" || columna == "registre_nacional")
                        {
                            if (!validarRepetit(columna, taula, valor))
                            {
                                dict.Add(columna, valor);
                                repetit = false;
                            }
                            else { repetit = true; }
                        }
                        else
                        {
                            dict.Add(columna, valor);
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
                                if (columnes == "")
                                {
                                    columnes = @entry.Key;

                                }
                                else { columnes += "," + entry.Key; }

                                if (valors == "")
                                {
                                    valors = "'" + entry.Value + "'";
                                }
                                else { valors += "," + "'" + entry.Value + "'"; }
                            }

                        }

                        inserirDades(columnes, taula, valors);
                    }
                    //reinicio variables desprès d'inserir. 
                    columnes = "";
                    valors = "";

                }
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
                var resultSet = conn.executaComanda("INSERT INTO " + taula + "( " + columna + " ) VALUES ( " + valor + " );");

                if ((!resultSet.Equals(0)))
                {
                    return inserit = true;
                }
                else { return inserit = false; }
            }
            return inserit;
        }

        public Boolean validarDades(string columna, string taula, string valor)
        {
            Boolean correcte = false;

            if (columna == null || taula == null || valor == null)
            {
                MessageBox.Show("Dades subministrades incorrectes");
            } else if (!conn.executaComanda("SELECT * FROM " + taula))
            {
                MessageBox.Show("La taula no existeix - contacti amb els desenvolupadors");
            } else if (!conn.executaComanda("SELECT " + columna + " FROM " + taula))
            {
                MessageBox.Show("La columna no existeix - contacti amb els desenvolupadors");
            }
            else
            {
                correcte = true;
            }

            return correcte;
        }

        public Boolean validarRepetit(string columna, string taula, string valor)
        {
            Boolean repetit = false;

            if (columna == null || taula == null || valor == null)
            {

                return repetit;
            } else if (conn.executaComanda("SELECT * FROM " + taula + " WHERE " + columna + " = '" + valor + "'"))
            {

                return repetit = true;
            }
            else { repetit = false; }

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
                    columna = "codi_laboratori";
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
            }
            return columna;
        }

        private FileStream generarFileStream(string strPath){

            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);

            return fs;
            
            }

        private XmlNodeList generarXmlNode(string str, FileStream fs)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNodeList xmlNode;

            xmlDoc.Load(fs);
            xmlNode = xmlDoc.GetElementsByTagName(str);
                
            return xmlNode;

        }

    }
}
