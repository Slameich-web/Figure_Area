using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyLibrary
    {


        // Метод для площади круга

        public double Area(double firstValue)
        {
            if (firstValue <= 0)
            {
                return 0;
            }

            return Math.Round(((firstValue * firstValue) * 3.14),2);

        }

        // Метод для площади треугольника

        public double Area(double firstValue, double SecondValue, double ThridValue)
        {
            if (firstValue <= 0 || SecondValue <= 0 || ThridValue <= 0)
            {
                return 0;
            }

            double result = 0;
            double p = (firstValue + SecondValue + ThridValue) / 2; //Находим полупериметр
            int flag = 0; // 
            bool isoscelesTriangle = false; // Результат проверки на равнобедренность треугольника
            double maxValue = -1; /*Для наибольшой стороны
                                   Использую -1 так как длина стороны треугольника не может быть отрицательной*/

            //Находим MaxValue

            if (firstValue > SecondValue && firstValue > ThridValue)
            {
                maxValue = firstValue;
                flag = 1;
                    
            }
            else if(SecondValue > firstValue && SecondValue > ThridValue)
            {
                flag = 2;
                maxValue = SecondValue;
            }
            else if (ThridValue > firstValue && ThridValue > SecondValue)
            {
                flag = 3;
                maxValue = ThridValue;
            }

            //Провереям треугольник на равнобедренность

            if (flag == 3)
            {
                isoscelesTriangle = ((maxValue*maxValue) == (SecondValue * SecondValue) + (firstValue * firstValue));
            }
            if (flag == 2)
            {
                isoscelesTriangle = ((maxValue * maxValue) == (ThridValue * ThridValue) + (firstValue * firstValue));
            }
            if (flag == 1)
            {
                isoscelesTriangle = ((maxValue * maxValue) == (SecondValue * SecondValue) + (ThridValue * ThridValue));
            }

            //Выводим результат проверки на равнобедренность(В ТЗ нет информации что делать с проверкой, поэтому консоль)
            if (isoscelesTriangle)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
            result = Math.Round(Math.Sqrt(p * (p - firstValue) * (p - SecondValue) * (p - ThridValue)), 2);
            if(Double.IsNaN(result))
            {
                return result = 0;
            }
            return result;
        }
    }
}
