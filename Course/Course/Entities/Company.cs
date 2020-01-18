namespace Course.Entities
{
    class Company : TaxPayer
    {
        public int Employers { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int employers) : base(name, anualIncome)
        {
            Employers = employers;
        }

        public override double Tax()
        {
            if (Employers > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
