namespace LearningDotNetFramework.classes
{
    public class Student
    {
        private string name;
        private string address;

        
        //property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //property
        public string Address
        {
            get => address;
            set => address = value;
        }
        
        //Automatic Properties (Short Hand)
        public string Age { get; set; }
    }
}