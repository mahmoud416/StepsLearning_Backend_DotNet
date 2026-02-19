namespace ConsoleApp1
{
    public enum Gender
    {
        Male,
        Female
    }

    #region IMovable
    public interface IMovable{
        void Move();
        int Speed { get; set; }
    }
    #endregion

    #region ITransport
    public interface ITransport
    {
        void Start();
        void Stop();
    }
    #endregion

    #region Car
    public class Car : IMovable, ITransport
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"The car is moving at {Speed} km/h.");
        }
        public void Start()
        {
            Console.WriteLine("The car has started.");
        }
        public void Stop()
        {
            Console.WriteLine("The car has stopped.");
        }
    }
    #endregion

    #region Bicycle
    public class Bicycle : IMovable, ITransport
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"The bicycle is moving at {Speed} km/h.");
        }
        public void Start()
        {
            Console.WriteLine("The bicycle ride has started.");
        }
        public void Stop()
        {
            Console.WriteLine("The bicycle ride has stopped.");
        }
    }
    #endregion

    #region InvalidTransportException
    public class InvalidSalaryException : Exception
    {
        public InvalidSalaryException(string message) : base(message)
        {
        }
    }


    #endregion


    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Gender Gender { get; set; }

        private decimal salary;

        public Student(int id, string name, int age, Gender gender, decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Salary = salary;
        }


        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }
    }



        internal class Program
    {
        static void Main(string[] args)
        {

            IMovable car = new Car();
            car.Speed = 120;
            car.Move();

            IMovable bicycle = new Bicycle();
            bicycle.Speed = 30;
            bicycle.Move();

            ITransport transport = new Car();
            transport.Start();
            transport.Stop();

            try
            {
                Student s1 = new Student(1, "Ahmed", 22, Gender.Male, 4000);
            }
            catch (InvalidSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
