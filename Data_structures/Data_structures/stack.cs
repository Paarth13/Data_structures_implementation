using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    class stack:ICommon
    {
        
        int[] stac=new int[5];
        int top = -1;

        public void Add()
        {
            Console.WriteLine("Enter the Element you want to add");
            if ( !IsOverFlow())
            {
            stac[++top] = Convert.ToInt32(Console.ReadLine());
            
            }
            else
            {
                Console.WriteLine("Overflow");
            }
        }


        public void Display()
        {
            for(int i=0;i<=top;i++)
            {
                Console.WriteLine(stac[i]);
            }
        }
        public bool IsOverFlow()
        {
            if (top == 4)
                return true;
            else
                return false;
        }

        public bool IsUnderFlow()
        {
            if (top ==-1)
                return true;
            else
                return false;
        }
        public void Delete()
        {
            if (!IsUnderFlow())
            top -= 1;
            else
            {
                Console.WriteLine("Underflow");
            }
        }

        public void Top()
        {
            if (!IsUnderFlow())
                Console.WriteLine(stac[top]);
            else
            {
                Console.WriteLine("Underflow");
            }
        }

        public void Sort()
            {
                int temp;
                for (int itr = 0; itr <= top; itr++)
                {
                    for (int itr1 = 1; itr1 <= top; itr1++)
                    {
                        if (stac[itr-1] > stac[itr1])
                        {
                            temp = stac[itr];
                            stac[itr] = stac[itr1];
                            stac[itr1] = temp;
                        }
                    }
                }
            }
        }
    }



