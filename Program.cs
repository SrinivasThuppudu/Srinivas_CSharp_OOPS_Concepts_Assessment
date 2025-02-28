    Console.WriteLine("--------------------First Program-----------------");
    BankAccount bc = new BankAccount(2000);
    Console.WriteLine($"Current Balance: {bc.GetBalance()}");
    bc.Deposit(100);
    Console.WriteLine($"Current Balance After Deposit: {bc.GetBalance()}");
    bc.Withdraw(1000);
    Console.WriteLine($"Current Balance After Withdraw: {bc.GetBalance()}");
    Console.WriteLine();

    Console.WriteLine("-------------------Second Program------------------");
    Student st = new Student("Srini", 18);
    Console.WriteLine($"Student Name: {st.Name}, RollNo: {st.RollNo}");
    Console.WriteLine();

    Console.WriteLine("-------------------Third Program-------------------");
    Book b1 = new Book("The Mahabharatham", "Veda Vyasa");
    Console.WriteLine($"Book Title: {b1.Title}, Author: {b1.Author}");
    Console.WriteLine();

    Console.WriteLine("-------------------Fourth Program-------------------");
    Circle circle = new Circle(12);
    Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
    Rectangle rec = new Rectangle(12, 13);
    Console.WriteLine($"Rectangle Area: {rec.CalculateArea()}");
    Console.WriteLine();

    Console.WriteLine("-------------------Fifth Program-------------------");
    Car car = new Car();
    car.Start();
    Bike bike = new Bike();
    bike.Start();
    Console.WriteLine();

    Console.WriteLine("-------------------Sixth Program-------------------");
    Student1 stu = new Student1();
    stu.GetDetails();
    Teacher tc = new Teacher();
    tc.GetDetails();
    Console.WriteLine();

    Console.WriteLine("-------------------Seventh Program-------------------");
    Calculator calc = new Calculator();
    calc.Add(10, 20);
    calc.Add(10, 20, 30);
    calc.Add(10.45678, 20.456789);
    Console.WriteLine();

    Console.WriteLine("-------------------Eighth Program-------------------");
    MusicPlayer mp = new MusicPlayer();
    mp.Play();
    VideoPlayer vp = new VideoPlayer();
    vp.Play();
    Console.WriteLine();

    Console.WriteLine("-------------------Ninth Program-------------------");
    Report report = new Report();
    report.Print();
    report.SaveToFile();
    Console.WriteLine();

    Console.WriteLine("-------------------Tenth Program-------------------");
    Admin admin = new Admin();
    admin.AccessControl();
    Customer cust = new Customer();
    cust.AccessControl();
    Console.WriteLine();

    Console.WriteLine("-------------------Eleventh Program-------------------");
    ComplexNumber c1 = new ComplexNumber(3, 4);
    ComplexNumber c2 = new ComplexNumber(1, 2);
    ComplexNumber sum = c1 + c2;
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine();

    Console.WriteLine("-------------------Twelfth Program-------------------");
    Department dept1 = new Department("IT", new Manager("John"));
    Department shallowCopy = dept1.ShallowCopy();
    Department deepCopy = dept1.DeepCopy();
    Console.WriteLine($"Original Manager: {dept1.DeptManager.Name}");
    shallowCopy.DeptManager.Name = "Alice";
    Console.WriteLine($"After modifying shallow copy, Original Manager: {dept1.DeptManager.Name}");
    Console.WriteLine($"Deep Copy Manager: {deepCopy.DeptManager.Name}");
    Console.WriteLine();

    Console.WriteLine("-------------------Thirteenth Program-------------------");
    Console.WriteLine("Initial Interest Rate: " + Bank.GetInterestRate());
    Bank.SetInterestRate(5.0);
    Console.WriteLine("Updated Interest Rate: " + Bank.GetInterestRate());
    Console.WriteLine();

    Console.WriteLine("-------------------Fourteenth Program-------------------");
    SecuritySystem system = new SecuritySystem();
    system.Authenticate();
    Console.WriteLine();

    Console.WriteLine("-------------------Fifteenth Program-------------------");
    Button button = new Button();
    button.OnClick += ButtonClicked;
    button.Click();
    static void ButtonClicked()
    {
        Console.WriteLine("Button was clicked!");
    }
    Console.WriteLine();

    Console.WriteLine("-------------------Sixteenth Program-------------------");
    Vehicle1 car1 = VehicleFactory.GetVehicle("Car");
    car1.Drive();
    Vehicle1 bike1 = VehicleFactory.GetVehicle("Bike");
    bike1.Drive();
    Console.WriteLine();

    Console.WriteLine("-------------------Seventeenth Program-------------------");
    ILogger fileLogger = new FileLogger();
    ILogger timestampLogger = new TimestampLogger(fileLogger);
    fileLogger.Log("This is a log message.");
    timestampLogger.Log("This is a log message with timestamp.");
    Console.WriteLine();

    Console.WriteLine("-------------------Eighteenth Program-------------------");
    ConfigurationManager config1 = ConfigurationManager.GetInstance();
    ConfigurationManager config2 = ConfigurationManager.GetInstance();
    Console.WriteLine(config1 == config2);
    Console.WriteLine();

    Console.WriteLine("-------------------Nineteenth Program-------------------");
    NotificationService service = new NotificationService();
    INotificationObserver emailNotifier = new EmailNotifier();
    INotificationObserver smsNotifier = new SMSNotifier();
    service.Subscribe(emailNotifier);
    service.Subscribe(smsNotifier);
    service.Notify("New Message Arrived!");
    service.Unsubscribe(smsNotifier);
    service.Notify("Another Message Arrived!");
    Console.WriteLine();

    Console.WriteLine("-------------------Twentieth Program-------------------");
    ShoppingCart cart1 = new ShoppingCart(new NoDiscount());
    cart1.Checkout(100);
    ShoppingCart cart2 = new ShoppingCart(new PercentageDiscount(10));
    cart2.Checkout(100);
    ShoppingCart cart3 = new ShoppingCart(new FixedAmountDiscount(20));
    cart3.Checkout(100);