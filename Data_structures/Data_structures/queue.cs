using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    class queue:ICommon
    {
        
        int front=0,rear=-1;
        int[] que = new int[5];
        public void Add()
        {
            Console.WriteLine("Enter the Elements you want to add");
            if (!IsOverFlow())
            {
                que[++rear] = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Overflow");
            }
        }


        public void Display()
        {
            Console.WriteLine();
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(que[i]);
            }
        }
        public bool IsOverFlow()
        {
            if (rear == 4 )
                return true;
            else
                return false;
        }

        public bool IsUnderFlow()
        {
            if (front == rear+1 || rear==-1)
                return true;
            else
                return false;
        }
        public void Delete()
        {
            if (!IsUnderFlow())
                front+=1;
            else
            {
                Console.WriteLine("Underflow");
            }
        }

        public void Front()
        {
            if(!IsUnderFlow())
            Console.WriteLine(que[front]);
            else
            {
                Console.WriteLine("Underflow");
            }
        }

        public void Sort()
        {
            int temp;
            for (int itr = front; itr <= rear; itr++)
            {
                for (int itr1 = 1; itr1 <= rear; itr1++)
                {
                    if (que[itr-1] > que[itr1])
                    {
                        temp = que[itr];
                        que[itr] = que[itr1];
                        que[itr1] = temp;
                    }
                }
            }
        }
    }
}
