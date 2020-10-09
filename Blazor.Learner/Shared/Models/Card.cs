using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Learner.Shared.Models
{
    public class Card : BaseEntity
    {
        public string CardName { get; set; }
        public string CardDescription { get; set; }
    }
}
