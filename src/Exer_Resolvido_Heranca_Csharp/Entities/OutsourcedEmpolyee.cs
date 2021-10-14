
namespace Exer_Resolvido_Heranca_Csharp.Entities
{
    class OutsourcedEmpolyee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmpolyee()
        {
        }

        public OutsourcedEmpolyee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
