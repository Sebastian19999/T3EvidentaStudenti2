using System;
using System.Collections.Generic;
using System.Text;

namespace EvidentaStudenti2
{
    class Student
    {

            private int[][] note;
            private string nume;
            
            static int p = 1;
            // contructor implicit
            public Student()
            {
            }

            // constructor cu parametri
            public Student(string _nume)
            {
                nume = _nume;
            }

            public void SetNote()
            {
                int n;
                note= new int[4][];
            for (int a = 0; a < 4; a++)
                note[a] = new int[15];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Cate note doriti pentru anul "+(i+1)+":");
                
                n = Convert.ToInt32(Console.ReadLine());
                
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nota " + (j+1)+": " );
                    int r = -1;
                    while (!(r > 0 && r < 11))
                    {
                        
                        r = Convert.ToInt32(Console.ReadLine());
                        if (!(r > 0 && r < 11))
                            Console.Write("Nota gresita, introduceti din nou nota... ");


                    }
                    note[i][j]= r;
                }
            }

            }
            public void Setnote(string sir)
            {
                int i = 0, j = 0;
                note = new int[4][];
                
                for(int a=0;a<4;a++)
                    note[a] = new int[15];
                //string[] _note = sir.Split(";");
                string[] _note = sir.Split(" ");
                p = sir.Length;
                foreach (var nota in _note)
                {

                if (nota == ",")
                {
                    i++;
                    j = 0;
                    p -= 2;
                }
                else
                {
                    note[i][j] = Convert.ToInt32(nota);
                    j++;
                }
            }
            
            }
            
            public void ConversieLaSir()
            {
            
            Console.WriteLine(nume);
                for (int i = 0; i < 4; i++)
                {
                    int n = i;
                    n++;
                    Console.Write("An{0}:", n);
                    for (int j = 0; j < 15; j++)
                        if(note[i][j]!=0)
                            Console.Write(" "+note[i][j]);
                    Console.Write("\n");
                }
            
        }
        }
    }

