
namespace UML_First_Task
{


    #region Creational DesignPatterns (Product)
    // burda ilk olarak Product interface i var ve Creator classi ile arada assocation elaqe var,yeni ki Creator classi daxilinde bir methodda Product INterface i ve icerisindeki doStuff methodu islenib;
    //ProductA ve ProductB classlari Product interfaceden implement elyir;
    //ConcretCreatorA ve ConcretCreatorB classlarida Creator classinda torenib ve createProduct Methodunu override edibler,her biri ferqli objecvt return edir cunki returb type her iki obkecti referans ede biler (Product) 

    public interface Product
    {
        void doStuff();
    }

    public class ProductA : Product
    {
        public void doStuff()
        {
            //asdasdasda
        }

    }

    public class ProductB : Product
    {
        public void doStuff()
        {
            //asdasdasda
        }

    }


    public class Creator
    {
        public void SomeOperation()
        {
            Product product = CreatProduct();
            product.doStuff();
        }

        public Product CreatProduct()
        {
            return default;
        }
    }
    public class ConcreteCreatorA : Creator
    {
        public Product CreatProduct()
        {
            return new ProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public Product CreatProduct()
        {
            return new ProductB();
        }
    }
    #endregion

    #region Structur Design Patterns (Adapter)
    //burda roundHole classi icerisinde RoundPeg classi use olunub ve yungul accosiat ion realtion var;
    //SquarePegAdapter RoundPeg classindan toruyub,ve eyni zamanda SquarePeg Classini constructorunda use edib,composition elaqe var ama uml seklinde ki ox yungul accosation elaqeni gosterir ,basa dusmedim tam olaraq;

    public class RoundPage
    {
        private int radius;
        public RoundPage(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
    }

    public class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        {
            return radius;
        }


        public bool fits(RoundPage peg)
        {
            return peg != null;
        }
    }


    public class SquarePeg
    {
        private int width;

        public SquarePeg(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }
    }

    public class SquarePegAdapter : RoundPage
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base(peg.getWidth())
        {
            this.peg = peg;
        }

        public int getRadius()
        {
            return peg.getWidth();
        }
    }
    #endregion



    #region Behavior DesignPatterns (Client)

    public class Client
    {
        private Iterator? iterator;
        private IterableCollection? iterableCollection;

    }
    public interface Iterator
    {
        void getNext();
        bool hasMore();
    }

    public interface IterableCollection
    {
        Iterator creatIterator();
    }


    public class ConcretIterator : Iterator
    {
        private ConcreteCollection concreteCollection;
        public void getNext()
        {
            throw new NotImplementedException();
        }

        public bool hasMore()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteCollection : IterableCollection
    {
        public Iterator creatIterator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}