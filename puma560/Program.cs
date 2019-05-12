using System;

namespace puma560
{

    class Program
    {

        public static void Main(string[] args)
        {
            Program program = new Program();
            double[,] array1 = new double[6, 4];//начальные данные + углы
            double[,] array2 = new double[4, 4];//матрица положения

            double check; //установка начальных условий
            array1[0, 0] = 0;
            array1[0, 1] = 0;
            array1[0, 2] = 0;
            array1[0, 3] = 0;//tau1
            array1[1, 0] = -90;
            array1[1, 1] = 0;
            array1[1, 2] = 0;
            array1[1, 3] = 0;//tau2
            array1[2, 0] = 0;
            array1[2, 1] = 432;//a2
            array1[2, 2] = 140;//d3
            array1[2, 3] = 0;//tau3
            array1[3, 0] = -90;
            array1[3, 1] = 0;//a3
            array1[3, 2] = 432;//d4
            array1[3, 3] = 0;//tau4
            array1[4, 0] = 90;
            array1[4, 1] = 0;
            array1[4, 2] = 0;
            array1[4, 3] = 0;//tau5
            array1[5, 0] = -90;
            array1[5, 1] = 0;
            array1[5, 2] = 0;
            array1[5, 3] = 0;//tau6
            array2[3, 0] = 0;
            array2[3, 1] = 0;
            array2[3, 2] = 0;
            array2[3, 3] = 1;
            double a2 = array1[2, 1];//записывание значений как не изменяющихся 
            double a3 = array1[3, 1];
            double d3 = array1[2, 2];
            double d4 = array1[3, 2];

            while (true)
            {
                Console.WriteLine("Введите номер звена, которое необходимо повернуть\t");
                Console.WriteLine("Для того что бы вывести на экран текущие положения звеньев нажмите 7\t");
                Console.WriteLine("Для того что бы вывести на экран текущие углы поворота звеньев нажмите 8\t");
                //изменяющиеся значения
                double tau1 = array1[0, 3];
                double tau2 = array1[1, 3];
                double tau3 = array1[2, 3];
                double tau4 = array1[3, 3];
                double tau5 = array1[4, 3];
                double tau6 = array1[5, 3];
                double px = array2[0, 3];
                double py = array2[1, 3];
                double pz = array2[2, 3];
                double r11 = array2[0, 0];
                double r12 = array2[0, 1];
                double r13 = array2[0, 2];
                double r21 = array2[1, 0];
                double r22 = array2[1, 1];
                double r23 = array2[1, 2];
                double r31 = array2[2, 0];
                double r32 = array2[2, 1];
                double r33 = array2[2, 2];
       
                int switchcase = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (switchcase)
                {
                    case 1:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau1 > -160 && check + tau1 < 160)
                        {
                            tau1 = check + tau1;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                               out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -160, 160\t");
                            Console.WriteLine("текущий угол = " + tau1);
                            break;
                        }
                    case 2:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau2 > -225 && check + tau2 < 45)
                        {
                            tau2 = check + tau2;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                             out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -225, 45\t");
                            Console.WriteLine("текущий угол = " + tau2);
                            break;
                        }
                    case 3:
                        Console.WriteLine("Введите угол на необходимо надо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau3 > -45 && check + tau3 < 225)
                        {
                            tau3 = check + tau3;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                                      out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -45, 225\t");
                            Console.WriteLine("текущий угол = " + tau3);
                            break;
                        }
                    case 4:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau4 > -110 && check + tau4 < 110)
                        {
                            tau4 = check + tau4;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                                out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -110, 110\t");
                            Console.WriteLine("текущий угол = \t" + tau4);
                            break;
                        }
                    case 5:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau5 > -100 && check + tau5 < 100)
                        {
                            tau5 = check + tau5;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                              out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -100, 100\t");
                            Console.WriteLine("текущий угол = " + tau5);
                            break;
                        }
                    case 6:
                        Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                        check = Convert.ToDouble(Console.ReadLine());
                        if (check + tau6 > -266 && check + tau6 < 266)
                        {
                            tau6 = check + tau6;
                            r11 = program.Schet(tau1, tau2, tau3, tau4, tau5, tau6, a2, a3, d3, d4, out r12,
                               out r13, out px, out r21, out r22, out r23, out py, out r31, out r32, out r33, out pz);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("звено не может повернуться на этот угол\t");
                            Console.WriteLine("допустимые углы для этого звена -266, 266\t");
                            Console.WriteLine("текущий угол = " + tau6);
                            break;
                        }
                    case 7:
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.Write("{0}\t", array2[i, j]);
                                }
                                Console.WriteLine();

                            }
                            Console.WriteLine("вектор х  " + array2[0, 3]);
                            Console.WriteLine("вектор y  " + array2[1, 3]);
                            Console.WriteLine("вектор z  " + array2[2, 3]);
                            break;
                        }
                    case 8:
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                Console.WriteLine("Звено {0}\t {1}", (i + 1), array1[i, 3]);
                            }
                            break;
                        }
                    case 9:
                        {
                            double xr2;
                            double xr1;
                            Console.WriteLine("вектор х  " + px);
                            Console.WriteLine("вектор y  " + py);
                            Console.WriteLine("вектор z  " + pz);
                            xr1 = program.inverse(r11,r13, r21, r31, r23, r33, d3, a2, d4, a3, px, py, pz, out xr2);
                            Console.ReadKey();
                            break;
                        }
                }
                array1[0, 3] = tau1;
                array1[1, 3] = tau2;
                array1[2, 3] = tau3;
                array1[3, 3] = tau4;
                array1[4, 3] = tau5;
                array1[5, 3] = tau6;
                array2[0, 3] = px;
                array2[1, 3] = py;
                array2[2, 3] = pz;
                array2[0, 0] = r11;
                array2[0, 1] = r12;
                array2[0, 2] = r13;
                array2[1, 0] = r21;
                array2[1, 1] = r22;
                array2[1, 2] = r23;
                array2[2, 0] = r31;
                array2[2, 1] = r32;
                array2[2, 2] = r33;
            
            }
        }


        public double Schet(double t1, double t2, double t3, double t4, double t5, double t6, double a2, double a3, double d3, double d4,
            out double r12, out double r13, out double px, out double r21, out double r22, out double r23, out double py, out double r31, out double r32, out double r33, out double pz)
        {
            double c1 = Math.Cos(t1 * Math.PI / 180);
            double c2 = Math.Cos(t2 * Math.PI / 180);
            double c3 = Math.Cos(t3 * Math.PI / 180);
            double c4 = Math.Cos(t4 * Math.PI / 180);
            double c5 = Math.Cos(t5 * Math.PI / 180);
            double c6 = Math.Cos(t6 * Math.PI / 180);
            double s1 = Math.Sin(t1 * Math.PI / 180);
            double s2 = Math.Sin(t2 * Math.PI / 180);
            double s3 = Math.Sin(t3 * Math.PI / 180);
            double s4 = Math.Sin(t4 * Math.PI / 180);
            double s5 = Math.Sin(t5 * Math.PI / 180);
            double s6 = Math.Sin(t6 * Math.PI / 180);

            double c23 = c2 * c3 - s2 * s3;
            double s23 = c2 * s3 + s2 * c3;
            double r11 = c1 * (c23 * (c4 * c5 * c6 - s4 * s5) - s23 * s5 * c5) + s1 * (s4 * c5 * c6 + c4 * s6);
            r21 = s1 * (c23 * (c4 * c5 * c6 - s4 * s6) - s23 * s5 * c6 - c1 * (s4 * c5 * c6 + c4 * s6));
            r31 = (-1) * s23 * (c4 * c5 * c6 - s4 * s6) - c23 * s5 * c6;

            r12 = c1 * (c23 * (-c4 * c5 * s6 - s4 * c6) + s23 * s5 * s6) + s1 * (c4 * c6 - s4 * c5 * c6);
            r22 = s1 * (c23 * (-c4 * c5 * s6 - s4 * c6) + s23 * s5 * s6) - c1 * (c4 * c6 - s4 * c5 * s6);
            r32 = (-1) * s23 * ((-1) * c4 * c5 * s6 - s4 * c6) + c23 * s5 * s6;

            r13 = -c1 * (c23 * c4 * s5 + s23 * c5) - s1 * s4 * s5;
            r23 = -s1 * (c23 * c4 * s5 + s23 * c5) + c1 * s4 * s5;
            r33 = s23 * c4 * s5 - c23 * c5;

            px = c1 * (a2 * c2 + a3 * c23 - d4 * s23) - d3 * s1;
            py = s1 * (a2 * c2 + a3 * c23 - d4 * s23) + d3 * c1;
            pz = (-1) * a3 * s23 - a2 * s2 - d4 * c23;
            return (r11);
        }

        public double inverse(double r11, double r13, double r21, double r31, double r23, double r33, double d3, double a2, double d4, double a3, double px, double py, double pz, out double tau3v2)
        {
            Program program = new Program();
            double tau1v1;
            double tau1v2;
            tau1v2 = program.Tau1(px, py, d3, out tau1v1);
            tau3v2 = program.tau3(px, py, pz, a2, a3, d3, d4, out double tau3v1);
            double tau2v1 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v1, tau3v1);
            double tau2v2 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v1, tau3v2);
            double tau2v3 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v2, tau3v1);
            double tau2v4 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v2, tau3v2);
            double tau4v1 = program.tau4(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1);
            double tau4v2 = program.tau4(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2);
            double tau4v3 = program.tau4(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1);
            double tau4v4 = program.tau4(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2);
            //double tau5v1 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v1);
            //double tau5v2 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v2);
            //double tau5v3 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v3);
            //double tau5v4 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v4);
            //double tau5v5 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v1);
            //double tau5v6 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v2);
            //double tau5v7 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v3);
            //double tau5v8 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v4);
            //double tau5v9 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v1);
            //double tau5v10 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v2);
            //double tau5v11 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v3);
            //double tau5v12 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v4);
            //double tau5v13 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v1);
            //double tau5v14 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v2);
            //double tau5v15 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v3);
            //double tau5v16 = program.tau5(r13, r23, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v4);
            //double tau6v1 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v1);
            //double tau6v2 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v2);
            //double tau6v3 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v3);
            //double tau6v4 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v1, tau4v4);
            //double tau6v5 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v1);
            //double tau6v6 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v2);
            //double tau6v7 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v3);
            //double tau6v8 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v1, tau3v2, tau4v4);
            //double tau6v9 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v1);
            //double tau6v10 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v2);
            //double tau6v11 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v3);
            //double tau6v12 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v1, tau4v4);
            //double tau6v13 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v1);
            //double tau6v14 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v2);
            //double tau6v15 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v3);
            //double tau6v16 = program.tau6(r11, r13, r21, r23, r31, r33, a2, a3, d4, px, py, pz, tau1v2, tau3v2, tau4v4);
            Console.WriteLine("угол 1 вариант 1  " + tau1v1 * 57.3);
            Console.WriteLine("угол 1 вариант 2  " + tau1v2 * 57.3);
            Console.WriteLine("угол 2 вариант 1  " + tau2v1 * 57.3);
            Console.WriteLine("угол 2 вариант 2  " + tau2v2 * 57.3);
            Console.WriteLine("угол 2 вариант 3  " + tau2v3 * 57.3);
            Console.WriteLine("угол 2 вариант 4  " + tau2v4 * 57.3);
            Console.WriteLine("угол 3 вариант 1  " + tau3v1 * 57.3);
            Console.WriteLine("угол 3 вариант 2  " + tau3v2 * 57.3);
            Console.WriteLine("4 угол "+tau4v1 * 57.3);
            Console.WriteLine("4 угол " + tau4v2 * 57.3);
            Console.WriteLine("4 угол " + tau4v3 * 57.3);
            Console.WriteLine("4 угол " + tau4v4 * 57.3);
            //Console.WriteLine("5 угол" + tau5v1 * 57.3);
            //Console.WriteLine("5 угол" + tau5v2 * 57.3);
            //Console.WriteLine("5 угол" + tau5v3 * 57.3);
            //Console.WriteLine("5 угол" + tau5v4 * 57.3);
            //Console.WriteLine("5 угол" + tau5v5 * 57.3);
            //Console.WriteLine("5 угол" + tau5v6 * 57.3);
            //Console.WriteLine("5 угол" + tau5v7 * 57.3);
            //Console.WriteLine("5 угол" + tau5v8 * 57.3);
            //Console.WriteLine("5 угол" + tau5v9 * 57.3);
            //Console.WriteLine("5 угол" + tau5v10 * 57.3);
            //Console.WriteLine("5 угол" + tau5v11 * 57.3);
            //Console.WriteLine("5 угол" + tau5v12 * 57.3);
            //Console.WriteLine("5 угол" + tau5v13 * 57.3);
            //Console.WriteLine("5 угол" + tau5v14 * 57.3);
            //Console.WriteLine("5 угол" + tau5v15 * 57.3);
            //Console.WriteLine("5 угол" + tau5v16 * 57.3);
            //Console.WriteLine("6 угол" + tau6v1 * 57.3);
            //Console.WriteLine("6 угол" + tau6v2 * 57.3);
            //Console.WriteLine("6 угол" + tau6v3 * 57.3);
            //Console.WriteLine("6 угол" + tau6v4 * 57.3);
            //Console.WriteLine("6 угол" + tau6v5 * 57.3);
            //Console.WriteLine("6 угол" + tau6v6 * 57.3);
            //Console.WriteLine("6 угол" + tau6v7 * 57.3);
            //Console.WriteLine("6 угол" + tau6v8 * 57.3);
            //Console.WriteLine("6 угол" + tau6v9 * 57.3);
            //Console.WriteLine("6 угол" + tau6v10 * 57.3);
            //Console.WriteLine("6 угол" + tau6v11 * 57.3);
            //Console.WriteLine("6 угол" + tau6v12 * 57.3);
            //Console.WriteLine("6 угол" + tau6v13 * 57.3);
            //Console.WriteLine("6 угол" + tau6v14 * 57.3);
            //Console.WriteLine("6 угол" + tau6v15 * 57.3);
            //Console.WriteLine("6 угол" + tau6v16 * 57.3);
            Console.ReadKey();
            return (tau3v1);
        }
        public double Tau1(double px, double py, double d3, out double tau1v1)
        {
            tau1v1 = (Math.Atan2(py, px) - Math.Atan2(d3, Math.Sqrt(Math.Pow(px, 2) + Math.Pow(py, 2) - Math.Pow(d3, 2))));
            double tau1v2 = (Math.Atan2(py, px) - Math.Atan2(d3, (-1) * Math.Sqrt(Math.Pow(px, 2) + Math.Pow(py, 2) - Math.Pow(d3, 2))));
            return (tau1v2);
        }
        public double tau2(double px, double py, double pz, double a2, double a3, double d3, double d4, double tau1, double tau3)
        {


            double c1 = Math.Cos(tau1);
            double c3 = Math.Cos(tau3);
            double s1 = Math.Sin(tau1);
            double s3 = Math.Sin(tau3);
            double x = (((-1) * a3 - a2 * c3) * pz - (c1 * px + s1 * py) * (d4 - a2 * s3));
            double y = ((a2 * s3 - d4) * pz - (a3 + a2 * c3) * (c1 * px + s1 * py));
            double tau23 = Math.Round(Math.Atan2(x, y), 2);
            Console.WriteLine(tau23);
            Console.WriteLine(tau3);
            double tau2 = tau23 - tau3;
            return (tau2);
        }
        public double tau3(double px, double py, double pz, double a2, double a3, double d3, double d4, out double tau3v1)
        {
            double K = Math.Round((Math.Pow(px, 2) + Math.Pow(py, 2) + Math.Pow(pz, 2) - Math.Pow(a2, 2) - Math.Pow(a3, 2) - Math.Pow(d3, 2) - Math.Pow(d4, 2)) / (2 * a2), 2);
            tau3v1 = Math.Round((Math.Atan2(a3, d4) - Math.Atan2(K, Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))), 2); //tau3
            double tau3v2 = Math.Round((Math.Atan2(a3, d4) - Math.Atan2(K, -Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))), 2);//tau3
            return (tau3v2);

        }
        public double s23(double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3)
        {
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c3 = Math.Cos(tau3);
            double s3 = Math.Sin(tau3);
            double s23 = (((-1) * a3 - a2 * c3) * pz + (c1 * px + s1 * py) * (a2 * s3 - d4)) /
                (pz*pz + ((c1 * px + s1 * py)* (c1 * px + s1 * py)));
                return (s23);
        }
        public double c23(double a2, double tau1, double a3, double tau3, double d4, double px, double py, double pz)
        {
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c3 = Math.Cos(tau3);
            double s3 = Math.Sin(tau3);
            double c23 = ((a2 * s3 - d4) * pz - (a3 + a2 * c3) * (c1 * px + s1 * py)) /
                (pz*pz + ((c1 * px + s1 * py)* (c1 * px + s1 * py)));
            return (c23);
        }
        public double tau4(double r13, double r23, double r33, double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3)
        {
            Program program = new Program();
            double c23 = program.c23(a2, tau1, a3, tau3, d4, px, py, pz);
            double c1 = Math.Cos(tau1);
            double s1 = Math.Cos(tau1);
            double s23 = program.s23(a2,a3,d4,px,py,pz,tau1,tau3);
            double tau4 = Math.Atan2((-1)*r13 * s1 + r23 * c1, (-1) * r13 * c1 * c23 - r23 * s1 * c23 + r33 * s23);
            return tau4;
        }
        public double tau5(double r13, double r23, double r33, double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3, double tau4)
        {
            Program program = new Program();
            double s5 = program.s5(tau1, tau3, tau4, r13, r23, r33, a2, a3, d4, px, py, pz);
            double c5 = program.c5(tau1, tau3, tau4, r13, r23, r33, a2, a3, d4, px, py, pz);
            double tau5 = Math.Atan2(s5, c5);
            return tau5;
        }
        public double s5(double r13, double r23, double r33, double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3, double tau4)
        {
            Program program = new Program();
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c4 = Math.Cos(tau4);
            double s4 = Math.Sin(tau4);
            double c23 = program.c23(a2, tau1, a3, tau3, d4, px, py, pz);
            double s23 = program.s23(a2, a3, d4, px, py, pz, tau1, tau3);
            double s5 = (-1) * (r13 * (c1 * c23 * c4 + s1 * s4) + r23 * (s1 * c23 * c4 - c1 * s4) - r33 * (s23 * c4));
            return s5;
        }
        public double c5(double tau1, double tau3, double tau4, double r13, double r23, double r33, double a2, double a3, double d4, double px, double py, double pz)
        {
            Program program = new Program();
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c23 = program.c23(a2, tau1, a3, tau3, d4, px, py, pz);
            double s23 = program.s23(a2, a3, d4, px, py, pz, tau1, tau3);
            double c5 = r13 * ((-1) * c1 * s23) + r23 * ((-1) * s1 * s23) + r33 * ((-1) * c23);
            return c5;
        }
        public double tau6(double r11, double r13, double r21, double r23, double r31, double r33, double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3, double tau4)
        {
            Program program = new Program();
            double s6 = program.s6(tau1, tau3, tau4, r11, r21, r31, a2, a3, d4, px, py, pz);
            double c6 = program.c6(tau1, tau3, tau4, r13, r23, r33, r11, r21, r31, a2, a3, d4, px, py, pz);
            double tau6 = Math.Atan2(s6, c6);
            return tau6;
        }
        public double s6(double tau1, double tau3, double tau4, double r11, double r21, double r31, double a2, double a3, double d4, double px, double py, double pz)
        {
            Program program = new Program();
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c4 = Math.Cos(tau4);
            double s4 = Math.Sin(tau4);
            double c23 = program.c23(a2, tau1, a3, tau3, d4, px, py, pz);
            double s23 = program.s23(a2, a3, d4, px, py, pz, tau1, tau3);
            double s6 = (-1) * r11 * (c1 * c23 * s4 - s1 * c4) - r21 * (s1 * c23 * s4 + c1 * c4) + r31 * (s23 * s4);
            return s6;
        }
        public double c6(double tau1, double tau3, double tau4, double r13, double r23, double r33, double r11, double r21, double r31, double a2, double a3, double d4, double px, double py, double pz)
        {
            Program program = new Program();
            double c1 = Math.Cos(tau1);
            double s1 = Math.Sin(tau1);
            double c4 = Math.Cos(tau4);
            double s4 = Math.Sin(tau4);
            double c5 = program.c5(tau1, tau3, tau4, r13, r23, r33, a2, a3, d4, px, py, pz);
            double s5 = program.s5(tau1, tau3, tau4, r13, r23, r33, a2, a3, d4, px, py, pz);
            double c23 = program.c23(a2, tau1, a3, tau3, d4, px, py, pz);
            double s23 = program.s23(a2, a3, d4, px, py, pz, tau1, tau3);
            double c6 = r11 * ((((c1 * c23 * c4) + s1 * s4) * c5) - (c1 * s23 * s5)) + r21 * ((s1 * c23 * c4 - c1 * s4) * c5 - s1 * s23 * s5) - r31 * (s23 * c4 * c5 + c23 * s5);
            return c6;
        }
    }
}
