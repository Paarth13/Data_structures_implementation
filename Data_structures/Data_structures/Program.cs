using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int val=0,val1=0,flag=0;
            stack stack_obj = new stack();
            queue queue_obj = new queue();
            Linked_list linked_obj = new Linked_list();
            while(true)
            {
                Console.WriteLine("Select from the following options\n1.Stack\n2.Queue\n3.Linked List\n4.Exit");
                val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        while (true) { 
                        Console.WriteLine("1.Push in stack\n2.Display stack\n3.Pop in stack\n4.Sort\n5.Top of Stack\n6.Exit");
                        val1 = Convert.ToInt32(Console.ReadLine());
                        switch (val1)
                        {
                            case 1:
                                stack_obj.Add();
                                break;
                            case 2:
                                stack_obj.Display();
                                break;
                            case 3:
                                stack_obj.Delete();
                                break;
                                case 4:
                                    stack_obj.Sort();
                                    break;
                                case 5:
                                    stack_obj.Top();
                                    break;
                            default:
                                    flag = 1;
                                    break;
                                
                        }
                            if(flag==1)
                            {
                                flag = 0;
                                break;
                            }
                }
                   break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("1.Enqueue\n2.Display queue\n3.Dequeue\n4.Sort\n5.Front element\n6.Exit");
                            val1 = Convert.ToInt32(Console.ReadLine());
                            switch (val1)
                            {
                                case 1:
                                    queue_obj.Add();
                                    break;
                                case 2:
                                    queue_obj.Display();
                                    break;
                                case 3:
                                    queue_obj.Delete();
                                    break;
                                case 4:
                                    queue_obj.Sort();
                                    break;
                                case 5:
                                    queue_obj.Front();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input");
                                    flag = 1;
                                    break;

                            }
                            if (flag == 1)
                            {
                                flag = 0;
                                break;
                            }
                        }
                       
                        break;

                    case 3:
                        {
                            while (true)
                            {
                                Console.WriteLine("1.Push in Linked list\n2.Display Linked list\n3.Pop in Linked list at a specified point\n4.Delete\n5.Insert at any position\n6.Sort\n7.Exit");
                                val1 = Convert.ToInt32(Console.ReadLine());
                                switch (val1)
                                {
                                    case 1:
                                        linked_obj.Add();
                                        break;
                                    case 2:
                                        linked_obj.Display();
                                        break;
                                    case 3:
                                        linked_obj.DeleteAtAnyPos();
                                        break;
                                    case 4:
                                        linked_obj.Delete();
                                        break;
                                    case 5:
                                        linked_obj.InsertAtAny();
                                        break;
                                    case 6:
                                        linked_obj.Sort();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        flag = 1;
                                        break;

                                }
                                if (flag == 1)
                                {
                                    flag = 0;
                                    break;
                                }
                            }

                            break;
                        }
                    case 4:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
