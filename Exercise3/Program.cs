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
        /*Method Mencari */
        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = LAST;
            current = LAST;
            while ((current != null) && (nim != current.studentNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return (false);
            else
                return (true);
        }
        /*Method Traverse/mengunjungi dan membaca isi list*/
        public void traverse()//add method traverse
        {
            if (listEmpty())
                Console.WriteLine("\nList kosong. \n");
            else
            {
                Console.WriteLine("\nData didalam list adalah : \n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != null)
                {
                    Console.Write(currentNode.studentNumber + " " + currentNode.studentName + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.studentNumber + " " + LAST.studentName + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()//add method listempty
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void firstNode()//add method firstNode 
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list is:\n\n" + LAST.next.studentNumber + "     " + LAST.next.studentName);
        }
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add data kedalam list");
                    Console.WriteLine("2. Delete data dari dalam list");
                    Console.WriteLine("3. View semua data didalam list");
                    Console.WriteLine("4. Search sebuah data didalam list");
                    Console.WriteLine("5. Display record pertama dalam list");
                    Console.WriteLine("6. Exit");
                    Console.Write("\nMasukkan Pilihan Anda (1-6): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}
