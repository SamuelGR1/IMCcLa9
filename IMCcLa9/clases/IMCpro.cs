using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCcLa9.clases
{
    public class IMCpro
    {


        public const double kg = 2.2046;

        public String nombre { get; set; }
        public String sexo { get; set; }
        public int edad { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }


        public String calculador()
        {

            nombre = "SAMUEL";
            edad = 20;
            altura = 163;
            peso = 125;
            sexo = "M";

            double pesokg = peso / kg;
            double estaturaMTS = (double)altura / 100;
            double alturatem = (Math.Pow(estaturaMTS, 2));
            imc = pesokg / alturatem;

            imc = Math.Round(imc, 2);

            return imc.ToString();


        }


        public override string ToString()
        {

            string retorno = $"Informacion Ingresada...\n\nNombre: {nombre}\nSexo: {sexo}\nEdad: {edad} anios\n" +
                $"Altura {altura} cm\nPeso: {peso} lb\n\nResultado...\nIMC: {imc}";
            return retorno;

        }

        public string Resultmedia()
        {
            if (edad >= 20)
            {

                if (imc <= 18.5)
                {
                    return "Bajo Peso";
                }

                if (imc >= 25 && imc < 30)
                {
                    return "Sobre Peso\nConsidera revisar tus habitos alimenticios";
                }
                 
                if (imc > 30)
                {
                     return "Obesidad";
                }
                else
                {
                        return "Peso Normal\nSigue asi";
                }

            }
            else
            {
                return Resuladole();
            }
                
            
        }

        public string Resuladole()
        {
            if (edad >=12 && edad <=19)
            {
                
                if (imc <= 14.5)
                {
                    return "Adolecente con Delgadez";
                }

                if (imc >=21 && imc < 25)
                {
                    return "Adolecente con Sobre Peso\nConsidera revisar tus habitos alimenticios";
                }
                else
                {
                    if (imc > 25)
                    {
                        return "Adolecente con Obesidad";
                    }
                    else
                    {
                        return "Adolecente con Peso Normal\nSigue asi";
                    }
                }


            }
            else
            {

                if (edad >=1 && edad <=11)
                {

                    if (imc <= 14.5)
                    {
                        return "niño con Bajo Peso";
                    }

                    if (imc >= 17 && imc < 19)
                    {
                        return "niño con Sobre Peso\nConsidera revisar habitos alimenticios";
                    }

                    if (imc > 19.1)
                    {
                        return "niño con Obesidad";
                    }
                    else
                    {
                        return "niño con Peso Normal";
                    }

                }
                else
                {
                    return Resultmedia();
                }
                
            }
            


        }





    }
}
