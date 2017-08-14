using System;

namespace PruebaNET
{
    class ChangeString
    {
        string diccionario = "abcdefghijklmnñopqrstuvwxyz";
        string cadena2;
        public void build(ref string cadena) {
            string abuscar = "";
            cadena2 = cadena;
            char car;
            foreach (char caracter in cadena)
            {
                car = char.ToLower(caracter);
             
                //ubicamos los caracteres que pertenecen al diccionario

                if (diccionario.Contains(car.ToString()))
                {
                    
                    if (abuscar.Contains(car.ToString()) == false)
                    {

                        //buscar en diccionario
                        int pos = diccionario.IndexOf(car.ToString());
                        if (pos == diccionario.Length)
                        {
                            pos = 0;
                        }
                        //con esta instruccion grabamos lo que vamos leyendo para salir rapido del bucle
                        abuscar = abuscar + car;
                        //evaluamos si es mayuscula
                        char nuevo_caracter = Convert.ToChar(diccionario.Substring(pos + 1, 1));
                        if (Char.IsUpper(caracter))
                        {
                            nuevo_caracter = Char.ToUpper(nuevo_caracter);
                        }

                        

                        //buscar posicion en cadena
                        int pos_fin = cadena.IndexOf(caracter.ToString());

                        string cad_izq = cadena2.Substring(0,pos_fin);
                        string cad_der = cadena2.Substring(pos_fin, cadena2.Length - pos_fin);
                        
                        cadena2 = cad_izq+cad_der.Replace(caracter, nuevo_caracter);
                    }
                }

            }
            cadena = cadena2;
        }

    }
}
