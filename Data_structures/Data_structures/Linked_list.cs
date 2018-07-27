using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    class Linked_list:ICommon
    {
        int _count = 0;
       public  class Node
        {
            public int val;
            public Node next;
            public Node(int Number)
            {
                val = Number;
                next = null;
            }
        }
        public Node head = null;

        int _number;
        public void Add()
        {
            Console.WriteLine("Enter Value");
            _number = Convert.ToInt32(Console.ReadLine());
            Node linked_l = new Node(_number);
            linked_l.next = head;
            head = linked_l;
            _count += 1;

        }

        public void Display()
        {
            Node traverse = head;
            while(traverse!=null)
            {
                Console.WriteLine(traverse.val);
                traverse = traverse.next;
            }
        }

        public void Delete()
        {
            head = head.next;
        }

        public void DeleteAtAnyPos()
        {
            int number;
            Console.WriteLine("Enter the position of element you want to remove");
            number = Convert.ToInt32(Console.ReadLine());
            Node traverse = head;
            Node save = head;
            if (traverse!=null)
            {
                while (traverse != null || number != 0)
                {
                    save = traverse;
                    traverse = traverse.next;
                    number -= 1;
                }

                if (traverse == null)
                {
                    save.next = null;
                }
                else if (number == 0)
                {
                    save.next = traverse.next;
                }
                else
                {
                    head = head.next;
                }
            }

            
        }

        public void InsertAtAny()
        {
            Node traverse = head;
            Node save = head;
            Console.WriteLine("Enter the position");
            int value;
            

            value = int.Parse(Console.ReadLine());
            if (value > _count)
            {
                Console.WriteLine("Out of bounds");
            }
            else
            {

                Console.WriteLine("Enter the number");
                _number = int.Parse(Console.ReadLine());

                Node linked_l = new Node(_number);
                if (value == 1)
                {

                    linked_l.next=head;
                     head= linked_l ;
                }
                else
                {
                    while (traverse.next != null || value != 0)
                    {

                        traverse = traverse.next;
                        value -= 1;
                    }
                    if (traverse.next == null)
                    {
                        linked_l.next = traverse.next;
                        traverse.next = linked_l;
                    }

                }
            }
        }


        public void Sort()
        {

          

            int temp;
            for (int itr = 0; itr <= _count; itr++)
            {
                Node traverse = head;
                Node save = head.next;
                for (int itr1 = 1; itr1 < _count; itr1++)
                {
                   
                    if (traverse.val > save.val)
                    {
                        temp = traverse.val;
                        traverse.val = save.val;
                        save.val = temp;

                       
                    }
                    traverse = save;
                    save = save.next;
                    
                    
                }
            }
        }

    }


}
