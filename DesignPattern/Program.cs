using DesignPattern;
using DesignPattern.Abstract_Factory;
using DesignPattern.Adapter;
using DesignPattern.Adaptor;
using DesignPattern.Factory;

Console.WriteLine("Hello, World!");

#region singleton example
Parallel.Invoke(
    () => SingletonWithNothreadSafe.getInstance(),
    () => SingletonWithNothreadSafe.getInstance()
);

SingletonWithEagerLoading singletonWithEagerLoading = SingletonWithEagerLoading.Instance;
#endregion

#region Prototype example
User user = new User(123, "Rishabh", "rishabh@gmail.com", "rishbah@123");

User clonedUser = user.GetClone();
#endregion

#region Builder example
    Employee employee = new Employee.Employeebuilder()
                                    .SetName("Rishabh")
                                    .SetEmail("rishabh@gmail.com")
                                    .SetPassword("rishabh")
                                    .Build();
#endregion

#region Factory

ICreditCard creditCard = CreditCardFactory.GetCreditCard("Platinum");

int annualCharge = creditCard.GetAnnualCharge();

#endregion


#region Abstract Factory

IThemeFactory theme = AbstractThemeFactory.GetThemeFactory("LIGHT");
Console.WriteLine(theme.GetButton().CreateButton());
Console.WriteLine(theme.GetCheckBox().CreateCheckBox());

#endregion

#region Adapter expample

IPaymentGateway gateway = new RazorpayAdaptor();
gateway.GetPaymentStatus(123);

#endregion

#region Decorator
//ICream cream = new Corn();
//ICream valinna = new Vanilla(cream);
//ICream cocoloate = new Cocolate(valinna);
//ICream valinna2 = new Vanilla(cocoloate);

ICream cream = new Vanilla(new Cocolate(new Vanilla(new Corn())));

Console.WriteLine(cream.GetCost());
Console.WriteLine(cream.GetIngredient());
#endregion