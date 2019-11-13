using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CashDesk
{
    class CashDeskModell
    {
        public class Member
        {
            public int MemberNumer { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
        }

        public class Membership
        {
            public int MembershipID { get; set; }
            public Member Member { get; set; }
            public DateTime begin = DateTime.Now;
            public DateTime Begin
            {
                get { return begin; }
                set
                {
                    if (value > End)
                    {
                        throw new ArgumentException("Begin must be <= end", nameof(Begin));
                    }

                    begin = value;
                }
            }
            public DateTime end = DateTime.MaxValue;
            public DateTime End
            {
                get { return end; }
                set
                {
                    if (Begin > value)
                    {
                        throw new ArgumentException("Begin must be <= end", nameof(End));
                    }

                    end = value;
                }
            }

        }
    }
}
