using System.Linq;

namespace Gamer_Shop2._0.Validacion
{
    internal class ClaseValidacion
    {
        //   //---------------------------------------------------------------------------------------------------------\\
        //  //-----------------------------------------------------------------------------------------------------------\\
        //  ||Validaciones Generales                                                                                     ||
        //  \\-----------------------------------------------------------------------------------------------------------//
        //   \\---------------------------------------------------------------------------------------------------------//
        // Validación para verificar la longitud aplicando límite.
        public bool ValidarLongitudConLimite(string texto, int longitudMaxima, char keyChar)
        {
            if (texto.Length >= longitudMaxima && !char.IsControl(keyChar))
            {
                return false;
            }
            return true;
        }

        //validar longitud máxima.
        public bool ValidarLongitud(string texto, int longitudMaxima)
        {
            return texto.Length <= longitudMaxima;
        }

        // Validar longitud exacta
        public bool ValidarLongitudExacta(string texto, int longitudExacta)
        {
            return texto.Length == longitudExacta;
        }

        // Validar longitud mínima.
        public bool ValidarLongitudMinima(string texto, int longitudMinima)
        {
            return texto.Length >= longitudMinima;
        }

        // Validar que el campo solo contenga caracteres alfabeticos
        public bool ValidarCaracteresAlfabeticos(string texto)
        {
            return texto.All(char.IsLetter);
        }

        // Validar el KeyPress para permitir solo caracteres alfabeticos
        public bool ValidarKeyPressAlfabetico(char KeyChar)
        {
            return char.IsLetter(KeyChar) || char.IsControl(KeyChar) || char.IsWhiteSpace(KeyChar);
        }

        // Validar que el campo solo contenga caracteres numéricos
        public bool ValidarCaracteresNumericos(string texto)
        {
            return texto.All(char.IsDigit);
        }
        public bool ValidarKeyPressSoloNumeros(char keyChar)
        {
            return char.IsDigit(keyChar) || char.IsControl(keyChar);
        }

        // Validar que el campo solo contenga caracteres numéricos (Caso float)
        public bool ValidarCaracteresNumericosFloat(string texto)
        {
            return texto.Count(c => c == ',') <= 1 && texto.All(c => char.IsDigit(c) || c == ',');
        }
        public bool ValidarKeyPressSoloNumericosFloat(char keyChar, string textoActual)
        {
            if (char.IsDigit(keyChar) || char.IsControl(keyChar))
            {
                return true;
            }
            else if (keyChar == ',' && !textoActual.Contains(','))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validar que el campo no sea solo numérico o solo caracteres especiales
        public bool ValidarNoSoloNumerosNiEspeciales(string texto)
        {
            // Verifica si contiene al menos una letra
            return texto.Any(char.IsLetter);
        }

        // Función para poner en mayúscula la primera letra de cada palabra
        public string MayusculaPrimeraLetra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());
        }
        //    //---------------------------------------------------------------------------------------------------------\\
        //   //-----------------------------------------------------------------------------------------------------------\\
        //   ||Validaciones específicas                                                                                   ||
        //   \\-----------------------------------------------------------------------------------------------------------//
        //    \\---------------------------------------------------------------------------------------------------------//
        //Validaciones para campos que no permitan numeros.
        public bool ValidarCaracteresNombreSinNumeros(string texto)
        {
            string regexPattern = @"^[a-zA-Z\s\.\'\-]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(texto, regexPattern);
        }

        public bool ValidarKeyPressNombreSinNumeros(char keyChar)
        {
            if (char.IsLetter(keyChar) || char.IsWhiteSpace(keyChar) || keyChar == '.' || keyChar == '\'' || keyChar == '-' || char.IsControl(keyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Función para remover el formato telefónico
        public string RemoverFormatoTelefonico(string telefonoFormateado)
        {
            return telefonoFormateado.Replace("+", "").Replace("-", "").Replace(" ", "");
        }

        // Validación que aplica el formato telefónico "+54 9 XXX XXX-XXXX"
        public string AplicarFormatoTelefonico(string numero)
        {
            string numeroLimpio = new string(numero.Where(char.IsDigit).ToArray());

            if (numeroLimpio.Length == 13)
            {
                // Aplicar el formato: "+XX X XXX XXX-XXXX"
                string codigoPais = numeroLimpio.Substring(0, 2); // "+XX"
                string numeroInicial = numeroLimpio.Substring(2, 1); // "X"
                string codigoArea = numeroLimpio.Substring(3, 3); // "XXX"
                string primeraParte = numeroLimpio.Substring(6, 3); // "XXX"
                string segundaParte = numeroLimpio.Substring(9, 4); // "XXXX"

                return $"+{codigoPais} {numeroInicial} {codigoArea} {primeraParte}-{segundaParte}";
            }
            else
            {
                return numero;
            }
        }

        //Validación para campos como Correo Electrónico.
        public bool ValidarCorreoElectronico(string correo)
        {
            // Patrón para la primera parte
            string patronUsuario = @"^[^@\s]+";

            // Patrón para la segunda parte
            string patronDominioYExtension = @"@[a-zA-Z0-9.-]+\.(com|com\.ar|com\.ar\.or)$";

            if (System.Text.RegularExpressions.Regex.IsMatch(correo, patronUsuario + patronDominioYExtension))
            {
                return true;
            }

            return false;
        }

        // Validar que el texto solo contenga letras, números, espacios y ciertos caracteres especiales
        public bool ValidarCaracteresLNECE(string texto)
        {
            string regexPattern = @"^[a-zA-Z0-9\s\.\'\-\&]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(texto, regexPattern);
        }

        public bool ValidarKeyPressLNECE(char keyChar)
        {
            if (char.IsLetterOrDigit(keyChar) || char.IsWhiteSpace(keyChar) ||
                keyChar == '.' || keyChar == '\'' || keyChar == '-' || keyChar == '&' ||
                char.IsControl(keyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validar caracteres para direcciones
        public bool ValidarCaracteresDireccion(string texto)
        {
            string regexPattern = @"^[a-zA-Z0-9\s\,\.\-\/\&]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(texto, regexPattern);
        }

        public bool ValidarKeyPressDireccion(char keyChar)
        {
            if (char.IsLetterOrDigit(keyChar) ||
                char.IsWhiteSpace(keyChar) ||
                keyChar == ',' ||
                keyChar == '.' ||
                keyChar == '-' ||
                keyChar == '/' ||
                keyChar == '&' ||
                char.IsControl(keyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Validación para campos como ComboBoxs
        public bool ValidarSeleccion(string seleccion)
        {
            return !string.IsNullOrEmpty(seleccion) && seleccion != "Seleccionar...";
        }

        // Función para remover el formato cuil
        public string RemoverFormatoCuil(string cuilFormateado)
        {
            return cuilFormateado.Replace("-", "").Replace(" ", "");
        }

        // Validación que aplica el formato CUIL "XX-XXXXXXXX-X"
        public string AplicarFormatoCuil(string numero)
        {
            string numeroLimpio = new string(numero.Where(char.IsDigit).ToArray());

            if (numeroLimpio.Length == 11)
            {
                // Aplicar el formato: "XX-XXXXXXXX-X"
                string parteInicial = numeroLimpio.Substring(0, 2); // "XX"
                string numeroDocumento = numeroLimpio.Substring(2, 8); // "XXXXXXXX"
                string digitoVerificador = numeroLimpio.Substring(10, 1); // "X"

                return $"{parteInicial}-{numeroDocumento}-{digitoVerificador}";
            }
            else
            {
                return numero;
            }
        }

        // Validación de fechas
        public string AplicarFormatoFecha(string numero)
        {
            // Verificar que el número tenga exactamente 8 dígitos
            if (numero.Length == 8)
            {
                string dia = numero.Substring(0, 2); // "dd"
                string mes = numero.Substring(2, 2); // "mm"
                string año = numero.Substring(4, 4); // "yyyy"

                // Retornar la fecha con formato "dd-mm-yyyy"
                return $"{dia}-{mes}-{año}";
            }
            else
            {
                return numero;
            }
        }

        // Función para remover el formato fecha
        public string RemoverFormatoFecha(string cuilFormateado)
        {
            return cuilFormateado.Replace("-", "").Replace(" ", "");
        }

        // Validar que el texto solo contenga letras, números, espacios, apóstrofes, comillas dobles, y guiones
        public bool ValidarNombreProducto(string texto)
        {
            // Permite letras, números, espacios, apóstrofes, comillas dobles, guiones, y puntos
            string regexPattern = @"^[a-zA-Z0-9\s\'\""\-\.\,]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(texto, regexPattern);
        }

        public bool ValidarKeyPressNombreProducto(char keyChar)
        {
            if (char.IsLetterOrDigit(keyChar) || char.IsWhiteSpace(keyChar) ||
                keyChar == '\'' || keyChar == '\"' || keyChar == '-' || keyChar == '.' || keyChar == ',' ||
                char.IsControl(keyChar)) // Permite teclas de control como backspace
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //-----------------------------------------------------------------------------------------------------------\\
    }
}
