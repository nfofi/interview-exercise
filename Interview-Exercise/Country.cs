namespace Interview_Exercise
{
    public class Country
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { if (IsUnique() && IsValid())
                    code = value.ToUpper();
                }
        }

        private string name;
        public string Name { get; set; }

        public Country()
        {
        }

        public Country(string code, string name)
        {
            Code = code;
            Name = name;
        }

        private bool IsUnique()
        {
            //method to determine if code is unique
            return true;
        }

        private bool IsValid()
        {
            //method to determine if code a 3-character string and is not User-Assigned
            return true;
        }
    }
}