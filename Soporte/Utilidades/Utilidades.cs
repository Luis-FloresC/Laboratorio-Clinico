using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte.Utilidades
{
    public class Utilidades
    {

        public bool CampoVacio(string campo)
        {
          
            if (String.IsNullOrEmpty(campo) || string.IsNullOrWhiteSpace(campo))
            {
                Console.WriteLine(campo + "!" + String.IsNullOrEmpty(campo) + "!" + String.IsNullOrWhiteSpace(campo));
                return true;
            }

            return false;
        }

        public string GenerarNumeroSerie()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] serie = new char[10];

            for (int i = 0; i < serie.Length; i++)
            {
                serie[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(serie);
        }
        public bool ValidarPrecio(decimal precio)
        {
            if (precio < 0)
            {
                return false; // Precio no puede ser negativo
            }
            else if (precio == 0)
            {
                return false; // Precio no puede ser cero
            }
            else
            {
                return true; // Precio válido
            }
        }

        public bool EsSoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsSoloNumeros(string texto,bool isDecimal)
        {
            if (isDecimal)
            {
                try
                {
                    decimal numero;
                    bool isNum = Decimal.TryParse(texto, out numero);
                    return isNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return false;
                }
            }
            else
            {
                try
                {
                    int numero;
                    bool isNum = Int32.TryParse(texto, out numero);
                    return isNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return false;
                }
            }
        }

        public  bool ValidateDate(string date)
        {
            DateTime dt;
            bool isValid = DateTime.TryParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt);
            return isValid;
        }

        public  bool CheckDates(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AlgoritmoContraseñaSegura(string password)
        {
            bool mayuscula = false;
            bool minuscula = false;
            bool numero = false;
            bool carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        public void AlertMessage(string Mensaje, string tipo)
        {
           
            switch (tipo)
            {
                case "I":
                    MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "A":
                    MessageBox.Show(Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "E":
                    MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        /*
         *
         *    $max_description_length = 50;
        
        foreach($_data as $key => $value)
        {
            if(strlen($_data[$key]["ProdDescripcion"]) > $max_description_length)
            {
                $string = $value["ProdDescripcion"];
                $offset = ($max_description_length - 3) - strlen($string);
                $_data[$key]["ProdDescripcion"] = substr($string, 0, strrpos($string, ' ', $offset)) . '...';
            }

            $precioFinal = ($value["ProdPrecioVenta"]) + ($value["ProdPrecioVenta"] * 0.15); 
            $_data[$key]["ProdPrecioVenta"] = number_format($precioFinal, 2);
        }
         */


        public string LimitarCadena(string cadena, int maxCaracteres)
        {
            
            string nuevaCadena = "";
            nuevaCadena = cadena.Substring(0,maxCaracteres);

            return nuevaCadena + "...";
        }
    }
}
