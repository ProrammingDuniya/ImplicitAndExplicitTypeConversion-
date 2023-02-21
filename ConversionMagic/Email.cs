using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMagic
{
    internal class Email
    {
        public string Value { get; init; }

        public Email(string value) => Value = value;

        public static implicit operator string(Email email) => email.Value;

        public static explicit operator Email(string value) => new(value);
    }
}
