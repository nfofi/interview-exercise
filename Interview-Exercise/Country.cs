namespace Interview_Exercise
{
    public class Country
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { if (isUnique() && isValid())
                    code = value.ToUpper();
                }
        }

        private string name;
        public string Name { get; set; }

        private bool isUnique()
        {
            //method to determine if code is unique
            return true;
        }

        private bool isValid()
        {
            //method to determine if code a 3-character string and is not User-Assigned
            return true;
        }
    }
}