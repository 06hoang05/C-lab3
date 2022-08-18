using System.Text;
using System.Threading.Tasks;
 class Atom
{
    public int atomnb = 0;
    public string atomsb;
    public string atomfn;
    public float atomw = 0;
    
    public Atom(int stomnb,string atomsb,string atomfn,float atomw)
    {
        this.atomfn = atomfn;
        this.atomsb = atomsb;
        this.atomnb = stomnb;
        this.atomw = atomw;
    }
    public Atom(){}
    public void display()
    {
        Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", atomsb, atomfn, atomw, atomnb);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Atom atom = new Atom();
        Console.WriteLine("Atomic infomation");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        Console.WriteLine("Enter symbol : ");
        atom.atomsb = Console.ReadLine();
        Console.WriteLine("Enter atomic FullName: ");
        atom.atomfn = Console.ReadLine();
        Console.WriteLine("Emter atomic Weight: ");
        atom.atomw = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter atomic Number : ");
        atom.atomnb = int.Parse(Console.ReadLine());

        Console.WriteLine("-----------------------------");
        atom.display();
        Console.ReadLine();    
    }
}