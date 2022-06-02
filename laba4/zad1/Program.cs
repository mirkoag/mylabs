using System;

class Engine
{
    public Engine()
    {
        IsPowerOn = true;
        currentPower = 10;
    }
    public Engine(int power)
    {
        IsPowerOn = true;
        currentPower = power;
    }
    public Engine(bool isOnOff, int power)
    {
        IsPowerOn = isOnOff;
        if (IsPowerOn != true) currentPower = 0;
        else currentPower = power;
    }
    public bool IsPowerOn;

    public bool IsPowenOn
    {
        get { return IsPowerOn; }
    }

    private int currentPower;
    public int CurrentPower
    {
        get { return currentPower; }
    }

    public void PowerOn()
    {
        IsPowerOn = true;
    }
    public void PowerOff()
    {
        IsPowerOn = false;
        currentPower = 0;
    }
    public void PowerUp(int d)
    {
        if (IsPowerOn) currentPower += d;
    }
    public void PowerDown(int d)
    {
        currentPower -= d;
    }
}
class Auto
{   //ссылканаобъектклассаАвтомобиль
    private static Auto autoInstance;
    //ссылканаобъектклассаДвигатель
    private Engine autoEngine;
    //закрытыйконструктор
    private Auto()     {
        autoEngine = new Engine(false,0);     
    }     
    public static Auto GetInstanceAuto()    {
        if (autoInstance == null)   {
            autoInstance = new Auto();         
        }         return autoInstance;   
    } //наименованиеавтомобиля 
    private string nameAuto;
    public string NameAuto  {         
        get { return nameAuto;
        }         
        set {
            nameAuto = value;
        }     
    } //состояниедвигателя
    public bool IsEnginePowerOn {
        get {
            return autoEngine.IsPowerOn;
        }
    }
    public void EnginePowerOn() {
        autoEngine.PowerOn();
    }
    public void EnginePowerOff() {
        autoEngine.PowerOff();
    } 
    //текущаямощностьавтомобиля
    public int EngineCurrentPower {
        get {
            return  autoEngine.CurrentPower;
        }
    }
    //прибавитьмощность
    public void EnginePowerUp(int d)
    {         autoEngine.PowerUp(d);
    }
    //убавитьмощность
    public void EnginePowerDown(int d) {
        autoEngine.PowerDown(d);
    }
}
class Program
{
    static void Main(string[] args) {
        //созданиеобъектаклассаавтомобиль
        Auto auto1 = Auto.GetInstanceAuto();
        auto1.NameAuto = "BMW";
        PrintInfoOfAuto(auto1);
        //включитьдвигатель
        auto1.EnginePowerOn();
        //установитьмощность
        auto1.EnginePowerUp(20);
        PrintInfoOfAuto(auto1);
        //выключитьдвигатель
        auto1.EnginePowerOff();
        PrintInfoOfAuto(auto1);
    }   
    // выводинформацииопараметрахавтомобиля
    private  static  void  PrintInfoOfAuto(Auto auto1) {
        Console.WriteLine($"{auto1.NameAuto} двигательвключен {auto1.IsEnginePowerOn}");
        Console.WriteLine($"Текущаямощность(кВт) {auto1.EngineCurrentPower}");     
    }
}