using System;

namespace puma560
{
   
        class Program
        {
            public double[,] array1 = new double[6, 4];//начальные данные + углы
            public double[,] array2 = new double[4, 4];//матрица положения
            static void Main(string[] args)
            {
                Program program = new Program();
                double check; //установка начальных условий
                program.array1[0, 0] = 0;
                program.array1[0, 1] = 0;
                program.array1[0, 2] = 0;
                program.array1[0, 3] = 0;//tau1
                program.array1[1, 0] = -90;
                program.array1[1, 1] = 0;
                program.array1[1, 2] = 0;
                program.array1[1, 3] = 0;//tau2
                program.array1[2, 0] = 0;
                program.array1[2, 1] = 17;//a2
                program.array1[2, 2] = 9.2;//d3
                program.array1[2, 3] = 0;//tau3
                program.array1[3, 0] = -90;
                program.array1[3, 1] = 0;//a3
                program.array1[3, 2] = 17.05;//d4
                program.array1[3, 3] = 0;//tau4
                program.array1[4, 0] = 90;
                program.array1[4, 1] = 0;
                program.array1[4, 2] = 0;
                program.array1[4, 3] = 0;//tau5
                program.array1[5, 0] = -90;
                program.array1[5, 1] = 0;
                program.array1[5, 2] = 0;
                program.array1[5, 3] = 0;
                program.array2[3, 0] = 0;//tau6
                program.array2[3, 1] = 0;
                program.array2[3, 2] = 0;
                program.array2[3, 3] = 1;
                while (true)
                {
                    Console.WriteLine("Введите номер звена, которое необходимо повернуть\t");
                    Console.WriteLine("Для того что бы вывести на экран текущие положения звеньев нажмите 7\t");
                    Console.WriteLine("Для того что бы вывести на экран текущие углы поворота звеньев нажмите 8\t");

                    int switchcase = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    switch (switchcase)
                    {
                        case 1:
                            Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[0, 3] > -160 && check + program.array1[0, 3] < 160)
                            {
                                program.array1[0, 3] = check + program.array1[0, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -160, 160\t");
                                Console.WriteLine("текущий угол = " + program.array1[3, 0]);
                                break;
                            }
                        case 2:
                            Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[1, 3] > -225 && check + program.array1[1, 3] < 45)
                            {
                                program.array1[1, 3] = check + program.array1[1, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -225, 45\t");
                                Console.WriteLine("текущий угол = " + program.array1[3, 1]);
                                break;
                            }
                        case 3:
                            Console.WriteLine("Введите угол на необходимо надо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[2, 3] > -45 && check + program.array1[2, 3] < 225)
                            {
                                program.array1[2, 3] = check + program.array1[2, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -45, 225\t");
                                Console.WriteLine("текущий угол = " + program.array1[3, 2]);
                                break;
                            }
                        case 4:
                            Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[3, 3] > -110 && check + program.array1[3, 3] < 110)
                            {
                                program.array1[3, 3] = check + program.array1[3, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -110, 110\t");
                                Console.WriteLine("текущий угол = \t" + program.array1[3, 3]);
                                break;
                            }
                        case 5:
                            Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[4, 3] > -100 && check + program.array1[4, 3] < 100)
                            {
                                program.array1[4, 3] = check + program.array1[4, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -100, 100\t");
                                Console.WriteLine("текущий угол = " + program.array1[3, 4]);
                                break;
                            }
                        case 6:
                            Console.WriteLine("Введите угол на который необходимо повернуть звено\t");
                            check = Convert.ToDouble(Console.ReadLine());
                            if (check + program.array1[5, 3] > -266 && check + program.array1[5, 3] < 266)
                            {
                                program.array1[5, 3] = check + program.array1[5, 3];
                                program.array2[0, 0] = program.Schet(program.array1[0, 3], program.array1[1, 3], program.array1[2, 3], program.array1[3, 3], program.array1[4, 3], program.array1[5, 3], program.array1[2, 1], program.array1[3, 1], program.array1[2, 2], program.array1[3, 2],
                                out program.array2[0, 1], out program.array2[0, 2], out program.array2[0, 3], out program.array2[1, 0], out program.array2[1, 1], out program.array2[1, 2], out program.array2[1, 3], out program.array2[2, 0], out program.array2[2, 1], out program.array2[2, 2], out program.array2[2, 3]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("звено не может повернуться на этот угол\t");
                                Console.WriteLine("допустимые углы для этого звена -266, 266\t");
                                Console.WriteLine("текущий угол = " + program.array1[3, 5]);
                                break;
                            }
                        case 7:
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = 0; j < 4; j++)
                                    {
                                        Console.Write("{0}\t", program.array2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            }
                        case 8:
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    Console.WriteLine("Звено {0}\t {1}", (i + 1), program.array1[i, 3]);
                                }
                                break;
                            }
                        case 9:
                            {
                                double xr2;
                                double xr1;
                                Console.WriteLine("вектор х  " + program.array2[0, 3]);
                                Console.WriteLine("вектор y  " + program.array2[1, 3]);
                                Console.WriteLine("вектор z  " + program.array2[2, 3]);
                                xr1 = program.inverse(program.array1[2, 2], program.array1[2, 1], program.array1[3, 2], program.array1[3, 1], program.array2[0, 3], program.array2[1, 3], program.array2[2, 3], out xr2);


                                Console.ReadKey();
                                break;
                            }
                    }
                }
            }


            public double Schet(double t1, double t2, double t3, double t4, double t5, double t6, double a2, double a3, double d3, double d4,
                out double r12, out double r13, out double px, out double r21, out double r22, out double r23, out double py, out double r31, out double r32, out double r33, out double pz)
            {
                Program program = new Program();
                t1 = t1 * Math.PI / 180;
                t2 = t2 * Math.PI / 180;
                t3 = t3 * Math.PI / 180;
                t4 = t4 * Math.PI / 180;
                t5 = t5 * Math.PI / 180;
                t6 = t6 * Math.PI / 180;//формулы для расчета положений звена
                double r11 = Math.Round(Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t5)) - (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Cos(t5)) + Math.Sin(t1) * (Math.Sin(t4) * Math.Cos(t5) * Math.Cos(t6) + Math.Cos(t4) * Math.Sin(t6)), 4);
                r21 = Math.Round(Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t6)) - (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Cos(t6)) - Math.Cos(t1) * (Math.Sin(t4) * Math.Cos(t5) * Math.Cos(t6) + Math.Cos(t4) * Math.Sin(t6)), 4);
                r31 = Math.Round((-1) * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * (Math.Cos(t4) * Math.Cos(t5) * Math.Cos(t6) - Math.Sin(t4) * Math.Sin(t6)) - (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Sin(t5) * Math.Cos(t6), 4);
                r12 = Math.Round(Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Sin(t6)) + Math.Sin(t1) * (Math.Cos(t4) * Math.Cos(t6) - Math.Sin(t4) * Math.Cos(t5) * Math.Sin(t6)), 4);
                r22 = Math.Round(Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Sin(t5) * Math.Sin(t6)) - Math.Cos(t1) * (Math.Cos(t4) * Math.Cos(t6) - Math.Sin(t4) * Math.Cos(t5) * Math.Sin(t6)), 4);
                r32 = Math.Round((-1) * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * ((-1) * Math.Cos(t4) * Math.Cos(t5) * Math.Sin(t6) - Math.Sin(t4) * Math.Cos(t6)) + (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Sin(t5) * Math.Sin(t6), 4);
                r13 = Math.Round((-1) * Math.Cos(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t4) * Math.Sin(t5) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t5)) - Math.Sin(t1) * Math.Sin(t4) * Math.Sin(t5), 4);
                r23 = Math.Round((-1) * Math.Sin(t1) * ((Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t4) * Math.Sin(t5) + (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t5)) + Math.Cos(t1) * Math.Sin(t4) * Math.Sin(t5), 4);
                r33 = Math.Round((Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) * Math.Cos(t4) * Math.Sin(t5) - (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) * Math.Cos(t5), 4);
                px = Math.Round(Math.Cos(t1) * (a2 * Math.Cos(t2) + a3 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) - d4 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3))) - d3 * Math.Sin(t1), 4);
                py = Math.Round(Math.Sin(t1) * (a2 * Math.Cos(t2) + a3 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)) - d4 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3))) + d3 * Math.Cos(t1), 4);
                pz = Math.Round((-1) * a3 * (Math.Cos(t2) * Math.Sin(t3) - Math.Sin(t2) * Math.Cos(t3)) - a2 * Math.Sin(t2) - d4 * (Math.Cos(t2) * Math.Cos(t3) - Math.Sin(t2) * Math.Sin(t3)), 4);
                return (r11);
            }
            public double inverse(double d3, double a2, double d4, double a3, double px, double py, double pz, out double tau3v2)
            {
                Program program = new Program();
                double tau1v1;
                double tau1v2;
                //double d3 = program.array1[2, 2]; Console.WriteLine("d3" + d3);
                //double a2 = program.array1[2, 1]; Console.WriteLine("a2" + a2);
                //double a3 = program.array1[3, 1]; Console.WriteLine("a3" + a3);
                //double d4 = program.array1[3, 2]; Console.WriteLine("d4" + d4);
                //double px = program.array2[0, 3]; Console.WriteLine("px" + px);
                //double py = program.array2[1, 3]; Console.WriteLine("py" + py);
                //double pz = program.array2[2, 3]; Console.WriteLine("pz" + pz);
                tau1v2 = program.Tau1(px, py, d3, out tau1v1);


                double K = (Math.Pow(px, 2) + Math.Pow(py, 2) + Math.Pow(pz, 2) - Math.Pow(a2, 2) - Math.Pow(a3, 2) - Math.Pow(d3, 2) - Math.Pow(d4, 2)) / (2 * a2);
                double tau3v1 = (Math.Atan2(a3, d4) - Math.Atan2(K, +Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))) * 57.2958; //tau3
                tau3v2 = (Math.Atan2(a3, d4) - Math.Atan2(K, -Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))) * 57.2958;//tau3
                double tau2v1 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v1, tau3v1);
                double tau2v2 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v1, tau3v2);
                double tau2v3 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v2, tau3v1);
                double tau2v4 = program.tau2(px, py, pz, a2, a3, d3, d4, tau1v2, tau3v2);
                // double tau23 = Math.Atan2((-a3-a2*Math.Cos))
                Console.WriteLine("угол 1 вариант 1  " + tau1v1);
                Console.WriteLine("угол 1 вариант 2  " + tau1v2);
                Console.WriteLine("угол 2 вариант 1  " + tau2v1);
                Console.WriteLine("угол 2 вариант 2  " + tau2v2);
                Console.WriteLine("угол 2 вариант 3  " + tau2v3);
                Console.WriteLine("угол 2 вариант 4  " + tau2v4);
                Console.WriteLine("угол 3 вариант 1  " + tau3v1);
                Console.WriteLine("угол 3 вариант 2  " + tau3v2);
                Console.ReadKey();
                return (tau3v1);
            }
            public double Tau1(double px, double py, double d3, out double tau1v1)
            {
                tau1v1 = (Math.Atan2(py, px) - Math.Atan2(d3, Math.Sqrt(Math.Pow(px, 2) + Math.Pow(py, 2) - Math.Pow(d3, 2)))) * 57.2958;
                double tau1v2 = (Math.Atan2(py, px) - Math.Atan2(d3, -Math.Sqrt(Math.Pow(px, 2) + Math.Pow(py, 2) - Math.Pow(d3, 2)))) * 57.2958;
                return (tau1v2);

            }
            public double tau2(double px, double py, double pz, double a2, double a3, double d3, double d4, double tau1, double tau3)
            {
                Console.WriteLine("8=====0");
                Console.WriteLine("tau 1 " + tau1);
                Console.WriteLine("tau3 " + tau3);
                double tau23 = Math.Atan2(((-a3) - a2 * Math.Cos(tau3)) * pz - (Math.Cos(tau1) * px + Math.Sin(tau1) * py) * (d4 - a2 * Math.Sin(tau3)),
                    (a2 * Math.Sin(tau3) - d4) * pz - (a3 + a2 * Math.Cos(tau3)) * (Math.Cos(tau1) * px + Math.Sin(tau1) * py));
                Console.WriteLine("tau23 " + tau23);
                tau23 = tau23 * 57.2958;
                double tau2 = tau23 - tau3;
                return (tau2);
            }
            public double tau3(double px, double py, double pz, double a2, double a3, double d3, double d4, out double tau3v1)
            {
                double K = (Math.Pow(px, 2) + Math.Pow(py, 2) + Math.Pow(pz, 2) - Math.Pow(a2, 2) - Math.Pow(a3, 2) - Math.Pow(d3, 2) - Math.Pow(d4, 2)) / (2 * a2);
                tau3v1 = (Math.Atan2(a3, d4) - Math.Atan2(K, +Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))) * 57.2958; //tau3
                double tau3v2 = (Math.Atan2(a3, d4) - Math.Atan2(K, -Math.Sqrt(Math.Pow(a3, 2) + Math.Pow(d4, 2) - Math.Pow(K, 2)))) * 57.2958;//tau3
                return (tau3v2);

            }
            public double s23(double a2, double a3, double d4, double px, double py, double pz, double tau1, double tau3)
            {
                double s23 = (-a3 - a2 * Math.Cos(tau3) * pz - (Math.Cos(tau1) * px + Math.Sin(tau1) * py) * (a2 * Math.Sin(tau3) - d4) / (Math.Pow(pz, 2) + (Math.Cos(tau1) * px + Math.Sin(tau1) * py)));
                return (s23);
            }
            public double c23(double a2, double tau1, double a3, double tau3, double d4, double px, double py, double pz)
            {
                double c23 = ((a2 * Math.Sin(tau3) - d4) * pz - (a3 + a2 * Math.Cos(tau3)) * (Math.Cos(tau1) * px + Math.Sin(tau1) * py)
                    / (Math.Pow(pz, 2) + Math.Pow((Math.Cos(tau1) * px + Math.Sin(tau1) * py), 2)));
                return (c23);
            }
            public double tau23(double tau1, double tau3, double a2, double a3, double px, double py, double pz, double d4) //return tau2
            {
                double c1 = Math.Cos(tau1);
                double c3 = Math.Cos(tau3);
                double s1 = Math.Sin(tau1);
                double s3 = Math.Sin(tau3);
                double tau23 = Math.Atan2((-a3 - a2 * c3) * pz - (c1 * px + s1 * py) * (d4 - a2 * s3), (a2 * s3 - d4) * pz - (a3 + a2 * c3) * (c1 * px + s1 * py));
                double tau2 = tau23 - tau3;
                return (tau2);
            }
            public double tau5()
            {
            }
            //public double tau4 (double px, double py, double pz, double a2, double a3, double d3, double d4)
            //{
            //    double c23 =
            //}
            //public double tau5
            //{

            //}
            //public double tau6
            //{

            //}
        }
    }
