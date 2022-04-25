using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
           
            InitializeComponent();
        }
       
        private void btnVerFecha_Click(object sender, EventArgs e)
        {
            int Dia = 0;
            int Mes = 0;
            int Anio = 0;
            string DiaFecha;
            string AnioFecha;
            string MesFecha;

            if (txtDia.Text.Any(x => !char.IsNumber(x)) || txtMes.Text.Any(x => !char.IsNumber(x)) || txtAnio.Text.Any(x => !char.IsNumber(x)))
            {
                MessageBox.Show("El formato de fecha debe ser numérico");
                return;
            }

            Dia = int.Parse(txtDia.Text);
            Mes = int.Parse(txtMes.Text);
            Anio = int.Parse(txtAnio.Text);
            Dia = Dia + 1;
           
            MesFecha = Convert.ToString(Mes);
            DiaFecha = Convert.ToString(Dia);
            AnioFecha = Convert.ToString(Anio);

            switch (Mes)
            {
                case 1:
                    if (Mes == 1)
                    {                        
                        MesFecha = "Enero";
                        if(Dia > 0 && Dia < 31)
                        {                           
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Febrero";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }else if (Dia >= 32)
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                    }
                    break;
                case 2:
                    if (Mes == 2)
                    {
                        MesFecha = "Febrero";
                        if (Anio % 4 == 0 && Anio % 100 != 0 || Anio % 400 == 0)
                        {
                            if (Dia > 0 && Dia < 28)
                            {
                                MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);

                            }
                            else if (Dia >= 28 && Dia <= 29)
                            {
                                Dia = 1;
                                DiaFecha = DiaFecha = Convert.ToString(Dia);
                                MesFecha = "Marzo";
                                MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                            }
                            else
                            {
                                MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                            }
                        }
                        else
                        {
                            if (Dia > 0 && Dia < 29)
                            {
                                MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                            }
                            else if (Dia >= 29 && Dia <= 30)
                            {
                                Dia = 1;
                                DiaFecha = DiaFecha = Convert.ToString(Dia);
                                MesFecha = "Marzo";
                                MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                            }
                            else
                            {
                                MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                            }
                        }

                    }
                    break;

                case 3:
                    if (Mes == 3)
                    {
                        MesFecha = "Marzo";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Abril";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 4:
                    if (Mes == 4)
                    {
                        MesFecha = "Abril";
                        if (Dia > 0 && Dia < 30)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 30 && Dia <= 31)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Mayo";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 5:
                    if (Mes == 5)
                    {
                        MesFecha = "Mayo";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Junio";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 6:
                    if (Mes == 6)
                    {
                        MesFecha = "Junio";
                        if (Dia > 0 && Dia < 30)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 30 && Dia <= 31)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Julio";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 7:
                    if (Mes == 7)
                    {
                        MesFecha = "Julio";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {                           
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Agosto";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 8:
                    if (Mes == 8)
                    {
                        MesFecha = "Agosto";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Septiembre";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 9:
                    if (Mes == 9)
                    {
                        MesFecha = "Septiembre";
                        if (Dia > 0 && Dia < 30)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 30 && Dia <= 31)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Octubre";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 10:
                    if (Mes == 10)
                    {
                        MesFecha = "Octubre";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Noviembre";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;

                case 11:
                    if (Mes == 11)
                    {
                        MesFecha = "Noviembre";
                        if (Dia > 0 && Dia < 30)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 30 && Dia <= 31)
                        {
                            Dia = 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            MesFecha = "Diciembre";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");

                        }
                    }
                    break;

                case 12:
                    if (Mes == 12)
                    {
                        MesFecha = "Diciembre";
                        if (Dia > 0 && Dia < 31)
                        {
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else if (Dia >= 31 && Dia <= 32)
                        {
                            Dia = 1;
                            Anio = Anio + 1;
                            DiaFecha = DiaFecha = Convert.ToString(Dia);
                            AnioFecha = AnioFecha = Convert.ToString(Anio);
                            MesFecha = "Enero";
                            MessageBox.Show(DiaFecha + " de " + MesFecha + " de " + AnioFecha);
                        }
                        else
                        {
                            MessageBox.Show("Se introdujo un número de día que no corresponde al mes");
                        }
                    }
                    break;
                default: MessageBox.Show("Se introdujo un mes que no corresponde");
                    break;
                    //Agregar Default

            }


        }
        
    }

}
