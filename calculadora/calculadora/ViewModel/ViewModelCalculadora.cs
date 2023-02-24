using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using calculadora.Models;


namespace calculadora.ViewModel
{
    public class ViewModelCalculadora : INotifyPropertyChanged
    {
        public ViewModelCalculadora()
        {

            Sumar = new Command(
                () => {
                    Expresion suma = new Expresion()
                    {

                        Numero1 = this.num1,
                        Numero2 = this.num2,
                            

                    };
                    Mensaje = suma.Sumar();
                }
            );

            Restar = new Command(
                () => {
                    Expresion resta = new Expresion()
                    {

                        Numero1 = this.num1,
                        Numero2 = this.num2,


                    };
                    Mensaje = resta.Restar();
                }
            );

            Multiplicar = new Command(
                () => {
                    Expresion multiplicar = new Expresion()
                    {

                        Numero1 = this.num1,
                        Numero2 = this.num2,


                    };
                    Mensaje = multiplicar.Multiplicar();
                }
            );

            Dividir = new Command(
                () => {
                    Expresion dividir = new Expresion()
                    {

                        Numero1 = this.num1,
                        Numero2 = this.num2,


                    };
                    Mensaje = dividir.Dividir();
                }
            );


        }

        string mensaje;

        public string Mensaje
        {

            get => mensaje;
            set
            {

                mensaje = value;
                var arg = new PropertyChangedEventArgs(nameof(Mensaje));
                PropertyChanged?.Invoke(this, arg);

            }

        }

        decimal num1;

        public decimal Num1
        {

            get => num1;
            set
            {
                num1 = value;
                var arg = new PropertyChangedEventArgs(nameof(num1));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        decimal num2;

        public decimal Num2
        {

            get => num2;
            set
            {
                num2 = value;
                var arg = new PropertyChangedEventArgs(nameof(num2));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public Command Sumar { get; }
        public Command Restar { get; }
        public Command Multiplicar { get; }
        public Command Dividir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
