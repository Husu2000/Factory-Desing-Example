
interface FurnitureFactory
{
    public Chair createChair();

  

    public Sofa createSofa();
}

interface Chair
{
    public void hasLegs();
    public void sitOn();
}



interface Sofa
{

    public void hasLegs();
    public void sitOn();
}


class ModernFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new ModernChair();

   

    public Sofa createSofa() => new ModernSofa();


}
class VicFurnitureFactory : FurnitureFactory
{
    public Chair createChair() => new VicChair();


    public Sofa createSofa() => new VicSofa();
}



class ModernChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("has");

    }

    public void sitOn()
    {
        Console.WriteLine("do");

    }
}
class VicChair : Chair
{
    public void hasLegs()
    {
        Console.WriteLine("has");

    }

    public void sitOn()
    {
        Console.WriteLine("do");

    }
}


class ModernSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("has");
    }

    public void sitOn()
    {
        Console.WriteLine("do");
    }
}

class VicSofa : Sofa
{
    public void hasLegs()
    {
        Console.WriteLine("has");
    }

    public void sitOn()
    {
        Console.WriteLine("do");
    }
}

class Client
{
    private readonly Chair chair = null;
    private readonly Sofa sofa = null;

    public Client(FurnitureFactory furniturefac)
    {
        chair = furniturefac.createChair();
        sofa = furniturefac.createSofa();
    }

}
