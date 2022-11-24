using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Node
    {
        public int studentNumber;
        public string studentName;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public void addNode()/*Add method*/
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomor Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan Nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node NodeBaru = new Node();
            NodeBaru.studentNumber = nim;
            NodeBaru.studentName = nm;
            if (LAST == null || nim <= LAST.studentNumber)
            {
                if ((LAST != null) && (nim == LAST.studentNumber))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diijinkan\n");
                    return;
                }
                NodeBaru.next = LAST;
                LAST = NodeBaru;
                return;
            }
            /*Menemukan Node baru didalam list*/
            Node previous, current;
            previous = LAST;
            current = LAST;
            while ((current != null) && (nim >= current.studentNumber))
            {
                if (nim == current.studentNumber)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diijinkan\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            /*Node baru ditempatkan diantara previous dan current*/
            NodeBaru.next = current;
            previous.next = NodeBaru;
        }
        /*Method menghapus*/
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            /*check apakah Node*/
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == LAST)
                LAST = LAST.next;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
