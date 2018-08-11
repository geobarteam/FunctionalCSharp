using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FunctionalCSharp
{
    public abstract class Command { }

    public sealed class MakeTransfer : Command
    {
        public Guid DebitedAccountId { get; set; }

        public string Beneficiary { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public interface IValidator<T> { bool IsValid(T t); }

    public sealed class BicFormatValidator : IValidator<MakeTransfer>
    {
        static readonly Regex regex = new Regex("^[A-Z]{6}[A-Z1-9]{5}$");

        public bool IsValid(MakeTransfer cmd) => regex.IsMatch(cmd.Bic);
    }

    public class DateNotPastValidator : IValidator<MakeTransfer>
    {
        public bool IsValid(MakeTransfer cmd)
            => (DateTime.UtcNow.Date <= cmd.Date.Date);
    }

}
