using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;

namespace AppNumerosPrimos
{
    public partial class MainPage : ContentPage
    {
        string NumerosPrimos = "";
        int n1 = 1;
        int n2 = 10;

        for (int numeroVez = n1; numeroVez< = n2; numeroVez++)
            {
              int dividiu = 0;
        for (int divisor= 1; divisor <= numeroVez; divisor++)
            {
              if (numeroVez % divisor == 0)
               { 
                 dividiu++;
               }
            }
       if (dividiu  == 2)
       {
          numerosPrimos += (numerosPrimos == "" ?  )
        }
