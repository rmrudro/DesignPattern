// See https://aka.ms/new-console-template for more information
using Singleton;

Parallel.Invoke(() => Employee(),
    () => Student(),
    () => Student2());





Console.ReadLine();

static void Employee()
{
    Singleton.Singleton es = Singleton.Singleton.Instance;
    es.GetMessage("Employe");
    es.GetMessage("Employee2");
}

static void Student()
{
    Singleton.Singleton ss2 = Singleton.Singleton.Instance;
    ss2.GetMessage("Student1");
}

static void Student2()
{
    var ss3 = Singleton.Singleton.Instance;
    ss3.GetMessage("Another Student");
}