namespace CalculatorConsoleApp
{
    class program
    { static void Main(string[] args)
        {
            Console.title = "Aplikasi Calculator";

            int a;
            int b;
            int c;

            Console.Writeline("Pilih menu calculator : ");
            Console.Writeline("1.Penambahan\n 2.Pengurangan\n 3.Perkalian\n 4.Pembagian\n");

            COnsole.Write("input nomor menu [1..4]");
            c = int.Parse(console.Readline())

            if (c == 1)
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.Readline());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.Readline());
                Console.Write();
                Console.Writeline("Hasil Penambahan" + a + "+" + b + "=" + Penambahan(a,b));
            }
            else if (c == 2)
            {
               Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.Readline());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.Readline());
                Console.Write();
                Console.Writeline("Hasil Pengurangan" + a + "-" + b + "=" + Pengurangan(a,b));  
            }
            else if (c == 3)
            {
               Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.Readline());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.Readline());
                Console.Write();
                Console.Writeline("Hasil Perkalian" + a + "*" + b + "=" + Perkalian(a,b));  
            }
            else if (c == 4)
            {
               Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.Readline());
                Console.Write("Inputkan nilai b = ");
                b = int.Parse(Console.Readline());
                Console.Write();
                Console.Writeline("Hasil Pembagian" + a + "/" + b + "=" + Pembagian(a,b));  
            }
            else
            {
                Console.Writeline("Tidak Tersedia");
            }
            Console.Writeline("\nTekan sembarang untuk keluar");
            Console.Readkey();

            static int Penambahan(int a, int b)
            {
                return a + b;
            }
            
            static int Pengurangan(int a, int b)
            {
                return a - b;
            }

            static int Perkalian(int a, int b)
            {
                return a * b;
            }

            static int Pembagian(int a, int b)
            {
                return a / b;
            }
        }
    }
}