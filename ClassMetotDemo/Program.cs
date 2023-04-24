namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("__          __  _                           _____          _                                \r\n\\ \\        / / | |                         / ____|        | |                               \r\n \\ \\  /\\  / /__| | ___ ___  _ __ ___   ___| |    _   _ ___| |_ ___  _ __ ___   ___ _ __ ___ \r\n  \\ \\/  \\/ / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ |   | | | / __| __/ _ \\| '_ ` _ \\ / _ \\ '__/ __|\r\n   \\  /\\  /  __/ | (_| (_) | | | | | |  __/ |___| |_| \\__ \\ || (_) | | | | | |  __/ |  \\__ \\\r\n    \\/  \\/ \\___|_|\\___\\___/|_| |_| |_|\\___|\\_____\\__,_|___/\\__\\___/|_| |_| |_|\\___|_|  |___/");
            
            Console.WriteLine("\n\r");
            
            
            Customer customer1 = new Customer();

            customer1.Name = "Murat Ahmet";
            customer1.Surname = "Kiroglu";
            customer1.id = 1455;

            
            
            
            Customer customer2 = new Customer();

            customer2.Name = "Yusuf";
            customer2.Surname = "Caca";
            customer2.id = 555;


            
            
            
            Customer customer3 = new Customer();
            customer3.Name = "Salih Taha";
            customer3.Surname = "Demir";
            customer3.id = 8888;

            
            
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Name  : " + customer.Name  );
                Console.WriteLine("Customer SurName  : " + customer.Surname);
                Console.WriteLine("Customer id  : " + customer.id);
                Console.WriteLine("=========================================");


            }
            
            
            CustomerManager customerManager = new CustomerManager();
            
            
            customerManager.Add(customer1); // 1. Müşteri Eklendi 

            customerManager.Delete(customer1); // 1. Müşteri Silindi

            customerManager.Add(customer2); // 2. Müşteri Eklendi

            customerManager.Delete(customer2); // 2. Müşteri Silindi 

            customerManager.Add(customer3); // 3. Müşteri Eklendi

            customerManager.Delete(customer3); // 3. Müşteri Silindi

            Console.WriteLine("==========================================");

            customerManager.List(customers);




        }
    }
}