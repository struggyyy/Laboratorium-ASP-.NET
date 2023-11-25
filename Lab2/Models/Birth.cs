namespace Lab2.Models
{
    public class Birth
    {
        public string? Name { get; set; }
        public DateTime dateOfBirth { get; set; }

        public bool IsValid()
        {
            return Name != null && dateOfBirth < DateTime.Today;
        }

        public int Age
        {
            get
            {
                return (int)((DateTime.Today - dateOfBirth).Days / 365.25);
            }
        }
    }
}